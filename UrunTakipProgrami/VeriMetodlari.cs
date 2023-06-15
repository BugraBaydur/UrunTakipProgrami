using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using DataAccesLayer;

namespace UrunTakipProgrami
{
    public class VeriMetodlari
    {
        XDocument belge = new XDocument();
        Kullanicilar k = new Kullanicilar();

        //#region KullaniciMetodlari


        //    public void KlasorOlustur()
        //    {
        //        string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "Kullanicilar";
        //        if (Directory.Exists(KlasorYolu) == false)
        //        {
        //            Directory.CreateDirectory(KlasorYolu);
        //        }
        //    }

        //    public bool KullaniciOlustur(string KullaniciAdi, string Sifre, string Ad, string Soyad, string Vsrm, string Yetki)
        //    {
        //        try
        //        {
        //            string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "Kullanicilar";
        //            string DosyaYolu = KlasorYolu + "\\Kullanicilar.xml";
        //            XmlDocument belge2 = new XmlDocument();

        //            KlasorOlustur();
        //            if (File.Exists(DosyaYolu) == false)
        //            {
        //                FileStream fs = new FileStream(DosyaYolu, FileMode.OpenOrCreate);
        //                string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
        //                + Environment.NewLine + "<Kullanicilar> "
        //                + Environment.NewLine + "</Kullanicilar>";
        //                fs.Flush();
        //                fs.Close();
        //                File.AppendAllText(DosyaYolu, YazilacakIcerik);
        //                belge = XDocument.Load(DosyaYolu);

        //            }

        //            belge = XDocument.Load(DosyaYolu);

        //            if (belge.Descendants("KullaniciAdi").Where(a => a.Value == KullaniciAdi).Any())
        //            {
        //                return false;
        //            }
        //            XElement root = belge.Root;
        //            XElement Kullanici = new XElement("Kullanici");

        //            XElement KAd = new XElement("KullaniciAdi", KullaniciAdi);
        //            XElement sifre = new XElement("Sifre", Sifre);
        //            XElement ad = new XElement("Ad", Ad);
        //            XElement SAd = new XElement("SoyAd", Soyad);
        //            XElement vsrm = new XElement("SorumluKodu", Vsrm);

        //            XElement yetki = new XElement("Yetki", Yetki);

        //            Kullanici.Add(KAd, sifre, ad, SAd, vsrm, yetki);
        //            root.Add(Kullanici);
        //            belge.Save(DosyaYolu);
        //            return true;


        //        }


        //        catch (Exception)
        //        {

        //            return false;
        //        }
        //    }

        //    public DataSet KullaniciSirala()
        //    {
        //        try
        //        {
        //            string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "Kullanicilar";
        //            string DosyaYolu = KlasorYolu + "\\Kullanicilar.xml";

        //            belge = XDocument.Load(DosyaYolu);
        //            DataSet ds = new DataSet();
        //            ds.ReadXml(DosyaYolu);

        //            return ds;
        //        }
        //        catch (Exception)
        //        {
        //            return null;
        //        }

        //    }
        //    public int VsrmBul()
        //    {
        //        try
        //        {
        //            string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "Kullanicilar";
        //            string DosyaYolu = KlasorYolu + "\\Kullanicilar.xml";
        //            belge = XDocument.Load(DosyaYolu);
        //            List<XElement> l = new List<XElement>();
        //            List<int> il = new List<int>();
        //            l = belge.Descendants("SorumluKodu").ToList();
        //            foreach (var item in l)
        //            {
        //                il.Add(Int32.Parse(item.Value));
        //            }

        //            for (int j = 1; j <= il.Max(); j++)
        //            {
        //                if (!il.Contains(j))
        //                {
        //                    return j;
        //                }
        //            }
        //            return il.Max() + 1;

        //        }
        //        catch (Exception)
        //        {

        //            return 1;
        //        }


        //    }

        //    public Kullanicilar KullaniciGiris(string KullaniciAdi, string Sifre)
        //    {
        //        try
        //        {
        //            if (KullaniciAdi == "bugrabaydur@hotmail.com")
        //            {
        //                if (Sifre == "Baydur97")
        //                {
        //                    k.Ad = "Bugra";
        //                    k.Soyad = "Baydur";
        //                    k.Vsrm = "0";
        //                    k.Yetki = true;
        //                    return k;
        //                }

