namespace MiGame
{
    partial class frmFirmaProfil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGorusler = new System.Windows.Forms.Label();
            this.lblResim = new System.Windows.Forms.Label();
            this.lblDil = new System.Windows.Forms.Label();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnDegis = new System.Windows.Forms.Button();
            this.lblonay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 393);
            this.dataGridView1.TabIndex = 16;
            // 
            // lblGorusler
            // 
            this.lblGorusler.AutoSize = true;
            this.lblGorusler.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorusler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblGorusler.Location = new System.Drawing.Point(264, 137);
            this.lblGorusler.Name = "lblGorusler";
            this.lblGorusler.Size = new System.Drawing.Size(183, 55);
            this.lblGorusler.TabIndex = 17;
            this.lblGorusler.Text = "Görüşler";
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblResim.Location = new System.Drawing.Point(12, 9);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(121, 23);
            this.lblResim.TabIndex = 17;
            this.lblResim.Text = "Resim Güncelle";
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblDil.Location = new System.Drawing.Point(503, 9);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(85, 23);
            this.lblDil.TabIndex = 17;
            this.lblDil.Text = "Dil Seçimi";
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtResimYolu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResimYolu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResimYolu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.txtResimYolu.Location = new System.Drawing.Point(16, 35);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.ReadOnly = true;
            this.txtResimYolu.Size = new System.Drawing.Size(96, 23);
            this.txtResimYolu.TabIndex = 18;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(118, 36);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(31, 22);
            this.btnResimSec.TabIndex = 19;
            this.btnResimSec.Text = "...";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGuncelle.BackgroundImage = global::MiGame.Properties.Resources.buton_giris;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnGuncelle.Location = new System.Drawing.Point(32, 64);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 35);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnKod_Click);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            this.btnGuncelle.MouseHover += new System.EventHandler(this.btnGuncelle_MouseHover);
            // 
            // btnDegis
            // 
            this.btnDegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnDegis.BackgroundImage = global::MiGame.Properties.Resources.buton_giris;
            this.btnDegis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnDegis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnDegis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnDegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegis.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnDegis.Location = new System.Drawing.Point(507, 36);
            this.btnDegis.Name = "btnDegis";
            this.btnDegis.Size = new System.Drawing.Size(80, 35);
            this.btnDegis.TabIndex = 20;
            this.btnDegis.Text = "Değiştir";
            this.btnDegis.UseVisualStyleBackColor = false;
            this.btnDegis.Click += new System.EventHandler(this.btnDegis_Click);
            this.btnDegis.MouseLeave += new System.EventHandler(this.btnDegis_MouseLeave);
            this.btnDegis.MouseHover += new System.EventHandler(this.btnDegis_MouseHover);
            // 
            // lblonay
            // 
            this.lblonay.AutoSize = true;
            this.lblonay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblonay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblonay.Location = new System.Drawing.Point(12, 102);
            this.lblonay.Name = "lblonay";
            this.lblonay.Size = new System.Drawing.Size(0, 23);
            this.lblonay.TabIndex = 17;
            // 
            // frmFirmaProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.lblDil);
            this.Controls.Add(this.btnDegis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.txtResimYolu);
            this.Controls.Add(this.lblonay);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.lblGorusler);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFirmaProfil";
            this.Text = "frmFirmaProfil";
            this.Load += new System.EventHandler(this.frmFirmaProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGorusler;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.TextBox txtResimYolu;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnDegis;
        private System.Windows.Forms.Label lblonay;
    }
}