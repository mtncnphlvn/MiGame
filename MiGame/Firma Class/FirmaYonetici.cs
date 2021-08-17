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
    class FirmaYonetici
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();

        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        public bool KayitOl(Firma firma)
        {
            bool kayit = false;
            en();

            try
            {
                string sorgu = "insert into firma(firma_ad,firma_ceo,firma_eposta,firma_sifre) values('" + firma.getFirmaAdi + "','" + firma.getFirmaCeo + "','" + firma.getFirmaEposta + "','" + firma.getFirmaSifre + "')";
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
        public bool Giris(Firma firma)
        {
            en();
            bool giris = false;
            try
            {
                string sorgu = "select * from firma where firma_eposta='" + firma.getFirmaEposta + "'and firma_sifre='" + firma.getFirmaSifre + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    giris = true;
                    Firma.firmaID = Convert.ToInt32(reader[0]);
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
        public bool HesapKontrol(Firma firma)
        {

            bool giris = false;
            try
            {
                string sorgu = "select * from firma where firma_eposta='" + firma.getFirmaEposta + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    giris = false;
                    MessageBox.Show(Localization.firmaKayitli);
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
        public void ResimGuncelle(string resim, Label label)
        {
            string sorgu = "update firma_resim set firma_resim='" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(resim) + "' where firma_id='" + Firma.firmaID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;
            reader = komut.ExecuteReader();
            label.Text =Localization.guncelBasari;
            veritabaniYonetici.CloseConnection();
        }
    }
}
