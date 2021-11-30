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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }
            
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void link_add_Reader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmSACH book = new fmSACH();
            book.Show();
        }

        private void btn_booktitle_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookTitle booktitle = new BookTitle();
            booktitle.Show();
        }

        private void btn_Author_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmTACGIA res = new fmTACGIA();
            res.Show();
        }

        private void btn_Publis_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmNHAXUATBAN res = new fmNHAXUATBAN();
            res.Show();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmNHANVIEN res = new fmNHANVIEN();
            res.Show();
        }

        private void btn_reder_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmDOCGIA res = new fmDOCGIA();
            res.Show();
        }

        private void Manger_Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAdmin viewAdmin = new ViewAdmin();
            viewAdmin.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_LOGIN res = new fm_LOGIN();
            res.Show();
        }
    }
}
