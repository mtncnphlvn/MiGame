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
    public partial class frmKullaniciKayit : Form
    {
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void frmKullaniciKayit_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmKullaniciKayit_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void frmKullaniciKayit_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
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
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        private void Cinsiyet(ComboBox combobox)
        {
            en();
            txtAd.Text = Localization.ad;
            txtSoyad.Text = Localization.soyad;
            txtEposta.Text = Localization.posta;



            combobox.Items.Add(Localization.cinsiyet);
            combobox.Items.Add(Localization.kadin);
            combobox.Items.Add(Localization.erkek);
            combobox.SelectedIndex = 0;
        }
        Tarih tarih = new Tarih();
        private void frmKullaniciKayit_Load(object sender, EventArgs e)
        {
            Cinsiyet(cmbCinsiyet);
            tarih.Ay(cmbAy);  // Ay Listeler                    
            tarih.Yil(cmbYil); // Yıl Listeler
            cmbGun.ForeColor = System.Drawing.Color.FromArgb(114, 20, 126);
            cmbAy.ForeColor = System.Drawing.Color.FromArgb(114, 20, 126);
            cmbYil.ForeColor = System.Drawing.Color.FromArgb(114, 20, 126);
            cmbCinsiyet.ForeColor = System.Drawing.Color.FromArgb(114, 20, 126);
        }
        private void cmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTarihUyari.Text = "";
        }
        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarih.Gun(cmbGun, cmbAy); // Ay'a göre gün listeler
            lblTarihUyari.Text = "";
        }
        private void cmbYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTarihUyari.Text = "";
        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCinsiyet.SelectedIndex != 0)
            {
                lblCinsiyetUyari.Text = "";
            }
        }
        Kontrol kontrol = new Kontrol();
        TextDoldur textDoldur = new TextDoldur();
        private void txtAd_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtAd, Localization.ad);
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtAd, Localization.ad);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.HarfGir(e);
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtAd, 0, 2, lblAdUyari);
        }

        private void txtSoyad_Enter(object sender, EventArgs e)
        {

            textDoldur.TextEnter(txtSoyad, Localization.soyad);
        }

        private void txtSoyad_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtSoyad, Localization.soyad);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.HarfGir(e);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtAd, 0, 2, lblSoyadUyari);
        }

        private void txtEposta_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtEposta, Localization.posta);
        }

        private void txtEposta_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtEposta, Localization.posta);
        }

        private void txtEposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.EpostaHarf(e);
        }
    }
}
