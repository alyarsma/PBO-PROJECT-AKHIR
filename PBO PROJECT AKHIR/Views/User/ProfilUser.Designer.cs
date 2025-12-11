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
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(665, 514);
            tbpassword.Margin = new Padding(2, 2, 2, 2);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(716, 20);
            tbpassword.TabIndex = 0;
            // 
            // tbemail
            // 
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Location = new Point(665, 387);
            tbemail.Margin = new Padding(2, 2, 2, 2);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(716, 20);
            tbemail.TabIndex = 1;
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(665, 261);
            tbusername.Margin = new Padding(2, 2, 2, 2);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(716, 20);
            tbusername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 31);
            label1.TabIndex = 3;
            label1.Text = "Logout";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(107, 357);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 51);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.weui__back_filled;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(107, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 62);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ProfilUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PROFIL__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1471, 840);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbpassword;
        private TextBox tbemail;
        private TextBox tbusername;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}