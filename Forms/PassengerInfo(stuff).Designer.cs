
namespace BusRapidTransitManagement.Forms
{
    partial class PassengerInfo_stuff_
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
            this.PassengerNamelabel = new System.Windows.Forms.Label();
            this.PassengerNametextBox = new System.Windows.Forms.TextBox();
            this.PassengerSearchbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Busshowlabel
            // 
            this.Busshowlabel.AutoSize = true;
            this.Busshowlabel.Location = new System.Drawing.Point(38, 167);
            this.Busshowlabel.Name = "Busshowlabel";
            this.Busshowlabel.Size = new System.Drawing.Size(49, 13);
            this.Busshowlabel.TabIndex = 1;
            this.Busshowlabel.Text = "Show By";
            // 
            // BusshowcomboBox
            // 
            this.BusshowcomboBox.FormattingEnabled = true;
            this.BusshowcomboBox.Items.AddRange(new object[] {
            "Time",
            "Destinations"});
            this.BusshowcomboBox.Location = new System.Drawing.Point(135, 159);
            this.BusshowcomboBox.Name = "BusshowcomboBox";
            this.BusshowcomboBox.Size = new System.Drawing.Size(121, 21);
            this.BusshowcomboBox.TabIndex = 2;
            // 
            // PassengerNamelabel
            // 
            this.PassengerNamelabel.AutoSize = true;
            this.PassengerNamelabel.Location = new System.Drawing.Point(41, 107);
            this.PassengerNamelabel.Name = "PassengerNamelabel";
            this.PassengerNamelabel.Size = new System.Drawing.Size(88, 13);
            this.PassengerNamelabel.TabIndex = 3;
            this.PassengerNamelabel.Text = "Passenger Name";
            // 
            // PassengerNametextBox
            // 
            this.PassengerNametextBox.Location = new System.Drawing.Point(145, 100);
            this.PassengerNametextBox.Name = "PassengerNametextBox";
            this.PassengerNametextBox.Size = new System.Drawing.Size(111, 20);
            this.PassengerNametextBox.TabIndex = 4;
            // 
            // PassengerSearchbutton
            // 
            this.PassengerSearchbutton.Location = new System.Drawing.Point(262, 98);
            this.PassengerSearchbutton.Name = "PassengerSearchbutton";
            this.PassengerSearchbutton.Size = new System.Drawing.Size(75, 23);
            this.PassengerSearchbutton.TabIndex = 5;
            this.PassengerSearchbutton.Text = "Search";
            this.PassengerSearchbutton.UseVisualStyleBackColor = true;
            // 
            // PassengerInfo_stuff_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PassengerSearchbutton);
            this.Controls.Add(this.PassengerNametextBox);
            this.Controls.Add(this.PassengerNamelabel);
            this.Controls.Add(this.BusshowcomboBox);
            this.Controls.Add(this.Busshowlabel);
            this.Name = "PassengerInfo_stuff_";
            this.Size = new System.Drawing.Size(551, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Busshowlabel;
        private System.Windows.Forms.ComboBox BusshowcomboBox;
        private System.Windows.Forms.Label PassengerNamelabel;
        private System.Windows.Forms.TextBox PassengerNametextBox;
        private System.Windows.Forms.Button PassengerSearchbutton;
    }
}
