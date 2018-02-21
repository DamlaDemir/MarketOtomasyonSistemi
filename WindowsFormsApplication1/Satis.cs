using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class Satis
    {
        public List<SatisKalemi> kalemler { get; set; }
        public Musteri musteri { get; set; }

        public KasaGorevlisi kasiyer { get; set; }
        protected decimal toplamtutar ;
        public DateTime SatisTarihi { get; set; }

        public decimal ToplamTutar
        {
            get 
            {
                return toplamtutar;
            }
            set
            {
                toplamtutar = value;
            }
        }

      
       
        public void KalemEkle(SatisKalemi s)
        {
            kalemler.Add(s);
        }
     
        public string KalemleriListele()
        {
            string temp = "";
            foreach (SatisKalemi sk in kalemler)
            {
                temp += sk.UrunAciklama +" "+sk.SatisMiktari+" Tane"+ sk.UrunBirimFiyati+" TL"+"-";
            }
            return temp;
        }

        public abstract void IndirimHesapla();
       

        
        
    }
}
