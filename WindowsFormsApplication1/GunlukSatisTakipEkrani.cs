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
    public partial class GunlukSatisTakipEkrani : Form
    {
        public GunlukSatisTakipEkrani()
        {
            InitializeComponent();
        }

        private void GunlukSatisTakipEkrani_Load(object sender, EventArgs e)
        {
            txtGunlukSatisListele.Text=Dukkan.hd.GunlukSatisTakibi();
            lblGunlukSatisToplami.Text= Dukkan.hd.GunlukSatisToplamTutari()+" "+"TL";
        }
    }
}
