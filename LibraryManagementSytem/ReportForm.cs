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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void LoadAllBookGriedView()
        {
            List<Book> allBooks = Helper.collection.AsQueryable().ToList();
            dataGridViewAllBooks.DataSource = allBooks;
        }

        private void LoadALendedBookGriedView()
        {
            List<StudentBook> LendedBooks = Helper.collection2.AsQueryable().ToList();
            dataGridViewBorrowed.DataSource = LendedBooks;
        }
        private void LoadComboBoxBooks()
        {
            List<string> list = new List<string>();
            foreach (DataGridViewRow item in dataGridViewAllBooks.Rows)
            {
                list.Add(item.Cells[1].Value.ToString());
            }
            cmbBoxBooks.DataSource = list;

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadAllBookGriedView();
            LoadALendedBookGriedView();
            LoadComboBoxBooks();
            
            

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBoxStuName.Text) || string.IsNullOrEmpty(txtBoxStuSurname.Text) || string.IsNullOrEmpty(mskTxtBoxStuId.Text))
            {
                MessageBox.Show("Fill All Area","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                StudentBook studentBook = new StudentBook(txtBoxStuName.Text.ToLower(), txtBoxStuSurname.Text.ToLower(), mskTxtBoxStuId.Text.ToLower(),
                dataGridViewAllBooks.CurrentRow.Cells[1].Value.ToString(), dataGridViewAllBooks.CurrentRow.Cells[2].Value.ToString(),
                dataGridViewAllBooks.CurrentRow.Cells[3].Value.ToString(), dataGridViewAllBooks.CurrentRow.Cells[4].Value.ToString(),
                dataGridViewAllBooks.CurrentRow.Cells[5].Value.ToString(), dataGridViewAllBooks.CurrentRow.Cells[6].Value.ToString(),
                dataGridViewAllBooks.CurrentRow.Cells[7].Value.ToString(), dataGridViewAllBooks.CurrentRow.Cells[8].Value.ToString(),
                dataGridViewAllBooks.CurrentRow.Cells[9].Value.ToString(), DateTime.Now.ToString());
                Helper.collection2.InsertOne(studentBook);
                int count=Convert.ToInt32(dataGridViewAllBooks.CurrentRow.Cells[10].Value.ToString());
                if (count > 0)
                {
                    count--;
                    string newCount = count.ToString();
                    var update = Builders<Book>.Update.Set("Amount", newCount);
                    Helper.collection.UpdateOne(bk => bk.Id == ObjectId.Parse(dataGridViewAllBooks.CurrentRow.Cells[0].Value.ToString()), update);
               
                    LoadAllBookGriedView();
                    LoadALendedBookGriedView();
                    MessageBox.Show("Lended", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("There is not enoug book","Warning",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                




            }
            
            
            
                
        }

        private void btnTakeBook_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mskTextStuIdForBack.Text) || string.IsNullOrEmpty(cmbBoxBooks.SelectedItem.ToString())){
                MessageBox.Show("Fill All Area","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var builder = Builders<StudentBook>.Filter;
                var filter = builder.Eq("StudentId", mskTextStuIdForBack.Text) & builder.Eq("Title", cmbBoxBooks.SelectedItem.ToString());
                List<StudentBook> result = Helper.collection2.Find(filter).ToList();
                if (result.Count == 0)
                {
                    MessageBox.Show("There is no record like that","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    var results = Helper.collection.Find(bk => bk.Title == cmbBoxBooks.SelectedItem.ToString()).ToList();
                    int count = Convert.ToInt32(results[0].Amount.ToString());
                    count++;
                    var update = Builders<Book>.Update.Set("Amount", count.ToString());
                    Helper.collection.UpdateOne(bk => bk.Title == cmbBoxBooks.SelectedItem.ToString(), update);


                    Helper.collection2.DeleteOne(sb => sb.StudentId == mskTextStuIdForBack.Text);
                    MessageBox.Show("Taked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadALendedBookGriedView();
                    LoadAllBookGriedView();
                }
            }
        }

        private void BtnFindBook_Click(object sender, EventArgs e)
        {
            var builder = Builders<Book>.Filter;
            var filter = builder.Eq("Author", txtBoxAuthor.Text.ToLower()) | builder.Eq("Title", txtBoxTitle.Text.ToLower()) | builder.Eq("Edition", mskTxtBoxEdition.Text.ToLower());
            List<Book> result = Helper.collection.Find(filter).ToList();
            dataGridViewAllBooks.DataSource = result;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxStuName.Clear();
            txtBoxStuSurname.Clear();
            mskTxtBoxStuId.Clear();
            LoadAllBookGriedView();    
        }
    }
}
