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
    public partial class UrunListelemeEkrani : Form
    {
        public UrunListelemeEkrani()
        {
            InitializeComponent();
        }

        private void UrunListelemeEkrani_Load(object sender, EventArgs e)
        {
            dataGridViewUrunListele.DataSource = null;
            dataGridViewUrunListele.DataSource = Dukkan.urunler;
        }
    }
}
