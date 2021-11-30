
namespace QLTV_final
{
    partial class Review
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
            this.components = new System.ComponentModel.Container();
            this.cb_book = new System.Windows.Forms.ComboBox();
            this.qLTVTESTDataSet1 = new QLTV_final.QLTVTESTDataSet1();
            this.bookTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTitleTableAdapter = new QLTV_final.QLTVTESTDataSet1TableAdapters.BookTitleTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_reader = new System.Windows.Forms.ComboBox();
            this.qLTVTESTDataSet = new QLTV_final.QLTVTESTDataSet();
            this.qLTVTESTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVTESTDataSet2 = new QLTV_final.QLTVTESTDataSet2();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter = new QLTV_final.QLTVTESTDataSet2TableAdapters.ReaderTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_point = new System.Windows.Forms.TextBox();
            this.date_create = new System.Windows.Forms.DateTimePicker();
            this.a = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVTESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVTESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVTESTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVTESTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_book
            // 
            this.cb_book.DataSource = this.bookTitleBindingSource;
            this.cb_book.DisplayMember = "Name";
            this.cb_book.FormattingEnabled = true;
            this.cb_book.Location = new System.Drawing.Point(159, 112);
            this.cb_book.Name = "cb_book";
            this.cb_book.Size = new System.Drawing.Size(202, 21);
            this.cb_book.TabIndex = 0;
            this.cb_book.ValueMember = "Id";
            // 
            // qLTVTESTDataSet1
            // 
            this.qLTVTESTDataSet1.DataSetName = "QLTVTESTDataSet1";
            this.qLTVTESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTitleBindingSource
            // 
            this.bookTitleBindingSource.DataMember = "BookTitle";
            this.bookTitleBindingSource.DataSource = this.qLTVTESTDataSet1;
            // 
            // bookTitleTableAdapter
            // 
            this.bookTitleTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reader";
            // 
            // cb_reader
            // 
            this.cb_reader.DataSource = this.readerBindingSource;
            this.cb_reader.DisplayMember = "Email";
            this.cb_reader.FormattingEnabled = true;
            this.cb_reader.Location = new System.Drawing.Point(159, 177);
            this.cb_reader.Name = "cb_reader";
            this.cb_reader.Size = new System.Drawing.Size(202, 21);
            this.cb_reader.TabIndex = 3;
            this.cb_reader.ValueMember = "Id";
            // 
            // qLTVTESTDataSet
            // 
            this.qLTVTESTDataSet.DataSetName = "QLTVTESTDataSet";
            this.qLTVTESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLTVTESTDataSetBindingSource
            // 
            this.qLTVTESTDataSetBindingSource.DataSource = this.qLTVTESTDataSet;
            this.qLTVTESTDataSetBindingSource.Position = 0;
            // 
            // qLTVTESTDataSet2
            // 
            this.qLTVTESTDataSet2.DataSetName = "QLTVTESTDataSet2";
            this.qLTVTESTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "Reader";
            this.readerBindingSource.DataSource = this.qLTVTESTDataSet2;
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Point";
            // 
            // txt_point
            // 
            this.txt_point.Location = new System.Drawing.Point(159, 248);
            this.txt_point.Multiline = true;
            this.txt_point.Name = "txt_point";
            this.txt_point.Size = new System.Drawing.Size(202, 25);
            this.txt_point.TabIndex = 5;
            // 
            // date_create
            // 
            this.date_create.Location = new System.Drawing.Point(159, 316);
            this.date_create.Name = "date_create";
            this.date_create.Size = new System.Drawing.Size(202, 20);
            this.date_create.TabIndex = 6;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(30, 314);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(103, 24);
            this.a.TabIndex = 7;
            this.a.Text = "create date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hello user";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(73, 371);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(121, 37);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancle.Location = new System.Drawing.Point(211, 371);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(121, 37);
            this.btn_cancle.TabIndex = 10;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.a);
            this.Controls.Add(this.date_create);
            this.Controls.Add(this.txt_point);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_reader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_book);
            this.Name = "Review";
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTVTESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVTESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVTESTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVTESTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_book;
        private QLTVTESTDataSet1 qLTVTESTDataSet1;
        private System.Windows.Forms.BindingSource bookTitleBindingSource;
        private QLTVTESTDataSet1TableAdapters.BookTitleTableAdapter bookTitleTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_reader;
        private System.Windows.Forms.BindingSource qLTVTESTDataSetBindingSource;
        private QLTVTESTDataSet qLTVTESTDataSet;
        private QLTVTESTDataSet2 qLTVTESTDataSet2;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private QLTVTESTDataSet2TableAdapters.ReaderTableAdapter readerTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_point;
        private System.Windows.Forms.DateTimePicker date_create;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancle;
    }
}