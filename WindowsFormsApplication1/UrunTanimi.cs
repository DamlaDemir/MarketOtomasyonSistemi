using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public abstract class UrunTanimi
    {
        public int UrunKodu { get; set; }
        public string UrunAciklama { get; set; }
        public decimal UrunBirimFiyati { get; set; }
        public int UrunMiktari { get; set; }
        


    }
}
