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
    public partial class frmGirisSecim : Form
    {
        public frmGirisSecim()
        {
            InitializeComponent();
        }

        private void btnKullaniciGiris_MouseHover(object sender, EventArgs e)
        {
            btnKullaniciGiris.BackgroundImage = Properties.Resources.giris_buton_over;
        }

        private void btnKullaniciGiris_MouseLeave(object sender, EventArgs e)
        {
            btnKullaniciGiris.BackgroundImage = Properties.Resources.giris_buton;
        }

        private void btnKullaniciKayıt_MouseHover(object sender, EventArgs e)
        {
            btnKullaniciKayıt.BackgroundImage = Properties.Resources.giris_buton_over;
        }

        private void btnKullaniciKayıt_MouseLeave(object sender, EventArgs e)
        {
            btnKullaniciKayıt.BackgroundImage = Properties.Resources.giris_buton;
        }

        private void btnFirmaGiris_MouseHover(object sender, EventArgs e)
        {
            btnFirmaGiris.BackgroundImage = Properties.Resources.giris_buton_over;
        }

        private void btnFirmaGiris_MouseLeave(object sender, EventArgs e)
        {
            btnFirmaGiris.BackgroundImage = Properties.Resources.giris_buton;
        }

        private void btnFirmaKayit_MouseHover(object sender, EventArgs e)
        {
            btnFirmaKayit.BackgroundImage = Properties.Resources.giris_buton_over;
        }

        private void btnFirmaKayit_MouseLeave(object sender, EventArgs e)
        {
            btnFirmaKayit.BackgroundImage = Properties.Resources.giris_buton;
        }

        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {
            btnAdmin.BackgroundImage = Properties.Resources.giris_buton_over;
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAdmin.BackgroundImage = Properties.Resources.giris_buton_over;
        }

        private void btnCarpi_MouseHover(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.giris_buton_over;
        }
        private void btnCarpi_MouseLeave(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.giris_buton;
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            frmKullaniciGiris frmKullaniciGiris = new frmKullaniciGiris();
            frmKullaniciGiris.Show();
            this.Hide();
        }

        private void btnKullaniciKayıt_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit frmKullaniciKayit = new frmKullaniciKayit();
            frmKullaniciKayit.Show();
            this.Hide();
        }

        private void btnFirmaGiris_Click(object sender, EventArgs e)
        {
            frmFirmaGiris frmFirmaGiris = new frmFirmaGiris();
            frmFirmaGiris.Show();
            this.Hide();
        }

        private void btnFirmaKayit_Click(object sender, EventArgs e)
        {
            frmFirmaKayit frmFirmaKayit = new frmFirmaKayit();
            frmFirmaKayit.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdminGiris frmAdminGiris = new frmAdminGiris();
            frmAdminGiris.Show();
            this.Hide();
        }

        private void frmGirisSecim_Load(object sender, EventArgs e)
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            btnKullaniciGiris.Text = Localization.kullaniciGiris;
            btnKullaniciKayıt.Text = Localization.kullaniciKayit;
            btnFirmaGiris.Text = Localization.firmaGiris;
            btnFirmaKayit.Text = Localization.firmaKayit;
            btnAdmin.Text = Localization.adminGiris;
        }
    }
}
