
namespace BusRapidTransitManagement.Forms
{
    partial class BusInfoshow_Stuff_
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
            this.ShowBuslabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ShowBuslabel
            // 
            this.ShowBuslabel.AutoSize = true;
            this.ShowBuslabel.Location = new System.Drawing.Point(43, 102);
            this.ShowBuslabel.Name = "ShowBuslabel";
            this.ShowBuslabel.Size = new System.Drawing.Size(49, 13);
            this.ShowBuslabel.TabIndex = 0;
            this.ShowBuslabel.Text = "Show By";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Available Seats",
            "Destination"});
            this.comboBox1.Location = new System.Drawing.Point(175, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // BusInfoshow_Stuff_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ShowBuslabel);
            this.Name = "BusInfoshow_Stuff_";
            this.Size = new System.Drawing.Size(789, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShowBuslabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
