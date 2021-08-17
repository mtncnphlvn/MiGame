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
    public partial class frmKullaniciGoruslerim : Form
    {
        public frmKullaniciGoruslerim()
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

        private void frmKullaniciGoruslerim_Load(object sender, EventArgs e)
        {
            label1.Text = Localization.goruslerim;
            KullaniciYorum kullaniciYorum = new KullaniciYorum();
            kullaniciYorum.YorumlarKullanici(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
