using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace LibraryManagementSytem
{
    public partial class AddBookForm : Form
    {
        

        public AddBookForm()
        {
            InitializeComponent();
        }

        

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.Items.Add("Engilish");
            comboBoxLanguage.Items.Add("Deutsch");
            comboBoxLanguage.Items.Add("Italian");
            comboBoxLanguage.Items.Add("French");
            txtBoxTitle.Focus();

            toolTipWarn.ToolTipIcon = ToolTipIcon.Warning;
            toolTipWarn.ToolTipTitle = "WARNING";
            toolTipWarn.AutomaticDelay = 200;
            toolTipWarn.AutoPopDelay = 2000;

           

            toolTipWarn.SetToolTip(this.txtBoxAuthor, "Required");
            toolTipWarn.SetToolTip(this.txtBoxEditor, "Required");
            toolTipInfo.SetToolTip(this.txtBoxPublisher, "Required");
            toolTipInfo.SetToolTip(this.mskTextBoxAmount, "Required");
            toolTipInfo.SetToolTip(this.mskTextBoxEdition, "Required");
            toolTipInfo.SetToolTip(this.mskTextBoxIsbn, "Required");
            toolTipInfo.SetToolTip(this.mskTextBoxYear, "Required");
            toolTipInfo.SetToolTip(this.txtBoxTitle, "Required");
            toolTipInfo.SetToolTip(this.comboBoxLanguage, "Required");
            toolTipInfo.SetToolTip(this.mskTxtBoxPageCount, "Required");


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxTitle.Clear();
            txtBoxPublisher.Clear();
            txtBoxEditor.Clear();
            txtBoxAuthor.Clear();
            mskTextBoxAmount.Clear();
            mskTextBoxEdition.Clear();
            mskTextBoxIsbn.Clear();
            mskTextBoxYear.Clear();
            mskTxtBoxPageCount.Clear();
            comboBoxLanguage.SelectedIndex = -1;
            txtBoxTitle.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxTitle.Text) || string.IsNullOrEmpty(txtBoxPublisher.Text) || string.IsNullOrEmpty(txtBoxEditor.Text)||string.IsNullOrEmpty(txtBoxAuthor.Text)||string.IsNullOrEmpty(mskTextBoxAmount.Text)||string.IsNullOrEmpty(mskTextBoxEdition.Text)||string.IsNullOrEmpty(mskTextBoxIsbn.Text)||string.IsNullOrEmpty(mskTextBoxYear.Text)||string.IsNullOrEmpty(mskTxtBoxPageCount.Text))
            {
                
                MessageBox.Show("Fill All Area","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                Book newBook = new Book(
                txtBoxTitle.Text.ToLower(),
                txtBoxAuthor.Text.ToLower(),
                txtBoxEditor.Text.ToLower(),
                mskTextBoxIsbn.Text.ToLower(),
                mskTextBoxYear.Text.ToLower(),
                mskTextBoxEdition.Text.ToLower(),
                txtBoxPublisher.Text.ToLower(),
                mskTxtBoxPageCount.Text.ToLower(),
                comboBoxLanguage.SelectedItem.ToString(), mskTextBoxAmount.Text);
                Helper.collection.InsertOne(newBook);
                MessageBox.Show("Book Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
    }
}
