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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanelProduk = new FlowLayoutPanel();
            panel2 = new Panel();
            label5 = new Label();
            btnbatal = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1264, 18);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 82);
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
            panel1.Location = new Point(-2, 118);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1472, 110);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(480, 36);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 36);
            label4.TabIndex = 3;
            label4.Text = "Harga Satuan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(678, 36);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 36);
            label3.TabIndex = 2;
            label3.Text = "Kuantitas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(898, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 36);
            label2.TabIndex = 1;
            label2.Text = "Total Harga";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 36);
            label1.TabIndex = 0;
            label1.Text = "Produk";
            // 
            // flowLayoutPanelProduk
            // 
            flowLayoutPanelProduk.AutoScroll = true;
            flowLayoutPanelProduk.BackColor = Color.Transparent;
            flowLayoutPanelProduk.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelProduk.Location = new Point(2, 224);
            flowLayoutPanelProduk.Margin = new Padding(2);
            flowLayoutPanelProduk.Name = "flowLayoutPanelProduk";
            flowLayoutPanelProduk.Size = new Size(1451, 511);
            flowLayoutPanelProduk.TabIndex = 2;
            flowLayoutPanelProduk.WrapContents = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnbatal);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-2, 740);
            panel2.Name = "panel2";
            panel2.Size = new Size(1472, 165);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(508, 35);
            label5.Name = "label5";
            label5.Size = new Size(463, 36);
            label5.TabIndex = 2;
            label5.Text = "Apakah anda yakin membuat pesanan?";
            // 
            // btnbatal
            // 
            btnbatal.BackColor = Color.Gray;
            btnbatal.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbatal.ForeColor = Color.White;
            btnbatal.Location = new Point(995, 28);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(184, 46);
            btnbatal.TabIndex = 1;
            btnbatal.Text = "Batal";
            btnbatal.UseVisualStyleBackColor = false;
            btnbatal.Click += btnbatal_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1202, 28);
            button1.Name = "button1";
            button1.Size = new Size(184, 46);
            button1.TabIndex = 0;
            button1.Text = "Buat Pesanan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DetailPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DETAIL__2_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1470, 840);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanelProduk);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "DetailPesanan";
            Text = "DetailPesanan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanelProduk;
        private Panel panel2;
        private Button button1;
        private Label label5;
        private Button btnbatal;
    }
}