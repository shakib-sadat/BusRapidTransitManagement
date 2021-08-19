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
    }
}
