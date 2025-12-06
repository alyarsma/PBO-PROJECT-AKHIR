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
            pbprofilcustomer.Location = new Point(1753, 34);
            pbprofilcustomer.Name = "pbprofilcustomer";
            pbprofilcustomer.Size = new Size(75, 75);
            pbprofilcustomer.TabIndex = 3;
            pbprofilcustomer.TabStop = false;
            // 
            // lbkatalog
            // 
            lbkatalog.AutoSize = true;
            lbkatalog.BackColor = Color.Transparent;
            lbkatalog.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbkatalog.Location = new Point(727, 159);
            lbkatalog.Margin = new Padding(2, 0, 2, 0);
            lbkatalog.Name = "lbkatalog";
            lbkatalog.Size = new Size(86, 25);
            lbkatalog.TabIndex = 5;
            lbkatalog.Text = "Katalog";
            lbkatalog.Click += lbkatalog_Click;
            // 
            // lbtransaksi
            // 
            lbtransaksi.AutoSize = true;
            lbtransaksi.BackColor = Color.White;
            lbtransaksi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtransaksi.Location = new Point(1048, 159);
            lbtransaksi.Margin = new Padding(2, 0, 2, 0);
            lbtransaksi.Name = "lbtransaksi";
            lbtransaksi.Size = new Size(107, 25);
            lbtransaksi.TabIndex = 6;
            lbtransaksi.Text = "Transaksi";
            // 
            // lbberanda
            // 
            lbberanda.AutoSize = true;
            lbberanda.BackColor = Color.White;
            lbberanda.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbberanda.Location = new Point(402, 159);
            lbberanda.Margin = new Padding(2, 0, 2, 0);
            lbberanda.Name = "lbberanda";
            lbberanda.Size = new Size(93, 25);
            lbberanda.TabIndex = 7;
            lbberanda.Text = "Beranda";
            // 
            // pctbProfilUser
            // 
            pctbProfilUser.BackColor = Color.Transparent;
            pctbProfilUser.BackgroundImage = Properties.Resources.user;
            pctbProfilUser.BackgroundImageLayout = ImageLayout.Zoom;
            pctbProfilUser.Location = new Point(1390, 30);
            pctbProfilUser.Margin = new Padding(2, 2, 2, 2);
            pctbProfilUser.Name = "pctbProfilUser";
            pctbProfilUser.Size = new Size(122, 62);
            pctbProfilUser.TabIndex = 8;
            pctbProfilUser.TabStop = false;
            pctbProfilUser.Click += pctbProfilUser_Click;
            // 
            // BerandaCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1554, 882);
            Controls.Add(pctbProfilUser);
            Controls.Add(lbberanda);
            Controls.Add(lbtransaksi);
            Controls.Add(lbkatalog);
            Controls.Add(pbprofilcustomer);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
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