using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace FabrikaStokTakipSistemi
{
    class Veritabani
    {
        static string ServerName = "DESKTOP-RA5JL8S";
        static string Db = "FabrikaStokTakip";
        static SqlConnection con = new SqlConnection("Data Source=" + ServerName + ";Initial Catalog=" + Db + ";Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter da = new SqlDataAdapter();
        static SqlDataReader dr;
        public static void VeriEkle(string sql)
        {
            //INSERT INTO Kullanici VALUES(123654789,'Onur','KILINÇ',2,...)
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void TabloGoruntule(string sql, DataGridView dg)
        {
            //SELECT * FROM Stok
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dg.DataSource = ds.Tables[0];
            con.Close();
        }
        public static string IntegerCek(string sql)
        {
            //5 ID'li ürünün adetini çekeceğiz;
            //SELECT asgariMiktar FROM Stok WHERE ID=5
            con.Open();
            string deger;
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                deger = (dr[0].ToString());
            }
            else
            {
                deger = "-1";
            }
            con.Close();
            return deger;
        }
        public static string[] DiziCek(string sql)
        {
            //1-Yonetici 2-Personel
            //SELECT TC Kullanici WHERE UnvanID=1
            con.Open();
            string[] deger;
            string temp = "";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                temp = dr[0].ToString();
            }
            deger = temp.Split(',');
            con.Close();
            return deger;
        }
        public static string Giris(string TC, string Sifre)
        {
            string ret;
            con.Open();
            cmd = new SqlCommand("SELECT TC FROM Kullanici WHERE TC=@tc AND Sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@tc", TC);
            cmd.Parameters.AddWithValue("@sifre", Sifre);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ret = dr[0].ToString();
            }
            else
            {
                ret = "Invalid";
            }
            con.Close();
            return ret;
        }
        public static void baglantiKapat()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static void StokKontrol(string stokID)
        {
            con.Open();
            cmd = new SqlCommand("SELECT AsgariMiktar FROM Depo WHERE ID=" + stokID, con);
            dr = cmd.ExecuteReader();
            int asgariMiktar = -1;
            if (dr.Read())
            {
                asgariMiktar = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            if (asgariMiktar > 0)
            {
                //asgariMiktar = 50 //ürün miktarı= 20
                int stokMiktar = -1;
                cmd = new SqlCommand("SELECT Stok FROM Depo WHERE ID=" + stokID, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    stokMiktar = Convert.ToInt32(dr[0].ToString());
                }
                dr.Close();
                if (stokMiktar <= asgariMiktar)
                {
                    cmd = new SqlCommand("UPDATE Depo SET Stok=Stok+" + asgariMiktar + " WHERE ID=" + stokID, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stok Miktarı Otomatik Eklendi!");
                }
            }
            con.Close();

        }
        public static void comboBoxCek(string sql, ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
    }
}