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
    public partial class frmKullaniciKutuphane : Form
    {
        public frmKullaniciKutuphane()
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
        OyunYonetici oyunYonetici = new OyunYonetici();
        public void DatagridSecim()
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            Oyun.oyunID = Convert.ToInt32(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            Console.WriteLine(Oyun.oyunID);
            oyunYonetici.OnizlemeResim(pbOyunResim);
            txtOyunAdi.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtKonu.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridSecim();
        }
        KullaniciKutuphane kullaniciKutuphane = new KullaniciKutuphane();


        private void frmKullaniciKutuphane_Load(object sender, EventArgs e)
        {
            en();
            kullaniciKutuphane.KutuphaneListele(dataGridView1);

            pbOyunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //txtArama.Text = Localization.oyunAdi;
            txtOyunAdi.Text = Localization.oyunAdi;
            txtKonu.Text = Localization.oyunKonu;
            btnYorum.Text = Localization.yorumYap;
            btnPuan.Text = Localization.puanver;
        }
        TextDoldur textDoldur = new TextDoldur();

        //private void txtArama_Enter(object sender, EventArgs e)
        //{
        //    textDoldur.TextEnter(txtArama, Localization.oyunAdi);
        //}

        //private void txtArama_Leave(object sender, EventArgs e)
        //{
        //    textDoldur.TextLeave(txtArama, Localization.oyunAdi);
        //}

        //private void txtArama_TextChanged(object sender, EventArgs e)
        //{
        //    en();
        //    oyunYonetici.OyunListele(dataGridView1, txtArama);
        //    if (txtArama.Text == Localization.oyunAdi)
        //    {
        //        oyunYonetici.OyunListele(dataGridView1);
        //    }
        //}

        private void btnPuan_MouseHover(object sender, EventArgs e)
        {
            btnPuan.BackgroundImage = Properties.Resources.buton_mor_over;
        }

        private void btnPuan_MouseLeave(object sender, EventArgs e)
        {
            btnPuan.BackgroundImage = Properties.Resources.buton_mor;

        }

        private void btnYorum_MouseHover(object sender, EventArgs e)
        {
            btnYorum.BackgroundImage = Properties.Resources.buton_mor_over;

        }

        private void btnYorum_MouseLeave(object sender, EventArgs e)
        {
            btnYorum.BackgroundImage = Properties.Resources.buton_mor;

        }

        private void btnPuan_Click(object sender, EventArgs e)
        {
            frmKullaniciPuan frmKullaniciPuan = new frmKullaniciPuan();
            frmKullaniciPuan.Show();

        }

        private void btnYorum_Click(object sender, EventArgs e)
        {
            frmKullaniciYorum frmKullaniciYorum = new frmKullaniciYorum();
            frmKullaniciYorum.Show();

        }
    }
}
