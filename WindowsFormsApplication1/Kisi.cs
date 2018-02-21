using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class Kisi
    {
        public  string AdSoyad { get; set; }
        public  ulong TelefonNo { get; set; }
        public  string Adres { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string EmailAdresi { get; set; }
        public string Cinsiyet { get; set; }
        
    }
}
