namespace MiGame
{
    partial class frmFirmaOyunlarim
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblonay = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.txtOyunAdi = new System.Windows.Forms.RichTextBox();
            this.pbOyunResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(569, 326);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtFiyat);
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.cmbKategori);
            this.panel1.Controls.Add(this.lblKategori);
            this.panel1.Controls.Add(this.lblonay);
            this.panel1.Controls.Add(this.lblPara);
            this.panel1.Controls.Add(this.txtOyunAdi);
            this.panel1.Controls.Add(this.pbOyunResim);
            this.panel1.Location = new System.Drawing.Point(0, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 142);
            this.panel1.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(499, 65);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(77, 20);
            this.txtFiyat.TabIndex = 22;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackgroundImage = global::MiGame.Properties.Resources.buton_mor;
            this.btnGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGüncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnGüncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnGüncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnGüncelle.Location = new System.Drawing.Point(598, 51);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 45);
            this.btnGüncelle.TabIndex = 21;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            this.btnGüncelle.MouseLeave += new System.EventHandler(this.btnGüncelle_MouseLeave);
            this.btnGüncelle.MouseHover += new System.EventHandler(this.btnGüncelle_MouseHover);
            // 
            // cmbKategori
            // 
            this.cmbKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(318, 64);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(131, 21);
            this.cmbKategori.TabIndex = 20;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblKategori.Location = new System.Drawing.Point(327, 28);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(84, 25);
            this.lblKategori.TabIndex = 19;
            this.lblKategori.Text = "Kategori";
            // 
            // lblonay
            // 
            this.lblonay.AutoSize = true;
            this.lblonay.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblonay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblonay.Location = new System.Drawing.Point(342, 104);
            this.lblonay.Name = "lblonay";
            this.lblonay.Size = new System.Drawing.Size(0, 16);
            this.lblonay.TabIndex = 19;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblPara.Location = new System.Drawing.Point(493, 28);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(56, 25);
            this.lblPara.TabIndex = 19;
            this.lblPara.Text = "Fiyat";
            // 
            // txtOyunAdi
            // 
            this.txtOyunAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtOyunAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOyunAdi.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOyunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.txtOyunAdi.Location = new System.Drawing.Point(152, 28);
            this.txtOyunAdi.Name = "txtOyunAdi";
            this.txtOyunAdi.ReadOnly = true;
            this.txtOyunAdi.Size = new System.Drawing.Size(137, 79);
            this.txtOyunAdi.TabIndex = 18;
            this.txtOyunAdi.Text = "Oyun Adı";
            // 
            // pbOyunResim
            // 
            this.pbOyunResim.BackColor = System.Drawing.Color.White;
            this.pbOyunResim.Location = new System.Drawing.Point(21, 13);
            this.pbOyunResim.Name = "pbOyunResim";
            this.pbOyunResim.Size = new System.Drawing.Size(125, 107);
            this.pbOyunResim.TabIndex = 0;
            this.pbOyunResim.TabStop = false;
            // 
            // frmFirmaOyunlarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFirmaOyunlarim";
            this.Text = "frmFirmaOyunlarim";
            this.Load += new System.EventHandler(this.frmFirmaOyunlarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.RichTextBox txtOyunAdi;
        private System.Windows.Forms.PictureBox pbOyunResim;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblonay;
    }
}