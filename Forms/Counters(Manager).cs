using BusRapidTransitManagement.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusRapidTransitManagement.Forms
{
    public partial class Counters_Manager_ : UserControl
    {
        public Counters_Manager_()
        {
            InitializeComponent();
            RemoveCounterpanel.Visible = false;
            AddCounterpanel.Visible = false;
        }

        private void Counters_Manager__Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        public void ClearFields()
        {
            RemoveCountertextBox.Text = string.Empty;
            AddCountertextBox.Text = string.Empty;
        }

        public void UpdateGridView()
        {
            int count = 0;
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.GetDestinations() != null)
                CountersManagerdataGridView.DataSource = managerDataAccess.GetDestinations();
            for (int i = 0; i < CountersManagerdataGridView.Rows.Count; i++)
            {
                count++;
            }
            CounterCountlabel.Text = Convert.ToString(count);
        }

        private void AddCounterbutton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (AddCountertextBox.Text == "")
            {
                MessageBox.Show("Enter Counter");
            }
            else
            {
                if(managerDataAccess.AddCounters(AddCountertextBox.Text))
                {
                    MessageBox.Show("Counter Added");
                    UpdateGridView();
                    AddCountertextBox.Text = "";
                }
                else { MessageBox.Show("Error in Adding"); }
                    
            }
        }

        private void RemoveCountertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveCounterManagerbutton_Click(object sender, EventArgs e)
        {
            RemoveCounterpanel.Visible = true;
            AddCounterpanel.Visible = false;
        }

        private void AddCounterManagerbutton_Click(object sender, EventArgs e)
        {
            RemoveCounterpanel.Visible = false;
            AddCounterpanel.Visible = true;
        }

        private void RemoveCounterbutton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if(RemoveCountertextBox.Text == "")
            {
                MessageBox.Show("Enter a Location");
            }
            else
            {
                if (managerDataAccess.RemoveCounters(RemoveCountertextBox.Text))
                {
                    MessageBox.Show("Counter Removed");
                    UpdateGridView();
                    RemoveCountertextBox.Text = "";
                }
                else
                    MessageBox.Show("Falied to Remove Counter");
            }
        }
    }
}
