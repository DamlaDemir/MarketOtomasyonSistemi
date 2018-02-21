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
    public partial class StokGoruntulemeEkrani : Form
    {
        public StokGoruntulemeEkrani()
        {
            InitializeComponent();
        }

        private void StokGoruntulemeEkrani_Load(object sender, EventArgs e)
        {
            dgStokListele.DataSource = null;
           dgStokListele.DataSource = Dukkan.urunler;
          
          
        }
    }
}
