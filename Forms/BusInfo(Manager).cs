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
    public partial class BusInfo_Manager_ : UserControl
    {
        public BusInfo_Manager_()
        {
            InitializeComponent();
            AddBuspanel.Visible = false;
            RemoveBuspanel.Visible = false;
            SearchBuspanel.Visible = false;
        }

        private void AddBusbutton_Click(object sender, EventArgs e)
        {
            AddBuspanel.Visible = true;
            RemoveBuspanel.Visible = false;
            SearchBuspanel.Visible = false;
        }
        void ClearFields()
        {
           
            AddBusNametextBox.Text = string.Empty;
            AddBusCapacitytextBox.Text = string.Empty;
            AddBusArrivaltextBox.Text = string.Empty;
            AddBusDeparturetextBox.Text = string.Empty;
            SearchBustextBox.Text = string.Empty;




        }

        public void UpdateGridview()
        {
            int count = 0;
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.GetBusesInfo() != null)
            { BusInfodataGridView.DataSource = managerDataAccess.GetBusesInfo(); }
            else
                BusInfodataGridView.DataSource = null;
            for (int i = 0; i < BusInfodataGridView.Rows.Count; i++)
            {
                count++;
            }
            BusCountManagerlabel.Text = Convert.ToString(count);
            
            
        }

        private void RemoveBusbutton_Click(object sender, EventArgs e)
        {
            RemoveBuspanel.Visible = true;
            AddBuspanel.Visible = false;
            
            SearchBuspanel.Visible = false;
        }

        private void SearchBusbutton_Click(object sender, EventArgs e)
        {
            AddBuspanel.Visible = false;
            RemoveBuspanel.Visible = false;
            SearchBuspanel.Visible = true;
        }

        private void SearchBusConfirmbutton_Click(object sender, EventArgs e)
        {

        }

        private void AddBusConfirmbutton_Click(object sender, EventArgs e)
        {

            ManagerDataAccess managerDataAccess = new ManagerDataAccess();

            
            if (AddBusNametextBox.Text == "")
            {
                MessageBox.Show("Enter a Name");
            }
            else if (AddBusCapacitytextBox.Text == "")
            {
                MessageBox.Show("Enter Capacity");
            }
            else if (AddBusArrivaltextBox.Text == "")
            {
                MessageBox.Show("Enter Arrival Location");
            }
            else if (AddBusDeparturetextBox.Text == "")
            {
                MessageBox.Show("Enter Departure Location");
            }
            
            else
            {
                if (managerDataAccess.AddBus( AddBusNametextBox.Text, Convert.ToInt32(AddBusCapacitytextBox.Text), AddBusArrivaltextBox.Text, AddBusDeparturetextBox.Text))
                { MessageBox.Show("New Bus Added");
                UpdateGridview();
                ClearFields();
                }
                else
                {
                    MessageBox.Show("Error in Adding");
                    ClearFields();

                }
            }
        }

        private void BusInfo_Manager__Load(object sender, EventArgs e)
        {
            
            UpdateGridview();
            

        }

        private void SearchBustextBox_TextChanged(object sender, EventArgs e)
        {
            ManagerDataAccess manageDataAccess = new ManagerDataAccess();
            BusInfodataGridView.DataSource = manageDataAccess.GetBusesByName(SearchBustextBox.Text);
        }

        private void RemoveBusConfirmbutton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.RemoveBus(Convert.ToInt32(RemoveBustextBox.Text)))
            {
                MessageBox.Show("Bus removed");
                UpdateGridview();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Can Not be Removed");
                ClearFields();
            }
        }
    }
}
