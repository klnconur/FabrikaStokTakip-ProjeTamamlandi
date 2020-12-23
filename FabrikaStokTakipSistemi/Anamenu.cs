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
    public partial class Anamenu : Form
    {
        public static string AktifPersonelTC;
        static bool Yoneticimi = false;
        public Anamenu(string TC)
        {
            AktifPersonelTC = TC;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Stokislemleri().ShowDialog();
        }

        private void Anamenu_Load(object sender, EventArgs e)
        {
            string unvan = Veritabani.IntegerCek("SELECT UnvanID FROM Kullanici WHERE TC='" + AktifPersonelTC + "'");
            if (unvan == "1")
                Yoneticimi = true;
            else Yoneticimi = false;
            stok.Enabled = true;
            urun.Enabled = true;
            otomatiksiparis.Enabled = true;
            if (Yoneticimi)
            {
                kasa.Enabled = true;
                islemkaydi.Enabled = true;
                personelislemleri.Enabled = true;
            }
        }

        private void personelislemleri_Click(object sender, EventArgs e)
        {
            new PersonelIslemleri(AktifPersonelTC).ShowDialog();
        }

        private void Anamenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void urun_Click(object sender, EventArgs e)
        {
            new urunIslemleri().ShowDialog();
        }

        private void otomatiksiparis_Click(object sender, EventArgs e)
        {
            new OtomatikSiparis().ShowDialog();
        }

        private void islemkaydi_Click(object sender, EventArgs e)
        {
            new islemKaydi().ShowDialog();
        }

        private void kasa_Click(object sender, EventArgs e)
        {
            new kasaKaydi().ShowDialog();
        }
    }
}
