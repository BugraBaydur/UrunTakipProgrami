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
    public partial class MakinaKayit : Form
    {
        Helpers h = new Helpers();
        public MakinaKayit()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Makinalar mak = new Makinalar();
            mak.MakinaAdi = tb_makad.Text;
            mak.MakNo = Int32.Parse(tb_makno.Text);
            mak.Tur = tb_tur.Text;
            mak.Durum = chb_Durum.Checked;

            if (h.MakinaKaydet(mak))
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
