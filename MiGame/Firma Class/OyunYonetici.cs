using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Globalization;

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
    }
}
