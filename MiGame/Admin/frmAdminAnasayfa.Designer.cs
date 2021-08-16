namespace MiGame
{
    partial class frmAdminAnasayfa
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
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnCarpi = new System.Windows.Forms.Button();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.btnFirma = new System.Windows.Forms.Button();
            this.btnOnaysiz = new System.Windows.Forms.Button();
            this.btnOnayli = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblSaygi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlt
            // 
            this.pnlAlt.Location = new System.Drawing.Point(1, 121);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(900, 480);
            this.pnlAlt.TabIndex = 2;
            // 
            // pnlUst
            // 
            this.pnlUst.BackgroundImage = global::MiGame.Properties.Resources.admin_arayuz;
            this.pnlUst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUst.Controls.Add(this.btnCarpi);
            this.pnlUst.Controls.Add(this.btnKullanici);
            this.pnlUst.Controls.Add(this.btnFirma);
            this.pnlUst.Controls.Add(this.btnOnaysiz);
            this.pnlUst.Controls.Add(this.btnOnayli);
            this.pnlUst.Controls.Add(this.lblAdmin);
            this.pnlUst.Controls.Add(this.lblSaygi);
            this.pnlUst.Controls.Add(this.pictureBox1);
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(900, 120);
            this.pnlUst.TabIndex = 1;
            this.pnlUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlUst_MouseDown);
            this.pnlUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUst_MouseMove);
            this.pnlUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlUst_MouseUp);
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
            this.btnCarpi.Location = new System.Drawing.Point(877, 6);
            this.btnCarpi.Name = "btnCarpi";
            this.btnCarpi.Size = new System.Drawing.Size(20, 20);
            this.btnCarpi.TabIndex = 3;
            this.btnCarpi.UseVisualStyleBackColor = false;
            this.btnCarpi.Click += new System.EventHandler(this.btnCarpi_Click);
            this.btnCarpi.MouseLeave += new System.EventHandler(this.btnCarpi_MouseLeave);
            this.btnCarpi.MouseHover += new System.EventHandler(this.btnCarpi_MouseHover);
            // 
            // btnKullanici
            // 
            this.btnKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKullanici.BackgroundImage = global::MiGame.Properties.Resources.admin_buton;
            this.btnKullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKullanici.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKullanici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKullanici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanici.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKullanici.Location = new System.Drawing.Point(768, 26);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(120, 75);
            this.btnKullanici.TabIndex = 2;
            this.btnKullanici.Text = "Kullanıcılar";
            this.btnKullanici.UseVisualStyleBackColor = false;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            this.btnKullanici.MouseLeave += new System.EventHandler(this.btnKullanici_MouseLeave);
            this.btnKullanici.MouseHover += new System.EventHandler(this.btnKullanici_MouseHover);
            // 
            // btnFirma
            // 
            this.btnFirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnFirma.BackgroundImage = global::MiGame.Properties.Resources.admin_buton;
            this.btnFirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnFirma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnFirma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnFirma.Location = new System.Drawing.Point(644, 27);
            this.btnFirma.Name = "btnFirma";
            this.btnFirma.Size = new System.Drawing.Size(120, 75);
            this.btnFirma.TabIndex = 2;
            this.btnFirma.Text = "Firmalar";
            this.btnFirma.UseVisualStyleBackColor = false;
            this.btnFirma.Click += new System.EventHandler(this.btnFirma_Click);
            this.btnFirma.MouseLeave += new System.EventHandler(this.btnFirma_MouseLeave);
            this.btnFirma.MouseHover += new System.EventHandler(this.btnFirma_MouseHover);
            // 
            // btnOnaysiz
            // 
            this.btnOnaysiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnaysiz.BackgroundImage = global::MiGame.Properties.Resources.admin_buton;
            this.btnOnaysiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnaysiz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnaysiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnaysiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnaysiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnaysiz.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaysiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnaysiz.Location = new System.Drawing.Point(518, 27);
            this.btnOnaysiz.Name = "btnOnaysiz";
            this.btnOnaysiz.Size = new System.Drawing.Size(120, 75);
            this.btnOnaysiz.TabIndex = 2;
            this.btnOnaysiz.Text = "Onaysız Oyunlar";
            this.btnOnaysiz.UseVisualStyleBackColor = false;
            this.btnOnaysiz.Click += new System.EventHandler(this.btnOnaysiz_Click);
            this.btnOnaysiz.MouseLeave += new System.EventHandler(this.btnOnaysiz_MouseLeave);
            this.btnOnaysiz.MouseHover += new System.EventHandler(this.btnOnaysiz_MouseHover);
            // 
            // btnOnayli
            // 
            this.btnOnayli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnayli.BackgroundImage = global::MiGame.Properties.Resources.admin_buton;
            this.btnOnayli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnayli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnayli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnayli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnayli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayli.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnOnayli.Location = new System.Drawing.Point(392, 27);
            this.btnOnayli.Name = "btnOnayli";
            this.btnOnayli.Size = new System.Drawing.Size(120, 75);
            this.btnOnayli.TabIndex = 2;
            this.btnOnayli.Text = "Onaylı Oyunlar";
            this.btnOnayli.UseVisualStyleBackColor = false;
            this.btnOnayli.Click += new System.EventHandler(this.btnOnayli_Click);
            this.btnOnayli.MouseLeave += new System.EventHandler(this.btnOnayli_MouseLeave);
            this.btnOnayli.MouseHover += new System.EventHandler(this.btnOnayli_MouseHover);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblAdmin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblAdmin.Location = new System.Drawing.Point(225, 53);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(55, 23);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin";
            // 
            // lblSaygi
            // 
            this.lblSaygi.AutoSize = true;
            this.lblSaygi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblSaygi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaygi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblSaygi.Location = new System.Drawing.Point(180, 30);
            this.lblSaygi.Name = "lblSaygi";
            this.lblSaygi.Size = new System.Drawing.Size(66, 23);
            this.lblSaygi.TabIndex = 1;
            this.lblSaygi.Text = "Sevgili,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MiGame.Properties.Resources.balık5;
            this.pictureBox1.Location = new System.Drawing.Point(74, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.pnlAlt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmAdminAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminAnasayfa";
            this.Load += new System.EventHandler(this.frmAdminAnasayfa_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Button btnOnayli;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblSaygi;
        private System.Windows.Forms.Button btnKullanici;
        private System.Windows.Forms.Button btnFirma;
        private System.Windows.Forms.Button btnOnaysiz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCarpi;
    }
}