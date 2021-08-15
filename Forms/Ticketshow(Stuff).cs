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
    public partial class Ticketshow_Stuff_ : UserControl
    {
        public Ticketshow_Stuff_()
        {
            InitializeComponent();
            BookTicketpanel.Visible = false;
            CancelTicketpanel.Visible = false;
        }

       

        
        private void DepartureTimelabel_Click(object sender, EventArgs e)
        {

        }

        private void BookTicketbutton_Click(object sender, EventArgs e)
        {
            CancelTicketpanel.Visible = false;
            BookTicketpanel.Visible = true;
            
        }

        private void CancelTicketbutton_Click(object sender, EventArgs e)
        {
            //BookTicketpanel.Visible = false;
            CancelTicketpanel.Visible = true;
            
        }
    }
}
