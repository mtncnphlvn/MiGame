using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiGame
{
    class KullaniciYonetici:Kullanici
    {
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }

        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
        public bool KayitOl(Kullanici kullanici)
        {
            en();
            bool kayit = false;

            try
            {
                string sorgu = "insert into kullanici(kul_ad,kul_soyad,kul_dtarih,kul_cinsiyet,kul_eposta,kul_kulad,kul_sifre) values('" + kullanici.getKullaniciAdi + "','" + kullanici.getKullaniciSoyadi + "','" + kullanici.getKullaniciDogumTarih + "','" + kullanici.getKullaniciCinsiyet + "','" + kullanici.getKullaniciEposta + "','" + kullanici.getKullaniciKulAdi + "','" + kullanici.getKullaniciSifre + "')";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

                object sonuc = komut.ExecuteReader();
                if (sonuc != null)
                {
                    MessageBox.Show(Localization.kayitbasari);
                    kayit = true;
                }
                else
                {
                    MessageBox.Show(Localization.kayitbasarisiz);
                }

                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " : " + ex.Message);
            }
            return kayit;
        }
        public bool Giris(Kullanici kullanici)
        {
            en();
            bool giris = false;
            try
            {
                string sorgu = "select * from kullanici where kul_eposta='" + kullanici.getKullaniciEposta + "'and kul_sifre='" + kullanici.getKullaniciSifre + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    giris = true;
                    Kullanici.kullaniciID = Convert.ToInt32(reader[0]);
                    MessageBox.Show(Localization.gbasari);
                }
                else
                {
                    MessageBox.Show(Localization.gbasarisiz);
                }
                veritabaniYonetici.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " : " + ex.Message);
            }
            return giris;

        }
        public bool HesapKontrol(Kullanici kullanici)
        {
            en();
            bool giris = false;
            try
            {
                string sorgu = "select * from kullanici where kul_kulad='" + kullanici.getKullaniciKulAdi + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    giris = false;
                    MessageBox.Show(Localization.kulkayit);
                }
                else
                {
                    giris = true;
                }
                veritabaniYonetici.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " : " + ex.Message);
            }
            return giris;

        }
        public void BakiyeEkle()
        {
            string sorgu = "insert into kullanici_bakiye(kul_id,kul_bakiye) values ('" + Kullanici.kullaniciID + "',100)";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            komut.ExecuteReader();
            veritabaniYonetici.CloseConnection();
        }
    }
}
