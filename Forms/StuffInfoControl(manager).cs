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
            if (managerDataAccess.AddStuff(AddstuffNametextBox.Text, AddstuffEmailtextBox.Text, Convert.ToDouble(AddstuffSalarytextBox.Text) , Convert.ToInt32(AddstuffSalarytextBox.Text) ,AddStuffGendertextBox.Text, AddstuffContacttextBox.Text))
            {
               MessageBox.Show("New Stuff Added");
               AddGridView();
            }

           else
           {
               MessageBox.Show("Error in Adding");
           }

            


            /*if (AddstuffNametextBox.Text != "")
            {
                if (managerDataAccess.AddStuffName(AddstuffNametextBox.Text))
                { temp = true; }
                else temp = false;
            }

            if (AddstuffEmailtextBox.Text != "")
            {
                if (managerDataAccess.AddStuffEmail(AddstuffEmailtextBox.Text))
                { temp = true; }
                else temp = false;
            }

            if(AddstuffSalarytextBox.Text != "")
            {
                if (managerDataAccess.AddStuffSalary(Convert.ToDouble(AddstuffSalarytextBox.Text)))
                { temp = true; }
                else temp = false;
            }
            if (AddStuffGendertextBox.Text != "")
            {
                if (managerDataAccess.AddStuffGender(AddStuffGendertextBox.Text))
                { temp = true; }
                else temp = false;
            }
            if (AddstuffContacttextBox.Text != "")
            {
                if (managerDataAccess.AddStuffContactNo(AddstuffContacttextBox.Text))
                { temp = true; }
                else temp = false;
            }

            if (AddstuffAgetextBox.Text != "")
            {
                if (managerDataAccess.AddStuffAge(Convert.ToInt32(AddstuffAgetextBox.Text)))
                { temp = true; }
                else temp = false;
            }
            else
            {
                MessageBox.Show("Enter Values");
            }

            if(temp == true)
            {
                MessageBox.Show("Added Successfully");

            }*/
        }
    }
}

