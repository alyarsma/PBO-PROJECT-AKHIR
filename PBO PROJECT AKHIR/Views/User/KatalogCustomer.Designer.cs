namespace PBO_PROJECT_AKHIR.Views.User
{
    partial class KatalogCustomer
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(56, 272);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1729, 744);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.ANGGREK_CATTLEYA;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 302);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.image_5;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(41, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 133);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 159);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 1;
            label1.Text = "Anggrek Bulan Putih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(119, 192);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 2;
            label2.Text = "Rp 25.000,00";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(20, 194);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 3;
            label3.Text = "Stok : 30";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(88, 248);
            label4.Name = "label4";
            label4.Size = new Size(22, 28);
            label4.TabIndex = 4;
            label4.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(153, 247);
            label5.Name = "label5";
            label5.Size = new Size(24, 28);
            label5.TabIndex = 5;
            label5.Text = "+";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(853, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(134, 48);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(-13, -5);
            label6.Name = "label6";
            label6.Size = new Size(157, 56);
            label6.TabIndex = 0;
            label6.Text = "Katalog";
            // 
            // KatalogCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.KATALOG_PRODUK__2_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1838, 1050);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Name = "KatalogCustomer";
            Text = "KatalogCustomer";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Panel panel2;
        private Label label6;
    }
}