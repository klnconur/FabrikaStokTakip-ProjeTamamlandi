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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girisParametresi = Veritabani.Giris(tb_TC.Text, tb_Sifre.Text);
            if (girisParametresi!= "Invalid")
            {
                new Anamenu(girisParametresi).ShowDialog();
            }
            else
            {
                MessageBox.Show("Geçersiz TC/Şifre");
                tb_Sifre.Clear();
            }
        }
    }
}
