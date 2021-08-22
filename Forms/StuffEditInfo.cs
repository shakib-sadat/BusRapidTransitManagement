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
    public partial class StuffEditInfo : UserControl
    {
        public int stuffEditInfoid;
        public StuffEditInfo(int id)
        {
            InitializeComponent();
            this.stuffEditInfoid = id;
        }
        private void UpdateGridView()
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();

            if (stuffDataAccess.GetStuffInfo(this.stuffEditInfoid) != null)
                StuffInfodataGridView.DataSource = stuffDataAccess.GetStuffInfo(this.stuffEditInfoid);



        }
        private void StuffEditInfo_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        public void ClearFields()
        {
            StuffEmailinfotextBox.Text = string.Empty;
            StuffPasswordinfotextBox.Text = string.Empty;
            StuffContactinfotextBox.Text = string.Empty;
            StuffAgeInfotextBox.Text = string.Empty;
            StuffNameinfotextBox.Text = string.Empty;
            

        }
        private void StuffinfoUpdatebutton_Click(object sender, EventArgs e)
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();
            bool temp = false;


            if (StuffEmailinfotextBox.Text != "")
            {
                if (stuffDataAccess.UpdateStuffEmail(this.stuffEditInfoid, StuffEmailinfotextBox.Text))
                { temp = true; }
                else temp = false;
            }


            if (StuffPasswordinfotextBox.Text != "")
            {
                if (stuffDataAccess.UpdateStuffPassword(this.stuffEditInfoid, StuffPasswordinfotextBox.Text))
                { temp = true; }
                else temp = false;
            }

            if (StuffContactinfotextBox.Text != "")
            {
                if (stuffDataAccess.UpdateStuffContactNo(this.stuffEditInfoid, StuffContactinfotextBox.Text))
                { temp = true; }
                else temp = false;
            }

            if (StuffAgeInfotextBox.Text != "")
            {
                if (stuffDataAccess.UpdateStuffAge(this.stuffEditInfoid, Convert.ToInt32(StuffAgeInfotextBox.Text)))
                { temp = true; }
                else temp = false;
            }

            if (StuffNameinfotextBox.Text != "")
            {
                if (stuffDataAccess.UpdateStuffName(this.stuffEditInfoid, StuffNameinfotextBox.Text))
                { temp = true; }
                else temp = false;
            }

            if (StuffinfomaleradioButton.Checked == true || StuffInfoFemaleradioButton.Checked == true)
            {
                if (StuffinfomaleradioButton.Checked)
                {
                    if (stuffDataAccess.UpdateStuffGender(this.stuffEditInfoid, "Male"))
                    { temp = true; }
                    else temp = false;
                }

                else if (StuffInfoFemaleradioButton.Checked)
                {
                    if (stuffDataAccess.UpdateStuffGender(this.stuffEditInfoid, "Female"))
                    { temp = true; }
                    else temp = false;
                }

                else
                {
                    MessageBox.Show("Enter values");
                    ClearFields();
                }

            }
            if (temp == true)
            {
                MessageBox.Show("Updated Successfully");
                UpdateGridView();
                ClearFields();
            }
        }
        
    }
}
