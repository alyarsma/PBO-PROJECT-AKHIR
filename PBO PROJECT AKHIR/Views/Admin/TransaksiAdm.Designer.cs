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
            btnPesanan.BackColor = Color.Transparent;
            btnPesanan.FlatAppearance.BorderSize = 0;
            btnPesanan.FlatStyle = FlatStyle.Flat;
            btnPesanan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesanan.Location = new Point(212, 244);
            btnPesanan.Margin = new Padding(3, 4, 3, 4);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(337, 50);
            btnPesanan.TabIndex = 0;
            btnPesanan.Text = "Pesanan Masuk";
            btnPesanan.UseVisualStyleBackColor = false;
            btnPesanan.Click += btnPesanan_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.Transparent;
            btnRiwayat.FlatAppearance.BorderSize = 0;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayat.Location = new Point(970, 244);
            btnRiwayat.Margin = new Padding(3, 4, 3, 4);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(335, 50);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "Riwayat Pesanan";
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.Transparent;
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeranda.Location = new Point(431, 140);
            btnBeranda.Margin = new Padding(3, 4, 3, 4);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(117, 37);
            btnBeranda.TabIndex = 2;
            btnBeranda.Text = "Beranda";
            btnBeranda.UseVisualStyleBackColor = false;
            // 
            // btnKatalog
            // 
            btnKatalog.BackColor = Color.Transparent;
            btnKatalog.FlatAppearance.BorderSize = 0;
            btnKatalog.FlatStyle = FlatStyle.Flat;
            btnKatalog.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKatalog.Location = new Point(711, 140);
            btnKatalog.Margin = new Padding(3, 4, 3, 4);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(117, 37);
            btnKatalog.TabIndex = 3;
            btnKatalog.Text = "Katalog";
            btnKatalog.UseVisualStyleBackColor = false;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.Transparent;
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaksi.Location = new Point(993, 140);
            btnTransaksi.Margin = new Padding(3, 4, 3, 4);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(113, 37);
            btnTransaksi.TabIndex = 4;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = false;
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