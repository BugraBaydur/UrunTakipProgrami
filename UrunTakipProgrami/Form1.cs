using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccesLayer;
namespace UrunTakipProgrami
{
    public partial class AnaForm : Form
    {
        FormMetodlari f = new FormMetodlari();
        VeriMetodlari v = new VeriMetodlari();
        
        public AnaForm()
        {
            InitializeComponent();
            //v.KlasorOlustur();
            lbl_vardiya.Text = f.VardiyaBul();            
            dosyalarToolStripMenuItem.Visible = false;

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Globals.form = this;
            
        }

        private void etiketlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGiris kgf = new KullaniciGiris();


            f.FormGetir(kgf);

        }



        private void kullanicilariGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGoruntuleme kg = new KullaniciGoruntuleme();
            f.FormGetir(kg);
        }

        private void kullaniciKaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KullaniciOlustur ko = new KullaniciOlustur();
            f.FormGetir(ko);
        }

        private void dosyalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EtiketYazdirma ey = new EtiketYazdirma();
            f.FormGetir(ey);
        }

        private void excelRaporuOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KoliGoruntuleme kog = new KoliGoruntuleme();
            f.FormGetir(kog);
        }

        private void makinaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakinaKayit mk = new MakinaKayit();
            f.FormGetir(mk);
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakinaGoruntuleme mg = new MakinaGoruntuleme();
            f.FormGetir(mg);
        }

        private void lbl_ad_TextChanged(object sender, EventArgs e)
        {
            if (KullaniciBilgisi.Yetki)
            {
                dosyalarToolStripMenuItem.Visible = true;
                kullaniciKaydetToolStripMenuItem.Visible = true;
                makinaIslemleriToolStripMenuItem.Visible = true;
                raporlarToolStripMenuItem.Visible = true;
            }
            else
            {
                dosyalarToolStripMenuItem.Visible = true;
                kullaniciKaydetToolStripMenuItem.Visible = false;
                makinaIslemleriToolStripMenuItem.Visible = false;
                raporlarToolStripMenuItem.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.tb_tarih.Text = dt.ToString("yyyy-MM-dd HH:mm");
            lbl_vardiya.Text = f.VardiyaBul();
        }
    }
}
