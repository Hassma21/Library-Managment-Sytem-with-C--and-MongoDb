namespace LibraryManagementSytem
{
    partial class UpdateBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBookForm));
            this.label11 = new System.Windows.Forms.Label();
            this.mskTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.mskTxtBoxPageCount = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            this.mskTextBoxEdition = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxEditor = new System.Windows.Forms.TextBox();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTextBoxIsbn = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Author : ";
            // 
            // mskTextBoxAmount
            // 
            this.mskTextBoxAmount.Location = new System.Drawing.Point(397, 385);
            this.mskTextBoxAmount.Mask = "00000";
            this.mskTextBoxAmount.Name = "mskTextBoxAmount";
            this.mskTextBoxAmount.Size = new System.Drawing.Size(44, 22);
            this.mskTextBoxAmount.TabIndex = 41;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Engilish",
            "Deutsch",
            "French",
            "Italian"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(398, 302);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(112, 24);
            this.comboBoxLanguage.TabIndex = 40;
            // 
            // mskTxtBoxPageCount
            // 
            this.mskTxtBoxPageCount.Location = new System.Drawing.Point(398, 224);
            this.mskTxtBoxPageCount.Mask = "00000";
            this.mskTxtBoxPageCount.Name = "mskTxtBoxPageCount";
            this.mskTxtBoxPageCount.Size = new System.Drawing.Size(44, 22);
            this.mskTxtBoxPageCount.TabIndex = 39;
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.Location = new System.Drawing.Point(397, 113);
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(149, 22);
            this.txtBoxPublisher.TabIndex = 38;
            // 
            // mskTextBoxEdition
            // 
            this.mskTextBoxEdition.Location = new System.Drawing.Point(395, 26);
            this.mskTextBoxEdition.Mask = "00000000000";
            this.mskTextBoxEdition.Name = "mskTextBoxEdition";
            this.mskTextBoxEdition.Size = new System.Drawing.Size(83, 22);
            this.mskTextBoxEdition.TabIndex = 37;
            // 
            // mskTextBoxYear
            // 
            this.mskTextBoxYear.Location = new System.Drawing.Point(139, 388);
            this.mskTextBoxYear.Mask = "0000";
            this.mskTextBoxYear.Name = "mskTextBoxYear";
            this.mskTextBoxYear.Size = new System.Drawing.Size(36, 22);
            this.mskTextBoxYear.TabIndex = 36;
            // 
            // txtBoxEditor
            // 
            this.txtBoxEditor.Location = new System.Drawing.Point(99, 224);
            this.txtBoxEditor.Multiline = true;
            this.txtBoxEditor.Name = "txtBoxEditor";
            this.txtBoxEditor.Size = new System.Drawing.Size(152, 21);
            this.txtBoxEditor.TabIndex = 35;
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(99, 124);
            this.txtBoxAuthor.Multiline = true;
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(162, 21);
            this.txtBoxAuthor.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = " Amount : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Language :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Page Count : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Publisher : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Edition : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Publish Year : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "ISBN : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Editor : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 25;
            // 
            // mskTextBoxIsbn
            // 
            this.mskTextBoxIsbn.Location = new System.Drawing.Point(103, 302);
            this.mskTextBoxIsbn.Mask = "00000-9999";
            this.mskTextBoxIsbn.Name = "mskTextBoxIsbn";
            this.mskTextBoxIsbn.Size = new System.Drawing.Size(72, 22);
            this.mskTextBoxIsbn.TabIndex = 24;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(99, 37);
            this.txtBoxTitle.Multiline = true;
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(162, 21);
            this.txtBoxTitle.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Title : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(566, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 380);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Location = new System.Drawing.Point(852, 418);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 23);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(20, 504);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UpdateBookForm
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(1231, 614);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Book";
            this.Load += new System.EventHandler(this.UpdateBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskTextBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxPageCount;
        private System.Windows.Forms.TextBox txtBoxPublisher;
        private System.Windows.Forms.MaskedTextBox mskTextBoxEdition;
        private System.Windows.Forms.MaskedTextBox mskTextBoxYear;
        private System.Windows.Forms.TextBox txtBoxEditor;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTextBoxIsbn;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTipInfo;
    }
}