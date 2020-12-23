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
    public partial class OtomatikSiparis : Form
    {
        public OtomatikSiparis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (urunCb.SelectedIndex>=0&&stokMiktari.Text!="")
            {
                Veritabani.VeriEkle("UPDATE Depo SET AsgariMiktar=" + stokMiktari.Text + " WHERE ID=" + urunCb.Text);
                MessageBox.Show("Otomatik Sipariş Miktarı Güncellendi!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OtomatikSiparis_Load(object sender, EventArgs e)
        {
            Veritabani.comboBoxCek("SELECT ID From Depo", urunCb);
        }
    }
}
