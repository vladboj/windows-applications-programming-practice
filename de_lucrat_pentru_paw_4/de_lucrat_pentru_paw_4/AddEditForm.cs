using de_lucrat_pentru_paw_4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_lucrat_pentru_paw_4
{
    public partial class AddEditForm : Form
    {
        public Waiter Waiter { get; set; }

        public AddEditForm()
        {
            InitializeComponent();
            Waiter = new Waiter();
            Waiter.BirthDate = DateTime.Now;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Waiter.Id = (int)numericUpDownId.Value;
            Waiter.Name = textBoxName.Text;
            Waiter.BirthDate = dateTimePickerBirthDate.Value;
        }

        private void numericUpDownId_Validating(object sender, CancelEventArgs e)
        {
            if(numericUpDownId.Value < 1 || numericUpDownId.Value > 20)
            {
                e.Cancel = true;
                errorProvider.SetError(numericUpDownId, "ID must be between 1 and 20!");
            }
            else
            {
                errorProvider.SetError(numericUpDownId, "");
            }
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxName.Text.Length < 2 || textBoxName.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxName, "Name length must be between 2 and 50!");
            }
            else
            {
                errorProvider.SetError(textBoxName, "");
            }
        }

        private void dateTimePickerBirthDate_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePickerBirthDate.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider.SetError(dateTimePickerBirthDate, "Waiter can't be born after this moment!");
            }
            else
            {
                errorProvider.SetError(dateTimePickerBirthDate, "");
            }
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            numericUpDownId.Value = Waiter.Id;
            textBoxName.Text = Waiter.Name;
            dateTimePickerBirthDate.Value = Waiter.BirthDate;
        }
    }
}
