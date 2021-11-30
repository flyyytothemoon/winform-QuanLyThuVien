using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_final
{
    public partial class UpdateReader : Form
    {
        Ketnoi ketnoi = new Ketnoi();
        public UpdateReader()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser res = new HomeUser();
            res.Show();
        }
        public void Load_Dulieu_Docgia()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Reader");
            DataGrid_DOCGIA.DataSource = dta;
            // cbo_GIOITINH.DataSource = dta;
            // cbo_GIOITINH.DisplayMember = "Gender";
            // cbo_GIOITINH.ValueMember = "Gender";
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txt_TENDG.DataBindings.Clear();
            txt_TENDG.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "FirstName");

            txt_HODG.DataBindings.Clear();
            txt_HODG.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "LastName");

            txt_MADG.DataBindings.Clear();
            txt_MADG.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "Code");

            txt_QUYDG.DataBindings.Clear();
            txt_QUYDG.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "Money");

            date_dob.DataBindings.Clear();
            date_dob.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "DOB");

            txt_SDT.DataBindings.Clear();
            txt_SDT.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "Phone");

            txt_EMAIL.DataBindings.Clear();
            txt_EMAIL.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "Email");

            if (rad_female.Checked == true)
            {
                rad_female.DataBindings.Clear();
                rad_male.DataBindings.Clear();
                rad_female.DataBindings.Add("checked", DataGrid_DOCGIA.DataSource, "Gender");
            }
            if (rad_male.Checked == true)
            {
                rad_female.DataBindings.Clear();
                rad_male.DataBindings.Clear();
                rad_male.DataBindings.Add("checked", DataGrid_DOCGIA.DataSource, "Gender");
            }


            rad_female.DataBindings.Clear();
            rad_female.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "Gender");


            richtxt_GHICHU.DataBindings.Clear();
            richtxt_GHICHU.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "Notes");

            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("Text", DataGrid_DOCGIA.DataSource, "Id");

        }

        private void fmDOCGIA_Load(object sender, EventArgs e)
        {
            Load_Dulieu_Docgia();
            Hienthi_Dulieu();
        }

        



        private void btn_THEM_Click(object sender, EventArgs e)
        {
            int gender = 1;
            if (rad_female.Checked == true)
            {
                gender = 1;
            }
            if (rad_male.Checked == true)
                gender = 0;
            DateTime DOB = date_dob.Value;
            DateTime now = DateTime.Now;
            string sql1 = "Insert into Reader Values('" + txt_MADG.Text + "' ,'" + txt_TENDG.Text + "','" + txt_HODG.Text + "','"
                + txt_EMAIL.Text + "','" + txt_Pass.Text + "','" + txt_SDT.Text + "','" + gender + "','" + DOB + "','" + txt_QUYDG.Text +
                "', '" + now + "','" + now + "','1','1','" + richtxt_GHICHU.Text + "','1')";
            ketnoi.Execute(sql1);
            Load_Dulieu_Docgia();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int gender = 1;
            if (rad_female.Checked == true)
            {
                gender = 1;
            }
            if (rad_male.Checked == true)
                gender = 0;
            string id = txt_id.Text;
            string sql2 = "Update Reader Set Code ='" + txt_MADG.Text + "', FirstName ='" + txt_TENDG.Text + "'";
            sql2 = sql2 + ", LastName ='" + txt_HODG.Text + "',Money ='" + txt_QUYDG.Text + "', Phone ='" + txt_SDT.Text + "',DOB ='" + date_dob.Value + "',Email ='" + txt_EMAIL.Text + "', Gender = '" + gender + "',Notes ='" + richtxt_GHICHU.Text + "' where Id = '" + id + "'";
            ketnoi.Execute(sql2);
            Load_Dulieu_Docgia();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            ketnoi.Execute("Delete Reader Where Id = '" + id + "'");
            Load_Dulieu_Docgia();
        }
    }
}
