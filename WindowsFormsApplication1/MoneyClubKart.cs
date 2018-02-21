using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class MoneyClubKart
    {
        public int KartNo { get; set; }
        public float KartPuani { get; set; }
        private const float INDIRIMPUANI=0.01F;

       public void KartPuaniEkle()
        {
            KartPuani += INDIRIMPUANI;
        }
    }
}
