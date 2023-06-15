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
    public partial class KullaniciGiris : Form
    {
        VeriMetodlari v = new VeriMetodlari();
        AnaForm a = new AnaForm();
        Globals g = new Globals();
        FormMetodlari f = new FormMetodlari();
        Helpers h = new Helpers();
       

        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (v.KullaniciGiris(tb_user.Text, tb_password.Text)!= null)
            //{
            //    k = v.KullaniciGiris(tb_user.Text, tb_password.Text);
            //    f.KullanicGuncelle(k.Ad, k.Soyad);
            //}
            //else
            //{
            //    MessageBox.Show("olmadi");
            //}
            ;
            if (h.KullaniciGiris(tb_user.Text, tb_password.Text))
            {
                MessageBox.Show("Basarili");
                f.KullanicGuncelle(KullaniciBilgisi.Ad, KullaniciBilgisi.Soyad);               
            }
            else
            {
                MessageBox.Show("Basarisiz");
            }
        }
    }
}
