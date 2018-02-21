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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        void YavruForm(Form Yavru)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == Yavru.Text)
                {
                    durum = true;
                    eleman.Activate();
                }

            }

            if (durum == false)
            {
                Yavru.MdiParent = this;
                Yavru.Show();
            }
        }

        private void müşteriEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MüsteriEklemeEkrani me = new MüsteriEklemeEkrani();
            YavruForm(me);
            
        }

      

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            Anasayfa asyf = new Anasayfa();
            YavruForm(asyf);
        }

        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriListelemeEkrani ml = new MusteriListelemeEkrani();
            YavruForm(ml);
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa asf = new Anasayfa();
            YavruForm(asf);
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEklemeEkrani ue = new UrunEklemeEkrani();
            YavruForm(ue);
        }


        private void ürünAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunAramaEkrani ua = new UrunAramaEkrani();
            YavruForm(ua);
        }

        private void satışEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisEklemeEkrani se = new SatisEklemeEkrani();
            YavruForm(se);
        }

        private void stokGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGoruntulemeEkrani sg = new StokGoruntulemeEkrani();
            YavruForm(sg);
        }

        private void günlükSatışTakibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunlukSatisTakipEkrani gst = new GunlukSatisTakipEkrani();
            YavruForm(gst);
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunListelemeEkrani ul = new UrunListelemeEkrani();
            YavruForm(ul);
        }

       

      
     

      
    }
}
