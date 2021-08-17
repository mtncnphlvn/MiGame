using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace MiGame
{
    class OyunYonetici
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        public bool OyunEkle(Oyun oyun)
        {
            en();
            bool kayit = false;

            try
            {
                string sorgu = "insert into oyun(oyun_adi,oyun_konu,kat_id,firma_id,oyun_fiyat,oyun_resim,oyun_durum) values('" + oyun.getOyunAdi + "','" + oyun.getOyunKonusu + "','" + oyun.getOyunKategori + "','" + Firma.firmaID + "','" + oyun.getOyunFiyat + "','" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(oyun.getOyunResim) + "','" + 0 + "')";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

                object sonuc = komut.ExecuteReader();
                if (sonuc != null)
                {
                    MessageBox.Show(Localization.eklendi);
                    kayit = true;
                }
                else
                {
                    MessageBox.Show(Localization.eklenemedi);
                }

                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " : " + ex.Message);
            }
            return kayit;
        }
        public void KategoriDoldur(ComboBox comboBox)
        {
            en();
            try
            {
                string sorgu = "select * from kategori order by kat_adi asc";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;

                comboBox.Items.Add(Localization.katsec);
                comboBox.SelectedIndex = 0;

                reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader["kat_adi"]);
                }
                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " : " + ex.Message);
            }
        }
        public int KategoriSec(ComboBox comboBox)
        {
            int secim = 0;

            string sorgu = "select * from kategori where kat_adi='" + comboBox.SelectedItem.ToString() + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;

            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                secim = Convert.ToInt32(reader["kat_id"]);
            }
            veritabaniYonetici.CloseConnection();

            return secim;
        }
        public void Oyunlarım(DataGridView dataGridView)
        {
            string sorgu = "select oyun.oyun_id as ID, oyun.oyun_adi as OyunAdı,oyun.oyun_konu as Konu, kategori.kat_adi as Kategori,AVG(puan.puan) as Puan, firma.firma_ad as Firma, oyun.oyun_fiyat as Fiyat from oyun inner join kategori on oyun.kat_id = kategori.kat_id inner join puan on oyun.oyun_id = puan.oyun_id  inner join firma on oyun.firma_id = firma.firma_id where firma.firma_id ='" + Firma.firmaID + "' group by oyun.oyun_adi order by oyun.oyun_adi;";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlDataReader reader;

            DataTable dTable;
            reader = komut.ExecuteReader();
            MyAdapter.SelectCommand = komut;
            veritabaniYonetici.CloseConnection();

            dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView.DataSource = dTable;
        }
        public void OyunListele(DataGridView dataGridView)
        {
            string sorgu = "select oyun.oyun_id as ID, oyun.oyun_adi as OyunAdı,oyun.oyun_konu as Konu, kategori.kat_adi as Kategori,AVG(puan.puan) as Puan, firma.firma_ad as Firma, oyun.oyun_fiyat as Fiyat from oyun inner join kategori on oyun.kat_id = kategori.kat_id inner join puan on oyun.oyun_id = puan.oyun_id  inner join firma on oyun.firma_id = firma.firma_id group by oyun.oyun_adi order by oyun.oyun_adi";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlDataReader reader;

            DataTable dTable;
            reader = komut.ExecuteReader();
            MyAdapter.SelectCommand = komut;
            veritabaniYonetici.CloseConnection();

            dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView.DataSource = dTable;

        }
        public void OyunListele(DataGridView dataGridView, TextBox textBox)
        {
            string sorgu = "select oyun.oyun_id as ID,oyun.oyun_adi as OyunAdı,oyun.oyun_konu as Konu, kategori.kat_adi as Kategori,AVG(puan.puan) as Puan, firma.firma_ad as Firma, oyun.oyun_fiyat as Fiyat from oyun inner join kategori on oyun.kat_id = kategori.kat_id inner join puan on oyun.oyun_id = puan.oyun_id  inner join firma on oyun.firma_id = firma.firma_id where oyun.oyun_adi like '" + "%" + textBox.Text + "%" + "' group by oyun.oyun_adi order by oyun.oyun_adi;";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MySqlDataReader reader;

            DataTable dTable;
            reader = komut.ExecuteReader();
            MyAdapter.SelectCommand = komut;
            veritabaniYonetici.CloseConnection();

            dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView.DataSource = dTable;
        }

        public void OnizlemeResim(PictureBox pictureBox)
        {
            string sorgu = "select oyun_resim from oyun where oyun_id='" + Oyun.oyunID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;

            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                pictureBox.ImageLocation = reader["oyun_resim"].ToString();
            }
            veritabaniYonetici.CloseConnection();
        }
        public void OyunGuncelle(ComboBox comboBox, TextBox textBox, Label label)
        {
            en();
            string sorgu = "update oyun set kat_id='" + KategoriSec(comboBox) + "',oyun_fiyat='" + textBox.Text + "' where oyun_id = '" + Oyun.oyunID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;
            reader = komut.ExecuteReader();
            label.Text = Localization.oyunGuncellendi;
            veritabaniYonetici.CloseConnection();
        }
    }
}
