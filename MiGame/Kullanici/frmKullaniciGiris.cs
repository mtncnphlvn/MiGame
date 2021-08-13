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
            btnGiris.Text = Localization.g4;
            txtEposta.Text = Localization.posta;
            txtSifre.Text = Localization.g3;
            lblEpostaUyari.Text = "";
            lblSifreUyari.Text = "";
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
            if (string.IsNullOrEmpty(txtEposta.Text) || txtEposta.Text == Localization.posta)
            {
                lblEpostaUyari.Text = Localization.bos;
            }
            else if (string.IsNullOrEmpty(txtSifre.Text) || txtSifre.Text == Localization.g3)
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
        Kontrol kontrol = new Kontrol();
        TextDoldur textDoldur = new TextDoldur();

        private void txtEposta_TextChanged(object sender, EventArgs e)
        {
            kontrol.Giris(txtEposta, lblEpostaUyari, "");
        }

        private void txtEposta_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtEposta, Localization.posta);
        }

        private void txtEposta_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtEposta, Localization.posta);
        }

        private void txtEposta_TextChanged_1(object sender, EventArgs e)
        {
            kontrol.Giris(txtEposta, lblEpostaUyari, Localization.posta);

        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            textDoldur.SifreEnter(txtSifre, Localization.g3);
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            textDoldur.SifreLeave(txtSifre, Localization.g3);
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            kontrol.Giris(txtSifre, lblSifreUyari, Localization.g3);
        }
    }
}