        //            }

        //            XmlDocument belge2 = new XmlDocument();
        //            string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "Kullanicilar";
        //            string DosyaYolu = KlasorYolu + "\\Kullanicilar.xml";

        //            belge2.Load(DosyaYolu);
        //            XmlNodeList kullaniciadi = belge2.GetElementsByTagName("KullaniciAdi");
        //            List<string> userlist = new List<string>();
        //            foreach (var item in kullaniciadi)
        //            {
        //                userlist.Add(item.ToString());
        //            }

        //            XmlDocument belge3 = new XmlDocument();
        //            belge3.LoadXml(DosyaYolu);
        //            XmlNodeList sifre = belge2.GetElementsByTagName("Sifre");

        //            List<string> sifrelist = new List<string>();
        //            foreach (var item in sifre)
        //            {
        //                sifrelist.Add(item.ToString());
        //            }




        //            if (userlist.Contains(KullaniciAdi))
        //            {
        //                if (sifrelist.Contains(Sifre))
        //                {
        //                    IDataReader d = KullaniciSirala().CreateDataReader();
        //                    k.KullaniciAdi = KullaniciAdi;
        //                    k.Ad = d.GetString(3);
        //                    k.Soyad = d.GetString(4);
        //                    k.Vsrm = d.GetString(5);
        //                    if (d.GetString(6) == "Yetkili")
        //                    {
        //                        k.Yetki = true;
        //                    }
        //                    else
        //                    {
        //                        k.Yetki = false;
        //                    }

        //                    return k;
        //                }
        //                else
        //                {
        //                    return null;
        //                }
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //        catch (Exception)
        //        {

        //            return null;
        //        }

        //    }
        //    public bool KullaniciSil(string KullaniciAdi)
        //    {
        //        try
        //        {
        //            string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "Kullanicilar";
        //            string DosyaYolu = KlasorYolu + "\\Kullanicilar.xml";
        //            belge = XDocument.Load(DosyaYolu);
        //            //var nodes = belge.Descendants("Kullanici");
        //            //nodes.Where(a => a.Element("KullaniciAdi").Value == KullaniciAdi).Remove();
        //            belge.Descendants("Kullanicilar").Elements("Kullanici").Where(a => a.Element("KullaniciAdi").Value == KullaniciAdi).Remove();
        //            belge.Save(DosyaYolu);


        //            return true;
        //        }
        //        catch (Exception)
        //        {

        //            return false; ;
        //        }
        //    }
        //    #endregion

        //    #region EtiketMetodlari
        //    public string isimleyici()
        //    {
        //        string isim;
        //        string zaman = DateTime.Now.ToString("MMMM yyyy");
        //        isim = zaman + " Raporlari";

        //        return isim;
        //    }

        //    public void KoliXMLOlustur()
        //    {
        //        string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.Name + "Raporlar";
        //        string DosyaYolu = KlasorYolu + "\\" + $"{isimleyici()}.xml";

        //        if (Directory.Exists(KlasorYolu) == false)
        //        {
        //            Directory.CreateDirectory(KlasorYolu);
        //        }
        //        if (File.Exists(DosyaYolu) == false)
        //        {
        //            FileStream fs = new FileStream(DosyaYolu, FileMode.OpenOrCreate);
        //            string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
        //            + Environment.NewLine + "<Koliler> "
        //            + Environment.NewLine + "</Koliler>";
        //            fs.Flush();
        //            fs.Close();
        //            File.AppendAllText(DosyaYolu, YazilacakIcerik);
        //            belge = XDocument.Load(DosyaYolu);


        //        }

        //    }

        //    public bool KoliKaydet(Koliler k)
        //    {
        //        string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.Name + "Raporlar";
        //        string DosyaYolu = KlasorYolu + "\\" + $"{isimleyici()}.xml";
        //        DateTime zaman = DateTime.Now;

