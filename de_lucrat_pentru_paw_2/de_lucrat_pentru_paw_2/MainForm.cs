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
    public partial class MainForm : Form
    {
        public Restaurant Restaurant { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Restaurant = new Restaurant();
        }

        private void DisplayReservations()
        {
            dataGridView.Rows.Clear();
            Restaurant.Reservations.Sort();
            for(int i = 0; i <  Restaurant.Reservations.Count; i++)
            {
                string[] row = new string[] { Restaurant.Reservations[i].Id.ToString(), Restaurant.Reservations[i].Name, Restaurant.Reservations[i].ReservationTime.ToString() };
                dataGridView.Rows.Add(row);
                dataGridView.Rows[i].Tag = Restaurant.Reservations[i];
            }
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            AddEditForm secondaryForm = new AddEditForm();
            if(secondaryForm.ShowDialog() == DialogResult.OK)
            {
                Restaurant.Reservations.Add(secondaryForm.Reservation);
                DisplayReservations();
            }
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count == 1)
            {
                AddEditForm secondaryForm = new AddEditForm();
                secondaryForm.Reservation = dataGridView.SelectedRows[0].Tag as Reservation;
                if (secondaryForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayReservations();
                }
            }
        }
    }
}
