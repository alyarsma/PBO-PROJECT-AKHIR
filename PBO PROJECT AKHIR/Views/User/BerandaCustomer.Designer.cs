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
            pbprofilcustomer = new PictureBox();
            lbkatalog = new Label();
            lbtransaksi = new Label();
            lbberanda = new Label();
            pctbProfilUser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbprofilcustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbProfilUser).BeginInit();
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
            // lbkatalog
            // 
            lbkatalog.AutoSize = true;
            lbkatalog.BackColor = Color.Transparent;
            lbkatalog.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbkatalog.Location = new Point(908, 190);
            lbkatalog.Margin = new Padding(2, 0, 2, 0);
            lbkatalog.Name = "lbkatalog";
            lbkatalog.Size = new Size(102, 29);
            lbkatalog.TabIndex = 5;
            lbkatalog.Text = "Katalog";
            lbkatalog.Click += lbkatalog_Click;
            // 
            // lbtransaksi
            // 
            lbtransaksi.AutoSize = true;
            lbtransaksi.BackColor = Color.White;
            lbtransaksi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtransaksi.Location = new Point(1293, 191);
            lbtransaksi.Margin = new Padding(2, 0, 2, 0);
            lbtransaksi.Name = "lbtransaksi";
            lbtransaksi.Size = new Size(127, 29);
            lbtransaksi.TabIndex = 6;
            lbtransaksi.Text = "Transaksi";
            // 
            // lbberanda
            // 
            lbberanda.AutoSize = true;
            lbberanda.BackColor = Color.White;
            lbberanda.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbberanda.Location = new Point(517, 190);
            lbberanda.Margin = new Padding(2, 0, 2, 0);
            lbberanda.Name = "lbberanda";
            lbberanda.Size = new Size(111, 29);
            lbberanda.TabIndex = 7;
            lbberanda.Text = "Beranda";
            // 
            // pctbProfilUser
            // 
            pctbProfilUser.BackColor = Color.Transparent;
            pctbProfilUser.BackgroundImage = Properties.Resources.user;
            pctbProfilUser.BackgroundImageLayout = ImageLayout.Zoom;
            pctbProfilUser.Location = new Point(1738, 38);
            pctbProfilUser.Margin = new Padding(2);
            pctbProfilUser.Name = "pctbProfilUser";
            pctbProfilUser.Size = new Size(152, 78);
            pctbProfilUser.TabIndex = 8;
            pctbProfilUser.TabStop = false;
            pctbProfilUser.Click += pctbProfilUser_Click;
            // 
            // BerandaCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Beranda_customer__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1924, 1050);
            Controls.Add(pctbProfilUser);
            Controls.Add(lbberanda);
            Controls.Add(lbtransaksi);
            Controls.Add(lbkatalog);
            Controls.Add(pbprofilcustomer);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "BerandaCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BerandaCustomer";
            Load += BerandaCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pbprofilcustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbProfilUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbberandacustomer;
        private TextBox tbtransaksicustomer;
        private PictureBox pbprofilcustomer;
        private Label lbkatalog;
        private Label lbtransaksi;
        private Label lbberanda;
        private PictureBox pctbProfilUser;
    }
}