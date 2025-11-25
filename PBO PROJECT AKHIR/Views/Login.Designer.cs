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
            panel1 = new Panel();
            lbregister = new Label();
            lblogin = new Label();
            tbpassword = new TextBox();
            tbusername = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lbregister);
            panel1.Controls.Add(lblogin);
            panel1.Controls.Add(tbpassword);
            panel1.Controls.Add(tbusername);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 1080);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbregister
            // 
            lbregister.AutoSize = true;
            lbregister.BackColor = Color.Navy;
            lbregister.Font = new Font("Poppins Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbregister.ForeColor = Color.Transparent;
            lbregister.Location = new Point(950, 559);
            lbregister.Margin = new Padding(2, 0, 2, 0);
            lbregister.Name = "lbregister";
            lbregister.Size = new Size(116, 39);
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
            lblogin.Location = new Point(962, 421);
            lblogin.Margin = new Padding(2, 0, 2, 0);
            lblogin.Name = "lblogin";
            lblogin.Size = new Size(81, 39);
            lblogin.TabIndex = 2;
            lblogin.Text = "Login";
            lblogin.Click += lblogin_Click;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(816, 346);
            tbpassword.Margin = new Padding(2);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(377, 16);
            tbpassword.TabIndex = 1;
            tbpassword.TextChanged += tbpassword_TextChanged;
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(816, 266);
            tbusername.Margin = new Padding(2);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(377, 16);
            tbusername.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 614);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblogin;
        private TextBox tbpassword;
        private TextBox tbusername;
        private Label lbregister;
    }
}