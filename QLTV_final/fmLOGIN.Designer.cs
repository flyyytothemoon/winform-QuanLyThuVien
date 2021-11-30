
namespace QLTV_final
{
    partial class fm_LOGIN
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
            this.btn_RESET = new System.Windows.Forms.Button();
            this.txt_PASSWORD = new System.Windows.Forms.TextBox();
            this.txt_gmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RESET
            // 
            this.btn_RESET.Location = new System.Drawing.Point(342, 238);
            this.btn_RESET.Name = "btn_RESET";
            this.btn_RESET.Size = new System.Drawing.Size(75, 23);
            this.btn_RESET.TabIndex = 20;
            this.btn_RESET.Text = "RESET";
            this.btn_RESET.UseVisualStyleBackColor = true;
            // 
            // txt_PASSWORD
            // 
            this.txt_PASSWORD.Location = new System.Drawing.Point(258, 190);
            this.txt_PASSWORD.Name = "txt_PASSWORD";
            this.txt_PASSWORD.Size = new System.Drawing.Size(178, 20);
            this.txt_PASSWORD.TabIndex = 18;
            this.txt_PASSWORD.UseSystemPasswordChar = true;
            // 
            // txt_gmail
            // 
            this.txt_gmail.Location = new System.Drawing.Point(258, 150);
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.Size = new System.Drawing.Size(178, 20);
            this.txt_gmail.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mật khẩu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.Location = new System.Drawing.Point(208, 238);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(75, 23);
            this.btn_sign_in.TabIndex = 21;
            this.btn_sign_in.Text = "Sing in";
            this.btn_sign_in.UseVisualStyleBackColor = true;
            this.btn_sign_in.Click += new System.EventHandler(this.btn_sign_in_Click);
            // 
            // fm_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_sign_in);
            this.Controls.Add(this.btn_RESET);
            this.Controls.Add(this.txt_PASSWORD);
            this.Controls.Add(this.txt_gmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fm_LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.fm_LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RESET;
        private System.Windows.Forms.TextBox txt_PASSWORD;
        private System.Windows.Forms.TextBox txt_gmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sign_in;
    }
}

