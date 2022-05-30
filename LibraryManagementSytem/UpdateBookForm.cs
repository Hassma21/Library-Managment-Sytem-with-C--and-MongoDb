using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSytem
{
    public partial class UpdateBookForm : Form
    {
        public UpdateBookForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxTitle.Text =dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBoxAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBoxEditor.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskTextBoxIsbn.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskTextBoxYear.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            mskTextBoxEdition.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtBoxPublisher.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            mskTxtBoxPageCount.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


            comboBoxLanguage.Text= dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            mskTextBoxAmount.Text= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

        }

        private void LoadGriedView()
        {
            List<Book> books = Helper.collection.AsQueryable().ToList();
            dataGridView1.DataSource = books;
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {
            toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo.ToolTipTitle = "WARNING";
            toolTipInfo.AutomaticDelay = 200;
            toolTipInfo.AutoPopDelay = 2000;



            toolTipInfo.SetToolTip(this.txtBoxAuthor, "Required");
            toolTipInfo.SetToolTip(this.txtBoxEditor, "Required");
            toolTipInfo.SetToolTip(this.txtBoxPublisher, "Required");
            toolTipInfo.SetToolTip(this.mskTextBoxAmount, "Required");
            toolTipInfo.SetToolTip(this.mskTextBoxEdition, "Required");
            toolTipInfo.SetToolTip(this.mskTextBoxIsbn, "Required");
            toolTipInfo.SetToolTip(this.mskTextBoxYear, "Required");
            toolTipInfo.SetToolTip(this.txtBoxTitle, "Required");
            toolTipInfo.SetToolTip(this.comboBoxLanguage, "Required");
            toolTipInfo.SetToolTip(this.mskTxtBoxPageCount, "Required");
            LoadGriedView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxTitle.Text) || string.IsNullOrEmpty(txtBoxPublisher.Text) || string.IsNullOrEmpty(txtBoxEditor.Text) || string.IsNullOrEmpty(txtBoxAuthor.Text) || string.IsNullOrEmpty(mskTextBoxAmount.Text) || string.IsNullOrEmpty(mskTextBoxEdition.Text) || string.IsNullOrEmpty(mskTextBoxIsbn.Text) || string.IsNullOrEmpty(mskTextBoxYear.Text) || string.IsNullOrEmpty(mskTxtBoxPageCount.Text) || string.IsNullOrEmpty(mskTxtBoxPageCount.Text))
            {

                MessageBox.Show("Fill All Area", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
              
                var update = Builders<Book>.Update.Set("Title", txtBoxTitle.Text.ToLower()).Set("Author", txtBoxAuthor.Text.ToLower()).Set("Editor", txtBoxEditor.Text.ToLower()).
                    Set("ISBN", mskTextBoxIsbn.Text.ToLower()).Set("PublishYear", mskTextBoxYear.Text.ToLower()).Set("Edition", mskTextBoxEdition.Text.ToLower()).
                    Set("Publisher", txtBoxPublisher.Text.ToLower()).Set("Pagecount", mskTxtBoxPageCount.Text.ToLower()).Set("Language", comboBoxLanguage.SelectedItem.ToString()).
                    Set("Amount", mskTextBoxAmount.Text.ToLower());
                Helper.collection.UpdateOne(bk => bk.Id == ObjectId.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), update);
                MessageBox.Show("Updated","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadGriedView();

            }
            
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
            comboBoxLanguage.SelectedIndex = -1;
            txtBoxTitle.Focus();
        }
    }
}
