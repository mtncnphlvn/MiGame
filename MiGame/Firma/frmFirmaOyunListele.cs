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
    public partial class frmFirmaOyunListele : Form
    {
        public frmFirmaOyunListele()
        {
            InitializeComponent();
        }
        OyunYonetici oyunYonetici = new OyunYonetici();
        private void en()
        {
            if (Settings.Default.dil == "English")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
        }
        private void frmFirmaOyunListele_Load(object sender, EventArgs e)
        {
            en();
            pbOyunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            oyunYonetici.OyunListele(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            txtArama.Text = Localization.oyunAdi;
            txtOyunAdi.Text = Localization.oyunAdi;
            txtKonu.Text = Localization.oyunKonu;
            lblPara.Text = Localization.oyunFiyat;

        }
        public void DatagridSecim()
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            Oyun.oyunID = Convert.ToInt32(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            oyunYonetici.OnizlemeResim(pbOyunResim);
            txtOyunAdi.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtKonu.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            lblFiyat.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString() + " " +Localization.paraisaret;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridSecim();
        }
        TextDoldur textDoldur = new TextDoldur();

        private void txtArama_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtArama, Localization.oyunAdi);
        }

        private void txtArama_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtArama, Localization.oyunAdi);
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            en();
            oyunYonetici.OyunListele(dataGridView1, txtArama);
            if (txtArama.Text == Localization.oyunAdi)
            {
                oyunYonetici.OyunListele(dataGridView1);
            }
        }
    }
}
