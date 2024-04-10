using de_lucrat_pentru_paw_3.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_lucrat_pentru_paw_3
{
    public partial class MainForm : Form
    {
        public Farm Farm { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Farm = new Farm();
        }

        private void DisplayTractors()
        {
            treeView.Nodes.Clear();
            Farm.Tractors.Sort();
            for (int i = 0; i < Farm.Tractors.Count; i++)
            {
                TreeNode tvn = new TreeNode($"Tractor {i + 1}");
                tvn.Tag = Farm.Tractors[i];
                tvn.Nodes.Add(Farm.Tractors[i].Id.ToString());
                tvn.Nodes.Add(Farm.Tractors[i].Brand);
                tvn.Nodes.Add(Farm.Tractors[i].IsElectric ? "Electric" : "Gas");
                treeView.Nodes.Add(tvn);
            }
        }

        private void buttonAddTractor_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm();
            if(addEditForm.ShowDialog() == DialogResult.OK)
            {
                Farm.Tractors.Add(addEditForm.Tractor);
                DisplayTractors();
            }
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            if(treeView.SelectedNode != null)
            {
                AddEditForm addEditForm = new AddEditForm();
                addEditForm.Tractor = treeView.SelectedNode.Tag as Tractor;
                if (addEditForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayTractors();
                }
            }
        }
    }
}
