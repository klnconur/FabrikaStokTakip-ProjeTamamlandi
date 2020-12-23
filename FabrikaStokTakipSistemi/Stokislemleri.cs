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
    public partial class Stokislemleri : Form
    {
        public Stokislemleri()
        {
            InitializeComponent();
        }
        string sql = "SELECT Depo.ID,Urun.Isim,Urun.AlisFiyati,Urun.Firma,Depo.Stok,Depo.SonAlimTarihi,Depo.AsgariMiktar FROM Urun INNER JOIN Depo ON Depo.UrunID=Urun.ID";
        private void button3_Click(object sender, EventArgs e)
        {
            Veritabani.TabloGoruntule(sql, dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                Veritabani.TabloGoruntule(sql + " WHERE Depo.ID=" + textBox1.Text, dataGridView1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (urunCb.SelectedIndex>=0&&stokMiktari.Text!="")
            {
                Veritabani.VeriEkle("UPDATE Depo SET Stok+=" + stokMiktari.Text + ", SonAlimTarihi=CAST(GETDATE() as Date) WHERE ID=" + urunCb.Text);
                string uid = Veritabani.IntegerCek("SELECT UrunID FROM Depo WHERE ID=" + urunCb.Text);
                double fiyat = Convert.ToDouble(Veritabani.IntegerCek("SELECT AlisFiyati FROM Urun WHERE ID=" + uid));
                int adet = Convert.ToInt32(stokMiktari.Text);
                Veritabani.VeriEkle("INSERT INTO Islemler VALUES('" + Anamenu.AktifPersonelTC + "'," + uid + "," + stokMiktari.Text + "," + (adet * fiyat) + ",CAST(GETDATE() as DATE))");
            }
            Veritabani.TabloGoruntule(sql, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (urunCb.SelectedIndex >= 0 && stokMiktari.Text != "")
            {
                Veritabani.VeriEkle("UPDATE Depo SET Stok-=" + stokMiktari.Text + " WHERE ID=" + urunCb.Text);
                Veritabani.StokKontrol(urunCb.Text);
            }
            Veritabani.TabloGoruntule(sql, dataGridView1);
        }

        private void Stokislemleri_Load(object sender, EventArgs e)
        {
            Veritabani.TabloGoruntule(sql, dataGridView1);
            Veritabani.comboBoxCek("SELECT ID From Depo", urunCb);
        }
    }
}
