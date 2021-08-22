
namespace BusRapidTransitManagement.Forms
{
    partial class HomePage
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
            this.Profitlabel = new System.Windows.Forms.Label();
            this.TicketSelllabel = new System.Windows.Forms.Label();
            this.TotalSalarylabel = new System.Windows.Forms.Label();
            this.TicketSellCountlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Profitlabel
            // 
            this.Profitlabel.AutoSize = true;
            this.Profitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profitlabel.Location = new System.Drawing.Point(102, 98);
            this.Profitlabel.Name = "Profitlabel";
            this.Profitlabel.Size = new System.Drawing.Size(83, 33);
            this.Profitlabel.TabIndex = 12;
            this.Profitlabel.Text = "Profit";
            this.Profitlabel.Click += new System.EventHandler(this.Profitlabel_Click);
            // 
            // TicketSelllabel
            // 
            this.TicketSelllabel.AutoSize = true;
            this.TicketSelllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketSelllabel.Location = new System.Drawing.Point(440, 98);
            this.TicketSelllabel.Name = "TicketSelllabel";
            this.TicketSelllabel.Size = new System.Drawing.Size(215, 31);
            this.TicketSelllabel.TabIndex = 13;
            this.TicketSelllabel.Text = "Total Ticket Sell ";
            // 
            // TotalSalarylabel
            // 
            this.TotalSalarylabel.AutoSize = true;
            this.TotalSalarylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalarylabel.Location = new System.Drawing.Point(440, 283);
            this.TotalSalarylabel.Name = "TotalSalarylabel";
            this.TotalSalarylabel.Size = new System.Drawing.Size(230, 33);
            this.TotalSalarylabel.TabIndex = 14;
            this.TotalSalarylabel.Text = "Total stuff salary";
            this.TotalSalarylabel.Click += new System.EventHandler(this.TotalSalarylabel_Click);
            // 
            // TicketSellCountlabel
            // 
            this.TicketSellCountlabel.AutoSize = true;
            this.TicketSellCountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketSellCountlabel.Location = new System.Drawing.Point(195, 461);
            this.TicketSellCountlabel.Name = "TicketSellCountlabel";
            this.TicketSellCountlabel.Size = new System.Drawing.Size(151, 33);
            this.TicketSellCountlabel.TabIndex = 15;
            this.TicketSellCountlabel.Text = "Ticket Sell";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.TicketSellCountlabel);
            this.Controls.Add(this.TotalSalarylabel);
            this.Controls.Add(this.TicketSelllabel);
            this.Controls.Add(this.Profitlabel);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(970, 642);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Profitlabel;
        private System.Windows.Forms.Label TicketSelllabel;
        private System.Windows.Forms.Label TotalSalarylabel;
        private System.Windows.Forms.Label TicketSellCountlabel;
    }
}
