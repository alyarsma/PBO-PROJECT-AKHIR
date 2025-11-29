namespace PBO_PROJECT_AKHIR.Views.Admin
{
    partial class TransaksiAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaksiAdm));
            btnPesanan = new Button();
            btnRiwayat = new Button();
            btnBeranda = new Button();
            btnKatalog = new Button();
            btnTransaksi = new Button();
            SuspendLayout();
            // 
            // btnPesanan
            // 
            btnPesanan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesanan.Location = new Point(307, 185);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(126, 28);
            btnPesanan.TabIndex = 0;
            btnPesanan.Text = "Pesanan Masuk";
            btnPesanan.UseVisualStyleBackColor = true;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayat.Location = new Point(893, 185);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(126, 28);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "Riwayat Pesanan";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeranda.Location = new Point(404, 102);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(102, 28);
            btnBeranda.TabIndex = 2;
            btnBeranda.Text = "Beranda";
            btnBeranda.UseVisualStyleBackColor = true;
            // 
            // btnKatalog
            // 
            btnKatalog.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKatalog.Location = new Point(616, 102);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(102, 28);
            btnKatalog.TabIndex = 3;
            btnKatalog.Text = "Katalog";
            btnKatalog.UseVisualStyleBackColor = true;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaksi.Location = new Point(829, 102);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(99, 28);
            btnTransaksi.TabIndex = 4;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // TransaksiAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1287, 630);
            Controls.Add(btnTransaksi);
            Controls.Add(btnKatalog);
            Controls.Add(btnBeranda);
            Controls.Add(btnRiwayat);
            Controls.Add(btnPesanan);
            DoubleBuffered = true;
            Name = "TransaksiAdm";
            Text = "TransaksiAdm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPesanan;
        private Button btnRiwayat;
        private Button btnBeranda;
        private Button btnKatalog;
        private Button btnTransaksi;
    }
}