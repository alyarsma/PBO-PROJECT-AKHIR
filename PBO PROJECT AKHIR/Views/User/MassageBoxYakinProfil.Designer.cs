namespace PBO_PROJECT_AKHIR.Views.User
{
    partial class MassageBoxYakinProfil
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
            lbbatal = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lbyakin = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbbatal
            // 
            lbbatal.AutoSize = true;
            lbbatal.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbbatal.Location = new Point(10, 6);
            lbbatal.Name = "lbbatal";
            lbbatal.Size = new Size(85, 42);
            lbbatal.TabIndex = 0;
            lbbatal.Text = "Batal";
            lbbatal.Click += lbbatal_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lbbatal);
            panel1.Location = new Point(465, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 53);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lbyakin);
            panel2.Location = new Point(603, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(103, 53);
            panel2.TabIndex = 2;
            // 
            // lbyakin
            // 
            lbyakin.AutoSize = true;
            lbyakin.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbyakin.ForeColor = Color.White;
            lbyakin.Location = new Point(10, 6);
            lbyakin.Name = "lbyakin";
            lbyakin.Size = new Size(89, 42);
            lbyakin.TabIndex = 0;
            lbyakin.Text = "Yakin";
            lbyakin.Click += lbyakin_Click;
            // 
            // MassageBoxYakinProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.PEMBAYARAN_BERHASIL;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MassageBoxYakinProfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MassageBoxYakinProfil";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbbatal;
        private Panel panel1;
        private Panel panel2;
        private Label lbyakin;
    }
}