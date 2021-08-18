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
    public partial class frmFirmaProfil : Form
    {
        public frmFirmaProfil()
        {
            InitializeComponent();
        }
        public frmFirmaAnasayfa frmAna;

        private void btnResimSec_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;* |  Tüm Dosyalar |*.*";
            resim.ShowDialog();
            txtResimYolu.Text = resim.FileName;
        }
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        private void frmFirmaProfil_Load(object sender, EventArgs e)
        {
            en();
            KullaniciYorum kullaniciYorum = new KullaniciYorum();
            kullaniciYorum.Yorumlar(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            btnGuncelle.Text = Localization.güncelle;
            lblGorusler.Text = Localization.goruslerim;
            lblResim.Text = Localization.oyunResim;
            btnDegis.Text = Localization.degis;
            lblDil.Text = Localization.d1;
        }

        private void btnKod_Click(object sender, EventArgs e)
        {
            if (txtResimYolu.Text != "")
            {
                FirmaYonetici firmaYonetici = new FirmaYonetici();
                string resimYolu = txtResimYolu.Text;
                firmaYonetici.ResimGuncelle(resimYolu, lblonay);
                frmAna.FirmaBilgi();
            }
        }

        private void btnDegis_Click(object sender, EventArgs e)
        {
            frmDil frmDil = new frmDil();
            frmDil.Show();
           
        }

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            btnGuncelle.BackgroundImage = Properties.Resources.buton_giris_over;
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnGuncelle.BackgroundImage = Properties.Resources.buton_giris;

        }

        private void btnDegis_MouseHover(object sender, EventArgs e)
        {
            btnDegis.BackgroundImage = Properties.Resources.buton_giris_over;

        }

        private void btnDegis_MouseLeave(object sender, EventArgs e)
        {
            btnDegis.BackgroundImage = Properties.Resources.buton_giris_over;

        }

        private void panKul_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
