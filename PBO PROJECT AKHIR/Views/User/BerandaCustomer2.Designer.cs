namespace PBO_PROJECT_AKHIR.Views.User
{
    partial class BerandaCustomer2
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
            pbprofilecustomer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbprofilecustomer).BeginInit();
            SuspendLayout();
            // 
            // btnberandacustomer
            // 
            btnberandacustomer.BackColor = Color.Transparent;
            btnberandacustomer.FlatAppearance.BorderSize = 0;
            btnberandacustomer.FlatStyle = FlatStyle.Flat;
            btnberandacustomer.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnberandacustomer.Location = new Point(490, 187);
            btnberandacustomer.Name = "btnberandacustomer";
            btnberandacustomer.Size = new Size(138, 49);
            btnberandacustomer.TabIndex = 0;
            btnberandacustomer.Text = "Beranda";
            btnberandacustomer.UseVisualStyleBackColor = false;
            btnberandacustomer.Click += btnberandacustomer_Click;
            // 
            // btnkatalogcustomer
            // 
            btnkatalogcustomer.BackColor = Color.Transparent;
            btnkatalogcustomer.FlatAppearance.BorderSize = 0;
            btnkatalogcustomer.FlatStyle = FlatStyle.Flat;
            btnkatalogcustomer.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkatalogcustomer.Location = new Point(887, 187);
            btnkatalogcustomer.Name = "btnkatalogcustomer";
            btnkatalogcustomer.Size = new Size(138, 49);
            btnkatalogcustomer.TabIndex = 1;
            btnkatalogcustomer.Text = "Katalog";
            btnkatalogcustomer.UseVisualStyleBackColor = false;
            btnkatalogcustomer.Click += btnkatalogcustomer_Click;
            // 
            // btntransaksicustomer
            // 
            btntransaksicustomer.BackColor = Color.Transparent;
            btntransaksicustomer.FlatAppearance.BorderSize = 0;
            btntransaksicustomer.FlatStyle = FlatStyle.Flat;
            btntransaksicustomer.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntransaksicustomer.Location = new Point(1286, 187);
            btntransaksicustomer.Name = "btntransaksicustomer";
            btntransaksicustomer.Size = new Size(156, 49);
            btntransaksicustomer.TabIndex = 2;
            btntransaksicustomer.Text = "Transaksi";
            btntransaksicustomer.UseVisualStyleBackColor = false;
            btntransaksicustomer.Click += btntransaksicustomer_Click;
            // 
            // pbprofilecustomer
            // 
            pbprofilecustomer.BackColor = Color.Transparent;
            pbprofilecustomer.Image = Properties.Resources.bi__person_circle;
            pbprofilecustomer.Location = new Point(1758, 38);
            pbprofilecustomer.Name = "pbprofilecustomer";
            pbprofilecustomer.Size = new Size(65, 65);
            pbprofilecustomer.SizeMode = PictureBoxSizeMode.Zoom;
            pbprofilecustomer.TabIndex = 3;
            pbprofilecustomer.TabStop = false;
            pbprofilecustomer.Click += pbprofilecustomer_Click;
            // 
            // BerandaCustomer2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Beranda_customer__2_;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pbprofilecustomer);
            Controls.Add(btntransaksicustomer);
            Controls.Add(btnkatalogcustomer);
            Controls.Add(btnberandacustomer);
            Name = "BerandaCustomer2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BerandaCustomer2";
            ((System.ComponentModel.ISupportInitialize)pbprofilecustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnberandacustomer;
        private Button btnkatalogcustomer;
        private Button btntransaksicustomer;
        private PictureBox pbprofilecustomer;
    }
}