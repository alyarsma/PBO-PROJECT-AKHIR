namespace PBO_PROJECT_AKHIR.Views.Admin
{
    partial class RiwayatPesanan
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
            dataGridView1 = new DataGridView();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            btnBeranda = new Label();
            btnKatalog = new Label();
            label3 = new Label();
            lblPesananMasuk = new Label();
            lblRiwayatPesanan = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.GradientInactiveCaption;
            dataGridView1.Location = new Point(208, 335);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1103, 451);
            dataGridView1.TabIndex = 0;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // btnBeranda
            // 
            btnBeranda.AutoSize = true;
            btnBeranda.BackColor = Color.Transparent;
            btnBeranda.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBeranda.ForeColor = Color.Gray;
            btnBeranda.Location = new Point(437, 142);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(110, 36);
            btnBeranda.TabIndex = 2;
            btnBeranda.Text = "Beranda";
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnKatalog
            // 
            btnKatalog.AutoSize = true;
            btnKatalog.BackColor = Color.Transparent;
            btnKatalog.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKatalog.ForeColor = Color.Gray;
            btnKatalog.Location = new Point(717, 142);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(102, 36);
            btnKatalog.TabIndex = 3;
            btnKatalog.Text = "Katalog";
            btnKatalog.Click += btnKatalog_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(988, 142);
            label3.Name = "label3";
            label3.Size = new Size(122, 36);
            label3.TabIndex = 4;
            label3.Text = "Transaksi";
            // 
            // lblPesananMasuk
            // 
            lblPesananMasuk.AutoSize = true;
            lblPesananMasuk.BackColor = Color.Transparent;
            lblPesananMasuk.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesananMasuk.ForeColor = Color.Gray;
            lblPesananMasuk.Location = new Point(290, 251);
            lblPesananMasuk.Name = "lblPesananMasuk";
            lblPesananMasuk.Size = new Size(189, 36);
            lblPesananMasuk.TabIndex = 5;
            lblPesananMasuk.Text = "Pesanan Masuk";
            lblPesananMasuk.Click += lblPesananMasuk_Click;
            // 
            // lblRiwayatPesanan
            // 
            lblRiwayatPesanan.AutoSize = true;
            lblRiwayatPesanan.BackColor = Color.Transparent;
            lblRiwayatPesanan.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRiwayatPesanan.ForeColor = Color.Black;
            lblRiwayatPesanan.Location = new Point(1037, 251);
            lblRiwayatPesanan.Name = "lblRiwayatPesanan";
            lblRiwayatPesanan.Size = new Size(206, 36);
            lblRiwayatPesanan.TabIndex = 6;
            lblRiwayatPesanan.Text = "Riwayat Pesanan";
            lblRiwayatPesanan.Click += lblRiwayatPesanan_Click;
            // 
            // RiwayatPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RIWAYAT_PESANAN__1_1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1471, 840);
            Controls.Add(lblRiwayatPesanan);
            Controls.Add(lblPesananMasuk);
            Controls.Add(label3);
            Controls.Add(btnKatalog);
            Controls.Add(btnBeranda);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RiwayatPesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RiwayatPesanan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Label btnBeranda;
        private Label btnKatalog;
        private Label label3;
        private Label lblPesananMasuk;
        private Label lblRiwayatPesanan;
    }
}