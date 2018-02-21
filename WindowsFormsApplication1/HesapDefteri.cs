using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public  class HesapDefteri
   {
        public  List<Odeme> odemeler{get; set;}
       public HesapDefteri()
       {
           odemeler = new List<Odeme>();
       }
      
     
       public  void OdemeEkle(Odeme o)
        {
            odemeler.Add(o);
        }
       public  string GunlukSatisTakibi()
       {
           string temp = "";
           foreach (Odeme o in odemeler)
           {
               temp +=o.SatisTarihi+"     "+"Müşteri:"+o.musteri.AdSoyad+"     Ürünler:"+o.KalemleriListele() + "     Toplam Tutar:"+o.ToplamTutar+" "+"     Kasiyer:"+o.kasiyer.AdSoyad+"     Kasa No:"+o.kasiyer.KasaNo+Environment.NewLine+Environment.NewLine;
           }
           
           return temp;
       }



       public decimal GunlukSatisToplamTutari()
       {
           decimal tutar = 0;
           foreach (Odeme o in odemeler)
           {
               tutar += o.ToplamTutar;
           }
           return tutar;
       }
    }


    
}
