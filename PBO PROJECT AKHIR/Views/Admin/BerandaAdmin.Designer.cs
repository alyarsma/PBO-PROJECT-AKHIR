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
            btnberandaadmin.Location = new Point(384, 140);
            btnberandaadmin.Margin = new Padding(3, 2, 3, 2);
            btnberandaadmin.Name = "btnberandaadmin";
            btnberandaadmin.Size = new Size(118, 30);
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
            btnkatalogadmin.Location = new Point(659, 140);
            btnkatalogadmin.Margin = new Padding(3, 2, 3, 2);
            btnkatalogadmin.Name = "btnkatalogadmin";
            btnkatalogadmin.Size = new Size(98, 33);
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
            btntransaksiadmin.Location = new Point(918, 140);
            btntransaksiadmin.Margin = new Padding(3, 2, 3, 2);
            btntransaksiadmin.Name = "btntransaksiadmin";
            btntransaksiadmin.Size = new Size(116, 30);
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
            button1.Location = new Point(1184, 140);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 3;
            button1.Text = "Keuangan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BerandaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Beranda_admin__2_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1684, 791);
            Controls.Add(button1);
            Controls.Add(btntransaksiadmin);
            Controls.Add(btnkatalogadmin);
            Controls.Add(btnberandaadmin);
            DoubleBuffered = true;
            Margin = new Padding(2);
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