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
    public partial class fmTACGIA : Form
    {
        public fmTACGIA()
        {
            InitializeComponent();
        }
        Ketnoi ketnoi = new Ketnoi();
        public void Load_Dulieu_Tacgia()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Author");
            DataGrid_TACGIA.DataSource = dta;
           // cbo_GIOITINH.DataSource = dta;
           // cbo_GIOITINH.DisplayMember = "Gender";
           // cbo_GIOITINH.ValueMember = "Gender";
            Hienthi_Dulieu();
        }
        
        private void Hienthi_Dulieu()
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("Text", DataGrid_TACGIA.DataSource, "Id");

            txt_MATG.DataBindings.Clear();
            txt_MATG.DataBindings.Add("Text", DataGrid_TACGIA.DataSource, "Code");

            txt_HOTEN.DataBindings.Clear();
            txt_HOTEN.DataBindings.Add("Text", DataGrid_TACGIA.DataSource, "FullName");
         
            // cbo_GIOITINH.DataBindings.Clear();
            // cbo_GIOITINH.DataBindings.Add("Text", DataGrid_TACGIA.DataSource, "Gender");
            //rad_NAM.DataBindings.Clear();
            //rad_NAM.DataBindings.Add("Text", DataGrid_TACGIA.DataSource, "Gender");

            //rad_NU.DataBindings.Clear();
            //rad_NU.DataBindings.Add("Text", DataGrid_TACGIA.DataSource, "Gender");

            //rad_0.DataBindings.Clear();
            //rad_0.DataBindings.Add("Text", DataGrid_TACGIA.DataSource, "Status");

            //rad_1.DataBindings.Clear();
            //rad_1.DataBindings.Add("Text", DataGrid_TACGIA.DataSource, "Status");

            richtxt_GHICHU.DataBindings.Clear();
            richtxt_GHICHU.DataBindings.Add("Text", DataGrid_TACGIA.DataSource, "Notes");

        }




        private void txtTINHTRANG_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void fmTACGIA_Load(object sender, EventArgs e)
        {
            Load_Dulieu_Tacgia();
            Hienthi_Dulieu();
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string code = txt_MATG.Text;
            string fullName = txt_HOTEN.Text;
            string notes = richtxt_GHICHU.Text;
            int gender = 1;
            if (rad_NAM.Checked == true)
                gender = 1;
            if (rad_NU.Checked == true)
                gender = 0;

            int status = 1;
            if (rad_1.Checked == true)
                status = 1;
            if (rad_0.Checked == true)
                status = 0;
            string sql2 = "Update Author Set FullName ='" + txt_HOTEN.Text + "'";
            sql2 = sql2 + ", Status ='" + status + "', Code = '" + code + "', Gender = '" + gender + "', Notes ='" + notes + "' where Id = '" + id + "'";
            ketnoi.Execute(sql2);
            Load_Dulieu_Tacgia();

        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            ketnoi.Execute("Delete Author Where Id = '" + id + "'");
            Load_Dulieu_Tacgia();

        }

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string code = txt_MATG.Text;
            string fullName = txt_HOTEN.Text;
            string notes = richtxt_GHICHU.Text;
            int gender = 1;
            if (rad_NAM.Checked == true)
                gender = 1;
            if (rad_NU.Checked == true)
                gender = 0;

            int status = 1;
            if (rad_1.Checked == true)
                status = 1;
            if (rad_0.Checked == true)
                status = 0;
            string sql1 = "Insert into Author Values('" + code + "' , '" + fullName+ "', '" + gender + "', '" + notes + "','" + status +"')";
            ketnoi.Execute(sql1);
            Load_Dulieu_Tacgia();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin res = new HomeAdmin();
            res.Show();
        }
    }
}
