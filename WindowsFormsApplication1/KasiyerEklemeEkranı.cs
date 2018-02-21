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
    public partial class KasiyerEklemeEkranı : Form
    {
        public KasiyerEklemeEkranı()
        {
            InitializeComponent();
        }

        private void btnKasiyerEkle_Click(object sender, EventArgs e)
        {
            KasaGorevlisi k = new KasaGorevlisi();
            k.KasaNo = cbKasaNo.SelectedItem.ToString();
            k.AdSoyad = txtKasiyerAdSoyad.Text;
            k.TcNo = Convert.ToUInt64(txtKasiyerTcNo.Text);
            k.TelefonNo = Convert.ToUInt64(txtKasiyerTelefonNo.Text);
            k.Parola = txtKasiyerParola.Text;
            k.Adres = txtKasiyerAdresi.Text;
            k.Cinsiyet = rbKasiyerErkek.Checked ? "Erkek" : "Kadın";
            k.DogumTarihi = Convert.ToDateTime(dtpKasiyerDogumTarihi.Text);
            k.EmailAdresi = txtKasiyerEmailAdresi.Text;
            Dukkan.KasaGorevlisiEkle(k);
            MessageBox.Show("Kasiyer Ekleme işlemi Başarılı.");

            cbKasaNo.SelectedItem = null;
            txtKasiyerAdSoyad.Text = "";
            txtKasiyerTcNo.Text = "";
            txtKasiyerTelefonNo.Text = "";
            txtKasiyerParola.Text = "";
            txtKasiyerEmailAdresi.Text = "";
            txtKasiyerAdresi.Text = "";
        }

        

        
    

        


        
    }
}
