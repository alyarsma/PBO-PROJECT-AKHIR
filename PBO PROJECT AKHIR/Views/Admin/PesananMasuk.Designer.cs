namespace PBO_PROJECT_AKHIR.Views.Admin
{
    partial class PesananMasuk
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
            dataGridPesanan = new DataGridView();
            label1 = new Label();
            btnKatalog = new Label();
            label3 = new Label();
            lblRiwayatPesanan = new Label();
            lblPesananMasuk = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPesanan).BeginInit();
            SuspendLayout();
            // 
            // dataGridPesanan
            // 
            dataGridPesanan.BackgroundColor = Color.White;
            dataGridPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPesanan.Location = new Point(208, 335);
            dataGridPesanan.Name = "dataGridPesanan";
            dataGridPesanan.RowHeadersWidth = 51;
            dataGridPesanan.Size = new Size(1103, 451);
            dataGridPesanan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(437, 142);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 1;
            label1.Text = "Beranda";
            label1.Click += label1_Click;
            // 
            // btnKatalog
            // 
            btnKatalog.AutoSize = true;
            btnKatalog.BackColor = Color.Transparent;
            btnKatalog.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKatalog.ForeColor = Color.Gray;
            btnKatalog.Location = new Point(719, 142);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(86, 25);
            btnKatalog.TabIndex = 2;
            btnKatalog.Text = "Katalog";
            btnKatalog.Click += btnKatalog_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(988, 142);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 3;
            label3.Text = "Transaksi";
            // 
            // lblRiwayatPesanan
            // 
            lblRiwayatPesanan.AutoSize = true;
            lblRiwayatPesanan.BackColor = Color.Transparent;
            lblRiwayatPesanan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRiwayatPesanan.ForeColor = Color.Gray;
            lblRiwayatPesanan.Location = new Point(1041, 251);
            lblRiwayatPesanan.Name = "lblRiwayatPesanan";
            lblRiwayatPesanan.Size = new Size(178, 25);
            lblRiwayatPesanan.TabIndex = 4;
            lblRiwayatPesanan.Text = "Riwayat Pesanan";
            lblRiwayatPesanan.Click += lblRiwayatPesanan_Click;
            // 
            // lblPesananMasuk
            // 
            lblPesananMasuk.AutoSize = true;
            lblPesananMasuk.BackColor = Color.Transparent;
            lblPesananMasuk.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesananMasuk.ForeColor = Color.Black;
            lblPesananMasuk.Location = new Point(283, 252);
            lblPesananMasuk.Name = "lblPesananMasuk";
            lblPesananMasuk.Size = new Size(167, 25);
            lblPesananMasuk.TabIndex = 5;
            lblPesananMasuk.Text = "Pesanan Masuk\r\n";
            lblPesananMasuk.Click += lblPesananMasuk_Click;
            // 
            // PesananMasuk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RIWAYAT_PESANAN__1_1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1471, 840);
            Controls.Add(lblPesananMasuk);
            Controls.Add(lblRiwayatPesanan);
            Controls.Add(label3);
            Controls.Add(btnKatalog);
            Controls.Add(label1);
            Controls.Add(dataGridPesanan);
            DoubleBuffered = true;
            Name = "PesananMasuk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PesananMasuk";
            ((System.ComponentModel.ISupportInitialize)dataGridPesanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridPesanan;
        private Label label1;
        private Label btnKatalog;
        private Label label3;
        private Label lblRiwayatPesanan;
        private Label lblPesananMasuk;
    }
}