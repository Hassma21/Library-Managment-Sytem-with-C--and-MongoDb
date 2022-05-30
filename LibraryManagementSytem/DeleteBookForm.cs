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
using static MongoDB.Bson.Serialization.BsonDeserializationContext;

namespace LibraryManagementSytem
{
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void DeleteBookForm_Load(object sender, EventArgs e)
        {
            cmbBoxLanguage.SelectedIndex = 0;

            LoadGriedView();
        }

       private void LoadGriedView()
        {
            List<Book> books = Helper.collection.AsQueryable().ToList();
            dataGridView1.DataSource = books;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Helper.collection.DeleteOne(bk => bk.Id == ObjectId.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            LoadGriedView();
            MessageBox.Show("Deleted","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            


        }

        private void btnFınd_Click(object sender, EventArgs e)
        {
           
           
            
            var builder = Builders<Book>.Filter;
            var filter = builder.Eq("Author", txtBoxAuthor.Text.ToLower()) | builder.Eq("Language", cmbBoxLanguage.SelectedItem.ToString()) | builder.Eq("PublishYear",mskTextBoxYear.Text.ToLower());
            List<Book> result = Helper.collection.Find(filter).ToList();
            dataGridView1.DataSource = result;
             
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxAuthor.Clear();
            mskTextBoxYear.Clear();
            LoadGriedView();
        }
    }
}
