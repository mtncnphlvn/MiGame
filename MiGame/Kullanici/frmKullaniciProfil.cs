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
    public partial class frmKullaniciProfil : Form
    {
        public frmKullaniciProfil()
        {
            InitializeComponent();
        }
        public frmKullaniciAnasayfa frmKullaniciAnasayfa;

        Kontrol kontrol = new Kontrol();

        private void txtKulAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.KullaniciHarf(e);

        }
        public void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }

        private void txtKulAd_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtKulAd, 0, 5, lblBos);
            kontrol.KullaniciAdiKontrol(txtKulAd, lblBos);
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtSifre, 0, 8, lblBos);
        }
        KullaniciGuncelle kullaniciGuncelle = new KullaniciGuncelle();
        private void btnAdGuncelle_Click(object sender, EventArgs e)
        {
            en();
            if (kontrol.KarakterKontrol(txtKulAd, 0, 5, lblBos) == true && !string.IsNullOrEmpty(txtKulAd.Text))
            {
                kullaniciGuncelle.KullaniciAdiDegis(txtKulAd);
                frmKullaniciAnasayfa.KullaniciBilgi();
                txtKulAd.Text = "";
            }
            else
            {
                MessageBox.Show(Localization.guncelBasarisiz);
            }
        }

        private void frmKullaniciProfil_Load(object sender, EventArgs e)
        {
            en();
            btnAdGuncelle.Text = Localization.güncelle;
            btnSifreGuncelle.Text = Localization.güncelle;
            btnResimGuncelle.Text = Localization.güncelle;
            label1.Text = Localization.kullanici;
            label7.Text = Localization.g3;
            label11.Text = Localization.oyunResim;
            btnSil.Text = Localization.hesapSil;
            label12.Text = Localization.hesap;
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (kontrol.KarakterKontrol(txtSifre, 0, 8, lblBos) == true && !string.IsNullOrEmpty(txtSifre.Text) && txtSifre.Text == txtSifreTekrar.Text)
            {
                kullaniciGuncelle.SifreDegis(txtSifre);
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
            }
            else
            {
                MessageBox.Show(Localization.guncelBasarisiz);
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;* |  Tüm Dosyalar |*.*";
            resim.ShowDialog();
            txtResimYolu.Text = resim.FileName;
        }

        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResimYolu.Text))
            {
                kullaniciGuncelle.ResimDegis(txtResimYolu);
                frmKullaniciAnasayfa.KullaniciBilgi();
                txtResimYolu.Text = "";
            }
            else
            {
                MessageBox.Show(Localization.guncelBasarisiz);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kullaniciGuncelle.HesapSil();
            Application.Exit();
        }
    }
}
