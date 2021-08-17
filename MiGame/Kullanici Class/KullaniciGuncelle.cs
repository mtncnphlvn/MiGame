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
    class KullaniciGuncelle
    {
        public void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
        public void KullaniciAdiDegis(TextBox textBox)
        {
            en();
            string sorgu = "update kullanici set kul_kulad='" + textBox.Text + "' where kul_id = '" + Kullanici.kullaniciID + "'";
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
        public void SifreDegis(TextBox textBox)
        {
            string sorgu = "update kullanici set kul_sifre='" + textBox.Text + "' where kul_id = '" + Kullanici.kullaniciID + "'";
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
        public void ResimDegis(TextBox textBox)
        {
            string sorgu = "update kullanici_resim set kul_resim='" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(textBox.Text) + "' where kul_id='" + Kullanici.kullaniciID + "'";
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
        public void HesapSil()
        {
            en();
            string sorgu = "delete from kullanici where kul_id='" + Kullanici.kullaniciID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show(Localization.bb);
            }
            else
            {
                MessageBox.Show(Localization.hatavar);

            }
            veritabaniYonetici.CloseConnection();
        }
    }
}
