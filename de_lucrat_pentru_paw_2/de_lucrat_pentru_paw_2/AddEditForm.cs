using de_lucrat_pentru_paw_2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_lucrat_pentru_paw_2
{
    public partial class AddEditForm : Form
    {
        public Reservation Reservation { get; set; }

        public AddEditForm()
        {
            InitializeComponent();
            Reservation = new Reservation();
            Reservation.ReservationTime = DateTime.Now;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Reservation.Id = (int)numericUpDownId.Value;
            Reservation.Name = textBoxName.Text;
            Reservation.ReservationTime = dateTimePickerReservationTime.Value;
        }

        private void numericUpDownId_Validating(object sender, CancelEventArgs e)
        {
            if(numericUpDownId.Value < 1 || numericUpDownId.Value > 1000)
            {
                e.Cancel = true;
                errorProvider.SetError(numericUpDownId, "ID must be between 1 and 1000!");
            }
            else
            {
                errorProvider.SetError(numericUpDownId, "");
            }
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxName.Text.Length < 2 || textBoxName.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxName, "Name length must be between 2 and 50!");
            }
            else
            {
                errorProvider.SetError(textBoxName, "");
            }
        }

        private void dateTimePickerReservationTime_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerReservationTime.Value < DateTime.Now)
            {
                e.Cancel = true;
                errorProvider.SetError(dateTimePickerReservationTime, "You can't make reservations in the past!");
            }
            else
            {
                errorProvider.SetError(dateTimePickerReservationTime, "");
            }
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            numericUpDownId.Value = Reservation.Id;
            textBoxName.Text = Reservation.Name;
            dateTimePickerReservationTime.Value = Reservation.ReservationTime;
        }
    }
}
