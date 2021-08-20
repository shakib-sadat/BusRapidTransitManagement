
namespace BusRapidTransitManagement.Forms
{
    partial class BusInfo_Manager_
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BusInfoEditpanel = new System.Windows.Forms.Panel();
            this.RemoveBusbutton = new System.Windows.Forms.Button();
            this.AddBusbutton = new System.Windows.Forms.Button();
            this.SearchBusbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddBuspanel = new System.Windows.Forms.Panel();
            this.AddBusIdlabel = new System.Windows.Forms.Label();
            this.AddBusArrivallabel = new System.Windows.Forms.Label();
            this.AddBusCapacitylabel = new System.Windows.Forms.Label();
            this.AddBusNamelabel = new System.Windows.Forms.Label();
            this.AddBusIdtextBox = new System.Windows.Forms.TextBox();
            this.AddBusArrivaltextBox = new System.Windows.Forms.TextBox();
            this.AddBusCapacitytextBox = new System.Windows.Forms.TextBox();
            this.AddBusNametextBox = new System.Windows.Forms.TextBox();
            this.AddBusDeparturelabel = new System.Windows.Forms.Label();
            this.AddBusDeparturetextBox = new System.Windows.Forms.TextBox();
            this.AddBusConfirmbutton = new System.Windows.Forms.Button();
            this.RemoveBuspanel = new System.Windows.Forms.Panel();
            this.RemoveBusIlabel = new System.Windows.Forms.Label();
            this.RemoveBusConfirmbutton = new System.Windows.Forms.Button();
            this.SearchBuspanel = new System.Windows.Forms.Panel();
            this.SearchBuslabel = new System.Windows.Forms.Label();
            this.RemoveBuscomboBox = new System.Windows.Forms.ComboBox();
            this.SearchBuscomboBox = new System.Windows.Forms.ComboBox();
            this.SearchBusConfirmbutton = new System.Windows.Forms.Button();
            this.BusInfoEditpanel.SuspendLayout();
            this.AddBuspanel.SuspendLayout();
            this.RemoveBuspanel.SuspendLayout();
            this.SearchBuspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BusInfoEditpanel
            // 
            this.BusInfoEditpanel.Controls.Add(this.RemoveBusbutton);
            this.BusInfoEditpanel.Controls.Add(this.AddBusbutton);
            this.BusInfoEditpanel.Controls.Add(this.SearchBusbutton);
            this.BusInfoEditpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BusInfoEditpanel.Location = new System.Drawing.Point(0, 0);
            this.BusInfoEditpanel.Name = "BusInfoEditpanel";
            this.BusInfoEditpanel.Size = new System.Drawing.Size(200, 574);
            this.BusInfoEditpanel.TabIndex = 0;
            // 
            // RemoveBusbutton
            // 
            this.RemoveBusbutton.Location = new System.Drawing.Point(40, 237);
            this.RemoveBusbutton.Name = "RemoveBusbutton";
            this.RemoveBusbutton.Size = new System.Drawing.Size(100, 23);
            this.RemoveBusbutton.TabIndex = 5;
            this.RemoveBusbutton.Text = "Remove Bus";
            this.RemoveBusbutton.UseVisualStyleBackColor = true;
            this.RemoveBusbutton.Click += new System.EventHandler(this.RemoveBusbutton_Click);
            // 
            // AddBusbutton
            // 
            this.AddBusbutton.Location = new System.Drawing.Point(40, 153);
            this.AddBusbutton.Name = "AddBusbutton";
            this.AddBusbutton.Size = new System.Drawing.Size(100, 23);
            this.AddBusbutton.TabIndex = 3;
            this.AddBusbutton.Text = "Add Bus";
            this.AddBusbutton.UseVisualStyleBackColor = true;
            this.AddBusbutton.Click += new System.EventHandler(this.AddBusbutton_Click);
            // 
            // SearchBusbutton
            // 
            this.SearchBusbutton.Location = new System.Drawing.Point(40, 315);
            this.SearchBusbutton.Name = "SearchBusbutton";
            this.SearchBusbutton.Size = new System.Drawing.Size(100, 23);
            this.SearchBusbutton.TabIndex = 4;
            this.SearchBusbutton.Text = "Search Bus";
            this.SearchBusbutton.UseVisualStyleBackColor = true;
            this.SearchBusbutton.Click += new System.EventHandler(this.SearchBusbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(801, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 574);
            this.panel1.TabIndex = 1;
            // 
            // AddBuspanel
            // 
            this.AddBuspanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddBuspanel.Controls.Add(this.RemoveBuspanel);
            this.AddBuspanel.Controls.Add(this.AddBusConfirmbutton);
            this.AddBuspanel.Controls.Add(this.AddBusDeparturetextBox);
            this.AddBuspanel.Controls.Add(this.AddBusDeparturelabel);
            this.AddBuspanel.Controls.Add(this.AddBusNametextBox);
            this.AddBuspanel.Controls.Add(this.AddBusCapacitytextBox);
            this.AddBuspanel.Controls.Add(this.AddBusArrivaltextBox);
            this.AddBuspanel.Controls.Add(this.AddBusIdtextBox);
            this.AddBuspanel.Controls.Add(this.AddBusNamelabel);
            this.AddBuspanel.Controls.Add(this.AddBusCapacitylabel);
            this.AddBuspanel.Controls.Add(this.AddBusArrivallabel);
            this.AddBuspanel.Controls.Add(this.AddBusIdlabel);
            this.AddBuspanel.Location = new System.Drawing.Point(206, 3);
            this.AddBuspanel.Name = "AddBuspanel";
            this.AddBuspanel.Size = new System.Drawing.Size(589, 568);
            this.AddBuspanel.TabIndex = 2;
            // 
            // AddBusIdlabel
            // 
            this.AddBusIdlabel.AutoSize = true;
            this.AddBusIdlabel.Location = new System.Drawing.Point(60, 57);
            this.AddBusIdlabel.Name = "AddBusIdlabel";
            this.AddBusIdlabel.Size = new System.Drawing.Size(37, 13);
            this.AddBusIdlabel.TabIndex = 0;
            this.AddBusIdlabel.Text = "Bus Id";
            // 
            // AddBusArrivallabel
            // 
            this.AddBusArrivallabel.AutoSize = true;
            this.AddBusArrivallabel.Location = new System.Drawing.Point(60, 254);
            this.AddBusArrivallabel.Name = "AddBusArrivallabel";
            this.AddBusArrivallabel.Size = new System.Drawing.Size(92, 13);
            this.AddBusArrivallabel.TabIndex = 1;
            this.AddBusArrivallabel.Text = "Arrival Destination";
            // 
            // AddBusCapacitylabel
            // 
            this.AddBusCapacitylabel.AutoSize = true;
            this.AddBusCapacitylabel.Location = new System.Drawing.Point(60, 180);
            this.AddBusCapacitylabel.Name = "AddBusCapacitylabel";
            this.AddBusCapacitylabel.Size = new System.Drawing.Size(69, 13);
            this.AddBusCapacitylabel.TabIndex = 2;
            this.AddBusCapacitylabel.Text = "Bus Capacity";
            // 
            // AddBusNamelabel
            // 
            this.AddBusNamelabel.AutoSize = true;
            this.AddBusNamelabel.Location = new System.Drawing.Point(60, 112);
            this.AddBusNamelabel.Name = "AddBusNamelabel";
            this.AddBusNamelabel.Size = new System.Drawing.Size(59, 13);
            this.AddBusNamelabel.TabIndex = 3;
            this.AddBusNamelabel.Text = "Bus Name ";
            // 
            // AddBusIdtextBox
            // 
            this.AddBusIdtextBox.Location = new System.Drawing.Point(180, 49);
            this.AddBusIdtextBox.Name = "AddBusIdtextBox";
            this.AddBusIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.AddBusIdtextBox.TabIndex = 4;
            // 
            // AddBusArrivaltextBox
            // 
            this.AddBusArrivaltextBox.Location = new System.Drawing.Point(180, 251);
            this.AddBusArrivaltextBox.Name = "AddBusArrivaltextBox";
            this.AddBusArrivaltextBox.Size = new System.Drawing.Size(100, 20);
            this.AddBusArrivaltextBox.TabIndex = 5;
            // 
            // AddBusCapacitytextBox
            // 
            this.AddBusCapacitytextBox.Location = new System.Drawing.Point(180, 180);
            this.AddBusCapacitytextBox.Name = "AddBusCapacitytextBox";
            this.AddBusCapacitytextBox.Size = new System.Drawing.Size(100, 20);
            this.AddBusCapacitytextBox.TabIndex = 6;
            // 
            // AddBusNametextBox
            // 
            this.AddBusNametextBox.Location = new System.Drawing.Point(180, 105);
            this.AddBusNametextBox.Name = "AddBusNametextBox";
            this.AddBusNametextBox.Size = new System.Drawing.Size(100, 20);
            this.AddBusNametextBox.TabIndex = 7;
            // 
            // AddBusDeparturelabel
            // 
            this.AddBusDeparturelabel.AutoSize = true;
            this.AddBusDeparturelabel.Location = new System.Drawing.Point(62, 317);
            this.AddBusDeparturelabel.Name = "AddBusDeparturelabel";
            this.AddBusDeparturelabel.Size = new System.Drawing.Size(110, 13);
            this.AddBusDeparturelabel.TabIndex = 8;
            this.AddBusDeparturelabel.Text = "Departure Destination";
            // 
            // AddBusDeparturetextBox
            // 
            this.AddBusDeparturetextBox.Location = new System.Drawing.Point(180, 310);
            this.AddBusDeparturetextBox.Name = "AddBusDeparturetextBox";
            this.AddBusDeparturetextBox.Size = new System.Drawing.Size(100, 20);
            this.AddBusDeparturetextBox.TabIndex = 9;
            // 
            // AddBusConfirmbutton
            // 
            this.AddBusConfirmbutton.Location = new System.Drawing.Point(180, 443);
            this.AddBusConfirmbutton.Name = "AddBusConfirmbutton";
            this.AddBusConfirmbutton.Size = new System.Drawing.Size(100, 23);
            this.AddBusConfirmbutton.TabIndex = 6;
            this.AddBusConfirmbutton.Text = "Add Bus";
            this.AddBusConfirmbutton.UseVisualStyleBackColor = true;
            // 
            // RemoveBuspanel
            // 
            this.RemoveBuspanel.BackColor = System.Drawing.Color.SteelBlue;
            this.RemoveBuspanel.Controls.Add(this.SearchBuspanel);
            this.RemoveBuspanel.Controls.Add(this.RemoveBuscomboBox);
            this.RemoveBuspanel.Controls.Add(this.RemoveBusConfirmbutton);
            this.RemoveBuspanel.Controls.Add(this.RemoveBusIlabel);
            this.RemoveBuspanel.Location = new System.Drawing.Point(0, 0);
            this.RemoveBuspanel.Name = "RemoveBuspanel";
            this.RemoveBuspanel.Size = new System.Drawing.Size(589, 565);
            this.RemoveBuspanel.TabIndex = 10;
            // 
            // RemoveBusIlabel
            // 
            this.RemoveBusIlabel.AutoSize = true;
            this.RemoveBusIlabel.Location = new System.Drawing.Point(83, 112);
            this.RemoveBusIlabel.Name = "RemoveBusIlabel";
            this.RemoveBusIlabel.Size = new System.Drawing.Size(62, 13);
            this.RemoveBusIlabel.TabIndex = 0;
            this.RemoveBusIlabel.Text = "Remove By";
            // 
            // RemoveBusConfirmbutton
            // 
            this.RemoveBusConfirmbutton.Location = new System.Drawing.Point(235, 222);
            this.RemoveBusConfirmbutton.Name = "RemoveBusConfirmbutton";
            this.RemoveBusConfirmbutton.Size = new System.Drawing.Size(100, 23);
            this.RemoveBusConfirmbutton.TabIndex = 6;
            this.RemoveBusConfirmbutton.Text = "Remove";
            this.RemoveBusConfirmbutton.UseVisualStyleBackColor = true;
            // 
            // SearchBuspanel
            // 
            this.SearchBuspanel.BackColor = System.Drawing.Color.SlateGray;
            this.SearchBuspanel.Controls.Add(this.SearchBusConfirmbutton);
            this.SearchBuspanel.Controls.Add(this.SearchBuscomboBox);
            this.SearchBuspanel.Controls.Add(this.SearchBuslabel);
            this.SearchBuspanel.Location = new System.Drawing.Point(3, 3);
            this.SearchBuspanel.Name = "SearchBuspanel";
            this.SearchBuspanel.Size = new System.Drawing.Size(583, 559);
            this.SearchBuspanel.TabIndex = 7;
            // 
            // SearchBuslabel
            // 
            this.SearchBuslabel.AutoSize = true;
            this.SearchBuslabel.Location = new System.Drawing.Point(61, 75);
            this.SearchBuslabel.Name = "SearchBuslabel";
            this.SearchBuslabel.Size = new System.Drawing.Size(56, 13);
            this.SearchBuslabel.TabIndex = 0;
            this.SearchBuslabel.Text = "Search By";
            // 
            // RemoveBuscomboBox
            // 
            this.RemoveBuscomboBox.FormattingEnabled = true;
            this.RemoveBuscomboBox.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Capacity"});
            this.RemoveBuscomboBox.Location = new System.Drawing.Point(235, 103);
            this.RemoveBuscomboBox.Name = "RemoveBuscomboBox";
            this.RemoveBuscomboBox.Size = new System.Drawing.Size(121, 21);
            this.RemoveBuscomboBox.TabIndex = 7;
            // 
            // SearchBuscomboBox
            // 
            this.SearchBuscomboBox.FormattingEnabled = true;
            this.SearchBuscomboBox.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Capacity"});
            this.SearchBuscomboBox.Location = new System.Drawing.Point(182, 72);
            this.SearchBuscomboBox.Name = "SearchBuscomboBox";
            this.SearchBuscomboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchBuscomboBox.TabIndex = 8;
            // 
            // SearchBusConfirmbutton
            // 
            this.SearchBusConfirmbutton.Location = new System.Drawing.Point(182, 155);
            this.SearchBusConfirmbutton.Name = "SearchBusConfirmbutton";
            this.SearchBusConfirmbutton.Size = new System.Drawing.Size(100, 23);
            this.SearchBusConfirmbutton.TabIndex = 6;
            this.SearchBusConfirmbutton.Text = "Search ";
            this.SearchBusConfirmbutton.UseVisualStyleBackColor = true;
            // 
            // BusInfo_Manager_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddBuspanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BusInfoEditpanel);
            this.Name = "BusInfo_Manager_";
            this.Size = new System.Drawing.Size(1001, 574);
            this.BusInfoEditpanel.ResumeLayout(false);
            this.AddBuspanel.ResumeLayout(false);
            this.AddBuspanel.PerformLayout();
            this.RemoveBuspanel.ResumeLayout(false);
            this.RemoveBuspanel.PerformLayout();
            this.SearchBuspanel.ResumeLayout(false);
            this.SearchBuspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BusInfoEditpanel;
        private System.Windows.Forms.Button RemoveBusbutton;
        private System.Windows.Forms.Button AddBusbutton;
        private System.Windows.Forms.Button SearchBusbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel AddBuspanel;
        private System.Windows.Forms.TextBox AddBusNametextBox;
        private System.Windows.Forms.TextBox AddBusCapacitytextBox;
        private System.Windows.Forms.TextBox AddBusArrivaltextBox;
        private System.Windows.Forms.TextBox AddBusIdtextBox;
        private System.Windows.Forms.Label AddBusNamelabel;
        private System.Windows.Forms.Label AddBusCapacitylabel;
        private System.Windows.Forms.Label AddBusArrivallabel;
        private System.Windows.Forms.Label AddBusIdlabel;
        private System.Windows.Forms.TextBox AddBusDeparturetextBox;
        private System.Windows.Forms.Label AddBusDeparturelabel;
        private System.Windows.Forms.Panel RemoveBuspanel;
        private System.Windows.Forms.Panel SearchBuspanel;
        private System.Windows.Forms.ComboBox SearchBuscomboBox;
        private System.Windows.Forms.Label SearchBuslabel;
        private System.Windows.Forms.ComboBox RemoveBuscomboBox;
        private System.Windows.Forms.Button RemoveBusConfirmbutton;
        private System.Windows.Forms.Label RemoveBusIlabel;
        private System.Windows.Forms.Button AddBusConfirmbutton;
        private System.Windows.Forms.Button SearchBusConfirmbutton;
    }
}
