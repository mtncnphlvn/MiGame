using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiGame
{
    class Kontrol
    {
   

        //------------------------------------------------------- HARF SAYI KONTROL ------------------------------------------------------------------
        public void HarfGir(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        public void SayiGir(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void OyunOzel(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ';
        }
        public void KullaniciHarf(KeyPressEventArgs e)//Kullanici Adi Özel
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_';
        }
        public void EpostaHarf(KeyPressEventArgs e)//E-Posta Özel
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@' && e.KeyChar != '-' && e.KeyChar != '_';
        }

        //------------------------------------------------------- KARAKTER KONTROL ------------------------------------------------------------------
        public bool KarakterKontrol(TextBox textBox, int x, int y, Label label)
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            bool sonuc = false;

            if (textBox.Text.Length > x && textBox.Text.Length < y)
            {
                label.Text = Localization.eksik1;
            }
            else
            {
                label.Text = "";
                sonuc = true;
            }
            return sonuc;
        }
     
        //-------------------------------------------------------------------------------------------------------------
        public bool KullaniciAdiKontrol(TextBox textBox, Label label)
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }

            bool sonuc = false;
            var m = Regex.Match(textBox.Text, @"((?=.*[a-z]))");
            if (!string.IsNullOrEmpty(textBox.Text) && !m.Success)
            {
                label.Text = Localization.hgir;
                sonuc = false;
            }
            else
            {
                sonuc = true;
            }
            return sonuc;
        }
        public void Giris(TextBox textBox, Label label, string yazi)
        {
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == yazi)
            {
                label.Text = "";
            }
        }
    }
}
