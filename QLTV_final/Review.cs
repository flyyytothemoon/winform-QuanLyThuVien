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
    public partial class Review : Form
    {
        Ketnoi ketnoi = new Ketnoi();
        public Review()
        {
            InitializeComponent();
        }

        private void Review_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVTESTDataSet2.Reader' table. You can move, or remove it, as needed.
            this.readerTableAdapter.Fill(this.qLTVTESTDataSet2.Reader);
            // TODO: This line of code loads data into the 'qLTVTESTDataSet1.BookTitle' table. You can move, or remove it, as needed.
            this.bookTitleTableAdapter.Fill(this.qLTVTESTDataSet1.BookTitle);

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser res = new HomeUser();
            res.Show();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string BookId = cb_book.SelectedValue.ToString();
            string ReaderId = cb_reader.SelectedValue.ToString();
            string pointres = txt_point.Text;
            int point = Int32.Parse(pointres);
            DateTime date = date_create.Value;

            string insert  = "Insert into Review Values('" + ReaderId + "' , '" + BookId + "', '" + point + "', '" + date + "')";
            ketnoi.Execute("Insert into Review Values('" + ReaderId + "' , '" + BookId + "', '" + point + "', '" + date + "')");
            MessageBox.Show("Đánh giá thành công");
        }
    }
}
