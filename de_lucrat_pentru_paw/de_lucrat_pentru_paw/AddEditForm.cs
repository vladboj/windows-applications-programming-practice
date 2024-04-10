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
    public partial class AddEditForm : Form
    {
        public Book Book { get; set; }

        public AddEditForm()
        {
            InitializeComponent();
            Book = new Book();
            Book.CreationDate = DateTime.Now;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Book.Id = (int)numericUpDownId.Value;
            Book.Title = textBoxTitle.Text;
            Book.CreationDate = dateTimePickerCreationDate.Value;
        }

        private void numericUpDownId_Validating(object sender, CancelEventArgs e)
        {
            if(numericUpDownId.Value < 1 || numericUpDownId.Value > 100000)
            {
                e.Cancel = true;
                errorProvider.SetError(numericUpDownId, "ID must be between 1 and 100000!");
            }
            else
            {
                errorProvider.SetError(numericUpDownId, "");
            }
        }

        private void textBoxTitle_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxTitle.Text.Length < 2 || textBoxTitle.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxTitle, "Title must be between 2 and 50!");
            }
            else
            {
                errorProvider.SetError(textBoxTitle, "");
            }
        }

        private void dateTimePickerCreationDate_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePickerCreationDate.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider.SetError(dateTimePickerCreationDate, "Book cannot be created in the future!");
            }
            else
            {
                errorProvider.SetError(dateTimePickerCreationDate, "");
            }
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            numericUpDownId.Value = Book.Id;
            textBoxTitle.Text = Book.Title;
            dateTimePickerCreationDate.Value = Book.CreationDate;
        }
    }
}
