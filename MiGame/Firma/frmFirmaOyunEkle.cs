using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiGame
{
    public partial class frmFirmaOyunEkle : Form
    {
        public frmFirmaOyunEkle()
        {
            InitializeComponent();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;* |  Tüm Dosyalar |*.*";
            resim.ShowDialog();
            txtResimYolu.Text = resim.FileName;
            pbResim.ImageLocation = resim.FileName.ToString();
        }
        Kontrol kontrol = new Kontrol();
        private void txtOyunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.OyunOzel(e);
        }

        private void txtKonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.OyunOzel(e);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.SayiGir(e);
        }
        public void TextTemizle()
        {
            txtOyunAdi.Text = "";
            txtKonu.Text = "";
            cmbKategori.SelectedIndex = 0;
            txtFiyat.Text = "";
            txtResimYolu.Text = "";
            pbResim.ImageLocation = null;


        }
        public void LabelTemizle()
        {
            lblAdUyari.Text = "";
            lblKonuUyari.Text = "";
            lblKatUyari.Text = "";
            lblFiyatUyari.Text = "";
            lblResimUyari.Text = "";

        }
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        OyunYonetici oyunYonetici = new OyunYonetici();
        private void frmFirmaOyunEkle_Load(object sender, EventArgs e)
        {
            en();
            LabelTemizle();
            oyunYonetici.KategoriDoldur(cmbKategori);
            TextTemizle();
            lblOyunAdi.Text = Localization.oyunAdi;
            lblOyunKonu.Text = Localization.oyunKonu;
            lblKategori.Text = Localization.oyunKategori;
            lblFiyat.Text = Localization.oyunFiyat;
            lblResim.Text = Localization.oyunResim;
            btnOyunEkle.Text = Localization.oyunEkle;
        }

        private void btnOyunEkle_Click(object sender, EventArgs e)
        {
            LabelTemizle();
            if (string.IsNullOrEmpty(txtOyunAdi.Text))
            {
                lblAdUyari.Text = "!";
            }
            else if (string.IsNullOrEmpty(txtKonu.Text))
            {
                lblKonuUyari.Text = "!";
            }
            else if (cmbKategori.SelectedIndex == 0)
            {
                lblKatUyari.Text = "!";
            }
            else if (string.IsNullOrEmpty(txtFiyat.Text))
            {
                lblFiyatUyari.Text = "!";
            }
            else if (string.IsNullOrEmpty(txtResimYolu.Text))
            {
                lblResimUyari.Text = "!";
            }
            else
            {
                Oyun oyun = new Oyun();
                oyun.getOyunAdi = txtOyunAdi.Text;
                oyun.getOyunKonusu = txtKonu.Text;
                oyun.getOyunKategori = oyunYonetici.KategoriSec(cmbKategori);
                oyun.getOyunFiyat = Convert.ToInt32(txtFiyat.Text);
                oyun.getOyunResim = txtResimYolu.Text;

                oyunYonetici.OyunEkle(oyun);
                TextTemizle();
            }
        }

        private void btnOyunEkle_MouseHover(object sender, EventArgs e)
        {
            btnOyunEkle.BackgroundImage = Properties.Resources.buton_mor_over;
        }

        private void btnOyunEkle_MouseLeave(object sender, EventArgs e)
        {
            btnOyunEkle.BackgroundImage = Properties.Resources.buton_mor;
        }
    }
}
