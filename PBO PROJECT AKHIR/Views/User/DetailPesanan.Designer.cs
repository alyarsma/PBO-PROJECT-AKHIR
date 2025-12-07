namespace PBO_PROJECT_AKHIR.Views.User
{
    partial class DetailPesanan
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1580, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(1840, 138);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 45);
            label1.Name = "label1";
            label1.Size = new Size(99, 42);
            label1.TabIndex = 0;
            label1.Text = "Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1636, 45);
            label2.Name = "label2";
            label2.Size = new Size(155, 42);
            label2.TabIndex = 1;
            label2.Text = "Total Harga";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1385, 45);
            label3.Name = "label3";
            label3.Size = new Size(129, 42);
            label3.TabIndex = 2;
            label3.Text = "Kuantitas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1078, 45);
            label4.Name = "label4";
            label4.Size = new Size(183, 42);
            label4.TabIndex = 3;
            label4.Text = "Harga Satuan";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(12, 291);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1814, 652);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1811, 218);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(3, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(1811, 218);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(3, 451);
            panel4.Name = "panel4";
            panel4.Size = new Size(1811, 218);
            panel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(53, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 171);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // DetailPesanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DETAIL__2_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1838, 1050);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "DetailPesanan";
            Text = "DetailPesanan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
    }
}