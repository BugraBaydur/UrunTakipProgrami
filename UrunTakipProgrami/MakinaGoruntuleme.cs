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
    public partial class MakinaGoruntuleme : Form
    {
        Helpers h = new Helpers();
        Makinalar mkn = new Makinalar();
        public MakinaGoruntuleme()
        {
            InitializeComponent();
            dataGridView1.DataSource = h.MakinaSirala();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Makinalar mak = new Makinalar();
            mak.MakNo = Int32.Parse(tb_makno.Text);
            mak.MakinaAdi = tb_makad.Text;            
            mak.Tur = tb_maktur.Text;
            mak.Durum = chb_Durum.Checked;

            if(h.MakinaDuzenle(mkn, mak))
            {
                MessageBox.Show("Basarili");
            }
            else
            {
                MessageBox.Show("Basarisiz");
            }

            dataGridView1.DataSource = h.MakinaSirala();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                tb_makid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() ;
                tb_makno.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_maktur.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_makad.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                chb_Durum.Checked = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());

                mkn.MakID = Int32.Parse(tb_makid.Text);
                mkn.MakinaAdi = tb_makad.Text;
                mkn.MakNo = Int32.Parse(tb_makno.Text);
                mkn.Tur = tb_maktur.Text;
                mkn.Durum = chb_Durum.Checked;
            }
        }
    }
}
