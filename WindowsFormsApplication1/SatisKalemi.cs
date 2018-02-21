using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class SatisKalemi:UrunTanimi
    {
        public int SatisMiktari { get; set; }
        private decimal uruntutari;
        public decimal UrunTutari
        {
            get { return uruntutari; }
            set { uruntutari = value; }
        }
        
     public  void UrunTutarHesapla()
        {
            UrunTutari = this.SatisMiktari * UrunBirimFiyati;
        }
       
    }
}
