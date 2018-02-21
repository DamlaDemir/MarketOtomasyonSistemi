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
    public partial class MusteriListelemeEkrani : Form
    {
        public MusteriListelemeEkrani()
        {
            InitializeComponent();
        }

        private void MusteriListelemeEkrani_Load(object sender, EventArgs e)
        {
            dgMusteriListele.DataSource = null;
            dgMusteriListele.DataSource = Dukkan.musteriler;

        }
    }
}
