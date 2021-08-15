using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiGame
{
    class Oyun
    {
        public static int oyunID;
        private string oyunAdi;
        private string oyunKonusu;
        private int oyunKategori;
        private int oyunFiyat;
        private string oyunResim;

        public string getOyunAdi
        {
            get { return oyunAdi; }
            set { oyunAdi = value; }
        }
        public string getOyunKonusu
        {
            get { return oyunKonusu; }
            set { oyunKonusu = value; }
        }
        public int getOyunKategori
        {
            get { return oyunKategori; }
            set { oyunKategori = value; }
        }
        public int getOyunFiyat
        {
            get { return oyunFiyat; }
            set { oyunFiyat = value; }
        }
        public string getOyunResim
        {
            get { return oyunResim; }
            set { oyunResim = value; }
        }
    }
}
