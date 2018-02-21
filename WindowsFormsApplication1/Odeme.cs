using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Odeme:Satis
    {
        public string OdemeTipi { get; set; }

        public override void IndirimHesapla()
        {
            toplamtutar -= toplamtutar * Convert.ToDecimal(musteri.Kart.KartPuani);
        }

        public Odeme()
        {
            kalemler = new List<SatisKalemi>();
            musteri = new Musteri();
            kasiyer = new KasaGorevlisi();
        }
    }
}
