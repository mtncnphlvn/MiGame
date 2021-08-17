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
    public partial class frmFirmaOyunlarim : Form
    {
        public frmFirmaOyunlarim()
        {
            InitializeComponent();
        }
        OyunYonetici oyunYonetici = new OyunYonetici();
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
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
            oyunYonetici.OnizlemeResim(pbOyunResim);
            txtOyunAdi.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            oyunYonetici.KategoriDoldur(cmbKategori);
            txtFiyat.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
        }

        private void frmFirmaOyunlarim_Load(object sender, EventArgs e)
        {
            en();
            pbOyunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            oyunYonetici.Oyunlarım(dataGridView1);
            txtOyunAdi.Text = Localization.oyunAdi;
            lblKategori.Text = Localization.oyunKategori;
            lblPara.Text = Localization.oyunFiyat;
            btnGüncelle.Text = Localization.güncelle;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridSecim();
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol kontrol = new Kontrol();
            kontrol.SayiGir(e);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            en();
            if (cmbKategori.SelectedIndex == 0)
            {
                lblonay.Text = Localization.katsec2;
            }
            else if (txtFiyat.Text == "")
            {
                lblonay.Text = Localization.fiyat2;
            }
            else
            {
                oyunYonetici.OyunGuncelle(cmbKategori, txtFiyat, lblonay);
                oyunYonetici.Oyunlarım(dataGridView1);
                DatagridSecim();
            }
        }

        private void btnGüncelle_MouseHover(object sender, EventArgs e)
        {
            btnGüncelle.BackgroundImage = Properties.Resources.buton_mor_over;
        }

        private void btnGüncelle_MouseLeave(object sender, EventArgs e)
        {
            btnGüncelle.BackgroundImage = Properties.Resources.buton_mor;

        }
    }
}
