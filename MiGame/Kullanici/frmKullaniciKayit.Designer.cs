namespace MiGame
{
    partial class frmKullaniciKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKayit = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtGuvenlik = new System.Windows.Forms.TextBox();
            this.txtKulAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnCarpi = new System.Windows.Forms.Button();
            this.cmbGun = new System.Windows.Forms.ComboBox();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.lblAdUyari = new System.Windows.Forms.Label();
            this.lblSoyadUyari = new System.Windows.Forms.Label();
            this.lblTarihUyari = new System.Windows.Forms.Label();
            this.lblCinsiyetUyari = new System.Windows.Forms.Label();
            this.lblEpostaUyari = new System.Windows.Forms.Label();
            this.lblKodUyari = new System.Windows.Forms.Label();
            this.lblKuladUyari = new System.Windows.Forms.Label();
            this.lblSifreUyari = new System.Windows.Forms.Label();
            this.lblSifreTekrarUyari = new System.Windows.Forms.Label();
            this.btnKod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblKayit.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblKayit.Location = new System.Drawing.Point(119, 35);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(215, 65);
            this.lblKayit.TabIndex = 1;
            this.lblKayit.Text = "Kayıt Ol";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.txtAd.Location = new System.Drawing.Point(93, 128);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(281, 23);
            this.txtAd.TabIndex = 4;
            this.txtAd.Text = "Ad";
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAd.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.txtSoyad.Location = new System.Drawing.Point(93, 179);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(281, 23);
            this.txtSoyad.TabIndex = 4;
            this.txtSoyad.Text = "Soyad";
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            this.txtSoyad.Enter += new System.EventHandler(this.txtSoyad_Enter);
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            this.txtSoyad.Leave += new System.EventHandler(this.txtSoyad_Leave);
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtEposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEposta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.txtEposta.Location = new System.Drawing.Point(93, 329);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(281, 23);
            this.txtEposta.TabIndex = 4;
            this.txtEposta.Text = "E-Posta";
            this.txtEposta.TextChanged += new System.EventHandler(this.txtEposta_TextChanged);
            this.txtEposta.Enter += new System.EventHandler(this.txtEposta_Enter);
            this.txtEposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEposta_KeyPress);
            this.txtEposta.Leave += new System.EventHandler(this.txtEposta_Leave);
            // 
            // txtGuvenlik
            // 
            this.txtGuvenlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtGuvenlik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGuvenlik.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuvenlik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.txtGuvenlik.Location = new System.Drawing.Point(93, 379);
            this.txtGuvenlik.Name = "txtGuvenlik";
            this.txtGuvenlik.Size = new System.Drawing.Size(281, 23);
            this.txtGuvenlik.TabIndex = 4;
            this.txtGuvenlik.Text = "Güvenlik Kodu";
            this.txtGuvenlik.TextChanged += new System.EventHandler(this.txtGuvenlik_TextChanged);
            this.txtGuvenlik.Enter += new System.EventHandler(this.txtGuvenlik_Enter);
            this.txtGuvenlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuvenlik_KeyPress);
            this.txtGuvenlik.Leave += new System.EventHandler(this.txtGuvenlik_Leave);
            // 
            // txtKulAd
            // 
            this.txtKulAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtKulAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKulAd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.txtKulAd.Location = new System.Drawing.Point(93, 429);
            this.txtKulAd.Name = "txtKulAd";
            this.txtKulAd.Size = new System.Drawing.Size(281, 23);
            this.txtKulAd.TabIndex = 4;
            this.txtKulAd.Text = "Kullanıcı Adı";
            this.txtKulAd.TextChanged += new System.EventHandler(this.txtKulAd_TextChanged);
            this.txtKulAd.Enter += new System.EventHandler(this.txtKulAd_Enter);
            this.txtKulAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKulAd_KeyPress);
            this.txtKulAd.Leave += new System.EventHandler(this.txtKulAd_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.txtSifre.Location = new System.Drawing.Point(93, 479);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(281, 23);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifreTekrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.txtSifreTekrar.Location = new System.Drawing.Point(93, 529);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(281, 23);
            this.txtSifreTekrar.TabIndex = 4;
            this.txtSifreTekrar.Text = "Şifre Tekrar";
            this.txtSifreTekrar.TextChanged += new System.EventHandler(this.txtSifreTekrar_TextChanged);
            this.txtSifreTekrar.Enter += new System.EventHandler(this.txtSifreTekrar_Enter);
            this.txtSifreTekrar.Leave += new System.EventHandler(this.txtSifreTekrar_Leave);
            // 
            // btnCarpi
            // 
            this.btnCarpi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnCarpi.BackgroundImage = global::MiGame.Properties.Resources.cross;
            this.btnCarpi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarpi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnCarpi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnCarpi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnCarpi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarpi.Location = new System.Drawing.Point(438, 12);
            this.btnCarpi.Name = "btnCarpi";
            this.btnCarpi.Size = new System.Drawing.Size(20, 20);
            this.btnCarpi.TabIndex = 0;
            this.btnCarpi.UseVisualStyleBackColor = false;
            this.btnCarpi.Click += new System.EventHandler(this.btnCarpi_Click);
            this.btnCarpi.MouseLeave += new System.EventHandler(this.btnCarpi_MouseLeave);
            this.btnCarpi.MouseHover += new System.EventHandler(this.btnCarpi_MouseHover);
            // 
            // cmbGun
            // 
            this.cmbGun.BackColor = System.Drawing.Color.White;
            this.cmbGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGun.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.cmbGun.FormattingEnabled = true;
            this.cmbGun.Location = new System.Drawing.Point(82, 228);
            this.cmbGun.Name = "cmbGun";
            this.cmbGun.Size = new System.Drawing.Size(85, 23);
            this.cmbGun.TabIndex = 5;
            this.cmbGun.SelectedIndexChanged += new System.EventHandler(this.cmbGun_SelectedIndexChanged);
            // 
            // cmbAy
            // 
            this.cmbAy.BackColor = System.Drawing.Color.White;
            this.cmbAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAy.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(193, 228);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(85, 23);
            this.cmbAy.TabIndex = 5;
            this.cmbAy.SelectedIndexChanged += new System.EventHandler(this.cmbAy_SelectedIndexChanged);
            // 
            // cmbYil
            // 
            this.cmbYil.BackColor = System.Drawing.Color.White;
            this.cmbYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYil.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Location = new System.Drawing.Point(303, 228);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(85, 23);
            this.cmbYil.TabIndex = 5;
            this.cmbYil.SelectedIndexChanged += new System.EventHandler(this.cmbYil_SelectedIndexChanged);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.BackColor = System.Drawing.Color.White;
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(82, 278);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(306, 23);
            this.cmbCinsiyet.TabIndex = 5;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbCinsiyet_SelectedIndexChanged);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKayitOl.BackgroundImage = global::MiGame.Properties.Resources.buton_giris;
            this.btnKayitOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayitOl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKayitOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKayitOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKayitOl.Location = new System.Drawing.Point(157, 580);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(130, 50);
            this.btnKayitOl.TabIndex = 6;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            this.btnKayitOl.MouseLeave += new System.EventHandler(this.btnKayitOl_MouseLeave);
            this.btnKayitOl.MouseHover += new System.EventHandler(this.btnKayitOl_MouseHover);
            // 
            // lblAdUyari
            // 
            this.lblAdUyari.AutoSize = true;
            this.lblAdUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblAdUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblAdUyari.Location = new System.Drawing.Point(173, 156);
            this.lblAdUyari.Name = "lblAdUyari";
            this.lblAdUyari.Size = new System.Drawing.Size(102, 17);
            this.lblAdUyari.TabIndex = 7;
            this.lblAdUyari.Text = "Boş Geçilemez";
            // 
            // lblSoyadUyari
            // 
            this.lblSoyadUyari.AutoSize = true;
            this.lblSoyadUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblSoyadUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblSoyadUyari.Location = new System.Drawing.Point(173, 205);
            this.lblSoyadUyari.Name = "lblSoyadUyari";
            this.lblSoyadUyari.Size = new System.Drawing.Size(102, 17);
            this.lblSoyadUyari.TabIndex = 7;
            this.lblSoyadUyari.Text = "Boş Geçilemez";
            // 
            // lblTarihUyari
            // 
            this.lblTarihUyari.AutoSize = true;
            this.lblTarihUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblTarihUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblTarihUyari.Location = new System.Drawing.Point(176, 255);
            this.lblTarihUyari.Name = "lblTarihUyari";
            this.lblTarihUyari.Size = new System.Drawing.Size(102, 17);
            this.lblTarihUyari.TabIndex = 7;
            this.lblTarihUyari.Text = "Boş Geçilemez";
            // 
            // lblCinsiyetUyari
            // 
            this.lblCinsiyetUyari.AutoSize = true;
            this.lblCinsiyetUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblCinsiyetUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyetUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblCinsiyetUyari.Location = new System.Drawing.Point(176, 306);
            this.lblCinsiyetUyari.Name = "lblCinsiyetUyari";
            this.lblCinsiyetUyari.Size = new System.Drawing.Size(102, 17);
            this.lblCinsiyetUyari.TabIndex = 7;
            this.lblCinsiyetUyari.Text = "Boş Geçilemez";
            // 
            // lblEpostaUyari
            // 
            this.lblEpostaUyari.AutoSize = true;
            this.lblEpostaUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblEpostaUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEpostaUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblEpostaUyari.Location = new System.Drawing.Point(176, 357);
            this.lblEpostaUyari.Name = "lblEpostaUyari";
            this.lblEpostaUyari.Size = new System.Drawing.Size(102, 17);
            this.lblEpostaUyari.TabIndex = 7;
            this.lblEpostaUyari.Text = "Boş Geçilemez";
            // 
            // lblKodUyari
            // 
            this.lblKodUyari.AutoSize = true;
            this.lblKodUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblKodUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKodUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblKodUyari.Location = new System.Drawing.Point(173, 405);
            this.lblKodUyari.Name = "lblKodUyari";
            this.lblKodUyari.Size = new System.Drawing.Size(102, 17);
            this.lblKodUyari.TabIndex = 7;
            this.lblKodUyari.Text = "Boş Geçilemez";
            // 
            // lblKuladUyari
            // 
            this.lblKuladUyari.AutoSize = true;
            this.lblKuladUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblKuladUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKuladUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblKuladUyari.Location = new System.Drawing.Point(173, 455);
            this.lblKuladUyari.Name = "lblKuladUyari";
            this.lblKuladUyari.Size = new System.Drawing.Size(102, 17);
            this.lblKuladUyari.TabIndex = 7;
            this.lblKuladUyari.Text = "Boş Geçilemez";
            // 
            // lblSifreUyari
            // 
            this.lblSifreUyari.AutoSize = true;
            this.lblSifreUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblSifreUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblSifreUyari.Location = new System.Drawing.Point(173, 505);
            this.lblSifreUyari.Name = "lblSifreUyari";
            this.lblSifreUyari.Size = new System.Drawing.Size(102, 17);
            this.lblSifreUyari.TabIndex = 7;
            this.lblSifreUyari.Text = "Boş Geçilemez";
            // 
            // lblSifreTekrarUyari
            // 
            this.lblSifreTekrarUyari.AutoSize = true;
            this.lblSifreTekrarUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblSifreTekrarUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreTekrarUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblSifreTekrarUyari.Location = new System.Drawing.Point(173, 555);
            this.lblSifreTekrarUyari.Name = "lblSifreTekrarUyari";
            this.lblSifreTekrarUyari.Size = new System.Drawing.Size(102, 17);
            this.lblSifreTekrarUyari.TabIndex = 7;
            this.lblSifreTekrarUyari.Text = "Boş Geçilemez";
            // 
            // btnKod
            // 
            this.btnKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKod.BackgroundImage = global::MiGame.Properties.Resources.buton_giris;
            this.btnKod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKod.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKod.Location = new System.Drawing.Point(397, 326);
            this.btnKod.Name = "btnKod";
            this.btnKod.Size = new System.Drawing.Size(68, 31);
            this.btnKod.TabIndex = 8;
            this.btnKod.Text = "Kod";
            this.btnKod.UseVisualStyleBackColor = false;
            this.btnKod.MouseLeave += new System.EventHandler(this.btnKod_MouseLeave);
            this.btnKod.MouseHover += new System.EventHandler(this.btnKod_MouseHover);
            // 
            // frmKullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiGame.Properties.Resources.kullanici_giris21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 650);
            this.Controls.Add(this.btnKod);
            this.Controls.Add(this.lblSifreTekrarUyari);
            this.Controls.Add(this.lblSifreUyari);
            this.Controls.Add(this.lblKuladUyari);
            this.Controls.Add(this.lblKodUyari);
            this.Controls.Add(this.lblEpostaUyari);
            this.Controls.Add(this.lblCinsiyetUyari);
            this.Controls.Add(this.lblTarihUyari);
            this.Controls.Add(this.lblSoyadUyari);
            this.Controls.Add(this.lblAdUyari);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.cmbYil);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.cmbGun);
            this.Controls.Add(this.btnCarpi);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKulAd);
            this.Controls.Add(this.txtGuvenlik);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullaniciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKullaniciKayit";
            this.Load += new System.EventHandler(this.frmKullaniciKayit_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmKullaniciKayit_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmKullaniciKayit_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmKullaniciKayit_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtGuvenlik;
        private System.Windows.Forms.TextBox txtKulAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Button btnCarpi;
        private System.Windows.Forms.ComboBox cmbGun;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label lblAdUyari;
        private System.Windows.Forms.Label lblSoyadUyari;
        private System.Windows.Forms.Label lblTarihUyari;
        private System.Windows.Forms.Label lblCinsiyetUyari;
        private System.Windows.Forms.Label lblEpostaUyari;
        private System.Windows.Forms.Label lblKodUyari;
        private System.Windows.Forms.Label lblKuladUyari;
        private System.Windows.Forms.Label lblSifreUyari;
        private System.Windows.Forms.Label lblSifreTekrarUyari;
        private System.Windows.Forms.Button btnKod;
    }
}