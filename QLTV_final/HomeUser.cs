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
    public partial class HomeUser : Form
    {
        public HomeUser()
        {
            InitializeComponent();
        }

        private void Manger_Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewUser res = new ViewUser();
            res.Show();
        }

        private void btn_Author_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateReader res = new UpdateReader();
            res.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_LOGIN res = new fm_LOGIN();
            res.Show();
        }

        private void btn_Publis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Review res = new Review();
            res.Show();
        }
    }
}
