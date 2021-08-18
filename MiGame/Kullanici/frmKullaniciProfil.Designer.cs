namespace MiGame
{
    partial class frmKullaniciProfil
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
            this.panKul = new System.Windows.Forms.Panel();
            this.lblBos = new System.Windows.Forms.Label();
            this.btnAdGuncelle = new System.Windows.Forms.Button();
            this.txtKulAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnResimGuncelle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDil = new System.Windows.Forms.Button();
            this.lblDil = new System.Windows.Forms.Label();
            this.panKul.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panKul
            // 
            this.panKul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.panKul.Controls.Add(this.lblBos);
            this.panKul.Controls.Add(this.btnAdGuncelle);
            this.panKul.Controls.Add(this.txtKulAd);
            this.panKul.Controls.Add(this.label1);
            this.panKul.Location = new System.Drawing.Point(12, 12);
            this.panKul.Name = "panKul";
            this.panKul.Size = new System.Drawing.Size(273, 181);
            this.panKul.TabIndex = 27;
            // 
            // lblBos
            // 
            this.lblBos.AutoSize = true;
            this.lblBos.Location = new System.Drawing.Point(111, 84);
            this.lblBos.Name = "lblBos";
            this.lblBos.Size = new System.Drawing.Size(0, 13);
            this.lblBos.TabIndex = 22;
            this.lblBos.Visible = false;
            // 
            // btnAdGuncelle
            // 
            this.btnAdGuncelle.BackgroundImage = global::MiGame.Properties.Resources.buton_mor;
            this.btnAdGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnAdGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnAdGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnAdGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnAdGuncelle.Location = new System.Drawing.Point(84, 131);
            this.btnAdGuncelle.Name = "btnAdGuncelle";
            this.btnAdGuncelle.Size = new System.Drawing.Size(100, 45);
            this.btnAdGuncelle.TabIndex = 21;
            this.btnAdGuncelle.Text = "Güncelle";
            this.btnAdGuncelle.UseVisualStyleBackColor = true;
            this.btnAdGuncelle.Click += new System.EventHandler(this.btnAdGuncelle_Click);
            this.btnAdGuncelle.MouseLeave += new System.EventHandler(this.btnAdGuncelle_MouseLeave);
            this.btnAdGuncelle.MouseHover += new System.EventHandler(this.btnAdGuncelle_MouseHover);
            // 
            // txtKulAd
            // 
            this.txtKulAd.Location = new System.Drawing.Point(72, 55);
            this.txtKulAd.Name = "txtKulAd";
            this.txtKulAd.Size = new System.Drawing.Size(135, 20);
            this.txtKulAd.TabIndex = 9;
            this.txtKulAd.TextChanged += new System.EventHandler(this.txtKulAd_TextChanged);
            this.txtKulAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKulAd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(79, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnSifreGuncelle);
            this.panel1.Controls.Add(this.txtSifreTekrar);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(415, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 181);
            this.panel1.TabIndex = 28;
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.BackgroundImage = global::MiGame.Properties.Resources.buton_mor;
            this.btnSifreGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifreGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnSifreGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnSifreGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnSifreGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnSifreGuncelle.Location = new System.Drawing.Point(90, 131);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(100, 45);
            this.btnSifreGuncelle.TabIndex = 22;
            this.btnSifreGuncelle.Text = "Güncelle";
            this.btnSifreGuncelle.UseVisualStyleBackColor = true;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnSifreGuncelle_Click);
            this.btnSifreGuncelle.MouseLeave += new System.EventHandler(this.btnSifreGuncelle_MouseLeave);
            this.btnSifreGuncelle.MouseHover += new System.EventHandler(this.btnSifreGuncelle_MouseHover);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(57, 81);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(174, 20);
            this.txtSifreTekrar.TabIndex = 15;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(57, 55);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(174, 20);
            this.txtSifre.TabIndex = 14;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.label7.Location = new System.Drawing.Point(122, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Şifre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnResimSec);
            this.panel2.Controls.Add(this.txtResimYolu);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnResimGuncelle);
            this.panel2.Location = new System.Drawing.Point(12, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 181);
            this.panel2.TabIndex = 29;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(203, 73);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(31, 22);
            this.btnResimSec.TabIndex = 25;
            this.btnResimSec.Text = "...";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.BackColor = System.Drawing.SystemColors.Window;
            this.txtResimYolu.Location = new System.Drawing.Point(108, 75);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.ReadOnly = true;
            this.txtResimYolu.Size = new System.Drawing.Size(99, 20);
            this.txtResimYolu.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.label11.Location = new System.Drawing.Point(31, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 28);
            this.label11.TabIndex = 23;
            this.label11.Text = "Resim :";
            // 
            // btnResimGuncelle
            // 
            this.btnResimGuncelle.BackgroundImage = global::MiGame.Properties.Resources.buton_mor;
            this.btnResimGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResimGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnResimGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnResimGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnResimGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnResimGuncelle.Location = new System.Drawing.Point(84, 126);
            this.btnResimGuncelle.Name = "btnResimGuncelle";
            this.btnResimGuncelle.Size = new System.Drawing.Size(100, 45);
            this.btnResimGuncelle.TabIndex = 21;
            this.btnResimGuncelle.Text = "Güncelle";
            this.btnResimGuncelle.UseVisualStyleBackColor = true;
            this.btnResimGuncelle.Click += new System.EventHandler(this.btnResimGuncelle_Click);
            this.btnResimGuncelle.MouseLeave += new System.EventHandler(this.btnResimGuncelle_MouseLeave);
            this.btnResimGuncelle.MouseHover += new System.EventHandler(this.btnResimGuncelle_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Location = new System.Drawing.Point(415, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 181);
            this.panel3.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.label12.Location = new System.Drawing.Point(103, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 28);
            this.label12.TabIndex = 22;
            this.label12.Text = "Hesap";
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::MiGame.Properties.Resources.buton_mor;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnSil.Location = new System.Drawing.Point(47, 68);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(196, 103);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Hesabı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.btnDil);
            this.panel4.Controls.Add(this.lblDil);
            this.panel4.Location = new System.Drawing.Point(226, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 118);
            this.panel4.TabIndex = 31;
            // 
            // btnDil
            // 
            this.btnDil.BackgroundImage = global::MiGame.Properties.Resources.buton_mor;
            this.btnDil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnDil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnDil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnDil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDil.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnDil.Location = new System.Drawing.Point(71, 51);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(100, 45);
            this.btnDil.TabIndex = 23;
            this.btnDil.Text = "Değiş";
            this.btnDil.UseVisualStyleBackColor = true;
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            this.btnDil.MouseLeave += new System.EventHandler(this.btnDil_MouseLeave);
            this.btnDil.MouseHover += new System.EventHandler(this.btnDil_MouseHover);
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.lblDil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblDil.Location = new System.Drawing.Point(46, 20);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(93, 28);
            this.lblDil.TabIndex = 13;
            this.lblDil.Text = "Dil Seçimi";
            // 
            // frmKullaniciProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panKul);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullaniciProfil";
            this.Text = "frmKullaniciProfil";
            this.Load += new System.EventHandler(this.frmKullaniciProfil_Load);
            this.panKul.ResumeLayout(false);
            this.panKul.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panKul;
        private System.Windows.Forms.TextBox txtKulAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdGuncelle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSifreGuncelle;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.TextBox txtResimYolu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnResimGuncelle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblBos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.Button btnDil;
    }
}