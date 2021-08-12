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
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void frmKullaniciGiris_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmKullaniciGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void frmKullaniciGiris_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void yazdir()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            lblGiris.Text = Localization.g1;
            lblEposta.Text = Localization.g2;
            lblSifre.Text = Localization.g3;
            btnGiris.Text = Localization.g4;
        }

        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackgroundImage = Properties.Resources.buton_giris_over;
            btnGiris.ForeColor = System.Drawing.Color.FromArgb(249, 228, 0);
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackgroundImage = Properties.Resources.buton_giris;
            btnGiris.ForeColor = System.Drawing.Color.FromArgb(114, 20, 126);
        }

        private void btnCarpi_MouseHover(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.cross_over;
        }

        private void btnCarpi_MouseLeave(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.cross;
        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {
            yazdir();
            lblEpostaUyari.Text = "";
            lblSifreUyari.Text = "";
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEposta.Text))
            {
                lblEpostaUyari.Text = Localization.bos;
            }
            else if (!string.IsNullOrEmpty(txtEposta.Text))
            {
                lblEpostaUyari.Text = "";
            }
            else if (string.IsNullOrEmpty(txtSifre.Text))
            {
                lblSifreUyari.Text = Localization.bos;
            }
            else
            {
                Kullanici kullanici = new Kullanici();
                KullaniciYonetici kullaniciYonetici = new KullaniciYonetici();
                kullanici.getKullaniciEposta = txtEposta.Text;
                kullanici.getKullaniciSifre = txtSifre.Text;

                if (kullaniciYonetici.Giris(kullanici) == true)
                {

                }
            }
        }
    }
}
