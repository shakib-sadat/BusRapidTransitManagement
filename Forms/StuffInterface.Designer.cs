
namespace BusRapidTransitManagement.Forms
{
    partial class StuffInterface
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
            this.StuffIHomepagepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Customersbutton = new System.Windows.Forms.Button();
            this.PassengerInfobutton = new System.Windows.Forms.Button();
            this.BusInformationbutton = new System.Windows.Forms.Button();
            this.Ticketbutton = new System.Windows.Forms.Button();
            this.StuffLogoutpanel = new System.Windows.Forms.Panel();
            this.StuffLogoutbutton = new System.Windows.Forms.Button();
            this.TicketBookpanel = new System.Windows.Forms.Panel();
            this.BusInfopanel = new System.Windows.Forms.Panel();
            
            this.StuffIHomepagepanel.SuspendLayout();
            this.StuffLogoutpanel.SuspendLayout();
            this.TicketBookpanel.SuspendLayout();
            this.BusInfopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StuffIHomepagepanel
            // 
            this.StuffIHomepagepanel.Controls.Add(this.label1);
            this.StuffIHomepagepanel.Controls.Add(this.Customersbutton);
            this.StuffIHomepagepanel.Controls.Add(this.PassengerInfobutton);
            this.StuffIHomepagepanel.Controls.Add(this.BusInformationbutton);
            this.StuffIHomepagepanel.Controls.Add(this.Ticketbutton);
            this.StuffIHomepagepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StuffIHomepagepanel.Location = new System.Drawing.Point(0, 0);
            this.StuffIHomepagepanel.Name = "StuffIHomepagepanel";
            this.StuffIHomepagepanel.Size = new System.Drawing.Size(1357, 89);
            this.StuffIHomepagepanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Customersbutton
            // 
            this.Customersbutton.Location = new System.Drawing.Point(887, 27);
            this.Customersbutton.Name = "Customersbutton";
            this.Customersbutton.Size = new System.Drawing.Size(132, 32);
            this.Customersbutton.TabIndex = 8;
            this.Customersbutton.Text = "Customers";
            this.Customersbutton.UseVisualStyleBackColor = true;
            // 
            // PassengerInfobutton
            // 
            this.PassengerInfobutton.Location = new System.Drawing.Point(680, 27);
            this.PassengerInfobutton.Name = "PassengerInfobutton";
            this.PassengerInfobutton.Size = new System.Drawing.Size(129, 32);
            this.PassengerInfobutton.TabIndex = 7;
            this.PassengerInfobutton.Text = "Passenger Information";
            this.PassengerInfobutton.UseVisualStyleBackColor = true;
            // 
            // BusInformationbutton
            // 
            this.BusInformationbutton.Location = new System.Drawing.Point(458, 27);
            this.BusInformationbutton.Name = "BusInformationbutton";
            this.BusInformationbutton.Size = new System.Drawing.Size(128, 32);
            this.BusInformationbutton.TabIndex = 6;
            this.BusInformationbutton.Text = "Bus Information";
            this.BusInformationbutton.UseVisualStyleBackColor = true;
            this.BusInformationbutton.Click += new System.EventHandler(this.BusInformationbutton_Click);
            // 
            // Ticketbutton
            // 
            this.Ticketbutton.Location = new System.Drawing.Point(273, 27);
            this.Ticketbutton.Name = "Ticketbutton";
            this.Ticketbutton.Size = new System.Drawing.Size(116, 32);
            this.Ticketbutton.TabIndex = 5;
            this.Ticketbutton.Text = "Ticket";
            this.Ticketbutton.UseVisualStyleBackColor = true;
            this.Ticketbutton.Click += new System.EventHandler(this.Ticketbutton_Click);
            // 
            // StuffLogoutpanel
            // 
            this.StuffLogoutpanel.Controls.Add(this.StuffLogoutbutton);
            this.StuffLogoutpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StuffLogoutpanel.Location = new System.Drawing.Point(0, 89);
            this.StuffLogoutpanel.Name = "StuffLogoutpanel";
            this.StuffLogoutpanel.Size = new System.Drawing.Size(200, 597);
            this.StuffLogoutpanel.TabIndex = 1;
            // 
            // StuffLogoutbutton
            // 
            this.StuffLogoutbutton.Location = new System.Drawing.Point(54, 553);
            this.StuffLogoutbutton.Name = "StuffLogoutbutton";
            this.StuffLogoutbutton.Size = new System.Drawing.Size(116, 32);
            this.StuffLogoutbutton.TabIndex = 6;
            this.StuffLogoutbutton.Text = "Logout";
            this.StuffLogoutbutton.UseVisualStyleBackColor = true;
            this.StuffLogoutbutton.Click += new System.EventHandler(this.StuffLogoutbutton_Click);
            // 
            // TicketBookpanel
            // 
            this.TicketBookpanel.Controls.Add(this.BusInfopanel);
            this.TicketBookpanel.Location = new System.Drawing.Point(206, 95);
            this.TicketBookpanel.Name = "TicketBookpanel";
            this.TicketBookpanel.Size = new System.Drawing.Size(899, 579);
            this.TicketBookpanel.TabIndex = 2;
            // 
            // BusInfopanel
            // 
            
            this.BusInfopanel.Location = new System.Drawing.Point(0, 0);
            this.BusInfopanel.Name = "BusInfopanel";
            this.BusInfopanel.Size = new System.Drawing.Size(893, 576);
            this.BusInfopanel.TabIndex = 0;
            // 
            // userControl11
            // 
           
            // 
            // StuffInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 686);
            this.Controls.Add(this.TicketBookpanel);
            this.Controls.Add(this.StuffLogoutpanel);
            this.Controls.Add(this.StuffIHomepagepanel);
            this.Name = "StuffInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StuffInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StuffInterface_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StuffInterface_FormClosed);
            this.Load += new System.EventHandler(this.StuffInterface_Load);
            this.StuffIHomepagepanel.ResumeLayout(false);
            this.StuffIHomepagepanel.PerformLayout();
            this.StuffLogoutpanel.ResumeLayout(false);
            this.TicketBookpanel.ResumeLayout(false);
            this.BusInfopanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StuffIHomepagepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Customersbutton;
        private System.Windows.Forms.Button PassengerInfobutton;
        private System.Windows.Forms.Button BusInformationbutton;
        private System.Windows.Forms.Button Ticketbutton;
        private System.Windows.Forms.Panel StuffLogoutpanel;
        private System.Windows.Forms.Button StuffLogoutbutton;
        private System.Windows.Forms.Panel TicketBookpanel;
        private System.Windows.Forms.Panel BusInfopanel;
        
    }
}