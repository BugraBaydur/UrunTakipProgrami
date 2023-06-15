namespace UrunTakipProgrami
{
    partial class KullaniciGoruntuleme
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_KullanicAdi = new System.Windows.Forms.Label();
            this.chb_Durum = new System.Windows.Forms.CheckBox();
            this.chb_Yetki = new System.Windows.Forms.CheckBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.tb_Sifre = new System.Windows.Forms.TextBox();
            this.tb_AD = new System.Windows.Forms.TextBox();
            this.tb_Soyad = new System.Windows.Forms.TextBox();
            this.btn_duzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(726, 647);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(786, 35);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(128, 23);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "Sorumlu Kodu";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(786, 121);
            this.lbl_Sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(51, 23);
            this.lbl_Sifre.TabIndex = 4;
            this.lbl_Sifre.Text = "Sifre";
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(991, 35);
            this.lbl_KullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(113, 23);
            this.lbl_KullaniciAdi.TabIndex = 5;
            this.lbl_KullaniciAdi.Text = "Kullanici adi";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(991, 121);
            this.lbl_Ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(34, 23);
            this.lbl_Ad.TabIndex = 6;
            this.lbl_Ad.Text = "Ad";
            // 
            // lbl_KullanicAdi
            // 
            this.lbl_KullanicAdi.AutoSize = true;
            this.lbl_KullanicAdi.Location = new System.Drawing.Point(786, 204);
            this.lbl_KullanicAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KullanicAdi.Name = "lbl_KullanicAdi";
            this.lbl_KullanicAdi.Size = new System.Drawing.Size(61, 23);
            this.lbl_KullanicAdi.TabIndex = 7;
            this.lbl_KullanicAdi.Text = "Soyad";
            // 
            // chb_Durum
            // 
            this.chb_Durum.AutoSize = true;
            this.chb_Durum.Location = new System.Drawing.Point(995, 217);
            this.chb_Durum.Name = "chb_Durum";
            this.chb_Durum.Size = new System.Drawing.Size(89, 27);
            this.chb_Durum.TabIndex = 8;
            this.chb_Durum.Text = "Durum";
            this.chb_Durum.UseVisualStyleBackColor = true;
            // 
            // chb_Yetki
            // 
            this.chb_Yetki.AutoSize = true;
            this.chb_Yetki.Location = new System.Drawing.Point(995, 250);
            this.chb_Yetki.Name = "chb_Yetki";
            this.chb_Yetki.Size = new System.Drawing.Size(76, 27);
            this.chb_Yetki.TabIndex = 9;
            this.chb_Yetki.Text = "Yetki";
            this.chb_Yetki.UseVisualStyleBackColor = true;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(790, 72);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(151, 30);
            this.tb_ID.TabIndex = 10;
            // 
            // tb_KullaniciAdi
            // 
            this.tb_KullaniciAdi.Location = new System.Drawing.Point(995, 72);
            this.tb_KullaniciAdi.Name = "tb_KullaniciAdi";
            this.tb_KullaniciAdi.Size = new System.Drawing.Size(151, 30);
            this.tb_KullaniciAdi.TabIndex = 11;
            // 
            // tb_Sifre
            // 
            this.tb_Sifre.Location = new System.Drawing.Point(790, 147);
            this.tb_Sifre.Name = "tb_Sifre";
            this.tb_Sifre.Size = new System.Drawing.Size(151, 30);
            this.tb_Sifre.TabIndex = 12;
            // 
            // tb_AD
            // 
            this.tb_AD.Location = new System.Drawing.Point(995, 147);
            this.tb_AD.Name = "tb_AD";
            this.tb_AD.Size = new System.Drawing.Size(151, 30);
            this.tb_AD.TabIndex = 13;
            // 
            // tb_Soyad
            // 
            this.tb_Soyad.Location = new System.Drawing.Point(790, 230);
            this.tb_Soyad.Name = "tb_Soyad";
            this.tb_Soyad.Size = new System.Drawing.Size(151, 30);
            this.tb_Soyad.TabIndex = 14;
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(875, 315);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(185, 62);
            this.btn_duzenle.TabIndex = 15;
            this.btn_duzenle.Text = "Duzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // KullaniciGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 647);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.tb_Soyad);
            this.Controls.Add(this.tb_AD);
            this.Controls.Add(this.tb_Sifre);
            this.Controls.Add(this.tb_KullaniciAdi);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.chb_Yetki);
            this.Controls.Add(this.chb_Durum);
            this.Controls.Add(this.lbl_KullanicAdi);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciGoruntuleme";
            this.Text = "KullaniciGoruntuleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label lbl_KullanicAdi;
        private System.Windows.Forms.CheckBox chb_Durum;
        private System.Windows.Forms.CheckBox chb_Yetki;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_KullaniciAdi;
        private System.Windows.Forms.TextBox tb_Sifre;
        private System.Windows.Forms.TextBox tb_AD;
        private System.Windows.Forms.TextBox tb_Soyad;
        private System.Windows.Forms.Button btn_duzenle;
    }
}