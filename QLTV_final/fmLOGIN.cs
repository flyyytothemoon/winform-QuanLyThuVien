using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_final
{
    public partial class fm_LOGIN : Form
    {
        Ketnoi ketnoi = new Ketnoi();
        public fm_LOGIN()
        {
            InitializeComponent();
        }

        private void fm_LOGIN_Load(object sender, EventArgs e)
        {

        }
      
        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            ketnoi.KetNoi_Dulieu();
            string user = txt_gmail.Text;
            string pass = txt_PASSWORD.Text;
            string sql_login = "Select Email, Password From Employee where Email= '" + user + "'and Password ='" + pass + "'";

            SqlCommand cmd = new SqlCommand(sql_login, ketnoi.cnn);
            SqlDataReader notify = cmd.ExecuteReader();
            if (notify.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                // FrmPhongBancs frm1 = new FrmPhongBancs();

                // Visible = false;
                this.Hide();
                string data = user.Substring(0, 1).ToString();
                if(data == "A" || data == "a")
                {
                    HomeAdmin res = new HomeAdmin();
                    res.Show();
                }
                else
                {
                    HomeUser res = new HomeUser();
                    res.Show();
                }
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
