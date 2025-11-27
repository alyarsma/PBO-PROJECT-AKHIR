namespace PBO_PROJECT_AKHIR.Views.User
{
    partial class BerandaCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BerandaCustomer));
            pbprofilcustomer = new PictureBox();
            pictureBox1 = new PictureBox();
            lbkatalog = new Label();
            lbtransaksi = new Label();
            lbberanda = new Label();
            ((System.ComponentModel.ISupportInitialize)pbprofilcustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbprofilcustomer
            // 
            pbprofilcustomer.BackColor = Color.Transparent;
            pbprofilcustomer.BackgroundImage = Properties.Resources.user;
            pbprofilcustomer.BackgroundImageLayout = ImageLayout.Stretch;
            pbprofilcustomer.Location = new Point(2191, 42);
            pbprofilcustomer.Margin = new Padding(4);
            pbprofilcustomer.Name = "pbprofilcustomer";
            pbprofilcustomer.Size = new Size(94, 94);
            pbprofilcustomer.TabIndex = 3;
            pbprofilcustomer.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1773, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lbkatalog
            // 
            lbkatalog.AutoSize = true;
            lbkatalog.BackColor = Color.Transparent;
            lbkatalog.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbkatalog.Location = new Point(909, 199);
            lbkatalog.Name = "lbkatalog";
            lbkatalog.Size = new Size(118, 42);
            lbkatalog.TabIndex = 5;
            lbkatalog.Text = "Katalog";
            lbkatalog.Click += lbkatalog_Click;
            // 
            // lbtransaksi
            // 
            lbtransaksi.AutoSize = true;
            lbtransaksi.BackColor = Color.White;
            lbtransaksi.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtransaksi.Location = new Point(1310, 199);
            lbtransaksi.Name = "lbtransaksi";
            lbtransaksi.Size = new Size(143, 42);
            lbtransaksi.TabIndex = 6;
            lbtransaksi.Text = "Transaksi";
            // 
            // lbberanda
            // 
            lbberanda.AutoSize = true;
            lbberanda.BackColor = Color.White;
            lbberanda.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbberanda.Location = new Point(503, 199);
            lbberanda.Name = "lbberanda";
            lbberanda.Size = new Size(128, 42);
            lbberanda.TabIndex = 7;
            lbberanda.Text = "Beranda";
            // 
            // BerandaCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1946, 1106);
            Controls.Add(lbberanda);
            Controls.Add(lbtransaksi);
            Controls.Add(lbkatalog);
            Controls.Add(pictureBox1);
            Controls.Add(pbprofilcustomer);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "BerandaCustomer";
            Text = "BerandaCustomer";
            Load += BerandaCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pbprofilcustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbberandacustomer;
        private TextBox tbtransaksicustomer;
        private PictureBox pbprofilcustomer;
        private PictureBox pictureBox1;
        private Label lbkatalog;
        private Label lbtransaksi;
        private Label lbberanda;
    }
}