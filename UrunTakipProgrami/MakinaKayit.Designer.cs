namespace UrunTakipProgrami
{
    partial class MakinaKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Tur = new System.Windows.Forms.Label();
            this.chb_Durum = new System.Windows.Forms.CheckBox();
            this.tb_makno = new System.Windows.Forms.TextBox();
            this.tb_makad = new System.Windows.Forms.TextBox();
            this.tb_tur = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Kaydet);
            this.groupBox1.Controls.Add(this.tb_tur);
            this.groupBox1.Controls.Add(this.tb_makad);
            this.groupBox1.Controls.Add(this.tb_makno);
            this.groupBox1.Controls.Add(this.chb_Durum);
            this.groupBox1.Controls.Add(this.lbl_Tur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(375, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Makina Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Makina No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Makina Adi";
            // 
            // lbl_Tur
            // 
            this.lbl_Tur.AutoSize = true;
            this.lbl_Tur.Location = new System.Drawing.Point(57, 183);
            this.lbl_Tur.Name = "lbl_Tur";
            this.lbl_Tur.Size = new System.Drawing.Size(39, 23);
            this.lbl_Tur.TabIndex = 2;
            this.lbl_Tur.Text = "Tur";
            // 
            // chb_Durum
            // 
            this.chb_Durum.AutoSize = true;
            this.chb_Durum.Location = new System.Drawing.Point(268, 224);
            this.chb_Durum.Name = "chb_Durum";
            this.chb_Durum.Size = new System.Drawing.Size(89, 27);
            this.chb_Durum.TabIndex = 3;
            this.chb_Durum.Text = "Durum";
            this.chb_Durum.UseVisualStyleBackColor = true;
            // 
            // tb_makno
            // 
            this.tb_makno.Location = new System.Drawing.Point(61, 135);
            this.tb_makno.Name = "tb_makno";
            this.tb_makno.Size = new System.Drawing.Size(130, 30);
            this.tb_makno.TabIndex = 4;
            // 
            // tb_makad
            // 
            this.tb_makad.Location = new System.Drawing.Point(268, 135);
            this.tb_makad.Name = "tb_makad";
            this.tb_makad.Size = new System.Drawing.Size(130, 30);
            this.tb_makad.TabIndex = 5;
            // 
            // tb_tur
            // 
            this.tb_tur.Location = new System.Drawing.Point(61, 224);
            this.tb_tur.Name = "tb_tur";
            this.tb_tur.Size = new System.Drawing.Size(130, 30);
            this.tb_tur.TabIndex = 6;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(142, 309);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(164, 59);
            this.btn_Kaydet.TabIndex = 7;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // MakinaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MakinaKayit";
            this.Text = "MakinaKayit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.TextBox tb_tur;
        private System.Windows.Forms.TextBox tb_makad;
        private System.Windows.Forms.TextBox tb_makno;
        private System.Windows.Forms.CheckBox chb_Durum;
        private System.Windows.Forms.Label lbl_Tur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}