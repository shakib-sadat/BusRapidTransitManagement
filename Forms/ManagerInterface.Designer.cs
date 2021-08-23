
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerInterface));
            this.Managerhomepanel = new System.Windows.Forms.Panel();
            this.ManagerIdShowlabel = new System.Windows.Forms.Label();
            this.managerCountersbutton = new System.Windows.Forms.Button();
            this.managerBusInformationbutton = new System.Windows.Forms.Button();
            this.ManagerTicketbutton = new System.Windows.Forms.Button();
            this.managerLogoutbutton = new System.Windows.Forms.Button();
            this.managerLogoutpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Stuffinformationupdatebutton = new System.Windows.Forms.Button();
            this.managereditinfobutton = new System.Windows.Forms.Button();
            this.ManagerIHomepagepanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.managerLogoutpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ManagerIHomepagepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Managerhomepanel
            // 
            this.Managerhomepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.Managerhomepanel.Location = new System.Drawing.Point(206, 144);
            this.Managerhomepanel.Name = "Managerhomepanel";
            this.Managerhomepanel.Size = new System.Drawing.Size(1303, 615);
            this.Managerhomepanel.TabIndex = 5;
            // 
            // ManagerIdShowlabel
            // 
            this.ManagerIdShowlabel.AutoSize = true;
            this.ManagerIdShowlabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerIdShowlabel.Location = new System.Drawing.Point(66, 96);
            this.ManagerIdShowlabel.Name = "ManagerIdShowlabel";
            this.ManagerIdShowlabel.Size = new System.Drawing.Size(88, 38);
            this.ManagerIdShowlabel.TabIndex = 9;
            this.ManagerIdShowlabel.Text = "label1";
            this.ManagerIdShowlabel.Click += new System.EventHandler(this.ManagerIdShowlabel_Click);
            // 
            // managerCountersbutton
            // 
            this.managerCountersbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.managerCountersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerCountersbutton.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerCountersbutton.Image = ((System.Drawing.Image)(resources.GetObject("managerCountersbutton.Image")));
            this.managerCountersbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerCountersbutton.Location = new System.Drawing.Point(0, 388);
            this.managerCountersbutton.Name = "managerCountersbutton";
            this.managerCountersbutton.Size = new System.Drawing.Size(197, 50);
            this.managerCountersbutton.TabIndex = 8;
            this.managerCountersbutton.Text = "     Counters";
            this.managerCountersbutton.UseVisualStyleBackColor = false;
            this.managerCountersbutton.Click += new System.EventHandler(this.managerCountersbutton_Click);
            // 
            // managerBusInformationbutton
            // 
            this.managerBusInformationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.managerBusInformationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerBusInformationbutton.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerBusInformationbutton.Image = ((System.Drawing.Image)(resources.GetObject("managerBusInformationbutton.Image")));
            this.managerBusInformationbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerBusInformationbutton.Location = new System.Drawing.Point(0, 309);
            this.managerBusInformationbutton.Name = "managerBusInformationbutton";
            this.managerBusInformationbutton.Size = new System.Drawing.Size(197, 50);
            this.managerBusInformationbutton.TabIndex = 6;
            this.managerBusInformationbutton.Text = "        Bus Information";
            this.managerBusInformationbutton.UseVisualStyleBackColor = false;
            this.managerBusInformationbutton.Click += new System.EventHandler(this.managerBusInformationbutton_Click);
            // 
            // ManagerTicketbutton
            // 
            this.ManagerTicketbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.ManagerTicketbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerTicketbutton.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerTicketbutton.Image = ((System.Drawing.Image)(resources.GetObject("ManagerTicketbutton.Image")));
            this.ManagerTicketbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerTicketbutton.Location = new System.Drawing.Point(0, 149);
            this.ManagerTicketbutton.Name = "ManagerTicketbutton";
            this.ManagerTicketbutton.Size = new System.Drawing.Size(197, 50);
            this.ManagerTicketbutton.TabIndex = 5;
            this.ManagerTicketbutton.Text = "      Ticket";
            this.ManagerTicketbutton.UseVisualStyleBackColor = false;
            this.ManagerTicketbutton.Click += new System.EventHandler(this.ManagerTicketbutton_Click);
            // 
            // managerLogoutbutton
            // 
            this.managerLogoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.managerLogoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerLogoutbutton.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLogoutbutton.Image = ((System.Drawing.Image)(resources.GetObject("managerLogoutbutton.Image")));
            this.managerLogoutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerLogoutbutton.Location = new System.Drawing.Point(0, 554);
            this.managerLogoutbutton.Name = "managerLogoutbutton";
            this.managerLogoutbutton.Size = new System.Drawing.Size(197, 50);
            this.managerLogoutbutton.TabIndex = 6;
            this.managerLogoutbutton.Text = "   Logout";
            this.managerLogoutbutton.UseVisualStyleBackColor = false;
            this.managerLogoutbutton.Click += new System.EventHandler(this.managerLogoutbutton_Click);
            // 
            // managerLogoutpanel
            // 
            this.managerLogoutpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.managerLogoutpanel.Controls.Add(this.label2);
            this.managerLogoutpanel.Controls.Add(this.pictureBox1);
            this.managerLogoutpanel.Controls.Add(this.ManagerIdShowlabel);
            this.managerLogoutpanel.Controls.Add(this.Stuffinformationupdatebutton);
            this.managerLogoutpanel.Controls.Add(this.managereditinfobutton);
            this.managerLogoutpanel.Controls.Add(this.managerLogoutbutton);
            this.managerLogoutpanel.Controls.Add(this.ManagerTicketbutton);
            this.managerLogoutpanel.Controls.Add(this.managerBusInformationbutton);
            this.managerLogoutpanel.Controls.Add(this.managerCountersbutton);
            this.managerLogoutpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.managerLogoutpanel.Location = new System.Drawing.Point(0, 116);
            this.managerLogoutpanel.Name = "managerLogoutpanel";
            this.managerLogoutpanel.Size = new System.Drawing.Size(200, 655);
            this.managerLogoutpanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Manager Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 53);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Stuffinformationupdatebutton
            // 
            this.Stuffinformationupdatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.Stuffinformationupdatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stuffinformationupdatebutton.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stuffinformationupdatebutton.Image = ((System.Drawing.Image)(resources.GetObject("Stuffinformationupdatebutton.Image")));
            this.Stuffinformationupdatebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stuffinformationupdatebutton.Location = new System.Drawing.Point(0, 227);
            this.Stuffinformationupdatebutton.Name = "Stuffinformationupdatebutton";
            this.Stuffinformationupdatebutton.Size = new System.Drawing.Size(197, 50);
            this.Stuffinformationupdatebutton.TabIndex = 10;
            this.Stuffinformationupdatebutton.Text = "        Staff Information";
            this.Stuffinformationupdatebutton.UseVisualStyleBackColor = false;
            this.Stuffinformationupdatebutton.Click += new System.EventHandler(this.Stuffinformationupdatebutton_Click);
            // 
            // managereditinfobutton
            // 
            this.managereditinfobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.managereditinfobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managereditinfobutton.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managereditinfobutton.Image = ((System.Drawing.Image)(resources.GetObject("managereditinfobutton.Image")));
            this.managereditinfobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managereditinfobutton.Location = new System.Drawing.Point(0, 472);
            this.managereditinfobutton.Name = "managereditinfobutton";
            this.managereditinfobutton.Size = new System.Drawing.Size(197, 50);
            this.managereditinfobutton.TabIndex = 7;
            this.managereditinfobutton.Text = "      Edit Info";
            this.managereditinfobutton.UseVisualStyleBackColor = false;
            this.managereditinfobutton.Click += new System.EventHandler(this.managereditinfobutton_Click);
            // 
            // ManagerIHomepagepanel
            // 
            this.ManagerIHomepagepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.ManagerIHomepagepanel.Controls.Add(this.pictureBox2);
            this.ManagerIHomepagepanel.Controls.Add(this.label1);
            this.ManagerIHomepagepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerIHomepagepanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerIHomepagepanel.Name = "ManagerIHomepagepanel";
            this.ManagerIHomepagepanel.Size = new System.Drawing.Size(1521, 116);
            this.ManagerIHomepagepanel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
            this.label1.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(554, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 68);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bus Rapid Transit Management";
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.Refreshbutton.Image = ((System.Drawing.Image)(resources.GetObject("Refreshbutton.Image")));
            this.Refreshbutton.Location = new System.Drawing.Point(1476, 116);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(45, 22);
            this.Refreshbutton.TabIndex = 6;
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // ManagerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1521, 771);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Managerhomepanel);
            this.Controls.Add(this.managerLogoutpanel);
            this.Controls.Add(this.ManagerIHomepagepanel);
            this.MaximumSize = new System.Drawing.Size(1537, 810);
            this.MinimumSize = new System.Drawing.Size(1537, 810);
            this.Name = "ManagerInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerInterface_FormClosing);
            this.Load += new System.EventHandler(this.ManagerInterface_Load);
            this.managerLogoutpanel.ResumeLayout(false);
            this.managerLogoutpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ManagerIHomepagepanel.ResumeLayout(false);
            this.ManagerIHomepagepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Managerhomepanel;
        private System.Windows.Forms.Label ManagerIdShowlabel;
        private System.Windows.Forms.Button managerCountersbutton;
        private System.Windows.Forms.Button managerBusInformationbutton;
        private System.Windows.Forms.Button ManagerTicketbutton;
        private System.Windows.Forms.Button managerLogoutbutton;
        private System.Windows.Forms.Panel managerLogoutpanel;
        private System.Windows.Forms.Button managereditinfobutton;
        private System.Windows.Forms.Panel ManagerIHomepagepanel;
        private System.Windows.Forms.Button Stuffinformationupdatebutton;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}