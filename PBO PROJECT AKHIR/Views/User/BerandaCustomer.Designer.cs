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
            tbberandacustomer = new TextBox();
            tbkatalogcustomer = new TextBox();
            tbtransaksicustomer = new TextBox();
            pbprofilcustomer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbprofilcustomer).BeginInit();
            SuspendLayout();
            // 
            // tbberandacustomer
            // 
            tbberandacustomer.BackColor = SystemColors.Window;
            tbberandacustomer.BorderStyle = BorderStyle.None;
            tbberandacustomer.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbberandacustomer.ForeColor = SystemColors.WindowText;
            tbberandacustomer.Location = new Point(503, 191);
            tbberandacustomer.Name = "tbberandacustomer";
            tbberandacustomer.Size = new Size(114, 38);
            tbberandacustomer.TabIndex = 0;
            tbberandacustomer.Text = "Beranda";
            // 
            // tbkatalogcustomer
            // 
            tbkatalogcustomer.BackColor = SystemColors.Window;
            tbkatalogcustomer.BorderStyle = BorderStyle.None;
            tbkatalogcustomer.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbkatalogcustomer.ForeColor = SystemColors.WindowText;
            tbkatalogcustomer.Location = new Point(905, 191);
            tbkatalogcustomer.Name = "tbkatalogcustomer";
            tbkatalogcustomer.Size = new Size(103, 38);
            tbkatalogcustomer.TabIndex = 1;
            tbkatalogcustomer.Text = "Katalog";
            // 
            // tbtransaksicustomer
            // 
            tbtransaksicustomer.BackColor = SystemColors.Window;
            tbtransaksicustomer.BorderStyle = BorderStyle.None;
            tbtransaksicustomer.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbtransaksicustomer.ForeColor = SystemColors.WindowText;
            tbtransaksicustomer.Location = new Point(1301, 191);
            tbtransaksicustomer.Name = "tbtransaksicustomer";
            tbtransaksicustomer.Size = new Size(131, 38);
            tbtransaksicustomer.TabIndex = 2;
            tbtransaksicustomer.Text = "Transaksi";
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
            // BerandaCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1920, 1080);
            Controls.Add(pbprofilcustomer);
            Controls.Add(tbtransaksicustomer);
            Controls.Add(tbkatalogcustomer);
            Controls.Add(tbberandacustomer);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BerandaCustomer";
            Text = "BerandaCustomer";
            ((System.ComponentModel.ISupportInitialize)pbprofilcustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbberandacustomer;
        private TextBox tbkatalogcustomer;
        private TextBox tbtransaksicustomer;
        private PictureBox pbprofilcustomer;
    }
}