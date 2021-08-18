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
using MySql.Data.MySqlClient;

namespace MiGame
{
    public partial class frmKullaniciAnasayfa : Form
    {
        public frmKullaniciAnasayfa()
        {
            InitializeComponent();
        }
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        private void FormGetir(Form frm)
        {
            pnlSag.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlSag.Controls.Add(frm);
            frm.Show();
        }
        public void KullaniciBilgi()
        {
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
            try
            {
                MySqlCommand komut = new MySqlCommand("select kullanici.kul_kulad,SUM(kullanici_bakiye.kul_bakiye),kullanici_resim.kul_resim from kullanici inner join kullanici_bakiye on kullanici.kul_id = kullanici_bakiye.kul_id inner join kullanici_resim on kullanici.kul_id = kullanici_resim.kul_id where kullanici.kul_id = '" + Kullanici.kullaniciID + "'", veritabaniYonetici.OpenConnection());

                MySqlDataReader reader;
                reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    lblKulAd.Text = Convert.ToString(reader[0]);
                    lblBakiye.Text = Convert.ToString(reader[1]) + " " +Localization.paraisaret;
                    pbResim.ImageLocation = Convert.ToString(reader[2]);
                }
                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " :", ex.Message);
            }

        }
        private void frmKullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            en();
            KullaniciBilgi();
            frmKullaniciOyunListele frmKullaniciOyunListele = new frmKullaniciOyunListele();
            FormGetir(frmKullaniciOyunListele);
            frmKullaniciOyunListele.frmKullaniciAnasayfa = this;


            linkBakiye.Text = Localization.bakiyeYukle;
            btnAnasayfa.Text = Localization.anasayfa;
            btnKutuphane.Text = Localization.kutuphane;
            btnGoruslerim.Text = Localization.goruslerim;
            btnProfil.Text = Localization.profil;
        }

        private void btnAnasayfa_MouseHover(object sender, EventArgs e)
        {
            btnAnasayfa.BackgroundImage = Properties.Resources.arayuz_buton_over;
        }
        private void btnOyunEkle_MouseHover(object sender, EventArgs e)
        {
            btnGoruslerim.BackgroundImage = Properties.Resources.arayuz_buton_over;
        }
        private void btnProfil_MouseHover(object sender, EventArgs e)
        {
            btnProfil.BackgroundImage = Properties.Resources.arayuz_buton_over;
        }
        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            btnAnasayfa.BackgroundImage = Properties.Resources.arayuz_buton;
        }
        private void btnProfil_MouseLeave(object sender, EventArgs e)
        {
            btnProfil.BackgroundImage = Properties.Resources.arayuz_buton;
        }

        private void btnGoruslerim_MouseHover(object sender, EventArgs e)
        {
            btnGoruslerim.BackgroundImage = Properties.Resources.arayuz_buton_over;
        }

        private void btnGoruslerim_MouseLeave(object sender, EventArgs e)
        {
            btnGoruslerim.BackgroundImage = Properties.Resources.arayuz_buton;
        }

        private void btnKutuphane_MouseHover(object sender, EventArgs e)
        {
            btnKutuphane.BackgroundImage = Properties.Resources.arayuz_buton_over;
        }

        private void btnKutuphane_MouseLeave(object sender, EventArgs e)
        {
            btnKutuphane.BackgroundImage = Properties.Resources.arayuz_buton;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmKullaniciOyunListele frmKullaniciOyunListele = new frmKullaniciOyunListele();
            FormGetir(frmKullaniciOyunListele);
        }

        private void btnKutuphane_Click(object sender, EventArgs e)
        {
            frmKullaniciKutuphane frmKullaniciKutuphane = new frmKullaniciKutuphane();
            FormGetir(frmKullaniciKutuphane);
        }

        private void btnGoruslerim_Click(object sender, EventArgs e)
        {
            frmKullaniciGoruslerim frmKullaniciGoruslerim = new frmKullaniciGoruslerim();
            FormGetir(frmKullaniciGoruslerim);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmKullaniciProfil frmKullaniciProfil = new frmKullaniciProfil();
            FormGetir(frmKullaniciProfil);
            frmKullaniciProfil.frmKullaniciAnasayfa = this;

        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarpi_MouseHover(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.cross_over;
        }

        private void btnCarpi_MouseLeave(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.cross;

        }

        private void linkBakiye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciYonetici kullaniciYonetici = new KullaniciYonetici();
            kullaniciYonetici.BakiyeEkle();
            KullaniciBilgi();
        }
    }
}
