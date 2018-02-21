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
    public partial class LoginEkrani : Form
    {
        public LoginEkrani()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            PatronAnaEkran pe = new PatronAnaEkran();
            AnaEkran ae = new AnaEkran();

            
            if(txtKullaniciAdi.Text == "Admin" && txtParola.Text == "1234")
            {
                pe.Show();
               
            }

            if (txtKullaniciAdi.Text == "" && txtParola.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez!");
            }
           
            string sifre=txtParola.Text;
            string ad=txtKullaniciAdi.Text;
            if (Dukkan.KasiyerGiris(ad, sifre) == 1)
            {
                Dukkan.KasiyereDurumAtama(txtKullaniciAdi.Text);
                ae.Show();
            }

          
            txtKullaniciAdi.Text = "";
            txtParola.Text = "";
            
            




        }

        
    
    }
}
