namespace PBO_PROJECT_AKHIR.Views.Admin
{
    partial class EditProduk
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
            pictureBox1 = new PictureBox();
            tbeditnamaproduk = new TextBox();
            tbedithargaproduk = new TextBox();
            tbeditstokproduk = new TextBox();
            btnupfotobaru = new Button();
            btnbataledit = new Button();
            btnsimpanedit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(934, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 160);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbeditnamaproduk
            // 
            tbeditnamaproduk.BackColor = Color.White;
            tbeditnamaproduk.BorderStyle = BorderStyle.None;
            tbeditnamaproduk.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbeditnamaproduk.Location = new Point(205, 297);
            tbeditnamaproduk.Name = "tbeditnamaproduk";
            tbeditnamaproduk.Size = new Size(442, 30);
            tbeditnamaproduk.TabIndex = 1;
            // 
            // tbedithargaproduk
            // 
            tbedithargaproduk.BackColor = Color.White;
            tbedithargaproduk.BorderStyle = BorderStyle.None;
            tbedithargaproduk.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbedithargaproduk.Location = new Point(205, 429);
            tbedithargaproduk.Name = "tbedithargaproduk";
            tbedithargaproduk.Size = new Size(442, 30);
            tbedithargaproduk.TabIndex = 2;
            // 
            // tbeditstokproduk
            // 
            tbeditstokproduk.BackColor = Color.White;
            tbeditstokproduk.BorderStyle = BorderStyle.None;
            tbeditstokproduk.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbeditstokproduk.Location = new Point(205, 563);
            tbeditstokproduk.Name = "tbeditstokproduk";
            tbeditstokproduk.Size = new Size(442, 30);
            tbeditstokproduk.TabIndex = 3;
            // 
            // btnupfotobaru
            // 
            btnupfotobaru.BackColor = Color.Transparent;
            btnupfotobaru.FlatAppearance.BorderSize = 0;
            btnupfotobaru.FlatStyle = FlatStyle.Flat;
            btnupfotobaru.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupfotobaru.Location = new Point(928, 534);
            btnupfotobaru.Name = "btnupfotobaru";
            btnupfotobaru.Size = new Size(219, 43);
            btnupfotobaru.TabIndex = 4;
            btnupfotobaru.Text = "Upload Gambar";
            btnupfotobaru.UseVisualStyleBackColor = false;
            btnupfotobaru.Click += btnupfotobaru_Click;
            // 
            // btnbataledit
            // 
            btnbataledit.BackColor = Color.Transparent;
            btnbataledit.FlatAppearance.BorderSize = 0;
            btnbataledit.FlatStyle = FlatStyle.Flat;
            btnbataledit.Font = new Font("Microsoft Sans Serif", 10.3F);
            btnbataledit.ForeColor = Color.White;
            btnbataledit.Location = new Point(916, 597);
            btnbataledit.Name = "btnbataledit";
            btnbataledit.Size = new Size(86, 35);
            btnbataledit.TabIndex = 5;
            btnbataledit.Text = "Batal";
            btnbataledit.UseVisualStyleBackColor = false;
            // 
            // btnsimpanedit
            // 
            btnsimpanedit.BackColor = Color.Transparent;
            btnsimpanedit.FlatAppearance.BorderSize = 0;
            btnsimpanedit.FlatStyle = FlatStyle.Flat;
            btnsimpanedit.Font = new Font("Microsoft Sans Serif", 10.3F);
            btnsimpanedit.ForeColor = Color.Indigo;
            btnsimpanedit.Location = new Point(1070, 596);
            btnsimpanedit.Name = "btnsimpanedit";
            btnsimpanedit.Size = new Size(102, 35);
            btnsimpanedit.TabIndex = 6;
            btnsimpanedit.Text = "Simpan";
            btnsimpanedit.UseVisualStyleBackColor = false;
            btnsimpanedit.Click += btnsimpanedit_Click;
            // 
            // EditProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.form_edit_produk1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1354, 853);
            Controls.Add(btnsimpanedit);
            Controls.Add(btnbataledit);
            Controls.Add(btnupfotobaru);
            Controls.Add(tbeditstokproduk);
            Controls.Add(tbedithargaproduk);
            Controls.Add(tbeditnamaproduk);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "EditProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbeditnamaproduk;
        private TextBox tbedithargaproduk;
        private TextBox tbeditstokproduk;
        private Button btnupfotobaru;
        private Button btnbataledit;
        private Button btnsimpanedit;
    }
}