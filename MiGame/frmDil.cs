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
    public partial class frmDil : Form
    {
        public frmDil()
        {
            InitializeComponent();
        }
        private void yazdir()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            lblDil.Text = Localization.d1;
            btnKaydet.Text = Localization.d2;
        }
        private void frmDil_Load(object sender, EventArgs e)
        {
            yazdir();
            cmbDiller.Items.Add("Türkçe");
            cmbDiller.Items.Add("English");
            cmbDiller.SelectedIndex = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbDiller.SelectedIndex == 0)
            {
                Localization.Culture = new CultureInfo("");
                Settings.Default.dil = "Türkçe";
                Settings.Default.Save();
                Application.Restart();
            }
            else if (cmbDiller.SelectedIndex == 1)
            {
                Localization.Culture = new CultureInfo("en-US");
                Settings.Default.dil = "English";
                Settings.Default.Save();
                Application.Restart();
            }


            Settings.Default.baslangicDil = 1;
            Settings.Default.Save();
        }
    }
}
