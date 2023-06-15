namespace UrunTakipProgrami
{
    partial class KullaniciGiris
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
            this.lbl_User = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_User.Location = new System.Drawing.Point(446, 207);
            this.lbl_User.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(129, 25);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "Kullanici adi";
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.Color.White;
            this.tb_user.Location = new System.Drawing.Point(451, 235);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(215, 30);
            this.tb_user.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(451, 309);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(215, 30);
            this.tb_password.TabIndex = 4;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_sifre.Location = new System.Drawing.Point(446, 281);
            this.lbl_sifre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(57, 25);
            this.lbl_sifre.TabIndex = 3;
            this.lbl_sifre.Text = "Sifre";
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_giris.Image = global::UrunTakipProgrami.Properties.Resources.icons8_enter_24;
            this.btn_giris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_giris.Location = new System.Drawing.Point(476, 365);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(139, 39);
            this.btn_giris.TabIndex = 6;
            this.btn_giris.Text = "Giris Yap";
            this.btn_giris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UrunTakipProgrami.Properties.Resources.icons8_password_1_24;
            this.pictureBox2.Location = new System.Drawing.Point(416, 309);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UrunTakipProgrami.Properties.Resources.icons8_user_30;
            this.pictureBox1.Location = new System.Drawing.Point(416, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 702);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lbl_User);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KullaniciGiris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_giris;
    }
}