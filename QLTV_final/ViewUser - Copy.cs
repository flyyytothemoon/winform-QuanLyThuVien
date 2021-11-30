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
    public partial class ViewUser : Form
    {
        Ketnoi ketnoi = new Ketnoi();
        public ViewUser()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

    

 

    
        public void Load_Searching()
        {
            string name = textBox1.Text;
            int active = 1;
            if (rad_act.Checked == true)
                active = 1;
            if (rad_non_act.Checked == true)
                active = 0;

            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu(" select Book.Id as 'Id', Book.BookLocation as 'vi tri', Book.OriginalState as 'tinh trang' , " +
                "BookTitle.Name as 'ten sach' , BookType.Title as 'the loai' , Releaser.Name as 'nha phat hanh', Publisher.Name as" +
                " 'nha xuat ban', Book.Status as 'trang thai' from BookTitle, Publisher, Book,BookType , Releaser where Book.Status = '"+ active +
                "' and Releaser.Id = BookTitle.ReleaserId and BookType.Id = BookTitle.BookTypeId and Book.BookTitleId = BookTitle.Id and Publisher.Id =  BookTitle.PublisherId and Publisher.Name like  '%" + name + "%'");

            dataGridView1.DataSource = dta;
            //cbo_GIOITINH.DataSource = dta;
            //cbo_GIOITINH.DisplayMember = "Gender";
            //cbo_GIOITINH.ValueMember = "Gender";
            Hienthi_Dulieu();
        }
        private void Hienthi_Dulieu()
        {
            txt_original.DataBindings.Clear();
            txt_original.DataBindings.Add("Text", dataGridView1.DataSource, "tinh trang");

            txt_name.DataBindings.Clear();
            txt_name.DataBindings.Add("Text", dataGridView1.DataSource, "ten sach");

            txt_location.DataBindings.Clear();
            txt_location.DataBindings.Add("Text", dataGridView1.DataSource, "vi tri");

            txt_publisher.DataBindings.Clear();
            txt_publisher.DataBindings.Add("Text", dataGridView1.DataSource, "nha xuat ban");


            txt_releaser.DataBindings.Clear();
            txt_releaser.DataBindings.Add("Text", dataGridView1.DataSource, "nha phat hanh");

            txt_status.DataBindings.Clear();
            txt_status.DataBindings.Add("text", dataGridView1.DataSource, "trang thai");

            txt_Id.DataBindings.Clear();
            txt_Id.DataBindings.Add("text", dataGridView1.DataSource, "Id");

        }
        /// <summary>
        /// sql: lấy ra thông tin sách có stt = 1
        /// data: láy ra tât cả t.tin sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_publisher_Click(object sender, EventArgs e)
        {
            int active = 1;
            if (rad_act.Checked == true)
                active = 1;
            if (rad_non_act.Checked == true)
                active = 0;
            string name = textBox1.Text;
            string sql = " select Book.BookLocation as 'vi tri', Book.OriginalState as 'tinh trang sach', BookTitle.Name as 'ten sach' , BookType.Title as 'the loai' , Releaser.Name as 'nha phat hanh', Publisher.Name as " +
                "'ten tac gia' , Book.Status as 'trang thai' from BookTitle, Publisher, Book,BookType , Releaser where Releaser.Id = BookTitle.ReleaserId and BookType.Id = BookTitle.BookTypeId and Book.Status = 1 and Book.BookTitleId = BookTitle.Id and Publisher.Id =  BookTitle.PublisherId and Publisher.Name like  '%" + name + "%'";
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu(" select Book.BookLocation as 'vi tri', Book.OriginalState as 'tinh trang', BookTitle.Name as 'ten sach' , BookType.Title as 'the loai' , Releaser.Name as 'nha phat hanh', Publisher.Name as " +
                "'ten tac gia' , Book.Status as 'trang thai' from BookTitle, Publisher, Book,BookType , Releaser where Releaser.Id = BookTitle.ReleaserId and BookType.Id = BookTitle.BookTypeId and Book.Status = '" + active + "'  and Book.BookTitleId = BookTitle.Id and Publisher.Id =  BookTitle.PublisherId and Publisher.Name like  '%" + name + "%'");
            dataGridView1.DataSource = dta;
            Load_Searching();
        }

        private void btn_Book_Title_Click(object sender, EventArgs e)
        {
            int active = 1;
            if (rad_act.Checked == true)
                active = 1;
            if (rad_non_act.Checked == true)
                active = 0;
            string name = textBox1.Text;
            string sql = " select Book.BookLocation as 'vi tri', Book.OriginalState as 'tinh trang sach', BookTitle.Name as 'ten sach' , BookType.Title as 'the loai' , Releaser.Name as 'nha phat hanh', Publisher.Name as " +
                "'ten tac gia' , Book.Status as 'trang thai'  from BookTitle, Publisher, Book,BookType , Releaser where Releaser.Id = BookTitle.ReleaserId and BookType.Id = BookTitle.BookTypeId and Book.Status = 1 and Book.BookTitleId = BookTitle.Id and Publisher.Id =  BookTitle.PublisherId and Publisher.Name like  '%" + name + "%'";
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu(" select Book.BookLocation as 'vi tri', Book.OriginalState as 'tinh trang sach', BookTitle.Name as 'ten sach' , BookType.Title as 'the loai' , Releaser.Name as 'nha phat hanh', Publisher.Name as " +
                "'ten tac gia' , Book.Status as 'trang thai'  from BookTitle, Publisher, Book,BookType , Releaser where Releaser.Id = BookTitle.ReleaserId and BookType.Id = BookTitle.BookTypeId and Book.Status = '" + active + "'  and Book.BookTitleId = BookTitle.Id and Publisher.Id =  BookTitle.PublisherId and Publisher.Name like  '%" + name + "%'");
            dataGridView1.DataSource = dta;
            Load_Searching();
        }

        private void btn_Realeser_Click(object sender, EventArgs e)
        {
            int active = 1;
            if (rad_act.Checked == true)
                active = 1;
            if (rad_non_act.Checked == true)
                active = 0;
            string name = textBox1.Text;
            string sql = " select Book.BookLocation as 'vi tri', Book.OriginalState as 'tinh trang sach', BookTitle.Name as 'ten sach' , BookType.Title as 'the loai' , Releaser.Name as 'nha phat hanh', Publisher.Name as " +
                "'ten tac gia' , Book.Status as 'trang thai'  from BookTitle, Publisher, Book,BookType , Releaser where Releaser.Id = BookTitle.ReleaserId and BookType.Id = BookTitle.BookTypeId and Book.Status = 1 and Book.BookTitleId = BookTitle.Id and Publisher.Id =  BookTitle.PublisherId and Publisher.Name like  '%" + name + "%'";
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu(" select Book.BookLocation as 'vi tri', Book.OriginalState as 'tinh trang sach', BookTitle.Name as 'ten sach' , BookType.Title as 'the loai' , Releaser.Name as 'nha phat hanh', Publisher.Name as " +
                "'ten tac gia' , Book.Status as 'trang thai'  from BookTitle, Publisher, Book,BookType , Releaser where Releaser.Id = BookTitle.ReleaserId and BookType.Id = BookTitle.BookTypeId and Book.Status = '" + active + "'  and Book.BookTitleId = BookTitle.Id and Publisher.Id =  BookTitle.PublisherId and Publisher.Name like  '%" + name + "%'");
            dataGridView1.DataSource = dta;
            Load_Searching();
        }

        private void btn_author_Click(object sender, EventArgs e)
        {
            int active = 1;
            if (rad_act.Checked == true)
                active = 1;
            if (rad_non_act.Checked == true)
                active = 0;
            string name = textBox1.Text;
            string sql = " select Book.BookLocation as 'vi tri', Book.OriginalState as 'tinh trang sach', BookTitle.Name as 'ten sach' , BookType.Title as 'the loai' , Releaser.Name as 'nha phat hanh', Publisher.Name as " +
                "'ten tac gia' , Book.Status as 'trang thai'  from BookTitle, Publisher, Book,BookType , Releaser where Releaser.Id = BookTitle.ReleaserId and BookType.Id = BookTitle.BookTypeId and Book.Status = '"+ active +"' and Book.BookTitleId = BookTitle.Id and Publisher.Id =  BookTitle.PublisherId and Publisher.Name like  '%" + name + "%'";
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu(" select Book.BookLocation as 'vi tri', Book.OriginalState as 'tinh trang sach', BookTitle.Name as 'ten sach' , BookType.Title as 'the loai' , Releaser.Name as 'nha phat hanh', Publisher.Name as " +
                "'ten tac gia' , Book.Status as 'trang thai'  from BookTitle, Publisher, Book,BookType , Releaser where Releaser.Id = BookTitle.ReleaserId and BookType.Id = BookTitle.BookTypeId and Book.Status = '" + active + "'  and Book.BookTitleId = BookTitle.Id and Publisher.Id =  BookTitle.PublisherId and Publisher.Name like  '%" + name + "%'");
            dataGridView1.DataSource = dta;
            Load_Searching();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txt_Id.Text;
            int res = 0;
            string sql2 = "Update Book Set Status ='" + res + "' where Id = '" + id + "'";
            ketnoi.Execute(sql2);
            Load_Searching();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
