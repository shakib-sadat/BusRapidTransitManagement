
namespace BusRapidTransitManagement.Forms
{
    partial class BusInfo_stuff_
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
            this.Busshowlabel = new System.Windows.Forms.Label();
            this.BusshowcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Busshowlabel
            // 
            this.Busshowlabel.AutoSize = true;
            this.Busshowlabel.Location = new System.Drawing.Point(126, 178);
            this.Busshowlabel.Name = "Busshowlabel";
            this.Busshowlabel.Size = new System.Drawing.Size(49, 13);
            this.Busshowlabel.TabIndex = 0;
            this.Busshowlabel.Text = "Show By";
            // 
            // BusshowcomboBox
            // 
            this.BusshowcomboBox.FormattingEnabled = true;
            this.BusshowcomboBox.Items.AddRange(new object[] {
            "Available Seats",
            "Destinations"});
            this.BusshowcomboBox.Location = new System.Drawing.Point(221, 170);
            this.BusshowcomboBox.Name = "BusshowcomboBox";
            this.BusshowcomboBox.Size = new System.Drawing.Size(121, 21);
            this.BusshowcomboBox.TabIndex = 1;
            // 
            // BusInfo_stuff_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BusshowcomboBox);
            this.Controls.Add(this.Busshowlabel);
            this.Name = "BusInfo_stuff_";
            this.Size = new System.Drawing.Size(888, 544);
            this.Load += new System.EventHandler(this.BusInfo_stuff__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Busshowlabel;
        private System.Windows.Forms.ComboBox BusshowcomboBox;
    }
}
