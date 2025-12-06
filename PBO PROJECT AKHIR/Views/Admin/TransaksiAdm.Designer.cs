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
            btnPesanan.Location = new Point(351, 247);
            btnPesanan.Margin = new Padding(3, 4, 3, 4);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(144, 37);
            btnPesanan.TabIndex = 0;
            btnPesanan.Text = "Pesanan Masuk";
            btnPesanan.UseVisualStyleBackColor = true;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayat.Location = new Point(1021, 247);
            btnRiwayat.Margin = new Padding(3, 4, 3, 4);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(144, 37);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "Riwayat Pesanan";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeranda.Location = new Point(462, 136);
            btnBeranda.Margin = new Padding(3, 4, 3, 4);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(117, 37);
            btnBeranda.TabIndex = 2;
            btnBeranda.Text = "Beranda";
            btnBeranda.UseVisualStyleBackColor = true;
            // 
            // btnKatalog
            // 
            btnKatalog.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKatalog.Location = new Point(704, 136);
            btnKatalog.Margin = new Padding(3, 4, 3, 4);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(117, 37);
            btnKatalog.TabIndex = 3;
            btnKatalog.Text = "Katalog";
            btnKatalog.UseVisualStyleBackColor = true;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaksi.Location = new Point(947, 136);
            btnTransaksi.Margin = new Padding(3, 4, 3, 4);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(113, 37);
            btnTransaksi.TabIndex = 4;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // TransaksiAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1471, 840);
            Controls.Add(btnTransaksi);
            Controls.Add(btnKatalog);
            Controls.Add(btnBeranda);
            Controls.Add(btnRiwayat);
            Controls.Add(btnPesanan);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TransaksiAdm";
            StartPosition = FormStartPosition.CenterScreen;
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