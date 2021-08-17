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
    class AdminYonetici
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();

        public bool Giris(Admin admin)
        {
            en();
            bool giris = false;
            try
            {
                string sorgu = "select * from admin where admin_ad='" + admin.getAdmin + "'and admin_sifre='" + admin.getSifre + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    giris = true;
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




        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        public void AdminOyunListeleOnayli(DataGridView dataGridView)
        {
            string sorgu = "select * from oyun where oyun_durum = 1";
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
        public void AdminOyunListeleOnaysiz(DataGridView dataGridView)
        {
            string sorgu = "select * from oyun where oyun_durum = 0";
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
        public void OyunOnayla()
        {
            en();
            string sorgu = "update oyun set oyun_durum = 1 where oyun_id = '" + Oyun.oyunID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show(Localization.guncelBasari);
            }
            else
            {
                MessageBox.Show(Localization.guncelBasarisiz);

            }
            veritabaniYonetici.CloseConnection();
        }
        public void OyunOnaylama()
        {
            en();
            string sorgu = "update oyun set oyun_durum = 0 where oyun_id = '" + Oyun.oyunID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show(Localization.guncelBasari);
            }
            else
            {
                MessageBox.Show(Localization.guncelBasarisiz);

            }
            veritabaniYonetici.CloseConnection();
        }
        public void FirmaListele(DataGridView dataGridView)
        {
            string sorgu = "select * from firma";
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
        public void FirmaSil()
        {
            en();
            string sorgu = "delete from firma where firma_id='" + Firma.firmaID+ "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show(Localization.silindi);
            }
            else
            {
                MessageBox.Show(Localization.silinemedi);

            }
            veritabaniYonetici.CloseConnection();
        }
        public void KullaniciListele(DataGridView dataGridView)
        {
            string sorgu = "select * from kullanici";
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
        public void KullaniciSil()
        {
            en();
            string sorgu = "delete from kullanici where kul_id='" + Kullanici.kullaniciID+ "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show(Localization.silindi);
            }
            else
            {
                MessageBox.Show(Localization.silinemedi);

            }
            veritabaniYonetici.CloseConnection();
        }
    }
}