        //        try
        //        {
        //            if (!File.Exists(DosyaYolu))
        //            {
        //                KoliXMLOlustur();
        //            }
        //            belge = XDocument.Load(DosyaYolu);
        //            XElement root = belge.Root;
        //            if (belge.Descendants("Gun").Where(p => p.Attribute("id").Value == zaman.Day.ToString()).Any())
        //            {                    
        //                XElement Gun = belge.Descendants("Gun").Where(p=>p.Attribute("id").Value==zaman.Day.ToString()).First();
        //                XElement Koli = new XElement("Koli");
        //                XElement MakNo = new XElement("MakinaNo", k.MakNo);
        //                XElement Vardiya = new XElement("Vardiya", k.Vardiya);
        //                XElement VardiyaSorumlusu = new XElement("VSRM", k.Vsrm);
        //                XElement Durum = new XElement("Durum", k.Durum);
        //                XElement OZ = new XElement("OZ", k.oz);
        //                XElement Saat = new XElement("Saat", zaman.ToString("HH:mm"));
        //                XElement Dtop = belge.Descendants("Gun").Where(p => p.Attribute("id").Value == zaman.Day.ToString()).Elements("DuzgunToplam").First();
        //                XElement Htop = belge.Descendants("Gun").Where(p => p.Attribute("id").Value == zaman.Day.ToString()).Elements("HataliToplam").First();
        //                if (k.Durum == "Duzgun")
        //                {

        //                    Dtop.Value = (Int32.Parse(Dtop.Value) + 1).ToString();
        //                }
        //                else
        //                {

        //                    Htop.Value = (Int32.Parse(Htop.Value) + 1).ToString();
        //                }
        //                Koli.Add(MakNo, Vardiya, VardiyaSorumlusu, Durum, OZ, Saat);
        //                Gun.Add(Koli);
        //                belge.Save(DosyaYolu);
        //                return true;
        //            }
        //            else
        //            {
        //                XElement Gun = new XElement("Gun");
        //                XAttribute id = new XAttribute("id", zaman.Day.ToString());
        //                XElement DuzgunToplam = new XElement("DuzgunToplam", 0);
        //                XElement HataliToplam = new XElement("HataliToplam", 0);
        //                Gun.Add(DuzgunToplam, HataliToplam);
        //                root.Add(Gun);
        //                //XElement gun = belge.Elements("Gun").Where(p => p.Attribute("id").Value == zaman.Day.ToString()).Single();
        //                XElement Koli = new XElement("Koli");
        //                XElement MakNo = new XElement("MakinaNo", k.MakNo);
        //                XElement Vardiya = new XElement("Vardiya", k.Vardiya);
        //                XElement VardiyaSorumlusu = new XElement("VSRM", k.Vsrm);
        //                XElement Durum = new XElement("Durum", k.Durum);
        //                XElement OZ = new XElement("OZ", k.oz);
        //                XElement Saat = new XElement("Saat", zaman.ToString("HH:mm"));
        //                XElement Dtop = new XElement("DuzgunToplam", 0);
        //                XElement Htop = new XElement("HataliToplam", 0);                    

        //                Koli.Add(OZ, MakNo, Vardiya, VardiyaSorumlusu, Durum, Saat);
        //                Gun.Add(id, Koli, Dtop, Htop);

        //                belge.Save(DosyaYolu);

        //                return true;
        //            }

        //        }

        //        catch (Exception e)
        //        {
        //            return false;
        //        }
        //    }

        //    public int ToplamKoliSayisiGetir(DateTime zaman)
        //    {
        //        string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.Name + "Raporlar";
        //        string DosyaYolu = KlasorYolu + "\\" + $"{isimleyici()}.xml";
        //        belge = XDocument.Load(DosyaYolu);
        //        int sayi;

        //        if (belge.Descendants("Gun").Where(p=> p.Attribute("id").Value==zaman.Day.ToString()).Any())
        //        {
        //            sayi = Int32.Parse(belge.Descendants("Gun").Where(p=>p.Attribute("id").Value== zaman.Day.ToString()).Elements("DuzgunToplam").First().Value);
        //            return sayi;
        //        }
        //        else
        //        {
        //            return 0;
        //        }


        //    }

        //    public int KoliSayisiGetir(string makno, DateTime zaman)
        //    {
        //        string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.Name + "Raporlar";
        //        string DosyaYolu = KlasorYolu + "\\" + $"{isimleyici()}.xml";
        //        belge = XDocument.Load(DosyaYolu);
        //        int sayi =50;

