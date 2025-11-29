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
            pictureBox1.Location = new Point(788, 224);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbeditnamaproduk
            // 
            tbeditnamaproduk.BackColor = Color.White;
            tbeditnamaproduk.BorderStyle = BorderStyle.None;
            tbeditnamaproduk.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbeditnamaproduk.Location = new Point(230, 223);
            tbeditnamaproduk.Margin = new Padding(3, 2, 3, 2);
            tbeditnamaproduk.Name = "tbeditnamaproduk";
            tbeditnamaproduk.Size = new Size(336, 19);
            tbeditnamaproduk.TabIndex = 1;
            // 
            // tbedithargaproduk
            // 
            tbedithargaproduk.BackColor = Color.White;
            tbedithargaproduk.BorderStyle = BorderStyle.None;
            tbedithargaproduk.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbedithargaproduk.Location = new Point(230, 322);
            tbedithargaproduk.Margin = new Padding(3, 2, 3, 2);
            tbedithargaproduk.Name = "tbedithargaproduk";
            tbedithargaproduk.Size = new Size(336, 19);
            tbedithargaproduk.TabIndex = 2;
            // 
            // tbeditstokproduk
            // 
            tbeditstokproduk.BackColor = Color.White;
            tbeditstokproduk.BorderStyle = BorderStyle.None;
            tbeditstokproduk.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbeditstokproduk.Location = new Point(230, 422);
            tbeditstokproduk.Margin = new Padding(3, 2, 3, 2);
            tbeditstokproduk.Name = "tbeditstokproduk";
            tbeditstokproduk.Size = new Size(336, 19);
            tbeditstokproduk.TabIndex = 3;
            // 
            // btnupfotobaru
            // 
            btnupfotobaru.BackColor = Color.Transparent;
            btnupfotobaru.FlatAppearance.BorderSize = 0;
            btnupfotobaru.FlatStyle = FlatStyle.Flat;
            btnupfotobaru.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupfotobaru.Location = new Point(767, 400);
            btnupfotobaru.Margin = new Padding(3, 2, 3, 2);
            btnupfotobaru.Name = "btnupfotobaru";
            btnupfotobaru.Size = new Size(192, 32);
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
            btnbataledit.Location = new Point(767, 447);
            btnbataledit.Margin = new Padding(3, 2, 3, 2);
            btnbataledit.Name = "btnbataledit";
            btnbataledit.Size = new Size(75, 26);
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
            btnsimpanedit.Location = new Point(885, 448);
            btnsimpanedit.Margin = new Padding(3, 2, 3, 2);
            btnsimpanedit.Name = "btnsimpanedit";
            btnsimpanedit.Size = new Size(89, 26);
            btnsimpanedit.TabIndex = 6;
            btnsimpanedit.Text = "Simpan";
            btnsimpanedit.UseVisualStyleBackColor = false;
            btnsimpanedit.Click += btnsimpanedit_Click;
            // 
            // EditProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.form_edit_produk1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1185, 640);
            Controls.Add(btnsimpanedit);
            Controls.Add(btnbataledit);
            Controls.Add(btnupfotobaru);
            Controls.Add(tbeditstokproduk);
            Controls.Add(tbedithargaproduk);
            Controls.Add(tbeditnamaproduk);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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