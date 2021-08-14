namespace MiGame
{
    partial class frmKullaniciAnasayfa
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
            this.pnlSol = new System.Windows.Forms.Panel();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnGoruslerim = new System.Windows.Forms.Button();
            this.btnKutuphane = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblKulAd = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.pnlSag = new System.Windows.Forms.Panel();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.Color.Pink;
            this.pnlSol.BackgroundImage = global::MiGame.Properties.Resources.firma_arayuz2;
            this.pnlSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSol.Controls.Add(this.btnProfil);
            this.pnlSol.Controls.Add(this.btnGoruslerim);
            this.pnlSol.Controls.Add(this.btnKutuphane);
            this.pnlSol.Controls.Add(this.btnAnasayfa);
            this.pnlSol.Controls.Add(this.lblBakiye);
            this.pnlSol.Controls.Add(this.lblKulAd);
            this.pnlSol.Controls.Add(this.pbResim);
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(200, 600);
            this.pnlSol.TabIndex = 1;
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnProfil.BackgroundImage = global::MiGame.Properties.Resources.arayuz_buton;
            this.btnProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnProfil.Location = new System.Drawing.Point(38, 555);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(120, 40);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            this.btnProfil.MouseLeave += new System.EventHandler(this.btnProfil_MouseLeave);
            this.btnProfil.MouseHover += new System.EventHandler(this.btnProfil_MouseHover);
            // 
            // btnGoruslerim
            // 
            this.btnGoruslerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGoruslerim.BackgroundImage = global::MiGame.Properties.Resources.arayuz_buton;
            this.btnGoruslerim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoruslerim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGoruslerim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGoruslerim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGoruslerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoruslerim.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruslerim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGoruslerim.Location = new System.Drawing.Point(38, 505);
            this.btnGoruslerim.Name = "btnGoruslerim";
            this.btnGoruslerim.Size = new System.Drawing.Size(120, 40);
            this.btnGoruslerim.TabIndex = 3;
            this.btnGoruslerim.Text = "Görüşlerim";
            this.btnGoruslerim.UseVisualStyleBackColor = false;
            this.btnGoruslerim.Click += new System.EventHandler(this.btnGoruslerim_Click);
            this.btnGoruslerim.MouseLeave += new System.EventHandler(this.btnGoruslerim_MouseLeave);
            this.btnGoruslerim.MouseHover += new System.EventHandler(this.btnGoruslerim_MouseHover);
            // 
            // btnKutuphane
            // 
            this.btnKutuphane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKutuphane.BackgroundImage = global::MiGame.Properties.Resources.arayuz_buton;
            this.btnKutuphane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKutuphane.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKutuphane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKutuphane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKutuphane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKutuphane.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKutuphane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKutuphane.Location = new System.Drawing.Point(38, 450);
            this.btnKutuphane.Name = "btnKutuphane";
            this.btnKutuphane.Size = new System.Drawing.Size(120, 40);
            this.btnKutuphane.TabIndex = 3;
            this.btnKutuphane.Text = "Kütüphane";
            this.btnKutuphane.UseVisualStyleBackColor = false;
            this.btnKutuphane.Click += new System.EventHandler(this.btnKutuphane_Click);
            this.btnKutuphane.MouseLeave += new System.EventHandler(this.btnKutuphane_MouseLeave);
            this.btnKutuphane.MouseHover += new System.EventHandler(this.btnKutuphane_MouseHover);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnAnasayfa.BackgroundImage = global::MiGame.Properties.Resources.arayuz_buton;
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnAnasayfa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnAnasayfa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnAnasayfa.Location = new System.Drawing.Point(39, 396);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(120, 40);
            this.btnAnasayfa.TabIndex = 3;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            this.btnAnasayfa.MouseHover += new System.EventHandler(this.btnAnasayfa_MouseHover);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblBakiye.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblBakiye.Location = new System.Drawing.Point(72, 337);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(60, 23);
            this.lblBakiye.TabIndex = 2;
            this.lblBakiye.Text = "Bakiye";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKulAd
            // 
            this.lblKulAd.AutoSize = true;
            this.lblKulAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblKulAd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKulAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblKulAd.Location = new System.Drawing.Point(58, 258);
            this.lblKulAd.Name = "lblKulAd";
            this.lblKulAd.Size = new System.Drawing.Size(98, 23);
            this.lblKulAd.TabIndex = 2;
            this.lblKulAd.Text = "Kullanıcı adı";
            this.lblKulAd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(29, 74);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(146, 147);
            this.pbResim.TabIndex = 0;
            this.pbResim.TabStop = false;
            // 
            // pnlSag
            // 
            this.pnlSag.BackColor = System.Drawing.Color.Red;
            this.pnlSag.Location = new System.Drawing.Point(200, 0);
            this.pnlSag.Name = "pnlSag";
            this.pnlSag.Size = new System.Drawing.Size(700, 600);
            this.pnlSag.TabIndex = 2;
            // 
            // frmKullaniciAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlSag);
            this.Controls.Add(this.pnlSol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmKullaniciAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKullaniciAnasayfa";
            this.Load += new System.EventHandler(this.frmKullaniciAnasayfa_Load);
            this.pnlSol.ResumeLayout(false);
            this.pnlSol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnGoruslerim;
        private System.Windows.Forms.Button btnKutuphane;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblKulAd;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Panel pnlSag;
    }
}