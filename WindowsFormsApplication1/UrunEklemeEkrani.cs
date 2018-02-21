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
    public partial class UrunEklemeEkrani : Form
    {
        public UrunEklemeEkrani()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
            u.UrunAciklama = txtUrunTanimi.Text;
            u.UrunBirimFiyati = Convert.ToDecimal(txtUrunBirimFiyati.Text);
            u.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
            Dukkan.UrunEkle(u);
            MessageBox.Show("Ürün Ekleme İşlemi Başarılı.");

            txtUrunKodu.Text = "";
            txtUrunTanimi.Text = "";
            txtUrunBirimFiyati.Text = "";
            txtUrunMiktari.Text = "";


        }

        private void UrunEklemeEkrani_Load(object sender, EventArgs e)
        {
            Dukkan.urunler = new List<Urun>();
        }
    }
}
