
namespace QLTV_final
{
    partial class fmSACH
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
            this.btn_XOA = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_THEM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGrid_THONGTINSACH = new System.Windows.Forms.DataGridView();
            this.btn_SUA = new System.Windows.Forms.Button();
            this.richtxt_NOTESACH = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_VITRI = new System.Windows.Forms.TextBox();
            this.txt_TENSACH = new System.Windows.Forms.TextBox();
            this.txt_MASACH = new System.Windows.Forms.TextBox();
            this.cbo_TENNXB = new System.Windows.Forms.Label();
            this.cbo_TENTG = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_0 = new System.Windows.Forms.RadioButton();
            this.rad_1 = new System.Windows.Forms.RadioButton();
            this.cboTENNXB = new System.Windows.Forms.ComboBox();
            this.cboTENTG = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_THONGTINSACH)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_XOA
            // 
            this.btn_XOA.Location = new System.Drawing.Point(40, 129);
            this.btn_XOA.Name = "btn_XOA";
            this.btn_XOA.Size = new System.Drawing.Size(75, 21);
            this.btn_XOA.TabIndex = 25;
            this.btn_XOA.Text = "Xóa ";
            this.btn_XOA.UseVisualStyleBackColor = true;
            this.btn_XOA.Click += new System.EventHandler(this.btn_XOA_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tình trạng hiện tại:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ghi chú :";
            // 
            // btn_THEM
            // 
            this.btn_THEM.Location = new System.Drawing.Point(40, 30);
            this.btn_THEM.Name = "btn_THEM";
            this.btn_THEM.Size = new System.Drawing.Size(75, 21);
            this.btn_THEM.TabIndex = 23;
            this.btn_THEM.Text = "Thêm ";
            this.btn_THEM.UseVisualStyleBackColor = true;
            this.btn_THEM.Click += new System.EventHandler(this.btn_THEM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(240, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập Nhật Thông Tin Sách";
            // 
            // DataGrid_THONGTINSACH
            // 
            this.DataGrid_THONGTINSACH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGrid_THONGTINSACH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_THONGTINSACH.Location = new System.Drawing.Point(118, 289);
            this.DataGrid_THONGTINSACH.Name = "DataGrid_THONGTINSACH";
            this.DataGrid_THONGTINSACH.RowHeadersWidth = 51;
            this.DataGrid_THONGTINSACH.Size = new System.Drawing.Size(800, 260);
            this.DataGrid_THONGTINSACH.TabIndex = 10;
            // 
            // btn_SUA
            // 
            this.btn_SUA.Location = new System.Drawing.Point(40, 81);
            this.btn_SUA.Name = "btn_SUA";
            this.btn_SUA.Size = new System.Drawing.Size(75, 21);
            this.btn_SUA.TabIndex = 24;
            this.btn_SUA.Text = "Sửa ";
            this.btn_SUA.UseVisualStyleBackColor = true;
            this.btn_SUA.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // richtxt_NOTESACH
            // 
            this.richtxt_NOTESACH.Location = new System.Drawing.Point(414, 136);
            this.richtxt_NOTESACH.Name = "richtxt_NOTESACH";
            this.richtxt_NOTESACH.Size = new System.Drawing.Size(186, 43);
            this.richtxt_NOTESACH.TabIndex = 11;
            this.richtxt_NOTESACH.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_THEM);
            this.groupBox3.Controls.Add(this.btn_SUA);
            this.groupBox3.Controls.Add(this.btn_XOA);
            this.groupBox3.Location = new System.Drawing.Point(765, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 205);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // txt_VITRI
            // 
            this.txt_VITRI.Location = new System.Drawing.Point(114, 90);
            this.txt_VITRI.Name = "txt_VITRI";
            this.txt_VITRI.Size = new System.Drawing.Size(186, 20);
            this.txt_VITRI.TabIndex = 4;
            // 
            // txt_TENSACH
            // 
            this.txt_TENSACH.Location = new System.Drawing.Point(114, 42);
            this.txt_TENSACH.Name = "txt_TENSACH";
            this.txt_TENSACH.Size = new System.Drawing.Size(186, 20);
            this.txt_TENSACH.TabIndex = 2;
            // 
            // txt_MASACH
            // 
            this.txt_MASACH.Location = new System.Drawing.Point(114, 18);
            this.txt_MASACH.Name = "txt_MASACH";
            this.txt_MASACH.Size = new System.Drawing.Size(186, 20);
            this.txt_MASACH.TabIndex = 1;
            // 
            // cbo_TENNXB
            // 
            this.cbo_TENNXB.AutoSize = true;
            this.cbo_TENNXB.Location = new System.Drawing.Point(339, 70);
            this.cbo_TENNXB.Name = "cbo_TENNXB";
            this.cbo_TENNXB.Size = new System.Drawing.Size(57, 13);
            this.cbo_TENNXB.TabIndex = 6;
            this.cbo_TENNXB.Text = "Tên NXB :";
            // 
            // cbo_TENTG
            // 
            this.cbo_TENTG.AutoSize = true;
            this.cbo_TENTG.Location = new System.Drawing.Point(328, 47);
            this.cbo_TENTG.Name = "cbo_TENTG";
            this.cbo_TENTG.Size = new System.Drawing.Size(67, 13);
            this.cbo_TENTG.TabIndex = 4;
            this.cbo_TENTG.Text = "Tên tác giả :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vị trí sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên sách :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sách :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(118, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 52);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_0);
            this.groupBox1.Controls.Add(this.rad_1);
            this.groupBox1.Controls.Add(this.cboTENNXB);
            this.groupBox1.Controls.Add(this.cboTENTG);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.richtxt_NOTESACH);
            this.groupBox1.Controls.Add(this.txt_VITRI);
            this.groupBox1.Controls.Add(this.txt_TENSACH);
            this.groupBox1.Controls.Add(this.txt_MASACH);
            this.groupBox1.Controls.Add(this.cbo_TENNXB);
            this.groupBox1.Controls.Add(this.cbo_TENTG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(118, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 205);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập đầy đủ các thông tin";
            // 
            // rad_0
            // 
            this.rad_0.AutoSize = true;
            this.rad_0.Location = new System.Drawing.Point(217, 142);
            this.rad_0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rad_0.Name = "rad_0";
            this.rad_0.Size = new System.Drawing.Size(80, 17);
            this.rad_0.TabIndex = 31;
            this.rad_0.TabStop = true;
            this.rad_0.Text = "Đang mượn";
            this.rad_0.UseVisualStyleBackColor = true;
            // 
            // rad_1
            // 
            this.rad_1.AutoSize = true;
            this.rad_1.Location = new System.Drawing.Point(114, 142);
            this.rad_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rad_1.Name = "rad_1";
            this.rad_1.Size = new System.Drawing.Size(79, 17);
            this.rad_1.TabIndex = 30;
            this.rad_1.TabStop = true;
            this.rad_1.Text = "Chưa mượn";
            this.rad_1.UseVisualStyleBackColor = true;
            // 
            // cboTENNXB
            // 
            this.cboTENNXB.FormattingEnabled = true;
            this.cboTENNXB.Location = new System.Drawing.Point(399, 72);
            this.cboTENNXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTENNXB.Name = "cboTENNXB";
            this.cboTENNXB.Size = new System.Drawing.Size(168, 21);
            this.cboTENNXB.TabIndex = 29;
            // 
            // cboTENTG
            // 
            this.cboTENTG.FormattingEnabled = true;
            this.cboTENTG.Location = new System.Drawing.Point(399, 47);
            this.cboTENTG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTENTG.Name = "cboTENTG";
            this.cboTENTG.Size = new System.Drawing.Size(168, 21);
            this.cboTENTG.TabIndex = 28;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(791, 576);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(126, 40);
            this.btn_back.TabIndex = 35;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // fmSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 628);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.DataGrid_THONGTINSACH);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmSACH";
            this.Text = "fmBOOK";
            this.Load += new System.EventHandler(this.fmSACH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_THONGTINSACH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_XOA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_THEM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrid_THONGTINSACH;
        private System.Windows.Forms.Button btn_SUA;
        private System.Windows.Forms.RichTextBox richtxt_NOTESACH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_VITRI;
        private System.Windows.Forms.TextBox txt_TENSACH;
        private System.Windows.Forms.TextBox txt_MASACH;
        private System.Windows.Forms.Label cbo_TENNXB;
        private System.Windows.Forms.Label cbo_TENTG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTENNXB;
        private System.Windows.Forms.ComboBox cboTENTG;
        private System.Windows.Forms.RadioButton rad_0;
        private System.Windows.Forms.RadioButton rad_1;
        private System.Windows.Forms.Button btn_back;
    }
}