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
    public partial class EtiketYazdirma : Form
    {
        Koliler k = new Koliler();
        VeriMetodlari v = new VeriMetodlari();        
        DateTime z = DateTime.Now;
        Helpers h = new Helpers();
        string vsrm = KullaniciBilgisi.KullaniciID.ToString();
        string makno;
        string kolisayisi;
        string durum;
        string vardiya;
        string geneltoplam;
        
        


        public EtiketYazdirma()
        {
            InitializeComponent();
            //v.KoliXMLOlustur();
            //k.Vsrm = "1";
            foreach (var item in h.MakinaSirala())
            {
                cb_MakinaNo.Items.Add(item);
            }
            cb_MakinaNo.DisplayMember = "MakNo";
            cb_MakinaNo.ValueMember = "MakNo";
            

        }

        private void btn_Duzgun_Click(object sender, EventArgs e)
        {            
            tb_KoliDurumu.Text = "Duzgun";
            durum = "1";
            tb_UTK.Text= h.UTKUret(vsrm, makno, kolisayisi, z.ToString("ddMMyyyy"), durum , h.VardiyaGetir());
            
        }

        private void btn_Hatali_Click(object sender, EventArgs e)
        {
            tb_KoliDurumu.Text = "Hatali";
            durum = "0";
            tb_UTK.Text = h.UTKUret(vsrm, makno, kolisayisi, z.ToString("ddMMyyyy"), durum, h.VardiyaGetir());
        }

        private void btn_Yazdir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_MakNo.Text) && !String.IsNullOrEmpty(tb_KoliDurumu.Text))
            {
                Koliler kl = new Koliler();
                kl.UTK = tb_UTK.Text;
                kl.Vardiya = h.VardiyaGetir();
                kl.Tarih = z.ToString("dd.MM.yyyy");
                kl.Saat = z.ToString("HH:mm");
                kl.VsrmKod = KullaniciBilgisi.KullaniciID;
                if (durum=="1")
                {
                    kl.Durum = true;
                }
                else
                {
                    kl.Durum = false;
                }
                kl.MakNo = Int32.Parse(tb_MakNo.Text);                

                if (h.KoliKaydet(kl))
                {
                    MessageBox.Show("Basarili");
                    tb_GenelToplam.Text = h.GenelToplamGetir(z, vardiya);
                    kolisayisi = h.KoliSayisiGetir(makno, z, h.VardiyaGetir());
                    tb_KoliSayisi.Text = kolisayisi;
                    tb_UTK.Text = h.UTKUret(vsrm, makno, kolisayisi, z.ToString("ddMMyyyy"), durum, h.VardiyaGetir());
                }
                else
                {
                    MessageBox.Show("Basarisiz");
                }
            }
            else
            {
                MessageBox.Show("Koli ozellikleri bos birakilamaz");
            }
            #region Printer

            try
            {
                string uruntakipkod = tb_UTK.Text;
                string marka = "ABNCUP";
                var sb = new StringBuilder();
                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new System.Drawing.Printing.PrinterSettings();

            }
            catch (Exception ex)
            {

                MessageBox.Show("hata = " + ex.Message );
            }


            #endregion
        }

        private void tb_MakNo_TextChanged(object sender, EventArgs e)
        {
            makno = tb_MakNo.Text;
            kolisayisi = h.KoliSayisiGetir(makno, z, h.VardiyaGetir());
            tb_KoliSayisi.Text = kolisayisi;
            tb_UTK.Text = h.UTKUret(vsrm, makno, kolisayisi, z.ToString("ddMMyyyy"), durum, h.VardiyaGetir());
            tb_GenelToplam.Text = h.GenelToplamGetir(z, h.VardiyaGetir());

        }

        private void cb_MakinaNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Makinalar m = new Makinalar();
            m = (Makinalar)(cb_MakinaNo.SelectedItem);
            tb_MakNo.Text = m.MakNo.ToString();
        }
    }
}
