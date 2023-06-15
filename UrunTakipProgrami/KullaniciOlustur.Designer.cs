namespace UrunTakipProgrami
{
    partial class KullaniciOlustur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Yetki = new System.Windows.Forms.CheckBox();
            this.cb_Durum = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Durum);
            this.groupBox1.Controls.Add(this.cb_Yetki);
            this.groupBox1.Controls.Add(this.btn_Kaydet);
            this.groupBox1.Controls.Add(this.tb_soyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_ad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_sifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_kullaniciadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(131, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(462, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kullanici Bilgileri";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(127, 259);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(167, 52);
            this.btn_Kaydet.TabIndex = 12;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(242, 149);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(147, 27);
            this.tb_soyad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyadi";
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(27, 149);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(147, 27);
            this.tb_ad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adi";
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(242, 85);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.PasswordChar = '*';
            this.tb_sifre.Size = new System.Drawing.Size(147, 27);
            this.tb_sifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre";
            // 
            // tb_kullaniciadi
            // 
            this.tb_kullaniciadi.Location = new System.Drawing.Point(27, 85);
            this.tb_kullaniciadi.Name = "tb_kullaniciadi";
            this.tb_kullaniciadi.Size = new System.Drawing.Size(147, 27);
            this.tb_kullaniciadi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici Adi";
            // 
            // cb_Yetki
            // 
            this.cb_Yetki.AutoSize = true;
            this.cb_Yetki.Location = new System.Drawing.Point(27, 215);
            this.cb_Yetki.Name = "cb_Yetki";
            this.cb_Yetki.Size = new System.Drawing.Size(72, 24);
            this.cb_Yetki.TabIndex = 13;
            this.cb_Yetki.Text = "Yetki";
            this.cb_Yetki.UseVisualStyleBackColor = true;
            // 
            // cb_Durum
            // 
            this.cb_Durum.AutoSize = true;
            this.cb_Durum.Location = new System.Drawing.Point(249, 215);
            this.cb_Durum.Name = "cb_Durum";
            this.cb_Durum.Size = new System.Drawing.Size(87, 24);
            this.cb_Durum.TabIndex = 1;
            this.cb_Durum.Text = "Durum";
            this.cb_Durum.UseVisualStyleBackColor = true;
            // 
            // KullaniciOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciOlustur";
            this.Text = "KullaniciOlustur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_kullaniciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.CheckBox cb_Yetki;
        private System.Windows.Forms.CheckBox cb_Durum;
    }
}