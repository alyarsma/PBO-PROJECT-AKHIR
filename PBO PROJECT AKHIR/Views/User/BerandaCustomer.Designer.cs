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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbprofilcustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbberandacustomer
            // 
            tbberandacustomer.BackColor = SystemColors.Window;
            tbberandacustomer.BorderStyle = BorderStyle.None;
            tbberandacustomer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbberandacustomer.ForeColor = SystemColors.WindowText;
            tbberandacustomer.Location = new Point(498, 201);
            tbberandacustomer.Margin = new Padding(4);
            tbberandacustomer.Name = "tbberandacustomer";
            tbberandacustomer.Size = new Size(142, 34);
            tbberandacustomer.TabIndex = 0;
            tbberandacustomer.Text = "Beranda";
            // 
            // tbkatalogcustomer
            // 
            tbkatalogcustomer.BackColor = SystemColors.Window;
            tbkatalogcustomer.BorderStyle = BorderStyle.None;
            tbkatalogcustomer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbkatalogcustomer.ForeColor = SystemColors.WindowText;
            tbkatalogcustomer.Location = new Point(903, 201);
            tbkatalogcustomer.Margin = new Padding(4);
            tbkatalogcustomer.Name = "tbkatalogcustomer";
            tbkatalogcustomer.Size = new Size(129, 34);
            tbkatalogcustomer.TabIndex = 1;
            tbkatalogcustomer.Text = "Katalog";
            // 
            // tbtransaksicustomer
            // 
            tbtransaksicustomer.BackColor = SystemColors.Window;
            tbtransaksicustomer.BorderStyle = BorderStyle.None;
            tbtransaksicustomer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbtransaksicustomer.ForeColor = SystemColors.WindowText;
            tbtransaksicustomer.Location = new Point(1305, 201);
            tbtransaksicustomer.Margin = new Padding(4);
            tbtransaksicustomer.Name = "tbtransaksicustomer";
            tbtransaksicustomer.Size = new Size(164, 34);
            tbtransaksicustomer.TabIndex = 2;
            tbtransaksicustomer.Text = "Transaksi";
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
            // BerandaCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1946, 1106);
            Controls.Add(pictureBox1);
            Controls.Add(pbprofilcustomer);
            Controls.Add(tbtransaksicustomer);
            Controls.Add(tbkatalogcustomer);
            Controls.Add(tbberandacustomer);
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
        private TextBox tbkatalogcustomer;
        private TextBox tbtransaksicustomer;
        private PictureBox pbprofilcustomer;
        private PictureBox pictureBox1;
    }
}