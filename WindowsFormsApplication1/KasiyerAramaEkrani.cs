using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class KasiyerAramaEkrani : Form
    {
        public KasiyerAramaEkrani()
        {
            InitializeComponent();
        }

        private void btnKasiyerAra_Click(object sender, EventArgs e)
        {
            txtBulunanKasiyer.Text = Dukkan.KasiyerAra(txtAranacakKasiyerAdSoyad.Text);
            txtAranacakKasiyerAdSoyad.Text = "";
        }

        
    }
}
