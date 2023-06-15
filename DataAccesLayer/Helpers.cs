using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Reflection;
using System.ComponentModel;
namespace DataAccesLayer
{
    public class Helpers
    {
        //Kullanicilar kul = new Kullanicilar();
        SqlConnection con; SqlCommand cmd;
        public Helpers()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
        }

        #region KullaniciMetodlari

        public bool KullaniciKaydet(Kullanicilar kul1)
        {
            Kullanicilar kul = new Kullanicilar();
            try
            {
                int yetki = kul1.Yetki ? 1 : 0;
                int durum = kul1.Yetki ? 1 : 0;
                cmd.CommandText = "INSERT INTO Kullanicilar(KullaniciAdi, Sifre, Isim, SoyAd, Durum, Yetki) VALUES(@Kullaniciadi, @Sifre, @AD, @Soyad, @Durum, @Yetki)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Kullaniciadi", kul1.KullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", kul1.Sifre);
                cmd.Parameters.AddWithValue("@AD", kul1.Ad);
                cmd.Parameters.AddWithValue("@Soyad", kul1.Soyad);
                cmd.Parameters.AddWithValue("@Durum", yetki );
                cmd.Parameters.AddWithValue("@Yetki", durum );

                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Kullanicilar> KullaniciSirala()
        {
            try
            {
                List<Kullanicilar> k = new List<Kullanicilar>();
                cmd.CommandText = "SELECT Kullanici_ID, KullaniciAdi, Sifre, Isim, SoyAd, Durum, Yetki FROM Kullanicilar";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kullanicilar kul = new Kullanicilar();
                    kul.KullaniciID = reader.GetInt32(0);
                    kul.KullaniciAdi = reader.GetString(1);
                    kul.Sifre = reader.GetString(2);
                    kul.Ad = reader.GetString(3);
                    kul.Soyad = reader.GetString(4);
                    kul.Durum = reader.GetBoolean(5);
                    kul.Yetki = reader.GetBoolean(6);
                    k.Add(kul);
                }


                return k;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool KullaniciGiris(string usr, string psw)
        {
            
            try
            {
                int i;
                cmd.CommandText = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi=@KAD AND Sifre=@SIF";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@KAD", usr);
                cmd.Parameters.AddWithValue("@SIF", psw);
                con.Open();
                i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i>0)
                {
                    cmd.CommandText = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@KAD AND Sifre=@SIF";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@KAD", usr);
                    cmd.Parameters.AddWithValue("@SIF", psw);                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        KullaniciBilgisi.KullaniciID = reader.GetInt32(0);
                        KullaniciBilgisi.KullaniciAdi = reader.GetString(1);
                        KullaniciBilgisi.Sifre = reader.GetString(2);
                        KullaniciBilgisi.Ad = reader.GetString(3);
                        KullaniciBilgisi.Soyad = reader.GetString(4);
                        KullaniciBilgisi.Durum = reader.GetBoolean(5);
                        KullaniciBilgisi.Yetki = reader.GetBoolean(6);
                    }
                    return true;
                }
                else
                {
                    return false;
                }


                

                
                
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool KullaniciDuzenle(Kullanicilar kul1, Kullanicilar kul2)
        {
            try
            {
                
                cmd.CommandText = "UPDATE Kullanicilar SET KullaniciAdi=@k2KA, Sifre=@k2Sif, Isim=@k2AD, SoyAd=@k2SA, Durum=@k2D, Yetki=@k2Y WHERE Kullanici_ID=@k1ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@k2KA", kul2.KullaniciAdi);
                cmd.Parameters.AddWithValue("@k2Sif", kul2.Sifre);
                cmd.Parameters.AddWithValue("@k2AD", kul2.Ad);
                cmd.Parameters.AddWithValue("@k2SA", kul2.Soyad);
                cmd.Parameters.AddWithValue("@k2D", kul2.Durum ? 1:0);
                cmd.Parameters.AddWithValue("@k2Y", kul2.Yetki ? 1:0);
                cmd.Parameters.AddWithValue("@k1ID", kul1.KullaniciID);
                con.Open();
                cmd.ExecuteNonQuery();
                
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }


        #endregion
        #region MakinaMetotlari
        public List<Makinalar> MakinaSirala()
        {
            try
            {
                List<Makinalar> m = new List<Makinalar>();
                cmd.CommandText = "SELECT * FROM Makinalar";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Makinalar mak = new Makinalar();
                    mak.MakID = reader.GetInt32(0);
                    mak.MakNo = reader.GetInt16(1);
                    mak.Tur = reader.GetString(2);
                    mak.MakinaAdi = reader.GetString(3);
                    mak.Durum = reader.GetBoolean(4);
                    m.Add(mak);
                }
                return m;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
       
        public bool MakinaKaydet(Makinalar m)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Makinalar(MakinaNo, Tur, Makina_Adi, Durum) VALUES(@makno, @tur, @makad, @durum)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@makno", m.MakNo);
                cmd.Parameters.AddWithValue("@tur", m.Tur);
                cmd.Parameters.AddWithValue("@makad", m.MakinaAdi);
                cmd.Parameters.AddWithValue("@durum", m.Durum);

                con.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool MakinaDuzenle(Makinalar m1, Makinalar m2)
        {
            try
            {
                cmd.CommandText = "UPDATE Makinalar SET MakinaNo=@m2makno, Tur=@m2tur, Makina_Adi=@m2makad, Durum=@m2D WHERE Makina_ID=@m1ID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@m2makno", m2.MakNo);
                cmd.Parameters.AddWithValue("@m2tur", m2.Tur);
                cmd.Parameters.AddWithValue("@m2makad", m2.MakinaAdi);
                cmd.Parameters.AddWithValue("@m2D", m2.Durum ? 1:0);
                cmd.Parameters.AddWithValue("@m1ID", m1.MakID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false ;
            }
            finally
            {
                con.Close();
            }
        }


        #endregion
        #region EtiketMetodlari

        public string KoliSayisiGetir(string makno, DateTime z, string vardiya)
        {
            try
            {
                DateTime z2 = z.AddHours(-14);
                string ks;
                cmd.CommandText = "SELECT COUNT(*) FROM Koliler WHERE MakinaNo=@makno AND (Tarih BETWEEN @t1 AND @t2) AND Vardiya=@v";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@makno", makno);
                cmd.Parameters.AddWithValue("@t2", z.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@t1", z2.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@v", vardiya);
                con.Open();
                ks = cmd.ExecuteScalar().ToString();

                return ks;
            }
            catch (Exception)
            {

                return "0";
            }
            finally
            {
                con.Close();
            }
        }

        public string GenelToplamGetir(DateTime z, string vardiya)
        {
            try
            {
                DateTime z2 = z.AddHours(-14);
                string ks;
                cmd.CommandText = "SELECT COUNT(*) FROM Koliler WHERE (Tarih > @t1 AND Tarih < @t2) AND Vardiya=@v";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@t2", z.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@t1", z2.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@v", vardiya);
                con.Open();
                ks = cmd.ExecuteScalar().ToString();

                return ks;
            }
            catch (Exception)
            {

                return "Hata";
            }
            finally
            {
                con.Close();
            }
        }



        public string VardiyaGetir()
        {
                string vardiya;
                int a;
                int b;
                DateTime zaman = DateTime.Now;
                DateTime gunduzbaslangic = new DateTime(zaman.Year, zaman.Month, zaman.Day, 8, 0, 0);
                DateTime GunduzBitis = new DateTime(zaman.Year, zaman.Month, zaman.Day, 20, 0, 0);
                a = DateTime.Compare(zaman, gunduzbaslangic);
                b = DateTime.Compare(zaman, GunduzBitis);
                if (a >= 0 && b < 0)
                {
                    vardiya = "1";
                }
                else
                {
                    vardiya = "0";
                }
                return vardiya;         
        }
        public string UTKUret(string VSRM, string makno, string KoliSayisi, string tarih, string durum, string vardiya)
        {
            // ABN-Makno-Vsrm-Sayi-tarih-vardiya-durum 
            string utk;

            if (VSRM==null)
            {
                VSRM = "0";
            }
            if (makno==null)
            {
                makno = "0";
            }
            if (KoliSayisi==null)
            {
                KoliSayisi = "0";
            }
            if (durum==null)
            {
                durum = "0";
            }

            utk = "ABN-" + VSRM + "-" + makno + "-" + KoliSayisi + "-" + tarih + "-" + vardiya + "-" + durum;
            return utk;

        }

        public bool KoliKaydet(Koliler ko)
        {
            DateTime z = DateTime.Now;
            try
            {
                cmd.CommandText = "INSERT INTO Koliler(UTK, Vsrm, MakinaNo, Vardiya, Tarih, Durum) VALUES(@utk, @vsrm, @makno, @vardiya, @tarih, @durum)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@utk", ko.UTK);
                cmd.Parameters.AddWithValue("@vsrm", ko.VsrmKod);
                cmd.Parameters.AddWithValue("@makno", ko.MakNo);
                cmd.Parameters.AddWithValue("@vardiya", ko.Vardiya);
                cmd.Parameters.AddWithValue("@tarih", z.ToString("yyyy-MM-dd HH:mm"));
                cmd.Parameters.AddWithValue("@durum", ko.Durum ? 1 : 0);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;                
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
            
        }

        public List<Koliler> KoliSirala(DateTime t1, DateTime t2)
        {
        //public string UTK { get; set; }
        //public int VsrmKod { get; set; }
        //public string VsrmAdSoyad { get; set; }
        //public int MakNo { get; set; }
        //public string Vardiya { get; set; }
        //public DateTime Tarih { get; set; }
        //public DateTime Saat { get; set; }
        //public bool Durum { get; set; }
            try
            {
                List<Koliler> kl = new List<Koliler>();
                cmd.CommandText = "SELECT Ko.UTK, Ko.Vsrm, Ku.Isim, Ku.SoyAd, Ko.MakinaNo, Ko.Vardiya, Ko.Tarih, Ko.Durum FROM Koliler AS Ko  JOIN Kullanicilar AS Ku ON Ko.Vsrm=Ku.Kullanici_ID JOIN Makinalar AS M ON M.Makina_ID=Ko.MakinaNo WHERE Tarih BETWEEN @t1 AND @t2 ORDER BY Ko.Tarih DESC";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@t1", t1.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@t2", t2.ToString("yyyy-MM-dd"));
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Koliler k = new Koliler();
                    k.UTK = reader.GetString(0);
                    k.VsrmKod =reader.GetInt32(1);
                    k.VsrmAdSoyad = reader.GetString(2) + " " + reader.GetString(3);
                    k.MakNo = reader.GetInt32(4);
                    if (reader.GetString(5)=="1")
                    {
                        k.Vardiya = "Gunduz";
                    }
                    else
                    {
                        k.Vardiya = "Gece";
                    }
                    DateTime zaman = reader.GetDateTime(6);
                    k.Tarih = zaman.ToString("dd.MM.yyyy");
                    k.Saat = zaman.ToString("HH:mm");
                    if (reader.GetBoolean(7))
                    {
                        k.Durum = true;
                    }
                    else
                    {
                        k.Durum = false;
                    }
                    kl.Add(k);
                }
                return kl;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }


        #endregion
        #region RaporMetotlari
        public bool ExcelRaporOlusturma(DateTime t1, DateTime t2)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            cmd.CommandText = "SELECT Ko.UTK, Ko.Vsrm, Ku.Isim, Ku.SoyAd, Ko.MakinaNo, Ko.Vardiya, Ko.Tarih, Ko.Durum FROM Koliler AS Ko  JOIN Kullanicilar AS Ku ON Ko.Vsrm=Ku.Kullanici_ID JOIN Makinalar AS M ON M.Makina_ID=Ko.MakinaNo WHERE Tarih BETWEEN @t1 AND @t2 ORDER BY Ko.Tarih DESC";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@t1", t1.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@t2", t2.ToString("yyyy-MM-dd"));
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            try
            {
                excel.Application app = new excel.Application();
                app.Visible = true;
                Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
                Worksheet sayfa = (Worksheet)kitap.Worksheets[1];
                

                for (int i = 1; i < dt.Columns.Count + 1; i++)
                {
                    sayfa.Cells[1, i] = dt.Columns[i - 1].ColumnName;
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        sayfa.Cells[i + 2, j + 1] = dt.Rows[i].ItemArray[j].ToString();
                    }
                }
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion

        #region PrinterMetodlari
        #endregion
    }
}
