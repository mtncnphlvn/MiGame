using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MiGame
{
    class KullaniciYorum
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();

        public void Yorumlar(DataGridView dataGridView)
        {
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
                MessageBox.Show("Hata Mesajı : " + ex.Message);
            }
        }
    }
}
