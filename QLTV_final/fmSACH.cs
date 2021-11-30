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
    public partial class fmSACH : Form
    {
        public fmSACH()
        {
            InitializeComponent();
        }

        Ketnoi ketnoi = new Ketnoi();
        public void Load_Dulieu_Sach()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Book");
            DataGrid_THONGTINSACH.DataSource = dta;
            /*cboTENTG.DataSource = dta;
            cboTENTG.DisplayMember = "FullName";
            cboTENTG.ValueMember = "FullName";
            cboTENNXB.DataSource = dta;
            cboTENNXB.DisplayMember = "Name";
            cboTENNXB.ValueMember = "Name";*/
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txt_MASACH.DataBindings.Clear();
            txt_MASACH.DataBindings.Add("Text", DataGrid_THONGTINSACH.DataSource, "Id");

            /*txt_TENSACH.DataBindings.Clear();
            txt_TENSACH.DataBindings.Add("Text", DataGrid_THONGTINSACH.DataSource, "BookTitleld");*/

            txt_VITRI.DataBindings.Clear();
            txt_VITRI.DataBindings.Add("Text", DataGrid_THONGTINSACH.DataSource, "BookLocation");

            // txt_OS.DataBindings.Clear();
            //txt_OS.DataBindings.Add("Text", DataGrid_THONGTINSACH.DataSource, "OriginalState");

            //rad_1.DataBindings.Clear();
            //rad_1.DataBindings.Add("Text", DataGrid_THONGTINSACH.DataSource, "OirginalState");

            //rad_0.DataBindings.Clear();
            //rad_0.DataBindings.Add("Text", DataGrid_THONGTINSACH.DataSource, "OirginalState");

            /* cboTENTG.DataBindings.Clear();
             cboTENTG.DataBindings.Add("Text", DataGrid_THONGTINSACH.DataSource, "FullName");

             cboTENNXB.DataBindings.Clear();
             cboTENNXB.DataBindings.Add("Text", DataGrid_THONGTINSACH.DataSource, "Name");*/



            richtxt_NOTESACH.DataBindings.Clear();
            richtxt_NOTESACH.DataBindings.Add("Text", DataGrid_THONGTINSACH.DataSource, "Notes");

        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void fmSACH_Load(object sender, EventArgs e)
        {
            Load_Dulieu_Sach();
            Hienthi_Dulieu();
        }

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            string sql3 = "Insert into Book Values('" + txt_MASACH.Text + "' , '" + txt_TENSACH.Text + "', '" + txt_VITRI.Text + "', '" + rad_1.Text + "','" + rad_0.Text + "','" + cboTENTG.Text + "', '" + cboTENNXB.Text + "', '" + richtxt_NOTESACH.Text + "')";
            ketnoi.Execute(sql3);
            Load_Dulieu_Sach();
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            string sql4 = "Update Book Set Name ='" + txt_TENSACH.Text + "'";
            sql4 = sql4 + ", BookLocation ='" + txt_VITRI.Text + "', OriginalState = '" + rad_1.Text + "', OriginalState = '" + rad_0.Text + "', FullName = '" + cbo_TENTG.Text + "',Name = '" + cboTENNXB.Text + "', Notes ='" + richtxt_NOTESACH.Text + "' where Id = '" + txt_MASACH.Text + "'";
            ketnoi.Execute(sql4);
            Load_Dulieu_Sach();
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete Book Where Id = '" + txt_MASACH.Text + "'");
            Load_Dulieu_Sach();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin res = new HomeAdmin();
            res.Show();
        }
    }
}
