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
    public partial class KullaniciGoruntuleme : Form
    {
        VeriMetodlari v = new VeriMetodlari();
        Helpers h = new Helpers();
        Kullanicilar usr = new Kullanicilar();
        public KullaniciGoruntuleme()
        {
            InitializeComponent();
            

            if (/*v.KullaniciSirala() != null*/ h.KullaniciSirala()!= null)
            {
                //dataGridView1.DataSource = v.KullaniciSirala().Tables["Kullanici"];
                dataGridView1.DataSource = h.KullaniciSirala();

                
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tb_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                tb_KullaniciAdi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_Sifre.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_AD.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tb_Soyad.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                chb_Durum.Checked = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                chb_Yetki.Checked = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
               
                usr.KullaniciID = Int32.Parse(tb_ID.Text);
                usr.KullaniciAdi = tb_KullaniciAdi.Text;
                usr.Sifre = tb_Sifre.Text;
                usr.Ad = tb_AD.Text;
                usr.Soyad = tb_Soyad.Text;
                usr.Durum = chb_Durum.Checked;
                usr.Yetki = chb_Yetki.Checked;
                btn_duzenle.Enabled = true;
            }
            

            
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            Kullanicilar kul = new Kullanicilar();
            kul.KullaniciID = Int32.Parse(tb_ID.Text);
            kul.KullaniciAdi = tb_KullaniciAdi.Text;
            kul.Sifre = tb_Sifre.Text;
            kul.Ad = tb_AD.Text;
            kul.Soyad = tb_Soyad.Text;
            kul.Durum = chb_Durum.Checked;
            kul.Yetki = chb_Yetki.Checked;
            h.KullaniciDuzenle(usr, kul);
            btn_duzenle.Enabled = false;
            dataGridView1.DataSource = h.KullaniciSirala();

        }
    }
}
