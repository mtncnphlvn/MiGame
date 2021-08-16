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
    public partial class frmAdminKullanicilar : Form
    {
        public frmAdminKullanicilar()
        {
            InitializeComponent();
        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            btnSil.BackgroundImage = Properties.Resources.admin_buton_over;
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            btnSil.BackgroundImage = Properties.Resources.admin_buton;
        }
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        public void DatagridSecim()
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            Kullanici.kullaniciID = Convert.ToInt32(dataGridView1.Rows[sec].Cells[0].Value.ToString());
        }
        AdminYonetici adminYonetici = new AdminYonetici();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridSecim();
        }

        private void frmAdminKullanicilar_Load(object sender, EventArgs e)
        {
            en();
            btnSil.Text = Localization.sil;
            adminYonetici.KullaniciListele(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            adminYonetici.KullaniciSil();
            adminYonetici.KullaniciListele(dataGridView1);
        }
    }
}
