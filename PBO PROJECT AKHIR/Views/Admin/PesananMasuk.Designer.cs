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
            // PesananMasuk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RIWAYAT_PESANAN__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1471, 840);
            Controls.Add(dataGridPesanan);
            DoubleBuffered = true;
            Name = "PesananMasuk";
            Text = "PesananMasuk";
            ((System.ComponentModel.ISupportInitialize)dataGridPesanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridPesanan;
    }
}