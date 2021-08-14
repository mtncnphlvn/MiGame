using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiGame
{
    class Kullanici
    {
        public static int kullaniciID =2;
        private string kullaniciAdi;
        private string kullaniciSoyadi;
        private string kullaniciKulAdi;
        private string kullaniciEposta;
        private string kullaniciCinsiyet;
        private string kullaniciDogumTarih;
        private string kullaniciSifre;




        public string getKullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }
        public string getKullaniciSoyadi
        {
            get { return kullaniciSoyadi; }
            set { kullaniciSoyadi = value; }
        }
        public string getKullaniciKulAdi
        {
            get { return kullaniciKulAdi; }
            set { kullaniciKulAdi = value; }
        }
        public string getKullaniciEposta
        {
            get { return kullaniciEposta; }
            set { kullaniciEposta = value; }
        }
        public string getKullaniciCinsiyet
        {
            get { return kullaniciCinsiyet; }
            set { kullaniciCinsiyet = value; }
        }
        public string getKullaniciDogumTarih
        {
            get { return kullaniciDogumTarih; }
            set { kullaniciDogumTarih = value; }
        }
        public string getKullaniciSifre
        {
            get { return kullaniciSifre; }
            set { kullaniciSifre = value; }
        }
    }
}
