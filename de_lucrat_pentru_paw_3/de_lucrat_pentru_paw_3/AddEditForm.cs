using de_lucrat_pentru_paw_3.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_lucrat_pentru_paw_3
{
    public partial class AddEditForm : Form
    {
        public Tractor Tractor { get; set; }

        public AddEditForm()
        {
            InitializeComponent();
            Tractor = new Tractor();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Tractor.Id = (int)numericUpDownId.Value;
            Tractor.Brand = textBoxBrand.Text;
            Tractor.IsElectric = checkBoxIsElectric.Checked;
        }

        private void numericUpDownId_Validating(object sender, CancelEventArgs e)
        {
            if(numericUpDownId.Value < 1 || numericUpDownId.Value > 100)
            {
                e.Cancel = true;
                errorProvider.SetError(numericUpDownId, "ID must be between 1 and 100!");
            }
            else
            {
                errorProvider.SetError(numericUpDownId, "");
            }
        }

        private void textBoxBrand_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxBrand.Text.Length < 2 || textBoxBrand.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxBrand, "Brand length must be between 2 and 50!");
            }
            else
            {
                errorProvider.SetError(textBoxBrand, "");
            }
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            numericUpDownId.Value = Tractor.Id;
            textBoxBrand.Text = Tractor.Brand;
            checkBoxIsElectric.Checked = Tractor.IsElectric;
        }
    }
}
