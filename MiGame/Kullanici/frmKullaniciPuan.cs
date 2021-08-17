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
    public partial class frmKullaniciPuan : Form
    {
        public frmKullaniciPuan()
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

        private void frmKullaniciPuan_Load(object sender, EventArgs e)
        {
            en();
            label1.Text = Localization.degerlendirme;
        }
        KullaniciYorum kullaniciYorum = new KullaniciYorum();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(1);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(2);
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(3);
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(4);
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(5);
            this.Hide();
        }
    }
}
