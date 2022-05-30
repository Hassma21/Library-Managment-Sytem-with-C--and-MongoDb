namespace LibraryManagementSytem
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.mskTextBoxIsbn = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.txtBoxEditor = new System.Windows.Forms.TextBox();
            this.mskTextBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBoxEdition = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            this.mskTxtBoxPageCount = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.mskTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTipWarn = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title : ";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(143, 78);
            this.txtBoxTitle.Multiline = true;
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(112, 21);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // mskTextBoxIsbn
            // 
            this.mskTextBoxIsbn.Location = new System.Drawing.Point(143, 346);
            this.mskTextBoxIsbn.Mask = "00000-9999";
            this.mskTextBoxIsbn.Name = "mskTextBoxIsbn";
            this.mskTextBoxIsbn.Size = new System.Drawing.Size(72, 23);
            this.mskTextBoxIsbn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Editor : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "ISBN : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Publish Year : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Edition : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(795, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Publisher : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(777, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Page Count : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(799, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Language :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(799, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = " Amount : ";
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(143, 168);
            this.txtBoxAuthor.Multiline = true;
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(112, 21);
            this.txtBoxAuthor.TabIndex = 12;
            // 
            // txtBoxEditor
            // 
            this.txtBoxEditor.Location = new System.Drawing.Point(143, 267);
            this.txtBoxEditor.Multiline = true;
            this.txtBoxEditor.Name = "txtBoxEditor";
            this.txtBoxEditor.Size = new System.Drawing.Size(112, 21);
            this.txtBoxEditor.TabIndex = 13;
            // 
            // mskTextBoxYear
            // 
            this.mskTextBoxYear.Location = new System.Drawing.Point(143, 432);
            this.mskTextBoxYear.Mask = "0000";
            this.mskTextBoxYear.Name = "mskTextBoxYear";
            this.mskTextBoxYear.Size = new System.Drawing.Size(36, 23);
            this.mskTextBoxYear.TabIndex = 14;
            // 
            // mskTextBoxEdition
            // 
            this.mskTextBoxEdition.Location = new System.Drawing.Point(948, 70);
            this.mskTextBoxEdition.Mask = "00000000000";
            this.mskTextBoxEdition.Name = "mskTextBoxEdition";
            this.mskTextBoxEdition.Size = new System.Drawing.Size(83, 23);
            this.mskTextBoxEdition.TabIndex = 15;
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.Location = new System.Drawing.Point(948, 168);
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(112, 23);
            this.txtBoxPublisher.TabIndex = 16;
            // 
            // mskTxtBoxPageCount
            // 
            this.mskTxtBoxPageCount.Location = new System.Drawing.Point(948, 267);
            this.mskTxtBoxPageCount.Mask = "00000";
            this.mskTxtBoxPageCount.Name = "mskTxtBoxPageCount";
            this.mskTxtBoxPageCount.Size = new System.Drawing.Size(44, 23);
            this.mskTxtBoxPageCount.TabIndex = 17;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(948, 354);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(112, 23);
            this.comboBoxLanguage.TabIndex = 18;
            // 
            // mskTextBoxAmount
            // 
            this.mskTextBoxAmount.Location = new System.Drawing.Point(948, 429);
            this.mskTextBoxAmount.Mask = "00000";
            this.mskTextBoxAmount.Name = "mskTextBoxAmount";
            this.mskTextBoxAmount.Size = new System.Drawing.Size(44, 23);
            this.mskTextBoxAmount.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(554, 506);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 22);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Author : ";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(955, 506);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AddBookForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(1160, 585);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mskTextBoxAmount);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.mskTxtBoxPageCount);
            this.Controls.Add(this.txtBoxPublisher);
            this.Controls.Add(this.mskTextBoxEdition);
            this.Controls.Add(this.mskTextBoxYear);
            this.Controls.Add(this.txtBoxEditor);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskTextBoxIsbn);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Felix Titling", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.MaskedTextBox mskTextBoxIsbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.TextBox txtBoxEditor;
        private System.Windows.Forms.MaskedTextBox mskTextBoxYear;
        private System.Windows.Forms.MaskedTextBox mskTextBoxEdition;
        private System.Windows.Forms.TextBox txtBoxPublisher;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxPageCount;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.MaskedTextBox mskTextBoxAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTipWarn;
        private System.Windows.Forms.ToolTip toolTipInfo;
    }
}