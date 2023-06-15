using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccesLayer;
namespace UrunTakipProgrami
{
    public  class FormMetodlari
    {
        Kullanicilar k = new Kullanicilar();
        public  void FormGetir(Form frm)
        {
            AnaForm form1 = new AnaForm();
            Globals.form.AnaPanel.Controls.Clear();
            frm.MdiParent = form1;
            frm.FormBorderStyle = FormBorderStyle.None;
            Globals.form.AnaPanel.Controls.Add(frm);
            frm.Show();


        }
        public void KullanicGuncelle(string ad, string soyad)
        {
            Globals.form.lbl_ad.Text = ad;
            Globals.form.lbl_SoyAd.Text = soyad;
        }


        public string VardiyaBul()
        {
            string vardiya;
            int a;
            int b;
            DateTime zaman = DateTime.Now;
            DateTime gunduzbaslangic = new DateTime(zaman.Year, zaman.Month, zaman.Day, 8, 0, 0);
            DateTime GunduzBitis = new DateTime(zaman.Year, zaman.Month, zaman.Day, 20, 0, 0);
            a = DateTime.Compare(zaman, gunduzbaslangic);
            b = DateTime.Compare(zaman, GunduzBitis);
            if (a>=0 && b<0)
            {
                vardiya = "Gunduz infazcilari";
            }
            else
            {
                vardiya = "Gecenin Yargiclari";
            }
            return vardiya;
        }

    }
}
