namespace MiGame
{
    partial class frmAdminGiris
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
            this.lblGiris = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblAdminUyari = new System.Windows.Forms.Label();
            this.lblSifreUyari = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCarpi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblGiris.Font = new System.Drawing.Font("Comic Sans MS", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblGiris.Location = new System.Drawing.Point(47, 47);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(151, 74);
            this.lblGiris.TabIndex = 2;
            this.lblGiris.Text = "Giriş";
            // 
            // txtAdmin
            // 
            this.txtAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdmin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.txtAdmin.Location = new System.Drawing.Point(84, 191);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(281, 23);
            this.txtAdmin.TabIndex = 11;
            this.txtAdmin.TextChanged += new System.EventHandler(this.txtAdmin_TextChanged);
            this.txtAdmin.Enter += new System.EventHandler(this.txtAdmin_Enter);
            this.txtAdmin.Leave += new System.EventHandler(this.txtAdmin_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.txtSifre.Location = new System.Drawing.Point(84, 283);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(281, 23);
            this.txtSifre.TabIndex = 11;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // lblAdminUyari
            // 
            this.lblAdminUyari.AutoSize = true;
            this.lblAdminUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblAdminUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblAdminUyari.Location = new System.Drawing.Point(166, 222);
            this.lblAdminUyari.Name = "lblAdminUyari";
            this.lblAdminUyari.Size = new System.Drawing.Size(102, 17);
            this.lblAdminUyari.TabIndex = 13;
            this.lblAdminUyari.Text = "Boş Geçilemez";
            // 
            // lblSifreUyari
            // 
            this.lblSifreUyari.AutoSize = true;
            this.lblSifreUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblSifreUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblSifreUyari.Location = new System.Drawing.Point(166, 318);
            this.lblSifreUyari.Name = "lblSifreUyari";
            this.lblSifreUyari.Size = new System.Drawing.Size(102, 17);
            this.lblSifreUyari.TabIndex = 13;
            this.lblSifreUyari.Text = "Boş Geçilemez";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGiris.BackgroundImage = global::MiGame.Properties.Resources.buton_giris;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGiris.Location = new System.Drawing.Point(149, 365);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(130, 50);
            this.btnGiris.TabIndex = 14;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            this.btnGiris.MouseLeave += new System.EventHandler(this.btnGiris_MouseLeave);
            this.btnGiris.MouseHover += new System.EventHandler(this.btnGiris_MouseHover);
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
            this.btnCarpi.Location = new System.Drawing.Point(402, 12);
            this.btnCarpi.Name = "btnCarpi";
            this.btnCarpi.Size = new System.Drawing.Size(20, 20);
            this.btnCarpi.TabIndex = 0;
            this.btnCarpi.UseVisualStyleBackColor = false;
            this.btnCarpi.Click += new System.EventHandler(this.btnCarpi_Click);
            this.btnCarpi.MouseLeave += new System.EventHandler(this.btnCarpi_MouseLeave);
            this.btnCarpi.MouseHover += new System.EventHandler(this.btnCarpi_MouseHover);
            // 
            // frmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiGame.Properties.Resources.kullanici_giris2;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.btnCarpi);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblSifreUyari);
            this.Controls.Add(this.lblAdminUyari);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.lblGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminGiris";
            this.Load += new System.EventHandler(this.frmAdminGiris_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAdminGiris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAdminGiris_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAdminGiris_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblAdminUyari;
        private System.Windows.Forms.Label lblSifreUyari;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCarpi;
    }
}