        //        if (belge.Descendants("Gun").Where(p => p.Attribute("id").Value == zaman.Day.ToString()).Any())
        //        {
        //            // burdaki sayiyi alamiyor


        //            sayi = belge.Descendants("Gun").Where(p => p.Attribute("id").Value == zaman.Day.ToString()).Elements("Koli").Where(q => q.Element("MakinaNo").Value == makno).Count();
        //            //sayi = belge.Descendants("Gun").Where(p => p.Attribute("id").Value == zaman.Day.ToString()).Elements("MakinaNo").Where(p => p.Element("MakinaNo").Value == makno);
        //            return sayi;
        //        }
        //        else
        //        {
        //            return 0;
        //        }


        //    }

        //    public string UTKOlustur(Koliler k, int sayi, string vardiya)
        //    {
        //        string strsayi = (sayi+1).ToString();
        //        if(vardiya=="Gunduz")
        //        {
        //            vardiya = "1";
        //        }
        //        else
        //        {
        //            vardiya = "2";
        //        }

        //        while (strsayi.Length<3)
        //        {
        //            strsayi = "0" + strsayi;
        //        }

        //        // ABN-Makno-Vsrm-Sayi-tarih-vardiya-durum 
        //        DateTime zaman = DateTime.Now;
        //        string utk = "ABN" + "-" + k.MakNo + "-" + k.Vsrm + "-" + strsayi + "-" + zaman.Day.ToString() + zaman.Month.ToString() + zaman.Year.ToString() + "-" + vardiya;

        //        return utk;
        //    }

        //    public string UTKDurumOlustur(Koliler k)
        //    {
        //        string durum = k.Durum;
        //        if (durum == "Duzgun")
        //        {
        //            durum = "1";
        //        }
        //        else
        //        {
        //            durum = "0";
        //        }
        //        return durum;
        //    }
        //    #endregion

        //    #region Excelmetodlari
        //    public bool ExcelRaporOlustur()
        //    {
        //        try
        //        {
        //            string KlasorYolu = Directory.GetParent(Environment.CurrentDirectory).Parent.Name + "Raporlar";
        //            string DosyaYolu = KlasorYolu + "\\" + $"{isimleyici()}.xml";
        //            DataSet ds = new DataSet();

        //            OpenFileDialog o = new OpenFileDialog();
        //            o.InitialDirectory = Directory.GetCurrentDirectory()+ "\\" + KlasorYolu;
        //            o.RestoreDirectory = true;
        //            o.Filter= "XML Files (*.xml)|*.xml";
        //            o.FilterIndex = 1;

        //            if (o.ShowDialog() == DialogResult.OK)
        //            {
        //                ds.ReadXml(o.FileName);

        //            }
        //            System.Data.DataTable dt = new System.Data.DataTable();
        //            dt.Load(ds.CreateDataReader(ds.Tables["Gun"]));


        //            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        //            Workbook kitap;
        //            Worksheet sayfa;
        //            xlApp.Visible = false;
        //            xlApp.DisplayAlerts = false;

        //            var misvalue = System.Reflection.Missing.Value;
        //            kitap = xlApp.Workbooks.Add(misvalue);
        //            sayfa = (Worksheet)kitap.Worksheets.get_Item(1);



        //            for (int i = 1; i < dt.Columns.Count + 1; i++)
        //            {
        //                sayfa.Cells[1, i] = dt.Columns[i - 1].ColumnName;
        //            }
        //            for (int i = 0; i < dt.Rows.Count; i++)
        //            {
        //                for (int j = 0; j < dt.Columns.Count; j++)
        //                {
        //                    sayfa.Cells[i + 2, j + 1] = dt.Rows[i].ItemArray[j].ToString();
        //                }
        //            }

        //            SaveFileDialog s = new SaveFileDialog();
        //            s.FileName = isimleyici();
        //            s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //            if (s.ShowDialog() == DialogResult.OK)
        //            {
        //                kitap.SaveAs(s.FileName, XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, XlSaveAsAccessMode.xlShared, misvalue, misvalue, misvalue, misvalue, misvalue);
        //            }

        //            kitap.Close();
        //            xlApp.Quit();
        //            return true;
        //        }
        //        catch (Exception)
        //        {

        //            return false;
        //        }
        //    }
        //    #endregion
        //}
    } }