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
using MySql.Data.MySqlClient;

namespace MiGame
{
    public partial class frmAdminAnasayfa : Form
    {
        public frmAdminAnasayfa()
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
        private void FormGetir(Form frm)
        {
            pnlAlt.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlAlt.Controls.Add(frm);
            frm.Show();
        }
        private void frmAdminAnasayfa_Load(object sender, EventArgs e)
        {           
            en();
            frmAdminOnayli frmAdminOnayli = new frmAdminOnayli();
            FormGetir(frmAdminOnayli);


            lblSaygi.Text = Localization.sev + ",";
            btnOnayli.Text = Localization.onayliOyun;
            btnOnaysiz.Text = Localization.onaysizOyun;
            btnFirma.Text = Localization.adminFirma;
            btnKullanici.Text = Localization.adminKullanici;

           

           

        }

        private void btnOnayli_MouseHover(object sender, EventArgs e)
        {
            btnOnayli.BackgroundImage = Properties.Resources.admin_buton_over;
        }

        private void btnOnayli_MouseLeave(object sender, EventArgs e)
        {
            btnOnayli.BackgroundImage = Properties.Resources.admin_buton;
        }

        private void btnOnaysiz_MouseHover(object sender, EventArgs e)
        {
            btnOnaysiz.BackgroundImage = Properties.Resources.admin_buton_over;
        }

        private void btnOnaysiz_MouseLeave(object sender, EventArgs e)
        {
            btnOnaysiz.BackgroundImage = Properties.Resources.admin_buton;
        }

        private void btnFirma_MouseHover(object sender, EventArgs e)
        {
            btnFirma.BackgroundImage = Properties.Resources.admin_buton_over;
        }

        private void btnFirma_MouseLeave(object sender, EventArgs e)
        {
            btnFirma.BackgroundImage = Properties.Resources.admin_buton;
        }

        private void btnKullanici_MouseHover(object sender, EventArgs e)
        {
            btnKullanici.BackgroundImage = Properties.Resources.admin_buton_over;
        }

        private void btnKullanici_MouseLeave(object sender, EventArgs e)
        {
            btnKullanici.BackgroundImage = Properties.Resources.admin_buton;
        }

        private void btnCarpi_MouseHover(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.cross_over;
        }

        private void btnCarpi_MouseLeave(object sender, EventArgs e)
        {
            btnCarpi.BackgroundImage = Properties.Resources.cross;
        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOnayli_Click(object sender, EventArgs e)
        {
            frmAdminOnayli frmAdminOnayli = new frmAdminOnayli();
            FormGetir(frmAdminOnayli);
        }

        private void btnOnaysiz_Click(object sender, EventArgs e)
        {
            frmAdminOnaysiz frmAdminOnaysiz = new frmAdminOnaysiz();
            FormGetir(frmAdminOnaysiz);
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            frmAdminFirmalar frmAdminFirmalar = new frmAdminFirmalar();
            FormGetir(frmAdminFirmalar);
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            frmAdminKullanicilar frmAdminKullanicilar = new frmAdminKullanicilar();
            FormGetir(frmAdminKullanicilar);
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void pnlUst_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void pnlUst_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void pnlUst_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
