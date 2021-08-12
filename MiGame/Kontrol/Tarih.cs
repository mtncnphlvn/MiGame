using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiGame
{
    class Tarih
    {
        public void Gun(ComboBox comboBoxGun, ComboBox comboBoxAy)
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }

            if (comboBoxAy.Text == Localization.ay4 || comboBoxAy.Text == Localization.ay6 || comboBoxAy.Text == Localization.ay9 || comboBoxAy.Text == Localization.ay11)
            {
                comboBoxGun.Items.Clear();
                comboBoxGun.Items.Add(Localization.gun);
                for (int gun = 1; gun <= 30; gun++)
                {
                    comboBoxGun.Items.Add(gun);
                }
            }
            else if (comboBoxAy.Text == Localization.ay2)
            {
                comboBoxGun.Items.Clear();
                comboBoxGun.Items.Add(Localization.gun);
                for (int gun = 1; gun <= 29; gun++)
                {
                    comboBoxGun.Items.Add(gun);
                }
            }
            else
            {
                comboBoxGun.Items.Clear();
                comboBoxGun.Items.Add(Localization.gun);
                for (int gun = 1; gun <= 31; gun++)
                {
                    comboBoxGun.Items.Add(gun);
                }
            }
            comboBoxGun.SelectedIndex = 0;
        }
        public void Ay(ComboBox comboBox)
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }

            string[] aylar = new string[13];
            aylar[0] = Localization.ay;
            aylar[1] = Localization.ay1;
            aylar[2] = Localization.ay2;
            aylar[3] = Localization.ay3;
            aylar[4] = Localization.ay4;
            aylar[5] = Localization.ay5;
            aylar[6] = Localization.ay6;
            aylar[7] = Localization.ay7;
            aylar[8] = Localization.ay8;
            aylar[9] = Localization.ay9;
            aylar[10] = Localization.ay10;
            aylar[11] = Localization.ay11;
            aylar[12] = Localization.ay12;

            foreach (string ay in aylar)
            {
                comboBox.Items.Add(ay);
            }
            comboBox.SelectedIndex = 0;
        }
        public void Yil(ComboBox comboBox)
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            int yil = DateTime.Now.Year;
            comboBox.Items.Add(Localization.yil);
            for (int i = yil - 18; i >= 1920; i--)
            {
                comboBox.Items.Add(i);
            }
            comboBox.SelectedIndex = 0;
        }
       

        public string AyCevirme(string ay)
        {
            
            string aySayi = "";

            switch (ay)
            {
                case "Ocak":
                    aySayi = "01";
                    break;
                case "Şubat":
                    aySayi = "02";
                    break;
                case "Mart":
                    aySayi = "03";
                    break;
                case "Nisan":
                    aySayi = "04";
                    break;
                case "Mayıs":
                    aySayi = "05";
                    break;
                case "Haziran":
                    aySayi = "06";
                    break;
                case "Temmuz":
                    aySayi = "07";
                    break;
                case "Ağustos":
                    aySayi = "08";
                    break;
                case "Eylül":
                    aySayi = "09";
                    break;
                case "Ekim":
                    aySayi = "10";
                    break;
                case "Kasım":
                    aySayi = "11";
                    break;
                case "Aralık":
                    aySayi = "12";
                    break;
            }

            return aySayi;
        }
        public string AyCevirmeEn(string ay)
        {

            string aySayi = "";

            switch (ay)
            {
                case "January":
                    aySayi = "01";
                    break;
                case "February":
                    aySayi = "02";
                    break;
                case "March":
                    aySayi = "03";
                    break;
                case "April":
                    aySayi = "04";
                    break;
                case "May":
                    aySayi = "05";
                    break;
                case "June":
                    aySayi = "06";
                    break;
                case "July":
                    aySayi = "07";
                    break;
                case "August":
                    aySayi = "08";
                    break;
                case "September":
                    aySayi = "09";
                    break;
                case "October":
                    aySayi = "10";
                    break;
                case "November":
                    aySayi = "11";
                    break;
                case "December":
                    aySayi = "12";
                    break;
            }

            return aySayi;
        }
        public string GunCevirme(string gun)
        {
            string gunSayi = "";

            switch (gun)
            {
                case "1":
                    gunSayi = "01";
                    break;
                case "2":
                    gunSayi = "02";
                    break;
                case "3":
                    gunSayi = "03";
                    break;
                case "4":
                    gunSayi = "04";
                    break;
                case "5":
                    gunSayi = "05";
                    break;
                case "6":
                    gunSayi = "06";
                    break;
                case "7":
                    gunSayi = "07";
                    break;
                case "8":
                    gunSayi = "08";
                    break;
                case "9":
                    gunSayi = "09";
                    break;
                default:
                    gunSayi = gun;
                    break;

            }

            return gunSayi;
        }
    }
}
