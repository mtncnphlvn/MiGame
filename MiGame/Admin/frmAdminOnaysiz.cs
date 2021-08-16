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
    public partial class frmAdminOnaysiz : Form
    {
        public frmAdminOnaysiz()
        {
            InitializeComponent();
        }

        private void btnIptal_MouseHover(object sender, EventArgs e)
        {
            btnIptal.BackgroundImage = Properties.Resources.admin_buton_over;
        }

        private void btnIptal_MouseLeave(object sender, EventArgs e)
        {
            btnIptal.BackgroundImage = Properties.Resources.admin_buton;
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
            Oyun.oyunID = Convert.ToInt32(dataGridView1.Rows[sec].Cells[0].Value.ToString());
        }

        AdminYonetici adminYonetici = new AdminYonetici();

        private void frmAdminOnaysiz_Load(object sender, EventArgs e)
        {

            en();
            btnIptal.Text = Localization.onayla;
            adminYonetici.AdminOyunListeleOnaysiz(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridSecim();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            adminYonetici.OyunOnayla();
            adminYonetici.AdminOyunListeleOnaysiz(dataGridView1);
        }
    }
}
