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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBookForm deleteBookForm = new DeleteBookForm();
            deleteBookForm.Show();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBookForm updateBookForm = new UpdateBookForm();
            updateBookForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

       
    }
}
