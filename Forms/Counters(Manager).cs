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

        public void UpdateGridView()
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.GetBusesInfo() != null)
                CountersManagerdataGridView.DataSource = managerDataAccess.GetDestinations();
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
    }
}
