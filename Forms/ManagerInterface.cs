﻿using System;
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
    public partial class ManagerInterface : Form
    {
        public ManagerInterface()
        {
            InitializeComponent();
        }

        private void ManagerInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Stuffinformationupdatebutton_Click(object sender, EventArgs e)
        {
            Managerhomepanel.Controls.Add(new StuffInfoControl_manager_());
        }

        private void managerLogoutbutton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ManagerTicketbutton_Click(object sender, EventArgs e)
        {
            Managerhomepanel.Controls.Clear();
            Managerhomepanel.Controls.Add(new Ticketshow_Manager_());
        }

        private void managerBusInformationbutton_Click(object sender, EventArgs e)
        {
            Managerhomepanel.Controls.Clear();
            Managerhomepanel.Controls.Add(new BusInfo_Manager_());
        }
    }
}