using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public  class KasaGorevlisi:Kisi
    {
        public string CalismaDurumu { get; set; }
        public string KasaNo { get; set; }
        public  string Parola { get; set; }
        

        private ulong tcno;

        public ulong TcNo
        {
            get { return tcno; }
            set { tcno = value; }
        }
        
    }
}
