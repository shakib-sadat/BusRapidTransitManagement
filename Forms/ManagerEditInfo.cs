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
    public partial class ManagerEditInfo : UserControl
    {
        public int managerEditInfoid;
        public ManagerEditInfo(int id)
        {
            InitializeComponent();
            this.managerEditInfoid = id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateGridView()
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();

            if (managerDataAccess.GetManagerInfo(this.managerEditInfoid) != null)
                ManagerinfodataGridView.DataSource = managerDataAccess.GetManagerInfo(this.managerEditInfoid);



        }

        private void ManagerinfodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManagerEditInfo_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            //ManagerNameinfotextBox.Text = ManagerAgeInfotextBox.Text = ManagerPasswordinfotextBox.Text = ManagerEmailinfotextBox.Text = ManagerContactinfotextBox.Text = "";

        }

        private void ManagerUpdateinfobutton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            bool check =false ;
            

            if (ManagerEmailinfotextBox.Text != "")
            {
                if (managerDataAccess.UpdateManagerEmail(this.managerEditInfoid, ManagerEmailinfotextBox.Text) )
                { check = true; }
                else check = false ;
            }


            if (ManagerPasswordinfotextBox.Text != "")
            {
                if (managerDataAccess.UpdateManagerPassword(this.managerEditInfoid, ManagerPasswordinfotextBox.Text))
                { check = true; }
                else check = false;
            }

            if (ManagerContactinfotextBox.Text != "")
            {
                if (managerDataAccess.UpdateManagerContactNo(this.managerEditInfoid, ManagerContactinfotextBox.Text))
                { check = true; }
                else check = false;
            }

            if (ManagerAgeInfotextBox.Text != "")
            {
                if (managerDataAccess.UpdateManagerAge(this.managerEditInfoid, Convert.ToInt32(ManagerAgeInfotextBox.Text)))
                { check = true; }
                else check = false;
            }

            if (ManagerNameinfotextBox.Text != "")
            {
                if (managerDataAccess.UpdateManagerName(this.managerEditInfoid, ManagerNameinfotextBox.Text))
                { check = true; }
                else check = false;
            }

            if (ManageinfomaleradioButton.Checked == true || ManagerInfoFemaleradioButton.Checked == true)
            {
                if (ManageinfomaleradioButton.Checked)
                {
                    if (managerDataAccess.UpdateManagerGender(this.managerEditInfoid, "Male"))
                    { check = true; }
                    else check = false;
                }

                else if (ManagerInfoFemaleradioButton.Checked)
                {
                    if (managerDataAccess.UpdateManagerGender(this.managerEditInfoid, "Female"))
                    { check = true; }
                    else check = false;
                }

                else
                {
                    MessageBox.Show("Enter values");
                }


                if (check == true)
                {
                    MessageBox.Show("Updated Successfully");
                    UpdateGridView();
                    ManagerNameinfotextBox.Text = ManagerAgeInfotextBox.Text = ManagerPasswordinfotextBox.Text = ManagerEmailinfotextBox.Text = ManagerContactinfotextBox.Text =  "";


                }
                

            }
        }
    }
}
