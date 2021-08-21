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
    public partial class StuffInfoControl_manager_ : UserControl
    {
        public StuffInfoControl_manager_()
        {
            InitializeComponent();
            Addstuffpanel.Visible = false;
            Removestuffpanel.Visible = false;
            UpdateStuffpanel.Visible = false;
        }

        private void StuffInfoControl_manager__Load(object sender, EventArgs e)
        {
            AddGridView();
        }

        void AddGridView()
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.GetStuffControl() != null)
                StuffControldataGridView.DataSource = managerDataAccess.GetStuffControl();
        }

        void ClearFields()
        {
            AddstuffNametextBox.Text = string.Empty;
            AddstuffEmailtextBox.Text = string.Empty;
            AddstuffSalarytextBox.Text = string.Empty;
            AddstuffAgetextBox.Text = string.Empty;
            AddStuffGendertextBox.Text = string.Empty;
            AddstuffContacttextBox.Text = string.Empty;
            AddstuffShifttextBox.Text = string.Empty;


        }
        private void Addstuffbutton_Click(object sender, EventArgs e)
        {
            Addstuffpanel.Visible = true;
            Removestuffpanel.Visible = false;
            UpdateStuffpanel.Visible = false;
        }

        private void Removestuffbutton_Click(object sender, EventArgs e)
        {
            Addstuffpanel.Visible = false;
            Removestuffpanel.Visible = true;
            UpdateStuffpanel.Visible = false;
        }

        private void Managesalarybutton_Click(object sender, EventArgs e)
        {
           
            Removestuffpanel.Visible = false;
            Addstuffpanel.Visible = false;
            UpdateStuffpanel.Visible = true;
        }

        private void AddStuffupdatebutton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            //bool temp = false;
            if(AddstuffNametextBox.Text == "")
            {
                MessageBox.Show("Enter a Name");
            }
            else if(AddstuffEmailtextBox.Text == "")
            {
                MessageBox.Show("Enter an Email Id");
            }
            else if (AddstuffShifttextBox.Text == "")
            {
                MessageBox.Show("Enter Shift");
            }
            else if (AddstuffSalarytextBox.Text == "")
            {
                MessageBox.Show("Enter Salary");
            }
            else if (AddstuffAgetextBox.Text == "")
            {
                MessageBox.Show("Enter Age");
            }
            else if (AddStuffGendertextBox.Text == "")
            {
                MessageBox.Show("Enter Gender");
            }
            else if (AddstuffContacttextBox.Text == "")
            {
                MessageBox.Show("Enter Contact No");
            }
            else 
            {
                if (managerDataAccess.AddStuff(AddstuffNametextBox.Text, AddstuffEmailtextBox.Text, AddstuffShifttextBox.Text, Convert.ToDouble(AddstuffSalarytextBox.Text), Convert.ToInt32(AddstuffAgetextBox.Text), AddStuffGendertextBox.Text, AddstuffContacttextBox.Text))
                {
                    MessageBox.Show("New Stuff Added");
                    AddGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error in Adding");
                    ClearFields();
                }
            }
            

        }

        private void Removestuffupdatebutton1_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if(managerDataAccess.RemoveStuff(Convert.ToInt32(RemovestuffIdtextBox.Text)))
            {
                MessageBox.Show("Stuff removed");
                AddGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Can Not be Removed");
                ClearFields();
            }
        }

        private void ManageSalaryupdatebutton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if(managerDataAccess.ManageSalary(Convert.ToInt32(ManageslaryIdtextBox.Text) , Convert.ToDouble(ManageNewsalarytextBox.Text)))
            {
                MessageBox.Show("Salary Updated");
                AddGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Can Not Update Salary");
                ClearFields();
            }
        }
    }
}

