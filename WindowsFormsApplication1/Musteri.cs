using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Musteri:Kisi
    {
        public MoneyClubKart Kart { get; set; }

        public Musteri()
        {
            Kart = new MoneyClubKart();
        }
    }
}
