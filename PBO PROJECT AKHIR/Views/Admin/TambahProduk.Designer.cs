namespace PBO_PROJECT_AKHIR.Views.Admin
{
    partial class TambahProduk
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
            openFileDialog1 = new OpenFileDialog();
            btnuploadfoto = new Button();
            tbnamaproduk = new TextBox();
            tbhargaproduk = new TextBox();
            tbstokproduk = new TextBox();
            btnsimpanproduk = new Button();
            btnbatalsimpan = new Button();
            pbgambarproduk = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbgambarproduk).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnuploadfoto
            // 
            btnuploadfoto.BackColor = Color.Transparent;
            btnuploadfoto.FlatAppearance.BorderSize = 0;
            btnuploadfoto.FlatStyle = FlatStyle.Flat;
            btnuploadfoto.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnuploadfoto.Location = new Point(931, 534);
            btnuploadfoto.Name = "btnuploadfoto";
            btnuploadfoto.Size = new Size(222, 43);
            btnuploadfoto.TabIndex = 0;
            btnuploadfoto.Text = "Upload Gambar";
            btnuploadfoto.UseVisualStyleBackColor = false;
            btnuploadfoto.Click += btnuploadfoto_Click;
            // 
            // tbnamaproduk
            // 
            tbnamaproduk.BorderStyle = BorderStyle.None;
            tbnamaproduk.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnamaproduk.Location = new Point(200, 298);
            tbnamaproduk.Name = "tbnamaproduk";
            tbnamaproduk.Size = new Size(449, 30);
            tbnamaproduk.TabIndex = 1;
            // 
            // tbhargaproduk
            // 
            tbhargaproduk.BorderStyle = BorderStyle.None;
            tbhargaproduk.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbhargaproduk.Location = new Point(200, 430);
            tbhargaproduk.Name = "tbhargaproduk";
            tbhargaproduk.Size = new Size(449, 30);
            tbhargaproduk.TabIndex = 2;
            // 
            // tbstokproduk
            // 
            tbstokproduk.BorderStyle = BorderStyle.None;
            tbstokproduk.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbstokproduk.Location = new Point(200, 561);
            tbstokproduk.Name = "tbstokproduk";
            tbstokproduk.Size = new Size(449, 30);
            tbstokproduk.TabIndex = 3;
            // 
            // btnsimpanproduk
            // 
            btnsimpanproduk.BackColor = Color.Transparent;
            btnsimpanproduk.FlatAppearance.BorderSize = 0;
            btnsimpanproduk.FlatStyle = FlatStyle.Flat;
            btnsimpanproduk.Font = new Font("Poppins", 10F);
            btnsimpanproduk.ForeColor = Color.Indigo;
            btnsimpanproduk.Location = new Point(1073, 597);
            btnsimpanproduk.Name = "btnsimpanproduk";
            btnsimpanproduk.Size = new Size(96, 34);
            btnsimpanproduk.TabIndex = 4;
            btnsimpanproduk.Text = "Simpan";
            btnsimpanproduk.UseVisualStyleBackColor = false;
            btnsimpanproduk.Click += btnsimpanproduk_Click;
            // 
            // btnbatalsimpan
            // 
            btnbatalsimpan.BackColor = Color.Transparent;
            btnbatalsimpan.FlatAppearance.BorderSize = 0;
            btnbatalsimpan.FlatStyle = FlatStyle.Flat;
            btnbatalsimpan.Font = new Font("Poppins", 10.3F);
            btnbatalsimpan.ForeColor = Color.White;
            btnbatalsimpan.Location = new Point(909, 596);
            btnbatalsimpan.Name = "btnbatalsimpan";
            btnbatalsimpan.Size = new Size(96, 34);
            btnbatalsimpan.TabIndex = 5;
            btnbatalsimpan.Text = "Batal";
            btnbatalsimpan.UseVisualStyleBackColor = false;
            btnbatalsimpan.Click += btnbatalsimpan_Click;
            // 
            // pbgambarproduk
            // 
            pbgambarproduk.BackColor = Color.Transparent;
            pbgambarproduk.BackgroundImageLayout = ImageLayout.Zoom;
            pbgambarproduk.Location = new Point(936, 299);
            pbgambarproduk.Name = "pbgambarproduk";
            pbgambarproduk.Size = new Size(210, 160);
            pbgambarproduk.TabIndex = 6;
            pbgambarproduk.TabStop = false;
            // 
            // TambahProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.form_tambah_produk__1_1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1354, 853);
            Controls.Add(pbgambarproduk);
            Controls.Add(btnbatalsimpan);
            Controls.Add(btnsimpanproduk);
            Controls.Add(tbstokproduk);
            Controls.Add(tbhargaproduk);
            Controls.Add(tbnamaproduk);
            Controls.Add(btnuploadfoto);
            DoubleBuffered = true;
            Name = "TambahProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TambahProduk";
            ((System.ComponentModel.ISupportInitialize)pbgambarproduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnuploadfoto;
        private TextBox tbnamaproduk;
        private TextBox tbhargaproduk;
        private TextBox tbstokproduk;
        private Button btnsimpanproduk;
        private Button btnbatalsimpan;
        private PictureBox pbgambarproduk;
    }
}