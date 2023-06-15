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
    public partial class KoliGoruntuleme : Form
    {
        Helpers h = new Helpers();
        DateTime z = DateTime.Now;
        DateTime z1;
        DateTime z2;
        public KoliGoruntuleme()
        {
            InitializeComponent();
            z1 = z.AddDays(-30);
            z2 = z.AddDays(1);
            dataGridView1.DataSource = h.KoliSirala(z1, z2);
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            z1 = z.AddDays(-30);
            z2 = z.AddDays(1);
            h.ExcelRaporOlusturma(z1, z2);
        }
    }
}
