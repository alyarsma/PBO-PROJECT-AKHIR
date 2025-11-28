namespace PBO_PROJECT_AKHIR.Views.User
{
    partial class KatalogCustomer2
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
            btnberandacustomer = new Button();
            btnkatalogcustomer = new Button();
            btntransaksicustomer = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnberandacustomer
            // 
            btnberandacustomer.BackColor = Color.Transparent;
            btnberandacustomer.FlatAppearance.BorderSize = 0;
            btnberandacustomer.FlatStyle = FlatStyle.Flat;
            btnberandacustomer.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnberandacustomer.Location = new Point(500, 182);
            btnberandacustomer.Name = "btnberandacustomer";
            btnberandacustomer.Size = new Size(139, 43);
            btnberandacustomer.TabIndex = 0;
            btnberandacustomer.Text = "Beranda";
            btnberandacustomer.UseVisualStyleBackColor = false;
            // 
            // btnkatalogcustomer
            // 
            btnkatalogcustomer.BackColor = Color.Transparent;
            btnkatalogcustomer.FlatAppearance.BorderSize = 0;
            btnkatalogcustomer.FlatStyle = FlatStyle.Flat;
            btnkatalogcustomer.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkatalogcustomer.Location = new Point(890, 182);
            btnkatalogcustomer.Name = "btnkatalogcustomer";
            btnkatalogcustomer.Size = new Size(139, 43);
            btnkatalogcustomer.TabIndex = 1;
            btnkatalogcustomer.Text = "Katalog";
            btnkatalogcustomer.UseVisualStyleBackColor = false;
            // 
            // btntransaksicustomer
            // 
            btntransaksicustomer.BackColor = Color.Transparent;
            btntransaksicustomer.FlatAppearance.BorderSize = 0;
            btntransaksicustomer.FlatStyle = FlatStyle.Flat;
            btntransaksicustomer.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntransaksicustomer.Location = new Point(1281, 182);
            btntransaksicustomer.Name = "btntransaksicustomer";
            btntransaksicustomer.Size = new Size(154, 43);
            btntransaksicustomer.TabIndex = 2;
            btntransaksicustomer.Text = "Transaksi";
            btntransaksicustomer.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.bi__person_circle;
            pictureBox1.Location = new Point(1742, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // KatalogCustomer2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.KATALOG_PRODUK__6_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pictureBox1);
            Controls.Add(btntransaksicustomer);
            Controls.Add(btnkatalogcustomer);
            Controls.Add(btnberandacustomer);
            DoubleBuffered = true;
            Name = "KatalogCustomer2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KatalogCustomer2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnberandacustomer;
        private Button btnkatalogcustomer;
        private Button btntransaksicustomer;
        private PictureBox pictureBox1;
    }
}