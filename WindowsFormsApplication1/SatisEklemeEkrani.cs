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
    public partial class SatisEklemeEkrani : Form
    {
        public SatisEklemeEkrani()
        {
            InitializeComponent();
        }



        Odeme o = new Odeme();
        private void btnListele_Click(object sender, EventArgs e)
        {

            SatisKalemi sk = new SatisKalemi();
            Urun u = new Urun();
            u = Dukkan.UrunBul(Convert.ToInt32(txtSatisUrunKodu.Text));

            sk.UrunAciklama = u.UrunAciklama;
            sk.UrunKodu = u.UrunKodu;
            sk.UrunBirimFiyati = u.UrunBirimFiyati;
            sk.SatisMiktari = Convert.ToInt32(txtUrunSatisMiktari.Text);
           
            if (Dukkan.StokKontrolu(sk.UrunKodu, sk.SatisMiktari) != 1)
                MessageBox.Show("Stokta yeteri kadar ürün yoktur.");

            sk.UrunTutarHesapla();
            o.ToplamTutar += sk.UrunTutari;
            o.KalemEkle(sk);

            lblSatisUrunAdi.Text = sk.UrunAciklama;
            lblUrunSatisFiyati.Text = sk.UrunBirimFiyati.ToString();
            lblSatisTutar.Text = sk.UrunTutari.ToString();

            dgSatisKalemi.DataSource = null;
            dgSatisKalemi.DataSource = o.kalemler;

            Dukkan.StokAzalt(Convert.ToInt32(txtSatisUrunKodu.Text), Convert.ToInt32(txtUrunSatisMiktari.Text));
        }
        private void btnTutarHesapla_Click(object sender, EventArgs e)
        {
            if (txtKartNo.Text != "")
            {
                o.musteri = Dukkan.KartlaMusteriBul(Convert.ToInt32(txtKartNo.Text));
                

                if (o.musteri.Kart.KartPuani > 0 && rbPuanKullanmaDurumu.Checked==true)
                {
                    if (o.ToplamTutar >= 50)
                      o.IndirimHesapla();
                }

                o.musteri.Kart.KartPuaniEkle();

            }
           
            txtToplamTutar.Text = o.ToplamTutar.ToString();
           
           
        }

        

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
           
            o.SatisTarihi = dateTimePickerSatisTarihi.Value;
            o.OdemeTipi = rbKrediKarti.Checked ? "Kredi Kartı" : "Nakit";
            
            if(o.OdemeTipi=="Kredi Kartı")
            {
                txtVerilenPara.Text = " ";
                txtParaUstu.Text = " ";
            }
            else
            {
                txtParaUstu.Text = ((Convert.ToDecimal(txtVerilenPara.Text)) - o.ToplamTutar).ToString();
            }

           
            o.kasiyer = Dukkan.KasaGorevlisiAta();
            Dukkan.hd.OdemeEkle(o);
            dgSatisKalemi.DataSource = null;
            o = new Odeme();

            txtKartNo.Text = "";
            
            txtToplamTutar.Text = "";
            txtVerilenPara.Text = "";
            txtSatisUrunKodu.Text = "";
            txtUrunSatisMiktari.Text = "";
            lblSatisTutar.Text = "";
            lblSatisUrunAdi.Text = "";
            lblUrunSatisFiyati.Text = "";
            rbPuanKullanmaDurumu.Checked = false;

        }

      

   
       
    }
}
