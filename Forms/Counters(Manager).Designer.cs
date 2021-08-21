
namespace BusRapidTransitManagement.Forms
{
    partial class Counters_Manager_
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
            this.CountersManagergroupBox = new System.Windows.Forms.GroupBox();
            this.CountersManagerdataGridView = new System.Windows.Forms.DataGridView();
            this.AddCounterlabel = new System.Windows.Forms.Label();
            this.AddCountertextBox = new System.Windows.Forms.TextBox();
            this.AddCounterbutton = new System.Windows.Forms.Button();
            this.AddCounterpanel = new System.Windows.Forms.Panel();
            this.RemoveCounterpanel = new System.Windows.Forms.Panel();
            this.RemoveCounterlabel = new System.Windows.Forms.Label();
            this.RemoveCountertextBox = new System.Windows.Forms.TextBox();
            this.RemoveCounterbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCounterManagerbutton = new System.Windows.Forms.Button();
            this.RemoveCounterManagerbutton = new System.Windows.Forms.Button();
            this.CountersManagergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountersManagerdataGridView)).BeginInit();
            this.AddCounterpanel.SuspendLayout();
            this.RemoveCounterpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountersManagergroupBox
            // 
            this.CountersManagergroupBox.Controls.Add(this.CountersManagerdataGridView);
            this.CountersManagergroupBox.Location = new System.Drawing.Point(501, 67);
            this.CountersManagergroupBox.Name = "CountersManagergroupBox";
            this.CountersManagergroupBox.Size = new System.Drawing.Size(337, 385);
            this.CountersManagergroupBox.TabIndex = 0;
            this.CountersManagergroupBox.TabStop = false;
            this.CountersManagergroupBox.Text = "Counters";
            // 
            // CountersManagerdataGridView
            // 
            this.CountersManagerdataGridView.AllowUserToAddRows = false;
            this.CountersManagerdataGridView.AllowUserToDeleteRows = false;
            this.CountersManagerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountersManagerdataGridView.Location = new System.Drawing.Point(15, 19);
            this.CountersManagerdataGridView.Name = "CountersManagerdataGridView";
            this.CountersManagerdataGridView.ReadOnly = true;
            this.CountersManagerdataGridView.Size = new System.Drawing.Size(309, 350);
            this.CountersManagerdataGridView.TabIndex = 0;
            // 
            // AddCounterlabel
            // 
            this.AddCounterlabel.AutoSize = true;
            this.AddCounterlabel.Location = new System.Drawing.Point(14, 13);
            this.AddCounterlabel.Name = "AddCounterlabel";
            this.AddCounterlabel.Size = new System.Drawing.Size(66, 13);
            this.AddCounterlabel.TabIndex = 1;
            this.AddCounterlabel.Text = "Add Counter";
            // 
            // AddCountertextBox
            // 
            this.AddCountertextBox.Location = new System.Drawing.Point(116, 10);
            this.AddCountertextBox.Name = "AddCountertextBox";
            this.AddCountertextBox.Size = new System.Drawing.Size(100, 20);
            this.AddCountertextBox.TabIndex = 2;
            // 
            // AddCounterbutton
            // 
            this.AddCounterbutton.Location = new System.Drawing.Point(59, 93);
            this.AddCounterbutton.Name = "AddCounterbutton";
            this.AddCounterbutton.Size = new System.Drawing.Size(75, 23);
            this.AddCounterbutton.TabIndex = 3;
            this.AddCounterbutton.Text = "Add";
            this.AddCounterbutton.UseVisualStyleBackColor = true;
            this.AddCounterbutton.Click += new System.EventHandler(this.AddCounterbutton_Click);
            // 
            // AddCounterpanel
            // 
            this.AddCounterpanel.Controls.Add(this.AddCounterlabel);
            this.AddCounterpanel.Controls.Add(this.AddCountertextBox);
            this.AddCounterpanel.Controls.Add(this.AddCounterbutton);
            this.AddCounterpanel.Location = new System.Drawing.Point(239, 67);
            this.AddCounterpanel.Name = "AddCounterpanel";
            this.AddCounterpanel.Size = new System.Drawing.Size(219, 169);
            this.AddCounterpanel.TabIndex = 4;
            // 
            // RemoveCounterpanel
            // 
            this.RemoveCounterpanel.Controls.Add(this.RemoveCounterlabel);
            this.RemoveCounterpanel.Controls.Add(this.RemoveCountertextBox);
            this.RemoveCounterpanel.Controls.Add(this.RemoveCounterbutton);
            this.RemoveCounterpanel.Location = new System.Drawing.Point(239, 257);
            this.RemoveCounterpanel.Name = "RemoveCounterpanel";
            this.RemoveCounterpanel.Size = new System.Drawing.Size(219, 169);
            this.RemoveCounterpanel.TabIndex = 5;
            // 
            // RemoveCounterlabel
            // 
            this.RemoveCounterlabel.AutoSize = true;
            this.RemoveCounterlabel.Location = new System.Drawing.Point(14, 38);
            this.RemoveCounterlabel.Name = "RemoveCounterlabel";
            this.RemoveCounterlabel.Size = new System.Drawing.Size(87, 13);
            this.RemoveCounterlabel.TabIndex = 4;
            this.RemoveCounterlabel.Text = "Remove Counter";
            // 
            // RemoveCountertextBox
            // 
            this.RemoveCountertextBox.Location = new System.Drawing.Point(116, 35);
            this.RemoveCountertextBox.Name = "RemoveCountertextBox";
            this.RemoveCountertextBox.Size = new System.Drawing.Size(100, 20);
            this.RemoveCountertextBox.TabIndex = 5;
            this.RemoveCountertextBox.TextChanged += new System.EventHandler(this.RemoveCountertextBox_TextChanged);
            // 
            // RemoveCounterbutton
            // 
            this.RemoveCounterbutton.Location = new System.Drawing.Point(59, 111);
            this.RemoveCounterbutton.Name = "RemoveCounterbutton";
            this.RemoveCounterbutton.Size = new System.Drawing.Size(75, 23);
            this.RemoveCounterbutton.TabIndex = 6;
            this.RemoveCounterbutton.Text = "Remove";
            this.RemoveCounterbutton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveCounterManagerbutton);
            this.panel1.Controls.Add(this.AddCounterManagerbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 609);
            this.panel1.TabIndex = 6;
            // 
            // AddCounterManagerbutton
            // 
            this.AddCounterManagerbutton.Location = new System.Drawing.Point(47, 160);
            this.AddCounterManagerbutton.Name = "AddCounterManagerbutton";
            this.AddCounterManagerbutton.Size = new System.Drawing.Size(96, 33);
            this.AddCounterManagerbutton.TabIndex = 4;
            this.AddCounterManagerbutton.Text = "Add Counter";
            this.AddCounterManagerbutton.UseVisualStyleBackColor = true;
            this.AddCounterManagerbutton.Click += new System.EventHandler(this.AddCounterManagerbutton_Click);
            // 
            // RemoveCounterManagerbutton
            // 
            this.RemoveCounterManagerbutton.Location = new System.Drawing.Point(47, 308);
            this.RemoveCounterManagerbutton.Name = "RemoveCounterManagerbutton";
            this.RemoveCounterManagerbutton.Size = new System.Drawing.Size(96, 37);
            this.RemoveCounterManagerbutton.TabIndex = 7;
            this.RemoveCounterManagerbutton.Text = "Remove Counter";
            this.RemoveCounterManagerbutton.UseVisualStyleBackColor = true;
            this.RemoveCounterManagerbutton.Click += new System.EventHandler(this.RemoveCounterManagerbutton_Click);
            // 
            // Counters_Manager_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RemoveCounterpanel);
            this.Controls.Add(this.AddCounterpanel);
            this.Controls.Add(this.CountersManagergroupBox);
            this.Name = "Counters_Manager_";
            this.Size = new System.Drawing.Size(1069, 609);
            this.Load += new System.EventHandler(this.Counters_Manager__Load);
            this.CountersManagergroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountersManagerdataGridView)).EndInit();
            this.AddCounterpanel.ResumeLayout(false);
            this.AddCounterpanel.PerformLayout();
            this.RemoveCounterpanel.ResumeLayout(false);
            this.RemoveCounterpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CountersManagergroupBox;
        private System.Windows.Forms.DataGridView CountersManagerdataGridView;
        private System.Windows.Forms.Label AddCounterlabel;
        private System.Windows.Forms.TextBox AddCountertextBox;
        private System.Windows.Forms.Button AddCounterbutton;
        private System.Windows.Forms.Panel AddCounterpanel;
        private System.Windows.Forms.Panel RemoveCounterpanel;
        private System.Windows.Forms.Label RemoveCounterlabel;
        private System.Windows.Forms.TextBox RemoveCountertextBox;
        private System.Windows.Forms.Button RemoveCounterbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveCounterManagerbutton;
        private System.Windows.Forms.Button AddCounterManagerbutton;
    }
}
