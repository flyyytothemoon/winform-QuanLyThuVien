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
    public partial class fmNHANVIEN : Form
    {
        public fmNHANVIEN()
        {
            InitializeComponent();
        }
        Ketnoi ketnoi = new Ketnoi();
        public void Load_Dulieu_Nhanvien()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Employee");
            DataGrid_NHANVIEN.DataSource = dta;
           // cbo_GIOITINH.DataSource = dta;
            //cbo_GIOITINH.DisplayMember = "Gender";
            //cbo_GIOITINH.ValueMember = "Gender";
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txt_TENNV.DataBindings.Clear();
            txt_TENNV.DataBindings.Add("Text", DataGrid_NHANVIEN.DataSource, "FirstName");

            txt_HONV.DataBindings.Clear();
            txt_HONV.DataBindings.Add("Text", DataGrid_NHANVIEN.DataSource, "LastName");

            txt_MANV.DataBindings.Clear();
            txt_MANV.DataBindings.Add("Text", DataGrid_NHANVIEN.DataSource, "Id");

            txt_SDT.DataBindings.Clear();
            txt_SDT.DataBindings.Add("Text", DataGrid_NHANVIEN.DataSource, "Phone");

            txt_EMAIL.DataBindings.Clear();
            txt_EMAIL.DataBindings.Add("Text", DataGrid_NHANVIEN.DataSource, "Email");

            // cbo_GIOITINH.DataBindings.Clear();
            // cbo_GIOITINH.DataBindings.Add("Text", DataGrid_NHANVIEN.DataSource, "Gender");
            rad_NAM.DataBindings.Clear();
            rad_NAM.DataBindings.Add("Text", DataGrid_NHANVIEN.DataSource, "Gender");

            rad_NU.DataBindings.Clear();
            rad_NU.DataBindings.Add("Text", DataGrid_NHANVIEN.DataSource, "Gender");

            richtxt_GHICHU.DataBindings.Clear();
            richtxt_GHICHU.DataBindings.Add("Text", DataGrid_NHANVIEN.DataSource, "Notes");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmNHANVIEN_Load(object sender, EventArgs e)
        {
            Load_Dulieu_Nhanvien();
            Hienthi_Dulieu();
        }

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into Employee Values('" + txt_TENNV.Text + "' , '" + txt_HONV.Text + "','" + txt_MANV.Text + "','" + txt_SDT.Text + "','" + txt_EMAIL.Text + "', '" + rad_NAM.Text + "',  '" + rad_NU.Text + "','" + richtxt_GHICHU.Text + "')";
            ketnoi.Execute(sql1);
            Load_Dulieu_Nhanvien();
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            string sql2 = "Update Employee Set FirstName ='" + txt_TENNV.Text + "'";
            sql2 = sql2 + ", LastName ='" + txt_HONV.Text + "', Phone ='" + txt_SDT.Text + "',Email ='" + txt_EMAIL.Text + "', Gender = '" + rad_NAM.Text + "', Gender = '" + rad_NU.Text + "',Notes ='" + richtxt_GHICHU.Text + "' where Id = '" + txt_MANV.Text + "'";
            ketnoi.Execute(sql2);
            Load_Dulieu_Nhanvien();
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete Employee Where Id = '" + txt_MANV.Text + "'");
            Load_Dulieu_Nhanvien();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin res = new HomeAdmin();
            res.Show();
        }
    }
}
