using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaStokTakipSistemi
{
    public partial class islemKaydi : Form
    {
        public islemKaydi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veritabani.TabloGoruntule("SELECT * FROM Islemler WHERE Tarih BETWEEN CAST('"+baslangicTarih.Value.Date+ "' as DATE) AND CAST('" + bitisTarih.Value.Date + "' as DATE) ", dataGridView1);
        }

        private void islemKaydi_Load(object sender, EventArgs e)
        {

            Veritabani.TabloGoruntule("SELECT * FROM Islemler", dataGridView1);
        }
    }
}
