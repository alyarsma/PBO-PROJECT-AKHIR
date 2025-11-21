namespace PBO_PROJECT_AKHIR
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            lblmasuk = new Label();
            lblregister = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkSlateBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1920, 1080);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.White;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.ForeColor = Color.White;
            txtusername.Location = new Point(1160, 585);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(547, 16);
            txtusername.TabIndex = 6;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.ForeColor = Color.White;
            txtpassword.Location = new Point(1160, 445);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(547, 16);
            txtpassword.TabIndex = 7;
            // 
            // lblmasuk
            // 
            lblmasuk.AutoSize = true;
            lblmasuk.BackColor = Color.Navy;
            lblmasuk.Font = new Font("Poppins Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmasuk.ForeColor = Color.White;
            lblmasuk.Location = new Point(1385, 710);
            lblmasuk.Name = "lblmasuk";
            lblmasuk.Size = new Size(104, 42);
            lblmasuk.TabIndex = 8;
            lblmasuk.Text = "Masuk";
            // 
            // lblregister
            // 
            lblregister.AutoSize = true;
            lblregister.BackColor = Color.Navy;
            lblregister.Font = new Font("Poppins Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblregister.ForeColor = Color.White;
            lblregister.Location = new Point(1398, 941);
            lblregister.Name = "lblregister";
            lblregister.Size = new Size(123, 42);
            lblregister.TabIndex = 9;
            lblregister.Text = "Register";
            lblregister.Click += lblregister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(lblregister);
            Controls.Add(lblmasuk);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label lblmasuk;
        private Label lblregister;
    }
}
