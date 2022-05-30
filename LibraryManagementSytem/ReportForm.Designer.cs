namespace LibraryManagementSytem
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.dataGridViewAllBooks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnFindBook = new System.Windows.Forms.Button();
            this.mskTxtBoxEdition = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLendBook = new System.Windows.Forms.Button();
            this.txtBoxStuName = new System.Windows.Forms.TextBox();
            this.txtBoxStuSurname = new System.Windows.Forms.TextBox();
            this.mskTxtBoxStuId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBorrowed = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTakeBook = new System.Windows.Forms.Button();
            this.mskTextStuIdForBack = new System.Windows.Forms.MaskedTextBox();
            this.cmbBoxBooks = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAllBooks
            // 
            this.dataGridViewAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllBooks.Location = new System.Drawing.Point(6, 177);
            this.dataGridViewAllBooks.Name = "dataGridViewAllBooks";
            this.dataGridViewAllBooks.RowHeadersWidth = 51;
            this.dataGridViewAllBooks.RowTemplate.Height = 24;
            this.dataGridViewAllBooks.Size = new System.Drawing.Size(730, 278);
            this.dataGridViewAllBooks.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnLendBook);
            this.groupBox1.Controls.Add(this.txtBoxStuName);
            this.groupBox1.Controls.Add(this.dataGridViewAllBooks);
            this.groupBox1.Controls.Add(this.txtBoxStuSurname);
            this.groupBox1.Controls.Add(this.mskTxtBoxStuId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 536);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lend Book";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnFindBook);
            this.groupBox3.Controls.Add(this.mskTxtBoxEdition);
            this.groupBox3.Controls.Add(this.txtBoxTitle);
            this.groupBox3.Controls.Add(this.txtBoxAuthor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(286, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 150);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FIND BOOK";
            // 
            // BtnFindBook
            // 
            this.BtnFindBook.Location = new System.Drawing.Point(158, 121);
            this.BtnFindBook.Name = "BtnFindBook";
            this.BtnFindBook.Size = new System.Drawing.Size(107, 23);
            this.BtnFindBook.TabIndex = 6;
            this.BtnFindBook.Text = "FIND BOOK";
            this.BtnFindBook.UseVisualStyleBackColor = true;
            this.BtnFindBook.Click += new System.EventHandler(this.BtnFindBook_Click);
            // 
            // mskTxtBoxEdition
            // 
            this.mskTxtBoxEdition.Location = new System.Drawing.Point(90, 89);
            this.mskTxtBoxEdition.Mask = "0000";
            this.mskTxtBoxEdition.Name = "mskTxtBoxEdition";
            this.mskTxtBoxEdition.Size = new System.Drawing.Size(51, 22);
            this.mskTxtBoxEdition.TabIndex = 5;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(91, 22);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTitle.TabIndex = 4;
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(91, 57);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtBoxAuthor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Edition : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Author : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Title : ";
            // 
            // btnLendBook
            // 
            this.btnLendBook.Location = new System.Drawing.Point(286, 461);
            this.btnLendBook.Name = "btnLendBook";
            this.btnLendBook.Size = new System.Drawing.Size(141, 23);
            this.btnLendBook.TabIndex = 6;
            this.btnLendBook.Text = "Lend Book";
            this.btnLendBook.UseVisualStyleBackColor = true;
            this.btnLendBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxStuName
            // 
            this.txtBoxStuName.Location = new System.Drawing.Point(164, 32);
            this.txtBoxStuName.Name = "txtBoxStuName";
            this.txtBoxStuName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxStuName.TabIndex = 5;
            // 
            // txtBoxStuSurname
            // 
            this.txtBoxStuSurname.Location = new System.Drawing.Point(164, 72);
            this.txtBoxStuSurname.Name = "txtBoxStuSurname";
            this.txtBoxStuSurname.Size = new System.Drawing.Size(100, 22);
            this.txtBoxStuSurname.TabIndex = 4;
            // 
            // mskTxtBoxStuId
            // 
            this.mskTxtBoxStuId.Location = new System.Drawing.Point(164, 121);
            this.mskTxtBoxStuId.Mask = "000000000";
            this.mskTxtBoxStuId.Name = "mskTxtBoxStuId";
            this.mskTxtBoxStuId.Size = new System.Drawing.Size(81, 22);
            this.mskTxtBoxStuId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Id : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student SurName : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name : ";
            // 
            // dataGridViewBorrowed
            // 
            this.dataGridViewBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowed.Location = new System.Drawing.Point(773, 12);
            this.dataGridViewBorrowed.Name = "dataGridViewBorrowed";
            this.dataGridViewBorrowed.RowHeadersWidth = 51;
            this.dataGridViewBorrowed.RowTemplate.Height = 24;
            this.dataGridViewBorrowed.Size = new System.Drawing.Size(636, 247);
            this.dataGridViewBorrowed.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTakeBook);
            this.groupBox2.Controls.Add(this.mskTextStuIdForBack);
            this.groupBox2.Controls.Add(this.cmbBoxBooks);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(773, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 253);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Take It Back";
            // 
            // btnTakeBook
            // 
            this.btnTakeBook.Location = new System.Drawing.Point(202, 187);
            this.btnTakeBook.Name = "btnTakeBook";
            this.btnTakeBook.Size = new System.Drawing.Size(83, 23);
            this.btnTakeBook.TabIndex = 5;
            this.btnTakeBook.Text = "Take Book";
            this.btnTakeBook.UseVisualStyleBackColor = true;
            this.btnTakeBook.Click += new System.EventHandler(this.btnTakeBook_Click);
            // 
            // mskTextStuIdForBack
            // 
            this.mskTextStuIdForBack.Location = new System.Drawing.Point(232, 56);
            this.mskTextStuIdForBack.Mask = "000000000";
            this.mskTextStuIdForBack.Name = "mskTextStuIdForBack";
            this.mskTextStuIdForBack.Size = new System.Drawing.Size(100, 22);
            this.mskTextStuIdForBack.TabIndex = 4;
            // 
            // cmbBoxBooks
            // 
            this.cmbBoxBooks.FormattingEnabled = true;
            this.cmbBoxBooks.Location = new System.Drawing.Point(232, 107);
            this.cmbBoxBooks.Name = "cmbBoxBooks";
            this.cmbBoxBooks.Size = new System.Drawing.Size(210, 24);
            this.cmbBoxBooks.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Which Book : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student Id : ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(566, 460);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1431, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewBorrowed);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLendBook;
        private System.Windows.Forms.TextBox txtBoxStuName;
        private System.Windows.Forms.TextBox txtBoxStuSurname;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxStuId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBorrowed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTakeBook;
        private System.Windows.Forms.MaskedTextBox mskTextStuIdForBack;
        private System.Windows.Forms.ComboBox cmbBoxBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnFindBook;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxEdition;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
    }
}