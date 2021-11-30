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
    public partial class fmMUONTRASACH : Form
    {
        public fmMUONTRASACH()
        {
            InitializeComponent();
        }
        Ketnoi ketnoi = new Ketnoi();
        public void Load_Dulieu_Muontra()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From BookBorrowReturn");
            DataGrid_MUONTRA.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txt_MADG.DataBindings.Clear();
            txt_MADG.DataBindings.Add("Text", DataGrid_MUONTRA.DataSource, "ReaderId");

            //txt_MASACH.DataBindings.Clear();
            //txt_MASACH.DataBindings.Add("Text", DataGrid_MUONTRA.DataSource, "Id");

            mkt_NGAYMUON.DataBindings.Clear();
            mkt_NGAYMUON.DataBindings.Add("Text", DataGrid_MUONTRA.DataSource, "BorrowTime");

            mkt_NGAYTRA.DataBindings.Clear();
            mkt_NGAYTRA.DataBindings.Add("Text", DataGrid_MUONTRA.DataSource, "ReturnTime");

            richtxt_GHICHU.DataBindings.Clear();
            richtxt_GHICHU.DataBindings.Add("Text", DataGrid_MUONTRA.DataSource, "Notes");

        }

        private void fmMUONTRASACH_Load(object sender, EventArgs e)
        {
            Load_Dulieu_Muontra();
            Hienthi_Dulieu();
        }

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into BookBorrowReturn Values('" + txt_MADG.Text + "' ,'" + txt_MASACH.Text + "','" + mkt_NGAYMUON.Text + "','" + mkt_NGAYTRA.Text + "','" + richtxt_GHICHU.Text + "')";
            ketnoi.Execute(sql1);
            Load_Dulieu_Muontra();
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            string sql2 = "Update BookBorrowReturn Set ReaderId ='" + txt_MADG.Text + "'";
            sql2 = sql2 + ", BorrowTime ='" + mkt_NGAYMUON.Text + "',ReturnTime ='" + mkt_NGAYTRA.Text + "',  Notes ='" + richtxt_GHICHU.Text + "' where ReaderId = '" + txt_MADG.Text + "'";
            ketnoi.Execute(sql2);
            Load_Dulieu_Muontra();
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete BookBorrowReturn Where ReaderId = '" + txt_MADG.Text + "'");
            Load_Dulieu_Muontra();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin res = new HomeAdmin();
            res.Show();
        }
    }
}
