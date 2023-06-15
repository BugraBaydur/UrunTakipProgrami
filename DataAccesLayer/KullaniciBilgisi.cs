using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public static class KullaniciBilgisi
    {
        public static int KullaniciID { get; set; }
        public static string KullaniciAdi { get; set; }
        public static string Sifre { get; set; }
        public static string Ad { get; set; }
        public static string Soyad { get; set; }
        public static bool Yetki { get; set; }
        public static bool Durum { get; set; }
    }
}
