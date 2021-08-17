using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace MiGame
{
    class KullaniciYorum
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        public void Yorumlar(DataGridView dataGridView)
        {
            en();
            try
            {
                string sorgu = "select kullanici.kul_kulad as KullanıcıAdı, oyun.oyun_adi as OyunAdı, goruslerim.mesaj as Mesaj from goruslerim inner join kullanici on goruslerim.kul_id = kullanici.kul_id inner join oyun on goruslerim.oyun_id = oyun.oyun_id inner join firma on oyun.firma_id = firma.firma_id where firma.firma_id ='" + Firma.firmaID + "'";
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
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " : " + ex.Message);
            }
        }
        public void PuanVer(int puan)
        {
            en();
            try
            {
                string sorgu = "insert into puan(kul_id, oyun_id, puan) values('" + Kullanici.kullaniciID + "','" + Oyun.oyunID + "','" + puan + "')";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                object sonuc = komut.ExecuteReader();
                if (sonuc != null)
                {
                    MessageBox.Show(Localization.puanEklendi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " : " + ex.Message);
            }
        }
        public bool YorumEkle(string mesaj)
        {
            bool durum = false;
            try
            {
                string sorgu = "insert into goruslerim(kul_id, oyun_id, mesaj) values('" + Kullanici.kullaniciID + "','" + Oyun.oyunID + "','" + mesaj + "')";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                object sonuc = komut.ExecuteReader();
                if (sonuc != null)
                {
                    durum = true;
                    MessageBox.Show(Localization.yorumEklendi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " : " + ex.Message);
            }
            return durum;
        }
        public void YorumlarKullanici(DataGridView dataGridView)
        {
            try
            {
                string sorgu = "select kullanici.kul_kulad as KullanıcıAdı, oyun.oyun_adi as OyunAdı, goruslerim.mesaj as Mesaj from goruslerim inner join kullanici on goruslerim.kul_id = kullanici.kul_id inner join oyun on goruslerim.oyun_id = oyun.oyun_id inner join firma on oyun.firma_id = firma.firma_id where kullanici.kul_id ='" + Kullanici.kullaniciID + "'";
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
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " : " + ex.Message);
            }
        }
    }
}
