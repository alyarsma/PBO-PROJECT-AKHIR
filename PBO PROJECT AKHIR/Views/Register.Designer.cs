namespace PBO_PROJECT_AKHIR.Views
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            tbusername = new TextBox();
            tbemail = new TextBox();
            tbpassword = new TextBox();
            lblogin = new Label();
            SuspendLayout();
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.Location = new Point(1131, 498);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(514, 30);
            tbusername.TabIndex = 0;
            // 
            // tbemail
            // 
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.Location = new Point(1131, 596);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(514, 30);
            tbemail.TabIndex = 1;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Poppins Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.Location = new Point(1131, 698);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(514, 30);
            tbpassword.TabIndex = 2;
            // 
            // lblogin
            // 
            lblogin.AutoSize = true;
            lblogin.BackColor = Color.Navy;
            lblogin.Font = new Font("Poppins Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblogin.ForeColor = Color.White;
            lblogin.Location = new Point(1314, 802);
            lblogin.Name = "lblogin";
            lblogin.Size = new Size(163, 56);
            lblogin.TabIndex = 3;
            lblogin.Text = "Register";
            lblogin.Click += lblogin_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1838, 1050);
            Controls.Add(lblogin);
            Controls.Add(tbpassword);
            Controls.Add(tbemail);
            Controls.Add(tbusername);
            DoubleBuffered = true;
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbusername;
        private TextBox tbemail;
        private TextBox tbpassword;
        private Label lblogin;
    }
}