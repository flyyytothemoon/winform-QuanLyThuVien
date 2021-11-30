
namespace QLTV_final
{
    partial class fmMUONTRASACH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richtxt_GHICHU = new System.Windows.Forms.RichTextBox();
            this.txt_MASACH = new System.Windows.Forms.TextBox();
            this.txt_MADG = new System.Windows.Forms.TextBox();
            this.mkt_NGAYTRA = new System.Windows.Forms.MaskedTextBox();
            this.mkt_NGAYMUON = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_XOA = new System.Windows.Forms.Button();
            this.btn_THEM = new System.Windows.Forms.Button();
            this.btn_SUA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGrid_MUONTRA = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_MUONTRA)).BeginInit();
            this.SuspendLayout();
            // 
            // richtxt_GHICHU
            // 
            this.richtxt_GHICHU.Location = new System.Drawing.Point(399, 19);
            this.richtxt_GHICHU.Name = "richtxt_GHICHU";
            this.richtxt_GHICHU.Size = new System.Drawing.Size(185, 91);
            this.richtxt_GHICHU.TabIndex = 16;
            this.richtxt_GHICHU.Text = "";
            // 
            // txt_MASACH
            // 
            this.txt_MASACH.Location = new System.Drawing.Point(107, 42);
            this.txt_MASACH.Name = "txt_MASACH";
            this.txt_MASACH.Size = new System.Drawing.Size(186, 20);
            this.txt_MASACH.TabIndex = 11;
            // 
            // txt_MADG
            // 
            this.txt_MADG.Location = new System.Drawing.Point(107, 18);
            this.txt_MADG.Name = "txt_MADG";
            this.txt_MADG.Size = new System.Drawing.Size(186, 20);
            this.txt_MADG.TabIndex = 10;
            // 
            // mkt_NGAYTRA
            // 
            this.mkt_NGAYTRA.Location = new System.Drawing.Point(107, 90);
            this.mkt_NGAYTRA.Mask = "00/00/0000";
            this.mkt_NGAYTRA.Name = "mkt_NGAYTRA";
            this.mkt_NGAYTRA.Size = new System.Drawing.Size(186, 20);
            this.mkt_NGAYTRA.TabIndex = 9;
            this.mkt_NGAYTRA.ValidatingType = typeof(System.DateTime);
            // 
            // mkt_NGAYMUON
            // 
            this.mkt_NGAYMUON.Location = new System.Drawing.Point(107, 67);
            this.mkt_NGAYMUON.Mask = "00/00/0000";
            this.mkt_NGAYMUON.Name = "mkt_NGAYMUON";
            this.mkt_NGAYMUON.Size = new System.Drawing.Size(186, 20);
            this.mkt_NGAYMUON.TabIndex = 8;
            this.mkt_NGAYMUON.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ghi chú :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày mượn :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày trả :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_XOA);
            this.groupBox3.Controls.Add(this.btn_THEM);
            this.groupBox3.Controls.Add(this.btn_SUA);
            this.groupBox3.Location = new System.Drawing.Point(656, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 156);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_XOA
            // 
            this.btn_XOA.Location = new System.Drawing.Point(40, 123);
            this.btn_XOA.Name = "btn_XOA";
            this.btn_XOA.Size = new System.Drawing.Size(75, 21);
            this.btn_XOA.TabIndex = 26;
            this.btn_XOA.Text = "Xóa";
            this.btn_XOA.UseVisualStyleBackColor = true;
            this.btn_XOA.Click += new System.EventHandler(this.btn_XOA_Click);
            // 
            // btn_THEM
            // 
            this.btn_THEM.Location = new System.Drawing.Point(40, 30);
            this.btn_THEM.Name = "btn_THEM";
            this.btn_THEM.Size = new System.Drawing.Size(75, 21);
            this.btn_THEM.TabIndex = 24;
            this.btn_THEM.Text = "Thêm";
            this.btn_THEM.UseVisualStyleBackColor = true;
            this.btn_THEM.Click += new System.EventHandler(this.btn_THEM_Click);
            // 
            // btn_SUA
            // 
            this.btn_SUA.Location = new System.Drawing.Point(40, 75);
            this.btn_SUA.Name = "btn_SUA";
            this.btn_SUA.Size = new System.Drawing.Size(75, 21);
            this.btn_SUA.TabIndex = 25;
            this.btn_SUA.Text = "Sửa";
            this.btn_SUA.UseVisualStyleBackColor = true;
            this.btn_SUA.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã sách :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã độc giả :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(49, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 52);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhật Thông Tin Mượn Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richtxt_GHICHU);
            this.groupBox1.Controls.Add(this.txt_MASACH);
            this.groupBox1.Controls.Add(this.txt_MADG);
            this.groupBox1.Controls.Add(this.mkt_NGAYTRA);
            this.groupBox1.Controls.Add(this.mkt_NGAYMUON);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập đầy đủ các thông tin";
            // 
            // DataGrid_MUONTRA
            // 
            this.DataGrid_MUONTRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_MUONTRA.Location = new System.Drawing.Point(97, 236);
            this.DataGrid_MUONTRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGrid_MUONTRA.Name = "DataGrid_MUONTRA";
            this.DataGrid_MUONTRA.RowHeadersWidth = 51;
            this.DataGrid_MUONTRA.RowTemplate.Height = 24;
            this.DataGrid_MUONTRA.Size = new System.Drawing.Size(686, 267);
            this.DataGrid_MUONTRA.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(719, 542);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 34);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // fmMUONTRASACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 600);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.DataGrid_MUONTRA);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmMUONTRASACH";
            this.Text = "fmMUONTRASACH";
            this.Load += new System.EventHandler(this.fmMUONTRASACH_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_MUONTRA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxt_GHICHU;
        private System.Windows.Forms.TextBox txt_MASACH;
        private System.Windows.Forms.TextBox txt_MADG;
        private System.Windows.Forms.MaskedTextBox mkt_NGAYTRA;
        private System.Windows.Forms.MaskedTextBox mkt_NGAYMUON;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_XOA;
        private System.Windows.Forms.Button btn_THEM;
        private System.Windows.Forms.Button btn_SUA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGrid_MUONTRA;
        private System.Windows.Forms.Button btn_back;
    }
}