using de_lucrat_pentru_paw.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_lucrat_pentru_paw
{
    public partial class MainForm : Form
    {
        public Library Library { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Library = new Library();
        }

        private void DisplayBooks()
        {
            listViewBooks.Items.Clear();
            Library.Books.Sort();
            foreach(Book book in Library.Books)
            {
                string[] row = new string[] { book.Id.ToString(), book.Title, book.CreationDate.ToString() };
                ListViewItem lvi = new ListViewItem(row);
                lvi.Tag = book;
                listViewBooks.Items.Add(lvi);
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddEditForm secondaryForm = new AddEditForm();
            if(secondaryForm.ShowDialog() == DialogResult.OK)
            {
                Library.Books.Add(secondaryForm.Book);
                DisplayBooks();
            }
        }

        private void listViewBooks_DoubleClick(object sender, EventArgs e)
        {
            if(listViewBooks.SelectedItems.Count == 1)
            {
                Book book = listViewBooks.SelectedItems[0].Tag as Book;
                AddEditForm secondaryForm = new AddEditForm();
                secondaryForm.Book = book;
                if(secondaryForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayBooks();
                }
            }
        }
    }
}
