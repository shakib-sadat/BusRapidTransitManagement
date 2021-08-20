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

        private void RemoveBusbutton_Click(object sender, EventArgs e)
        {
            RemoveBuspanel.Visible = true;
            //AddBuspanel.Visible = false;
            
            //SearchBuspanel.Visible = false;
        }

        private void SearchBusbutton_Click(object sender, EventArgs e)
        {
            //AddBuspanel.Visible = false;
            //RemoveBuspanel.Visible = false;
            SearchBuspanel.Visible = true;
        }
    }
}
