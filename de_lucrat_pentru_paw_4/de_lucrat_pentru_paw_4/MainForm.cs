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
    public partial class MainForm : Form
    {
        public Restaurant Restaurant { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Restaurant = new Restaurant();
        }

        private void DisplayWaiters()
        {
            listViewWaiters.Items.Clear();
            Restaurant.Waiters.Sort();
            for(int i = 0; i < Restaurant.Waiters.Count; i++)
            {
                string[] row = new string[] { Restaurant.Waiters[i].Id.ToString(), Restaurant.Waiters[i].Name, Restaurant.Waiters[i].BirthDate.ToString() };
                ListViewItem lvi = new ListViewItem(row);
                lvi.Tag = Restaurant.Waiters[i];
                listViewWaiters.Items.Add(lvi);
            }
        }

        private void buttonAddWaiter_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm();
            if(addEditForm.ShowDialog() == DialogResult.OK)
            {
                Restaurant.Waiters.Add(addEditForm.Waiter);
                DisplayWaiters();
            }
        }

        private void listViewWaiters_DoubleClick(object sender, EventArgs e)
        {
            if(listViewWaiters.SelectedItems.Count == 1)
            {
                AddEditForm addEditForm = new AddEditForm();
                addEditForm.Waiter = listViewWaiters.SelectedItems[0].Tag as Waiter;
                if(addEditForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayWaiters();
                }
            }
        }
    }
}
