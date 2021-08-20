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
    public partial class Ticketshow_Manager_ : UserControl
    {
        public Ticketshow_Manager_()
        {
            InitializeComponent();
            BookTicketManagerpanel.Visible = false;
            CancelTicketManagerpanel.Visible = false;
        }

        private void BookTicketManagerbutton_Click(object sender, EventArgs e)
        {
            CancelTicketManagerpanel.Visible = false;
            BookTicketManagerpanel.Visible = true;
        }

        private void CancelTicketManagerbutton_Click(object sender, EventArgs e)
        {
            //BookTicketManagerpanel.Visible = false ;
            CancelTicketManagerpanel.Visible = true;
        }
    }
}
