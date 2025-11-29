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
            button1 = new Button();
            SuspendLayout();
            // 
            // btnberandaadmin
            // 
            btnberandaadmin.BackColor = Color.Transparent;
            btnberandaadmin.FlatAppearance.BorderSize = 0;
            btnberandaadmin.FlatStyle = FlatStyle.Flat;
            btnberandaadmin.Font = new Font("Microsoft Sans Serif", 14.2F, FontStyle.Bold);
            btnberandaadmin.Location = new Point(360, 188);
            btnberandaadmin.Name = "btnberandaadmin";
            btnberandaadmin.Size = new Size(135, 40);
            btnberandaadmin.TabIndex = 0;
            btnberandaadmin.Text = "Beranda";
            btnberandaadmin.UseVisualStyleBackColor = false;
            // 
            // btnkatalogadmin
            // 
            btnkatalogadmin.BackColor = Color.Transparent;
            btnkatalogadmin.FlatAppearance.BorderSize = 0;
            btnkatalogadmin.FlatStyle = FlatStyle.Flat;
            btnkatalogadmin.Font = new Font("Microsoft Sans Serif", 14.2F, FontStyle.Bold);
            btnkatalogadmin.Location = new Point(728, 187);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(112, 44);
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
            btntransaksiadmin.Font = new Font("Microsoft Sans Serif", 14.45F, FontStyle.Bold);
            btntransaksiadmin.Location = new Point(1067, 188);
            btntransaksiadmin.Name = "btntransaksiadmin";
            btntransaksiadmin.Size = new Size(143, 40);
            btntransaksiadmin.TabIndex = 2;
            btntransaksiadmin.Text = "Transaksi";
            btntransaksiadmin.UseVisualStyleBackColor = false;
            btntransaksiadmin.Click += btntransaksiadmin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.41F, FontStyle.Bold);
            button1.Location = new Point(1425, 186);
            button1.Name = "button1";
            button1.Size = new Size(147, 45);
            button1.TabIndex = 3;
            button1.Text = "Keuangan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BerandaAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Beranda_admin__2_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button1);
            Controls.Add(btntransaksiadmin);
            Controls.Add(btnkatalogadmin);
            Controls.Add(btnberandaadmin);
            DoubleBuffered = true;
            Margin = new Padding(2, 3, 2, 3);
            Name = "BerandaAdmin";
            Text = "BerandaAdmin";
            Load += BerandaAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnberandaadmin;
        private Button btnkatalogadmin;
        private Button btntransaksiadmin;
        private Button button1;
    }
}