namespace UrunTakipProgrami
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.AnaPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.etiketlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciKaydetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanicilariGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makinaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makinaKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelRaporuOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AraPanel = new System.Windows.Forms.Panel();
            this.tb_tarih = new System.Windows.Forms.TextBox();
            this.lbl_vardiya = new System.Windows.Forms.Label();
            this.lbl_SoyAd = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.AraPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaPanel
            // 
            this.AnaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnaPanel.AutoSize = true;
            this.AnaPanel.Location = new System.Drawing.Point(0, 83);
            this.AnaPanel.Name = "AnaPanel";
            this.AnaPanel.Size = new System.Drawing.Size(932, 518);
            this.AnaPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiketlemeToolStripMenuItem,
            this.dosyalarToolStripMenuItem,
            this.kullaniciKaydetToolStripMenuItem,
            this.makinaIslemleriToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // etiketlemeToolStripMenuItem
            // 
            this.etiketlemeToolStripMenuItem.Name = "etiketlemeToolStripMenuItem";
            this.etiketlemeToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.etiketlemeToolStripMenuItem.Text = "Giris";
            this.etiketlemeToolStripMenuItem.Click += new System.EventHandler(this.etiketlemeToolStripMenuItem_Click);
            // 
            // dosyalarToolStripMenuItem
            // 
            this.dosyalarToolStripMenuItem.Name = "dosyalarToolStripMenuItem";
            this.dosyalarToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.dosyalarToolStripMenuItem.Text = "Etiketleme";
            this.dosyalarToolStripMenuItem.Visible = false;
            this.dosyalarToolStripMenuItem.Click += new System.EventHandler(this.dosyalarToolStripMenuItem_Click);
            // 
            // kullaniciKaydetToolStripMenuItem
            // 
            this.kullaniciKaydetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciKaydetToolStripMenuItem1,
            this.kullanicilariGoruntuleToolStripMenuItem});
            this.kullaniciKaydetToolStripMenuItem.Name = "kullaniciKaydetToolStripMenuItem";
            this.kullaniciKaydetToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.kullaniciKaydetToolStripMenuItem.Text = "Kullanici Islemleri";
            this.kullaniciKaydetToolStripMenuItem.Visible = false;
            // 
            // kullaniciKaydetToolStripMenuItem1
            // 
            this.kullaniciKaydetToolStripMenuItem1.Name = "kullaniciKaydetToolStripMenuItem1";
            this.kullaniciKaydetToolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.kullaniciKaydetToolStripMenuItem1.Text = "Kullanici Kaydet";
            this.kullaniciKaydetToolStripMenuItem1.Click += new System.EventHandler(this.kullaniciKaydetToolStripMenuItem1_Click);
            // 
            // kullanicilariGoruntuleToolStripMenuItem
            // 
            this.kullanicilariGoruntuleToolStripMenuItem.Name = "kullanicilariGoruntuleToolStripMenuItem";
            this.kullanicilariGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.kullanicilariGoruntuleToolStripMenuItem.Text = "Kullanici Islemleri";
            this.kullanicilariGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.kullanicilariGoruntuleToolStripMenuItem_Click);
            // 
            // makinaIslemleriToolStripMenuItem
            // 
            this.makinaIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makinaKaydetToolStripMenuItem,
            this.mToolStripMenuItem});
            this.makinaIslemleriToolStripMenuItem.Name = "makinaIslemleriToolStripMenuItem";
            this.makinaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.makinaIslemleriToolStripMenuItem.Text = "Makina Islemleri";
            this.makinaIslemleriToolStripMenuItem.Visible = false;
            // 
            // makinaKaydetToolStripMenuItem
            // 
            this.makinaKaydetToolStripMenuItem.Name = "makinaKaydetToolStripMenuItem";
            this.makinaKaydetToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.makinaKaydetToolStripMenuItem.Text = "Makina Kaydet";
            this.makinaKaydetToolStripMenuItem.Click += new System.EventHandler(this.makinaKaydetToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.mToolStripMenuItem.Text = "MakinaIslemleri";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelRaporuOlusturToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Visible = false;
            // 
            // excelRaporuOlusturToolStripMenuItem
            // 
            this.excelRaporuOlusturToolStripMenuItem.Name = "excelRaporuOlusturToolStripMenuItem";
            this.excelRaporuOlusturToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.excelRaporuOlusturToolStripMenuItem.Text = "Excel Raporu Olustur";
            this.excelRaporuOlusturToolStripMenuItem.Click += new System.EventHandler(this.excelRaporuOlusturToolStripMenuItem_Click);
            // 
            // AraPanel
            // 
            this.AraPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AraPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AraPanel.Controls.Add(this.tb_tarih);
            this.AraPanel.Controls.Add(this.lbl_vardiya);
            this.AraPanel.Controls.Add(this.lbl_SoyAd);
            this.AraPanel.Controls.Add(this.lbl_ad);
            this.AraPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AraPanel.Location = new System.Drawing.Point(0, 29);
            this.AraPanel.Name = "AraPanel";
            this.AraPanel.Size = new System.Drawing.Size(931, 55);
            this.AraPanel.TabIndex = 4;
            // 
            // tb_tarih
            // 
            this.tb_tarih.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_tarih.Location = new System.Drawing.Point(690, 23);
            this.tb_tarih.Name = "tb_tarih";
            this.tb_tarih.ReadOnly = true;
            this.tb_tarih.Size = new System.Drawing.Size(238, 27);
            this.tb_tarih.TabIndex = 4;
            // 
            // lbl_vardiya
            // 
            this.lbl_vardiya.AutoSize = true;
            this.lbl_vardiya.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_vardiya.Location = new System.Drawing.Point(853, 0);
            this.lbl_vardiya.Name = "lbl_vardiya";
            this.lbl_vardiya.Size = new System.Drawing.Size(78, 20);
            this.lbl_vardiya.TabIndex = 3;
            this.lbl_vardiya.Text = "Deneme";
            // 
            // lbl_SoyAd
            // 
            this.lbl_SoyAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SoyAd.AutoSize = true;
            this.lbl_SoyAd.Location = new System.Drawing.Point(12, 31);
            this.lbl_SoyAd.Name = "lbl_SoyAd";
            this.lbl_SoyAd.Size = new System.Drawing.Size(78, 20);
            this.lbl_SoyAd.TabIndex = 2;
            this.lbl_SoyAd.Text = "Deneme";
            // 
            // lbl_ad
            // 
            this.lbl_ad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(12, 2);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(78, 20);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Deneme";
            this.lbl_ad.TextChanged += new System.EventHandler(this.lbl_ad_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 602);
            this.Controls.Add(this.AraPanel);
            this.Controls.Add(this.AnaPanel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AraPanel.ResumeLayout(false);
            this.AraPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel AnaPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem etiketlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciKaydetToolStripMenuItem;
        public System.Windows.Forms.Panel AraPanel;
        public System.Windows.Forms.Label lbl_ad;
        public System.Windows.Forms.Label lbl_SoyAd;
        private System.Windows.Forms.ToolStripMenuItem kullaniciKaydetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kullanicilariGoruntuleToolStripMenuItem;
        private System.Windows.Forms.Label lbl_vardiya;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelRaporuOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makinaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makinaKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_tarih;
        private System.Windows.Forms.Timer timer1;
    }
}

