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
    public partial class frmFirmaAnasayfa : Form
    {
        public frmFirmaAnasayfa()
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
        public void FirmaBilgi()
        {
            en();
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
            
            try
            {
                MySqlCommand komut = new MySqlCommand("select firma.firma_ad,SUM(firma_bakiye.firma_bakiye),firma_resim.firma_resim from firma inner join firma_bakiye on firma.firma_id = firma_bakiye.firma_id inner join firma_resim on firma.firma_id = firma_resim.firma_id where firma.firma_id = '" + Firma.firmaID + "'", veritabaniYonetici.OpenConnection());

                MySqlDataReader reader;
                reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    lblKulAd.Text = Convert.ToString(reader[0]);
                    lblBakiye.Text = Convert.ToString(reader[1]) + " " + Localization.paraisaret;
                    pbResim.ImageLocation = Convert.ToString(reader[2]);
                }
                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hata + " :" , ex.Message);
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

        private void frmFirmaAnasayfa_Load(object sender, EventArgs e)
        {
            en();
            frmFirmaOyunListele frmFirmaOyunListele = new frmFirmaOyunListele();
            FirmaBilgi();
            FormGetir(frmFirmaOyunListele);

            btnAnasayfa.Text = Localization.anasayfa;
            btnOyunlarim.Text = Localization.oyunlarim;
            btnOyunEkle.Text = Localization.oyunEkle;
            btnProfil.Text = Localization.profil;

        }

        private void btnAnasayfa_MouseHover(object sender, EventArgs e)
        {
            btnAnasayfa.BackgroundImage = Properties.Resources.arayuz_buton_over;
        }
        private void btnOyunlarim_MouseHover(object sender, EventArgs e)
        {
            btnOyunlarim.BackgroundImage = Properties.Resources.arayuz_buton_over;
        }
        private void btnOyunEkle_MouseHover(object sender, EventArgs e)
        {
            btnOyunEkle.BackgroundImage = Properties.Resources.arayuz_buton_over;
        }
        private void btnProfil_MouseHover(object sender, EventArgs e)
        {
            btnProfil.BackgroundImage = Properties.Resources.arayuz_buton_over;
        }

        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            btnAnasayfa.BackgroundImage = Properties.Resources.arayuz_buton;
        }

        private void btnOyunlarim_MouseLeave(object sender, EventArgs e)
        {
            btnOyunlarim.BackgroundImage = Properties.Resources.arayuz_buton;
        }

        private void btnOyunEkle_MouseLeave(object sender, EventArgs e)
        {
            btnOyunEkle.BackgroundImage = Properties.Resources.arayuz_buton;
        }

        private void btnProfil_MouseLeave(object sender, EventArgs e)
        {
            btnProfil.BackgroundImage = Properties.Resources.arayuz_buton;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmFirmaOyunListele frmFirmaOyunListele = new frmFirmaOyunListele();
            FirmaBilgi();
            FormGetir(frmFirmaOyunListele);
        }

        private void btnOyunlarim_Click(object sender, EventArgs e)
        {
            frmFirmaOyunlarim frmFirmaOyunlarim = new frmFirmaOyunlarim();
            FirmaBilgi();
            FormGetir(frmFirmaOyunlarim);
        }

        private void btnOyunEkle_Click(object sender, EventArgs e)
        {
            frmFirmaOyunEkle frmFirmaOyunEkle = new frmFirmaOyunEkle();
            FirmaBilgi();
            FormGetir(frmFirmaOyunEkle);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmFirmaProfil frmFirmaProfil = new frmFirmaProfil();
            FirmaBilgi();
            FormGetir(frmFirmaProfil);
        }
    }
}
