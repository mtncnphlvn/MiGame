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
    public partial class frmKullaniciYorum : Form
    {
        public frmKullaniciYorum()
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

        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackgroundImage = Properties.Resources.giris_buton_over;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackgroundImage = Properties.Resources.giris_buton;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciYorum kullaniciYorum = new KullaniciYorum();
            string mesaj = rtxtMesaj.Text;

            if (rtxtMesaj.Text != "" && kullaniciYorum.YorumEkle(mesaj) == true)
            {
                this.Hide();

            }
        }

        private void frmKullaniciYorum_Load(object sender, EventArgs e)
        {
            btnGiris.Text = Localization.yorumYap;
            label1.Text = Localization.gorusYaz;
        }
    }
}
