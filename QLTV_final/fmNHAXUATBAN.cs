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
    public partial class fmNHAXUATBAN : Form
    {
        public fmNHAXUATBAN()
        {
            InitializeComponent();
        }

        Ketnoi ketnoi = new Ketnoi();
        public void Load_Dulieu_NXB()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Publisher");
            DataGrid_NXB.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txt_TENNXB.DataBindings.Clear();
            txt_TENNXB.DataBindings.Add("Text", DataGrid_NXB.DataSource, "Name");

            txt_MANXB.DataBindings.Clear();
            txt_MANXB.DataBindings.Add("Text", DataGrid_NXB.DataSource, "Id");

            rad_1.DataBindings.Clear();
            rad_1.DataBindings.Add("Text", DataGrid_NXB.DataSource, "Status");

            rad_0.DataBindings.Clear();
            rad_0.DataBindings.Add("Text", DataGrid_NXB.DataSource, "Status");

            richtxt_GHICHU.DataBindings.Clear();
            richtxt_GHICHU.DataBindings.Add("Text", DataGrid_NXB.DataSource, "Notes");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rtbGHICHU_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmNHAXUATBAN_Load(object sender, EventArgs e)
        {
            Load_Dulieu_NXB();
            Hienthi_Dulieu();
        }

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into Publisher Values('" + txt_TENNXB.Text + "' ,'" + txt_MANXB.Text + "','" + rad_1.Text + "','" + rad_0.Text + "','" + richtxt_GHICHU.Text + "')";
            ketnoi.Execute(sql1);
            Load_Dulieu_NXB();
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            string sql2 = "Update Publisher Set Name ='" + txt_TENNXB.Text + "'";
            sql2 = sql2 + ", Status ='" + rad_0.Text + "',  Status ='" + rad_1.Text + "',Notes ='" + richtxt_GHICHU.Text + "' where Id = '" + txt_MANXB.Text + "'";
            ketnoi.Execute(sql2);
            Load_Dulieu_NXB();
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete Publisher Where Id = '" + txt_MANXB.Text + "'");
            Load_Dulieu_NXB();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin res = new HomeAdmin();
            res.Show();
        }
    }
}
