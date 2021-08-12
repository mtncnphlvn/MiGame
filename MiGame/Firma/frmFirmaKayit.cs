using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiGame
{
    public partial class frmFirmaKayit : Form
    {
        public frmFirmaKayit()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void frmFirmaKayit_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmFirmaKayit_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void frmFirmaKayit_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        private void temizle()
        {
            lblFirmaAdUyari.Text = "";
            lblCeoUyari.Text = "";
            lblEpostaUyari.Text = "";
            lblGuvenlikUyari.Text = "";
            lblSifreUyari.Text = "";
            lblSifreTekrarUyari.Text = "";
        }
        private void frmFirmaKayit_Load(object sender, EventArgs e)
        {
            temizle();
            en();

            lblKayit.Text = Localization.kayit;
            txtFirmaAd.Text = Localization.fad;
            txtCeo.Text = Localization.ceo;
            txtPosta.Text = Localization.posta;
            txtGuvenlik.Text = Localization.kod;           
            txtSifre.Text = Localization.pass;
            txtSifreTekrar.Text = Localization.passagain;
            btnKayitOl.Text = Localization.kayit;
            btnKod.Text = Localization.kod2;

        }
        private void btnKod_MouseHover(object sender, EventArgs e)
        {
            btnKod.BackgroundImage = Properties.Resources.buton_giris_over;
        }
        private void btnKod_MouseLeave(object sender, EventArgs e)
        {
            btnKod.BackgroundImage = Properties.Resources.buton_giris;
        }
        private void btnCarpi_MouseHover(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.cross_over;
        }
        private void btnCarpi_MouseLeave(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.cross;
        }
        private void btnKayitOl_MouseHover(object sender, EventArgs e)
        {
            btnKayitOl.BackgroundImage = Properties.Resources.buton_giris_over;
        }
        private void btnKayitOl_MouseLeave(object sender, EventArgs e)
        {
            btnKayitOl.BackgroundImage = Properties.Resources.buton_giris;
        }
        private void btnCarpi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Kontrol kontrol = new Kontrol();
        TextDoldur textDoldur = new TextDoldur();
        private void txtFirmaAd_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtFirmaAd, Localization.fad);
        }
        private void txtFirmaAd_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtFirmaAd, Localization.fad);
        }
        private void txtFirmaAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.HarfGir(e);
        }
        private void txtFirmaAd_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtFirmaAd, 0, 2, lblFirmaAdUyari);
        }
        private void txtCeo_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtCeo, Localization.ceo);
        }
        private void txtCeo_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtCeo, Localization.ceo);
        }
        private void txtCeo_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.HarfGir(e);
        }
        private void txtCeo_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtCeo, 0, 2, lblCeoUyari);
        }
        private void txtPosta_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtPosta, Localization.posta);
        }
        private void txtPosta_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtPosta, Localization.posta);
        }
        private void txtPosta_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.EpostaHarf(e);
        }
        private void txtPosta_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtPosta, 0, 2, lblEpostaUyari);
        }
        private void txtGuvenlik_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtGuvenlik, Localization.kod);
        }
        private void txtGuvenlik_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtGuvenlik, Localization.kod);
        }
        private void txtGuvenlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.KullaniciHarf(e);
        }
        private void txtGuvenlik_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtGuvenlik, 0, 2, lblGuvenlikUyari);
        }
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            textDoldur.SifreEnter(txtSifre, Localization.pass);
        }
        private void txtSifre_Leave(object sender, EventArgs e)
        {
            textDoldur.SifreLeave(txtSifre, Localization.pass);
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtSifre, 0, 8, lblSifreUyari);
        }
        private void txtSifreTekrar_Enter(object sender, EventArgs e)
        {
            textDoldur.SifreEnter(txtSifreTekrar, Localization.passagain);
        }
        private void txtSifreTekrar_Leave(object sender, EventArgs e)
        {
            textDoldur.SifreLeave(txtSifreTekrar, Localization.passagain);
        }
        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtSifreTekrar, 0, 8, lblSifreTekrarUyari);
        }
        Random rnd = new Random();
        string onayKodu;
        private void btnKod_Click(object sender, EventArgs e)
        {
            en();
            if (string.IsNullOrEmpty(txtPosta.Text) || txtPosta.Text == Localization.posta)
            {
                lblEpostaUyari.Text = Localization.bos;
            }
            else if (kontrol.KarakterKontrol(txtCeo, 0, 4, lblCeoUyari) == false || txtCeo.Text == Localization.kullanici)
            {
                if (string.IsNullOrEmpty(txtCeo.Text) || txtCeo.Text == Localization.kullanici)
                {
                    lblCeoUyari.Text = Localization.bos;
                }
            }
            else if (kontrol.KullaniciAdiKontrol(txtCeo, lblCeoUyari) == false)
            {
                lblCeoUyari.Text = Localization.hgir;
            }
            else
            {
                onayKodu = rnd.Next(100, 999).ToString();
                MailMessage mesajim = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new NetworkCredential("stajproje@hotmail.com", "qweasdzxc123");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                mesajim.To.Add(txtPosta.Text);
                mesajim.From = new MailAddress("stajproje@hotmail.com");
                mesajim.Subject = Localization.guvenonay;
                mesajim.Body = Localization.sev + " " + txtCeo.Text + " " + Localization.kod + " : " + onayKodu;
                istemci.Send(mesajim);
                lblGuvenlikUyari.Text = Localization.kod3;

            }
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (kontrol.KarakterKontrol(txtFirmaAd, 0, 2, lblFirmaAdUyari) == false || txtFirmaAd.Text == Localization.fad)
            {
                if (string.IsNullOrEmpty(txtFirmaAd.Text) || txtFirmaAd.Text == Localization.fad)
                {
                    lblFirmaAdUyari.Text = Localization.bos;
                }
            }
            else if (kontrol.KarakterKontrol(txtCeo, 0, 2, lblCeoUyari) == false || txtCeo.Text == Localization.ceo)
            {
                if (string.IsNullOrEmpty(txtCeo.Text) || txtCeo.Text == Localization.ceo)
                {
                    lblCeoUyari.Text = Localization.bos;
                }
            }
            else if (string.IsNullOrEmpty(txtPosta.Text) || txtPosta.Text == Localization.posta)
            {
                lblEpostaUyari.Text = Localization.bos;
            }
            else if (string.IsNullOrEmpty(txtGuvenlik.Text) || txtGuvenlik.Text == Localization.kod)
            {
                lblGuvenlikUyari.Text = Localization.bos;
            }
            else if (txtGuvenlik.Text != onayKodu)
            {
                lblGuvenlikUyari.Text = Localization.kodhata;
            }
            else if (kontrol.KarakterKontrol(txtSifre, 0, 8, lblSifreUyari) == false || txtSifre.Text == Localization.pass)
            {
                if (string.IsNullOrEmpty(txtSifre.Text) || txtSifre.Text == Localization.pass)
                {
                    lblSifreUyari.Text = Localization.bos;
                }
            }
            else if (txtSifre.Text != txtSifreTekrar.Text)
            {
                lblSifreUyari.Text = Localization.passes;
            }
            else
            {
                //----------------------------------------------------------------------------
            }
      
        }

     
    }
}
