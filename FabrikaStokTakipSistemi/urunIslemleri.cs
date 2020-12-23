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
    public partial class urunIslemleri : Form
    {
        public urunIslemleri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (urunID.Text!="")
            {
                Veritabani.VeriEkle("UPDATE Urun SET Isim='"+urunAdi.Text+"',AlisFiyati='"+alisFiyati.Text+"',Firma='"+saglayiciFirma.Text+"' WHERE ID="+urunID.Text);
                MessageBox.Show("Ürün Bilgisi Güncellendi!");
                Veritabani.TabloGoruntule("SELECT * FROM Urun", dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veritabani.TabloGoruntule("SELECT * FROM Urun", dataGridView1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Veritabani.TabloGoruntule("SELECT * FROM Urun WHERE Isim LIKE '%"+textBox2.Text+"%'", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (urunAdi2.Text != "" && alisFiyati2.Text != "" && firma2.Text != "")
            {
                Veritabani.VeriEkle("INSERT INTO Urun VALUES('" + urunAdi2.Text + "','" + alisFiyati2.Text + "','" + firma2.Text + "')");
                Veritabani.VeriEkle("INSERT INTO Depo VALUES ((SELECT MAX(ID) FROM Urun),0,CAST(GETDATE() AS DATE),0)");
                MessageBox.Show("Ürün bilgisi eklendi.");
                Veritabani.TabloGoruntule("SELECT * FROM Urun", dataGridView1);
            }
            else MessageBox.Show("Tüm değerleri giriniz.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (id!=null)
                {
                    string[] urunBilgileri = Veritabani.DiziCek("SELECT CONCAT(ID,',',Isim,',',AlisFiyati,',',Firma) FROM Urun WHERE ID=" + id);
                    urunID.Text = urunBilgileri[0];
                    urunAdi.Text = urunBilgileri[1];
                    alisFiyati.Text = urunBilgileri[2];
                    saglayiciFirma.Text = urunBilgileri[3];
                }
            }
            catch (Exception)
            {
                Veritabani.baglantiKapat();
            }
        }

        private void dataGridView1_CellClick(object sender, EventArgs e)
        {

        }
    }
}
