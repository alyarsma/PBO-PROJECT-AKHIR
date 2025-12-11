namespace PBO_PROJECT_AKHIR.Views.Admin
{
    partial class BerandaAdmin
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
            btnberandaadmin = new Button();
            btnkatalogadmin = new Button();
            btntransaksiadmin = new Button();
            SuspendLayout();
            // 
            // btnberandaadmin
            // 
            btnberandaadmin.BackColor = Color.Transparent;
            btnberandaadmin.FlatAppearance.BorderSize = 0;
            btnberandaadmin.FlatStyle = FlatStyle.Flat;
            btnberandaadmin.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnberandaadmin.Location = new Point(374, 143);
            btnberandaadmin.Name = "btnberandaadmin";
            btnberandaadmin.Size = new Size(134, 46);
            btnberandaadmin.TabIndex = 0;
            btnberandaadmin.Text = "Beranda";
            btnberandaadmin.UseVisualStyleBackColor = false;
            // 
            // btnkatalogadmin
            // 
            btnkatalogadmin.BackColor = Color.Transparent;
            btnkatalogadmin.FlatAppearance.BorderSize = 0;
            btnkatalogadmin.FlatStyle = FlatStyle.Flat;
            btnkatalogadmin.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkatalogadmin.Location = new Point(692, 143);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(124, 46);
            btnkatalogadmin.TabIndex = 1;
            btnkatalogadmin.Text = "Katalog";
            btnkatalogadmin.UseVisualStyleBackColor = false;
            btnkatalogadmin.Click += btnkatalogadmin_Click;
            // 
            // btntransaksiadmin
            // 
            btntransaksiadmin.BackColor = Color.Transparent;
            btntransaksiadmin.FlatAppearance.BorderSize = 0;
            btntransaksiadmin.FlatStyle = FlatStyle.Flat;
            btntransaksiadmin.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntransaksiadmin.Location = new Point(1005, 144);
            btntransaksiadmin.Name = "btntransaksiadmin";
            btntransaksiadmin.Size = new Size(145, 45);
            btntransaksiadmin.TabIndex = 2;
            btntransaksiadmin.Text = "Transaksi";
            btntransaksiadmin.UseVisualStyleBackColor = false;
            btntransaksiadmin.Click += btntransaksiadmin_Click;
            // 
            // BerandaAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Beranda_admin__6_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1516, 854);
            Controls.Add(btntransaksiadmin);
            Controls.Add(btnkatalogadmin);
            Controls.Add(btnberandaadmin);
            DoubleBuffered = true;
            Margin = new Padding(2, 3, 2, 3);
            Name = "BerandaAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BerandaAdmin";
            Load += BerandaAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnberandaadmin;
        private Button btnkatalogadmin;
        private Button btntransaksiadmin;
    }
}