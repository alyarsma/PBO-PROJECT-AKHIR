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
            lbregister.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbregister.ForeColor = Color.Transparent;
            lbregister.Location = new Point(1296, 906);
            lbregister.Margin = new Padding(2, 0, 2, 0);
            lbregister.Name = "lbregister";
            lbregister.Size = new Size(142, 37);
            lbregister.TabIndex = 3;
            lbregister.Text = "Register";
            lbregister.Click += lbregister_Click;
            // 
            // lblogin
            // 
            lblogin.AutoSize = true;
            lblogin.BackColor = Color.Navy;
            lblogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblogin.ForeColor = Color.Transparent;
            lblogin.Location = new Point(1319, 685);
            lblogin.Margin = new Padding(2, 0, 2, 0);
            lblogin.Name = "lblogin";
            lblogin.Size = new Size(101, 37);
            lblogin.TabIndex = 2;
            lblogin.Text = "Login";
            lblogin.Click += lblogin_Click;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(1118, 561);
            tbpassword.Margin = new Padding(2, 4, 2, 4);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(406, 24);
            tbpassword.TabIndex = 1;
            tbpassword.TextChanged += tbpassword_TextChanged;
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(1118, 429);
            tbusername.Margin = new Padding(2, 4, 2, 4);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(406, 24);
            tbusername.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HalLogin_Customer__3_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1839, 1050);
            Controls.Add(tbpassword);
            Controls.Add(lblogin);
            Controls.Add(tbusername);
            Controls.Add(lbregister);
            DoubleBuffered = true;
            Margin = new Padding(2, 4, 2, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
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