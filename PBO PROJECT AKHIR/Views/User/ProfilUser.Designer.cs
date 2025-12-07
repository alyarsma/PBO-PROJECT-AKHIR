namespace PBO_PROJECT_AKHIR.Views.User
{
    partial class ProfilUser
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
            tbpassword = new TextBox();
            tbemail = new TextBox();
            tbusername = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(831, 643);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(895, 24);
            tbpassword.TabIndex = 0;
            // 
            // tbemail
            // 
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Location = new Point(831, 484);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(895, 24);
            tbemail.TabIndex = 1;
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(831, 326);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(895, 24);
            tbusername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 56);
            label1.TabIndex = 3;
            label1.Text = "Logout";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(134, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 64);
            panel1.TabIndex = 4;
            // 
            // ProfilUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PROFIL__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1839, 1050);
            Controls.Add(panel1);
            Controls.Add(tbusername);
            Controls.Add(tbemail);
            Controls.Add(tbpassword);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "ProfilUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfilUser";
            Load += ProfilUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbpassword;
        private TextBox tbemail;
        private TextBox tbusername;
        private Label label1;
        private Panel panel1;
    }
}