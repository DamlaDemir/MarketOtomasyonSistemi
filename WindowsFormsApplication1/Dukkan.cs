using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     public static class Dukkan
    {
        public static List<KasaGorevlisi> gorevliler = new List<KasaGorevlisi>();
        public static List<Musteri> musteriler = new List<Musteri>();
        public static List<Urun> urunler { get; set; }
        public static HesapDefteri hd = new HesapDefteri();

        public static void MusteriEkle(Musteri m)
        {
            musteriler.Add(m);
        }

        public static void UrunEkle(Urun u)
        {
            urunler.Add(u);
        }
        public static void KasaGorevlisiEkle(KasaGorevlisi k)
        {
            gorevliler.Add(k);
        }

       public static int KasiyerGiris(string Adsoyad,string parola)
        {
             int kilit = 0;
            foreach (KasaGorevlisi ks in gorevliler)
            {
               
                if (ks.AdSoyad == Adsoyad && ks.Parola == parola)
                    kilit = 1;
            }
            return kilit;
        }

         
         public static Urun UrunBul(int UrunKodu)
        {
            Urun bulunanUrun = null;    
            foreach (Urun urn in urunler)
            {
                if (urn.UrunKodu == UrunKodu)
                {
                    bulunanUrun = urn;
                    break;
                }
            }
            return bulunanUrun;
        }

         public static void StokAzalt(int UrunKodu, int Miktar)
         {
             foreach (Urun urn in urunler)
             {
                 if (urn.UrunKodu == UrunKodu)
                 {
                     urn.UrunMiktari -= Miktar;
                     break;
                 }

             }
         }

         public static int StokKontrolu(int UrunKodu, int SatisAdeti)
         {
             int kilit = 0;
             foreach (Urun u in urunler)
             {
                 if (u.UrunKodu == UrunKodu)
                 {
                     if (u.UrunMiktari > SatisAdeti)
                         kilit = 1;
                 }
             }
             return kilit;
         }

      
         public static KasaGorevlisi KasaGorevlisiAta()
         {
             KasaGorevlisi ksg = null;
             foreach (KasaGorevlisi kg in gorevliler)
             {
                 if (kg.CalismaDurumu=="aktif")
                 {
                     ksg = kg;
                    
                 }
                     
             }
             return ksg;
         }

         public static Musteri KartlaMusteriBul(int KartNo)
         {
             Musteri bulunanMusteri = null;
             foreach (Musteri m in musteriler)
             {
                 if (m.Kart.KartNo == KartNo)
                 {
                     bulunanMusteri = m;
                 }
             }
             return bulunanMusteri;
         }
      
         public static void KasiyereDurumAtama(string kullaniciAdi)
         {
             foreach (KasaGorevlisi kg in gorevliler)
             {
                 if(kg.AdSoyad==kullaniciAdi)
                 {
                     kg.CalismaDurumu = "aktif";
                 }
             }
         }

         public static string UrunAra(int UrunKodu)
         {
             string temp = "";
             foreach (Urun u in urunler)
             {
                 if (UrunKodu == u.UrunKodu)
                 {
                     temp += "Ürün Kodu:" + u.UrunKodu + "     Ürün Adi:" + u.UrunAciklama + "     Ürün Birim Fiyatı:" + u.UrunBirimFiyati + "     Ürün Miktarı:" + u.UrunMiktari;
                 } 
             }
             return temp;
         }

         public static string KasiyerAra(string isim)
         {
             string temp = "";
             foreach (KasaGorevlisi g in gorevliler)
             {
                 if (g.AdSoyad ==isim )
                 {
                     temp += "Kasiyer İsim:" + g.AdSoyad + "     Kasiyer Doğum Tarihi:" + g.DogumTarihi.ToShortDateString() + "     Kasiyer Cinsiyet::" + g.Cinsiyet + "     Kasiyer Adres:" + g.Adres+"     Kasiyer e-mail:"+g.EmailAdresi;
                 }
             }
             return temp;
         }

    }
}
