
namespace BusRapidTransitManagement.Forms
{
    partial class ManagerInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Managerhomepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.managerCountersbutton = new System.Windows.Forms.Button();
            this.managerPassengerInfobutton = new System.Windows.Forms.Button();
            this.managerBusInformationbutton = new System.Windows.Forms.Button();
            this.ManagerTicketbutton = new System.Windows.Forms.Button();
            this.managerLogoutbutton = new System.Windows.Forms.Button();
            this.managerLogoutpanel = new System.Windows.Forms.Panel();
            this.managereditinfobutton = new System.Windows.Forms.Button();
            this.ManagerIHomepagepanel = new System.Windows.Forms.Panel();
            this.Stuffinformationupdatebutton = new System.Windows.Forms.Button();
            this.managerLogoutpanel.SuspendLayout();
            this.ManagerIHomepagepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Managerhomepanel
            // 
            this.Managerhomepanel.Location = new System.Drawing.Point(206, 89);
            this.Managerhomepanel.Name = "Managerhomepanel";
            this.Managerhomepanel.Size = new System.Drawing.Size(1150, 589);
            this.Managerhomepanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // managerCountersbutton
            // 
            this.managerCountersbutton.Location = new System.Drawing.Point(915, 27);
            this.managerCountersbutton.Name = "managerCountersbutton";
            this.managerCountersbutton.Size = new System.Drawing.Size(132, 32);
            this.managerCountersbutton.TabIndex = 8;
            this.managerCountersbutton.Text = "Counters";
            this.managerCountersbutton.UseVisualStyleBackColor = true;
            // 
            // managerPassengerInfobutton
            // 
            this.managerPassengerInfobutton.Location = new System.Drawing.Point(739, 27);
            this.managerPassengerInfobutton.Name = "managerPassengerInfobutton";
            this.managerPassengerInfobutton.Size = new System.Drawing.Size(129, 32);
            this.managerPassengerInfobutton.TabIndex = 7;
            this.managerPassengerInfobutton.Text = "Passenger Information";
            this.managerPassengerInfobutton.UseVisualStyleBackColor = true;
            // 
            // managerBusInformationbutton
            // 
            this.managerBusInformationbutton.Location = new System.Drawing.Point(567, 27);
            this.managerBusInformationbutton.Name = "managerBusInformationbutton";
            this.managerBusInformationbutton.Size = new System.Drawing.Size(128, 32);
            this.managerBusInformationbutton.TabIndex = 6;
            this.managerBusInformationbutton.Text = "Bus Information";
            this.managerBusInformationbutton.UseVisualStyleBackColor = true;
            this.managerBusInformationbutton.Click += new System.EventHandler(this.managerBusInformationbutton_Click);
            // 
            // ManagerTicketbutton
            // 
            this.ManagerTicketbutton.Location = new System.Drawing.Point(413, 27);
            this.ManagerTicketbutton.Name = "ManagerTicketbutton";
            this.ManagerTicketbutton.Size = new System.Drawing.Size(116, 32);
            this.ManagerTicketbutton.TabIndex = 5;
            this.ManagerTicketbutton.Text = "Ticket";
            this.ManagerTicketbutton.UseVisualStyleBackColor = true;
            this.ManagerTicketbutton.Click += new System.EventHandler(this.ManagerTicketbutton_Click);
            // 
            // managerLogoutbutton
            // 
            this.managerLogoutbutton.Location = new System.Drawing.Point(28, 502);
            this.managerLogoutbutton.Name = "managerLogoutbutton";
            this.managerLogoutbutton.Size = new System.Drawing.Size(116, 32);
            this.managerLogoutbutton.TabIndex = 6;
            this.managerLogoutbutton.Text = "Logout";
            this.managerLogoutbutton.UseVisualStyleBackColor = true;
            this.managerLogoutbutton.Click += new System.EventHandler(this.managerLogoutbutton_Click);
            // 
            // managerLogoutpanel
            // 
            this.managerLogoutpanel.Controls.Add(this.managereditinfobutton);
            this.managerLogoutpanel.Controls.Add(this.managerLogoutbutton);
            this.managerLogoutpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.managerLogoutpanel.Location = new System.Drawing.Point(0, 83);
            this.managerLogoutpanel.Name = "managerLogoutpanel";
            this.managerLogoutpanel.Size = new System.Drawing.Size(200, 595);
            this.managerLogoutpanel.TabIndex = 4;
            // 
            // managereditinfobutton
            // 
            this.managereditinfobutton.Location = new System.Drawing.Point(28, 321);
            this.managereditinfobutton.Name = "managereditinfobutton";
            this.managereditinfobutton.Size = new System.Drawing.Size(116, 32);
            this.managereditinfobutton.TabIndex = 7;
            this.managereditinfobutton.Text = "Edit Info";
            this.managereditinfobutton.UseVisualStyleBackColor = true;
            // 
            // ManagerIHomepagepanel
            // 
            this.ManagerIHomepagepanel.Controls.Add(this.Stuffinformationupdatebutton);
            this.ManagerIHomepagepanel.Controls.Add(this.label1);
            this.ManagerIHomepagepanel.Controls.Add(this.managerCountersbutton);
            this.ManagerIHomepagepanel.Controls.Add(this.managerPassengerInfobutton);
            this.ManagerIHomepagepanel.Controls.Add(this.managerBusInformationbutton);
            this.ManagerIHomepagepanel.Controls.Add(this.ManagerTicketbutton);
            this.ManagerIHomepagepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerIHomepagepanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerIHomepagepanel.Name = "ManagerIHomepagepanel";
            this.ManagerIHomepagepanel.Size = new System.Drawing.Size(1522, 83);
            this.ManagerIHomepagepanel.TabIndex = 3;
            // 
            // Stuffinformationupdatebutton
            // 
            this.Stuffinformationupdatebutton.Location = new System.Drawing.Point(256, 27);
            this.Stuffinformationupdatebutton.Name = "Stuffinformationupdatebutton";
            this.Stuffinformationupdatebutton.Size = new System.Drawing.Size(116, 32);
            this.Stuffinformationupdatebutton.TabIndex = 10;
            this.Stuffinformationupdatebutton.Text = "Stuff Information";
            this.Stuffinformationupdatebutton.UseVisualStyleBackColor = true;
            this.Stuffinformationupdatebutton.Click += new System.EventHandler(this.Stuffinformationupdatebutton_Click);
            // 
            // ManagerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 678);
            this.Controls.Add(this.Managerhomepanel);
            this.Controls.Add(this.managerLogoutpanel);
            this.Controls.Add(this.ManagerIHomepagepanel);
            this.Name = "ManagerInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerInterface_FormClosing);
            this.managerLogoutpanel.ResumeLayout(false);
            this.ManagerIHomepagepanel.ResumeLayout(false);
            this.ManagerIHomepagepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Managerhomepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button managerCountersbutton;
        private System.Windows.Forms.Button managerPassengerInfobutton;
        private System.Windows.Forms.Button managerBusInformationbutton;
        private System.Windows.Forms.Button ManagerTicketbutton;
        private System.Windows.Forms.Button managerLogoutbutton;
        private System.Windows.Forms.Panel managerLogoutpanel;
        private System.Windows.Forms.Button managereditinfobutton;
        private System.Windows.Forms.Panel ManagerIHomepagepanel;
        private System.Windows.Forms.Button Stuffinformationupdatebutton;
    }
}