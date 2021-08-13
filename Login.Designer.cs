
namespace BusRapidTransitManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Loginpanel = new System.Windows.Forms.Panel();
            this.Managerlabel = new System.Windows.Forms.Label();
            this.ManagerLoginbutton = new System.Windows.Forms.Button();
            this.ManagerPasswordtextBox = new System.Windows.Forms.TextBox();
            this.ManagerIdtextBox = new System.Windows.Forms.TextBox();
            this.ManagerPasswordlabel = new System.Windows.Forms.Label();
            this.ManagerIdlabel = new System.Windows.Forms.Label();
            this.Managerbutton = new System.Windows.Forms.Button();
            this.Stuffbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loginpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginpanel
            // 
            this.Loginpanel.Controls.Add(this.Managerlabel);
            this.Loginpanel.Controls.Add(this.ManagerLoginbutton);
            this.Loginpanel.Controls.Add(this.ManagerPasswordtextBox);
            this.Loginpanel.Controls.Add(this.ManagerIdtextBox);
            this.Loginpanel.Controls.Add(this.ManagerPasswordlabel);
            this.Loginpanel.Controls.Add(this.ManagerIdlabel);
            this.Loginpanel.Location = new System.Drawing.Point(394, 12);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(394, 426);
            this.Loginpanel.TabIndex = 0;
            this.Loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ManagerLoginpanel_Paint);
            // 
            // Managerlabel
            // 
            this.Managerlabel.AutoSize = true;
            this.Managerlabel.Location = new System.Drawing.Point(186, 25);
            this.Managerlabel.Name = "Managerlabel";
            this.Managerlabel.Size = new System.Drawing.Size(49, 13);
            this.Managerlabel.TabIndex = 5;
            this.Managerlabel.Text = "Manager";
            this.Managerlabel.Click += new System.EventHandler(this.Managerlabel_Click);
            // 
            // ManagerLoginbutton
            // 
            this.ManagerLoginbutton.Location = new System.Drawing.Point(140, 240);
            this.ManagerLoginbutton.Name = "ManagerLoginbutton";
            this.ManagerLoginbutton.Size = new System.Drawing.Size(127, 37);
            this.ManagerLoginbutton.TabIndex = 3;
            this.ManagerLoginbutton.Text = "Login";
            this.ManagerLoginbutton.UseVisualStyleBackColor = true;
            // 
            // ManagerPasswordtextBox
            // 
            this.ManagerPasswordtextBox.Location = new System.Drawing.Point(140, 137);
            this.ManagerPasswordtextBox.Name = "ManagerPasswordtextBox";
            this.ManagerPasswordtextBox.PasswordChar = '*';
            this.ManagerPasswordtextBox.Size = new System.Drawing.Size(159, 20);
            this.ManagerPasswordtextBox.TabIndex = 3;
            // 
            // ManagerIdtextBox
            // 
            this.ManagerIdtextBox.Location = new System.Drawing.Point(140, 68);
            this.ManagerIdtextBox.Name = "ManagerIdtextBox";
            this.ManagerIdtextBox.Size = new System.Drawing.Size(159, 20);
            this.ManagerIdtextBox.TabIndex = 2;
            // 
            // ManagerPasswordlabel
            // 
            this.ManagerPasswordlabel.AutoSize = true;
            this.ManagerPasswordlabel.Location = new System.Drawing.Point(46, 144);
            this.ManagerPasswordlabel.Name = "ManagerPasswordlabel";
            this.ManagerPasswordlabel.Size = new System.Drawing.Size(53, 13);
            this.ManagerPasswordlabel.TabIndex = 1;
            this.ManagerPasswordlabel.Text = "Password";
            // 
            // ManagerIdlabel
            // 
            this.ManagerIdlabel.AutoSize = true;
            this.ManagerIdlabel.Location = new System.Drawing.Point(46, 67);
            this.ManagerIdlabel.Name = "ManagerIdlabel";
            this.ManagerIdlabel.Size = new System.Drawing.Size(44, 13);
            this.ManagerIdlabel.TabIndex = 0;
            this.ManagerIdlabel.Text = "User Id ";
            // 
            // Managerbutton
            // 
            this.Managerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Managerbutton.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managerbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Managerbutton.Location = new System.Drawing.Point(12, 268);
            this.Managerbutton.Name = "Managerbutton";
            this.Managerbutton.Size = new System.Drawing.Size(155, 59);
            this.Managerbutton.TabIndex = 1;
            this.Managerbutton.Text = "Manager";
            this.Managerbutton.UseVisualStyleBackColor = false;
            this.Managerbutton.Click += new System.EventHandler(this.Managerbutton_Click);
            // 
            // Stuffbutton
            // 
            this.Stuffbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Stuffbutton.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stuffbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Stuffbutton.Location = new System.Drawing.Point(12, 158);
            this.Stuffbutton.Name = "Stuffbutton";
            this.Stuffbutton.Size = new System.Drawing.Size(155, 60);
            this.Stuffbutton.TabIndex = 2;
            this.Stuffbutton.Text = "Stuff";
            this.Stuffbutton.UseVisualStyleBackColor = false;
            this.Stuffbutton.Click += new System.EventHandler(this.Stuffbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Stuffbutton);
            this.panel1.Controls.Add(this.Managerbutton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Loginpanel);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Loginpanel.ResumeLayout(false);
            this.Loginpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Loginpanel;
        private System.Windows.Forms.Button Managerbutton;
        private System.Windows.Forms.Button Stuffbutton;
        private System.Windows.Forms.Label Managerlabel;
        private System.Windows.Forms.Button ManagerLoginbutton;
        private System.Windows.Forms.TextBox ManagerPasswordtextBox;
        private System.Windows.Forms.TextBox ManagerIdtextBox;
        private System.Windows.Forms.Label ManagerPasswordlabel;
        private System.Windows.Forms.Label ManagerIdlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}