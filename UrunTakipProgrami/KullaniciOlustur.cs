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
    public partial class KullaniciOlustur : Form
    {
        VeriMetodlari v = new VeriMetodlari();
        Helpers h = new Helpers();
        public KullaniciOlustur()
        {
            InitializeComponent();
            //tb_VSRM.Text= v.VsrmBul().ToString();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAdi = tb_kullaniciadi.Text;
            k.Sifre = tb_sifre.Text;
            k.Ad = tb_ad.Text;
            k.Soyad = tb_soyad.Text;
            k.Yetki = cb_Yetki.Checked;
            k.Durum = cb_Durum.Checked;
            if (/*v.KullaniciOlustur(tb_kullaniciadi.Text, tb_sifre.Text, tb_ad.Text, tb_soyad.Text, tb_VSRM.Text, cb_Yetki.Text)*/ h.KullaniciKaydet(k))
            {
                
                MessageBox.Show("Basarili");
            }
            else
            {
                MessageBox.Show("Basarisiz");
            }
        }
    }
}
