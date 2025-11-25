namespace PBO_PROJECT_AKHIR.Views
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
            lbregister = new Label();
            lblogin = new Label();
            tbpassword = new TextBox();
            tbusername = new TextBox();
            SuspendLayout();
            // 
            // lbregister
            // 
            lbregister.AutoSize = true;
            lbregister.BackColor = Color.Navy;
            lbregister.Font = new Font("Poppins Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbregister.ForeColor = Color.Transparent;
            lbregister.Location = new Point(1310, 900);
            lbregister.Name = "lbregister";
            lbregister.Size = new Size(163, 56);
            lbregister.TabIndex = 3;
            lbregister.Text = "Register";
            lbregister.Click += lbregister_Click;
            // 
            // lblogin
            // 
            lblogin.AutoSize = true;
            lblogin.BackColor = Color.Navy;
            lblogin.Font = new Font("Poppins Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblogin.ForeColor = Color.Transparent;
            lblogin.Location = new Point(1325, 679);
            lblogin.Name = "lblogin";
            lblogin.Size = new Size(114, 56);
            lblogin.TabIndex = 2;
            lblogin.Text = "Login";
            lblogin.Click += lblogin_Click;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(1117, 561);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(517, 24);
            tbpassword.TabIndex = 1;
            tbpassword.TextChanged += tbpassword_TextChanged;
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(1117, 429);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(517, 24);
            tbusername.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1838, 1050);
            Controls.Add(tbpassword);
            Controls.Add(lblogin);
            Controls.Add(tbusername);
            Controls.Add(lbregister);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblogin;
        private TextBox tbpassword;
        private TextBox tbusername;
        private Label lbregister;
    }
}