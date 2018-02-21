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
    public partial class MüsteriEklemeEkrani : Form
    {
        public MüsteriEklemeEkrani()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            string cinsiyet;
            Musteri m = new Musteri();
            m.Kart.KartNo = Convert.ToInt32(txtKartNo.Text);
            m.AdSoyad = txtMusteriAdSoyad.Text;
            m.Adres = txtMusteriAdresi.Text;
            cinsiyet = rbMusteriErkek.Checked ? rbMusteriErkek.Text : rbMusteriKadin.Text;
            m.Cinsiyet = cinsiyet;
            m.DogumTarihi = dtpMusteriDogumTarihi.Value;
            m.EmailAdresi = txtEmailAdresi.Text;
            m.TelefonNo = Convert.ToUInt64(txtMusteriTelefonNo.Text);
            Dukkan.MusteriEkle(m);
            MessageBox.Show("Müşteri Ekleme İşlemi Başarılı.");

            txtKartNo.Text = "";
            txtMusteriAdSoyad.Text = "";
            txtMusteriAdresi.Text = "";
            rbMusteriErkek.Checked = false;
            rbMusteriKadin.Checked = false;
            txtEmailAdresi.Text = "";
            txtMusteriTelefonNo.Text = "";

            
        }

      

     
    }
}
