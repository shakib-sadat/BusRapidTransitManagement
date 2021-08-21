
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
            this.AddBuspanel = new System.Windows.Forms.Panel();
            this.RemoveBuspanel = new System.Windows.Forms.Panel();
            this.SearchBuspanel = new System.Windows.Forms.Panel();
            this.SearchBuslabel = new System.Windows.Forms.Label();
            this.RemoveBusConfirmbutton = new System.Windows.Forms.Button();
            this.RemoveBusIlabel = new System.Windows.Forms.Label();
            this.AddBusConfirmbutton = new System.Windows.Forms.Button();
            this.AddBusDeparturetextBox = new System.Windows.Forms.TextBox();
            this.AddBusDeparturelabel = new System.Windows.Forms.Label();
            this.AddBusNametextBox = new System.Windows.Forms.TextBox();
            this.AddBusCapacitytextBox = new System.Windows.Forms.TextBox();
            this.AddBusArrivaltextBox = new System.Windows.Forms.TextBox();
            this.AddBusNamelabel = new System.Windows.Forms.Label();
            this.AddBusCapacitylabel = new System.Windows.Forms.Label();
            this.AddBusArrivallabel = new System.Windows.Forms.Label();
            this.BusInfogroupBox = new System.Windows.Forms.GroupBox();
            this.BusInfodataGridView = new System.Windows.Forms.DataGridView();
            this.RemoveBustextBox = new System.Windows.Forms.TextBox();
            this.SearchBustextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Removelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BusInfoEditpanel.SuspendLayout();
            this.AddBuspanel.SuspendLayout();
            this.RemoveBuspanel.SuspendLayout();
            this.SearchBuspanel.SuspendLayout();
            this.BusInfogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusInfodataGridView)).BeginInit();
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
            // AddBuspanel
            // 
            this.AddBuspanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddBuspanel.Controls.Add(this.label2);
            this.AddBuspanel.Controls.Add(this.AddBusConfirmbutton);
            this.AddBuspanel.Controls.Add(this.AddBusDeparturetextBox);
            this.AddBuspanel.Controls.Add(this.AddBusDeparturelabel);
            this.AddBuspanel.Controls.Add(this.AddBusNametextBox);
            this.AddBuspanel.Controls.Add(this.AddBusCapacitytextBox);
            this.AddBuspanel.Controls.Add(this.AddBusArrivaltextBox);
            this.AddBuspanel.Controls.Add(this.AddBusNamelabel);
            this.AddBuspanel.Controls.Add(this.AddBusCapacitylabel);
            this.AddBuspanel.Controls.Add(this.AddBusArrivallabel);
            this.AddBuspanel.Location = new System.Drawing.Point(206, 35);
            this.AddBuspanel.Name = "AddBuspanel";
            this.AddBuspanel.Size = new System.Drawing.Size(356, 452);
            this.AddBuspanel.TabIndex = 2;
            // 
            // RemoveBuspanel
            // 
            this.RemoveBuspanel.BackColor = System.Drawing.Color.SteelBlue;
            this.RemoveBuspanel.Controls.Add(this.Removelabel);
            this.RemoveBuspanel.Controls.Add(this.RemoveBustextBox);
            this.RemoveBuspanel.Controls.Add(this.RemoveBusConfirmbutton);
            this.RemoveBuspanel.Controls.Add(this.RemoveBusIlabel);
            this.RemoveBuspanel.Location = new System.Drawing.Point(568, 295);
            this.RemoveBuspanel.Name = "RemoveBuspanel";
            this.RemoveBuspanel.Size = new System.Drawing.Size(352, 276);
            this.RemoveBuspanel.TabIndex = 10;
            // 
            // SearchBuspanel
            // 
            this.SearchBuspanel.BackColor = System.Drawing.Color.SlateGray;
            this.SearchBuspanel.Controls.Add(this.label1);
            this.SearchBuspanel.Controls.Add(this.SearchBustextBox);
            this.SearchBuspanel.Controls.Add(this.SearchBuslabel);
            this.SearchBuspanel.Location = new System.Drawing.Point(568, 35);
            this.SearchBuspanel.Name = "SearchBuspanel";
            this.SearchBuspanel.Size = new System.Drawing.Size(352, 254);
            this.SearchBuspanel.TabIndex = 7;
            // 
            // SearchBuslabel
            // 
            this.SearchBuslabel.AutoSize = true;
            this.SearchBuslabel.Location = new System.Drawing.Point(61, 75);
            this.SearchBuslabel.Name = "SearchBuslabel";
            this.SearchBuslabel.Size = new System.Drawing.Size(41, 13);
            this.SearchBuslabel.TabIndex = 0;
            this.SearchBuslabel.Text = "Search";
            // 
            // RemoveBusConfirmbutton
            // 
            this.RemoveBusConfirmbutton.Location = new System.Drawing.Point(136, 196);
            this.RemoveBusConfirmbutton.Name = "RemoveBusConfirmbutton";
            this.RemoveBusConfirmbutton.Size = new System.Drawing.Size(100, 23);
            this.RemoveBusConfirmbutton.TabIndex = 6;
            this.RemoveBusConfirmbutton.Text = "Remove";
            this.RemoveBusConfirmbutton.UseVisualStyleBackColor = true;
            this.RemoveBusConfirmbutton.Click += new System.EventHandler(this.RemoveBusConfirmbutton_Click);
            // 
            // RemoveBusIlabel
            // 
            this.RemoveBusIlabel.AutoSize = true;
            this.RemoveBusIlabel.Location = new System.Drawing.Point(150, 28);
            this.RemoveBusIlabel.Name = "RemoveBusIlabel";
            this.RemoveBusIlabel.Size = new System.Drawing.Size(68, 13);
            this.RemoveBusIlabel.TabIndex = 0;
            this.RemoveBusIlabel.Text = "Remove Bus";
            // 
            // AddBusConfirmbutton
            // 
            this.AddBusConfirmbutton.Location = new System.Drawing.Point(134, 385);
            this.AddBusConfirmbutton.Name = "AddBusConfirmbutton";
            this.AddBusConfirmbutton.Size = new System.Drawing.Size(97, 23);
            this.AddBusConfirmbutton.TabIndex = 6;
            this.AddBusConfirmbutton.Text = "Add ";
            this.AddBusConfirmbutton.UseVisualStyleBackColor = true;
            this.AddBusConfirmbutton.Click += new System.EventHandler(this.AddBusConfirmbutton_Click);
            // 
            // AddBusDeparturetextBox
            // 
            this.AddBusDeparturetextBox.Location = new System.Drawing.Point(156, 323);
            this.AddBusDeparturetextBox.Name = "AddBusDeparturetextBox";
            this.AddBusDeparturetextBox.Size = new System.Drawing.Size(100, 20);
            this.AddBusDeparturetextBox.TabIndex = 9;
            // 
            // AddBusDeparturelabel
            // 
            this.AddBusDeparturelabel.AutoSize = true;
            this.AddBusDeparturelabel.Location = new System.Drawing.Point(36, 326);
            this.AddBusDeparturelabel.Name = "AddBusDeparturelabel";
            this.AddBusDeparturelabel.Size = new System.Drawing.Size(110, 13);
            this.AddBusDeparturelabel.TabIndex = 8;
            this.AddBusDeparturelabel.Text = "Departure Destination";
            // 
            // AddBusNametextBox
            // 
            this.AddBusNametextBox.Location = new System.Drawing.Point(156, 115);
            this.AddBusNametextBox.Name = "AddBusNametextBox";
            this.AddBusNametextBox.Size = new System.Drawing.Size(100, 20);
            this.AddBusNametextBox.TabIndex = 7;
            // 
            // AddBusCapacitytextBox
            // 
            this.AddBusCapacitytextBox.Location = new System.Drawing.Point(156, 183);
            this.AddBusCapacitytextBox.Name = "AddBusCapacitytextBox";
            this.AddBusCapacitytextBox.Size = new System.Drawing.Size(100, 20);
            this.AddBusCapacitytextBox.TabIndex = 6;
            // 
            // AddBusArrivaltextBox
            // 
            this.AddBusArrivaltextBox.Location = new System.Drawing.Point(156, 260);
            this.AddBusArrivaltextBox.Name = "AddBusArrivaltextBox";
            this.AddBusArrivaltextBox.Size = new System.Drawing.Size(100, 20);
            this.AddBusArrivaltextBox.TabIndex = 5;
            // 
            // AddBusNamelabel
            // 
            this.AddBusNamelabel.AutoSize = true;
            this.AddBusNamelabel.Location = new System.Drawing.Point(36, 118);
            this.AddBusNamelabel.Name = "AddBusNamelabel";
            this.AddBusNamelabel.Size = new System.Drawing.Size(59, 13);
            this.AddBusNamelabel.TabIndex = 3;
            this.AddBusNamelabel.Text = "Bus Name ";
            // 
            // AddBusCapacitylabel
            // 
            this.AddBusCapacitylabel.AutoSize = true;
            this.AddBusCapacitylabel.Location = new System.Drawing.Point(36, 186);
            this.AddBusCapacitylabel.Name = "AddBusCapacitylabel";
            this.AddBusCapacitylabel.Size = new System.Drawing.Size(69, 13);
            this.AddBusCapacitylabel.TabIndex = 2;
            this.AddBusCapacitylabel.Text = "Bus Capacity";
            // 
            // AddBusArrivallabel
            // 
            this.AddBusArrivallabel.AutoSize = true;
            this.AddBusArrivallabel.Location = new System.Drawing.Point(36, 263);
            this.AddBusArrivallabel.Name = "AddBusArrivallabel";
            this.AddBusArrivallabel.Size = new System.Drawing.Size(92, 13);
            this.AddBusArrivallabel.TabIndex = 1;
            this.AddBusArrivallabel.Text = "Arrival Destination";
            // 
            // BusInfogroupBox
            // 
            this.BusInfogroupBox.Controls.Add(this.BusInfodataGridView);
            this.BusInfogroupBox.Location = new System.Drawing.Point(926, 35);
            this.BusInfogroupBox.Name = "BusInfogroupBox";
            this.BusInfogroupBox.Size = new System.Drawing.Size(462, 301);
            this.BusInfogroupBox.TabIndex = 11;
            this.BusInfogroupBox.TabStop = false;
            this.BusInfogroupBox.Text = "Bus ";
            // 
            // BusInfodataGridView
            // 
            this.BusInfodataGridView.AllowUserToAddRows = false;
            this.BusInfodataGridView.AllowUserToDeleteRows = false;
            this.BusInfodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusInfodataGridView.Location = new System.Drawing.Point(7, 20);
            this.BusInfodataGridView.Name = "BusInfodataGridView";
            this.BusInfodataGridView.ReadOnly = true;
            this.BusInfodataGridView.Size = new System.Drawing.Size(449, 264);
            this.BusInfodataGridView.TabIndex = 0;
            // 
            // RemoveBustextBox
            // 
            this.RemoveBustextBox.Location = new System.Drawing.Point(136, 93);
            this.RemoveBustextBox.Name = "RemoveBustextBox";
            this.RemoveBustextBox.Size = new System.Drawing.Size(100, 20);
            this.RemoveBustextBox.TabIndex = 10;
            // 
            // SearchBustextBox
            // 
            this.SearchBustextBox.Location = new System.Drawing.Point(136, 72);
            this.SearchBustextBox.Name = "SearchBustextBox";
            this.SearchBustextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchBustextBox.TabIndex = 11;
            this.SearchBustextBox.TextChanged += new System.EventHandler(this.SearchBustextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Bus";
            // 
            // Removelabel
            // 
            this.Removelabel.AutoSize = true;
            this.Removelabel.Location = new System.Drawing.Point(61, 100);
            this.Removelabel.Name = "Removelabel";
            this.Removelabel.Size = new System.Drawing.Size(37, 13);
            this.Removelabel.TabIndex = 11;
            this.Removelabel.Text = "Bus Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add Bus";
            // 
            // BusInfo_Manager_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BusInfogroupBox);
            this.Controls.Add(this.SearchBuspanel);
            this.Controls.Add(this.RemoveBuspanel);
            this.Controls.Add(this.AddBuspanel);
            this.Controls.Add(this.BusInfoEditpanel);
            this.Name = "BusInfo_Manager_";
            this.Size = new System.Drawing.Size(1548, 574);
            this.Load += new System.EventHandler(this.BusInfo_Manager__Load);
            this.BusInfoEditpanel.ResumeLayout(false);
            this.AddBuspanel.ResumeLayout(false);
            this.AddBuspanel.PerformLayout();
            this.RemoveBuspanel.ResumeLayout(false);
            this.RemoveBuspanel.PerformLayout();
            this.SearchBuspanel.ResumeLayout(false);
            this.SearchBuspanel.PerformLayout();
            this.BusInfogroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BusInfodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BusInfoEditpanel;
        private System.Windows.Forms.Button RemoveBusbutton;
        private System.Windows.Forms.Button AddBusbutton;
        private System.Windows.Forms.Button SearchBusbutton;
        private System.Windows.Forms.Panel AddBuspanel;
        private System.Windows.Forms.TextBox AddBusNametextBox;
        private System.Windows.Forms.TextBox AddBusCapacitytextBox;
        private System.Windows.Forms.TextBox AddBusArrivaltextBox;
        private System.Windows.Forms.Label AddBusNamelabel;
        private System.Windows.Forms.Label AddBusCapacitylabel;
        private System.Windows.Forms.Label AddBusArrivallabel;
        private System.Windows.Forms.TextBox AddBusDeparturetextBox;
        private System.Windows.Forms.Label AddBusDeparturelabel;
        private System.Windows.Forms.Panel RemoveBuspanel;
        private System.Windows.Forms.Panel SearchBuspanel;
        private System.Windows.Forms.Label SearchBuslabel;
        private System.Windows.Forms.Button RemoveBusConfirmbutton;
        private System.Windows.Forms.Label RemoveBusIlabel;
        private System.Windows.Forms.Button AddBusConfirmbutton;
        private System.Windows.Forms.GroupBox BusInfogroupBox;
        private System.Windows.Forms.DataGridView BusInfodataGridView;
        private System.Windows.Forms.TextBox RemoveBustextBox;
        private System.Windows.Forms.TextBox SearchBustextBox;
        private System.Windows.Forms.Label Removelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
