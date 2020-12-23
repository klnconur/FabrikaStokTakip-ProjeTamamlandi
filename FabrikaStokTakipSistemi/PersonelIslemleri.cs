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
    public partial class PersonelIslemleri : Form
    {
        static string PersonelTC;
        public PersonelIslemleri(string TC)
        {
            PersonelTC = TC;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Veritabani.TabloGoruntule("SELECT * FROM Kullanici WHERE TC Like '%" + textBox1.Text + "%'", personelTablo);
        }
        string SecilenPersonel;
        private void personelTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenPersonel = personelTablo.Rows[e.RowIndex].Cells[0].Value.ToString();
            string[] PersonelVeri = Veritabani.DiziCek("SELECT CONCAT(TC,',',Ad,',',Soyad,',',Sifre,',',Tel,',',Adres) FROM Kullanici WHERE TC='" + SecilenPersonel + "'");
            TC_tb.Text = PersonelVeri[0];
            Ad_tb.Text = PersonelVeri[1];
            Soyad_tb.Text = PersonelVeri[2];
            Sifre_tb.Text = PersonelVeri[3];
            Telefon_tb.Text = PersonelVeri[4];
            Adres_tb.Text = PersonelVeri[5];
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            Veritabani.TabloGoruntule("SELECT * FROM Kullanici",personelTablo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TC_tb.Text!="")
            {
                DialogResult dr = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Veritabani.VeriEkle("DELETE FROM Kullanici WHERE TC='" + TC_tb.Text + "'");
                    Veritabani.TabloGoruntule("SELECT * FROM Kullanici", personelTablo);
                    TC_tb.Clear();
                }
            }
            else
            {
                MessageBox.Show("Bir personel seçiniz.");
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (TC_tb.Text!="")
            {
                Veritabani.VeriEkle("UPDATE Kullanici SET Ad='" + Ad_tb.Text + "',Soyad='" + Soyad_tb.Text + "',Sifre='" + Sifre_tb.Text + "', Tel='" + Telefon_tb.Text + "', Adres='" + Adres_tb.Text + "' WHERE TC='" + TC_tb.Text + "'");
                MessageBox.Show("Personel bilgileri güncellendi.");
                Veritabani.TabloGoruntule("SELECT * FROM Kullanici", personelTablo);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tct2_tb.Text!="")
            {
                int unvan;
                if (unvancb.Text == "Yonetici")
                {
                    unvan = 1;
                }
                else unvan = 2;
                Veritabani.VeriEkle("INSERT INTO Kullanici VALUES('" + tct2_tb.Text + "','" + sifre2_tb.Text + "','" + ad2_tb.Text + "','" + soyad2_tb.Text + "','" + unvan.ToString() + "','" + tel2_tb.Text + "','" + adres2_tb.Text + "')");
                MessageBox.Show("Yeni kayıt eklendi!");
                Veritabani.TabloGoruntule("SELECT * FROM Kullanici", personelTablo);
            }
        }
    }
}
