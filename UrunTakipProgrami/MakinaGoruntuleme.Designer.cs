namespace UrunTakipProgrami
{
    partial class MakinaGoruntuleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.chb_Durum = new System.Windows.Forms.CheckBox();
            this.tb_makid = new System.Windows.Forms.TextBox();
            this.tb_makad = new System.Windows.Forms.TextBox();
            this.tb_makno = new System.Windows.Forms.TextBox();
            this.tb_maktur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 618);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Makina ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(945, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Makina Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Makina No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(945, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Makina Tur";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(949, 214);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(96, 35);
            this.btn_Kaydet.TabIndex = 6;
            this.btn_Kaydet.Text = "Duzenle";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // chb_Durum
            // 
            this.chb_Durum.AutoSize = true;
            this.chb_Durum.Location = new System.Drawing.Point(713, 214);
            this.chb_Durum.Name = "chb_Durum";
            this.chb_Durum.Size = new System.Drawing.Size(89, 27);
            this.chb_Durum.TabIndex = 7;
            this.chb_Durum.Text = "Durum";
            this.chb_Durum.UseVisualStyleBackColor = true;
            // 
            // tb_makid
            // 
            this.tb_makid.Location = new System.Drawing.Point(713, 54);
            this.tb_makid.Name = "tb_makid";
            this.tb_makid.Size = new System.Drawing.Size(150, 30);
            this.tb_makid.TabIndex = 8;
            // 
            // tb_makad
            // 
            this.tb_makad.Location = new System.Drawing.Point(949, 54);
            this.tb_makad.Name = "tb_makad";
            this.tb_makad.Size = new System.Drawing.Size(150, 30);
            this.tb_makad.TabIndex = 9;
            // 
            // tb_makno
            // 
            this.tb_makno.Location = new System.Drawing.Point(713, 142);
            this.tb_makno.Name = "tb_makno";
            this.tb_makno.Size = new System.Drawing.Size(150, 30);
            this.tb_makno.TabIndex = 10;
            // 
            // tb_maktur
            // 
            this.tb_maktur.Location = new System.Drawing.Point(949, 142);
            this.tb_maktur.Name = "tb_maktur";
            this.tb_maktur.Size = new System.Drawing.Size(150, 30);
            this.tb_maktur.TabIndex = 11;
            // 
            // MakinaGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.tb_maktur);
            this.Controls.Add(this.tb_makno);
            this.Controls.Add(this.tb_makad);
            this.Controls.Add(this.tb_makid);
            this.Controls.Add(this.chb_Durum);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MakinaGoruntuleme";
            this.Text = "MakinaGoruntuleme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.CheckBox chb_Durum;
        private System.Windows.Forms.TextBox tb_makid;
        private System.Windows.Forms.TextBox tb_makad;
        private System.Windows.Forms.TextBox tb_makno;
        private System.Windows.Forms.TextBox tb_maktur;
    }
}