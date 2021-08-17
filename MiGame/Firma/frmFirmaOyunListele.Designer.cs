namespace MiGame
{
    partial class frmFirmaOyunListele
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
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.RichTextBox();
            this.txtOyunAdi = new System.Windows.Forms.RichTextBox();
            this.pbOyunResim = new System.Windows.Forms.PictureBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(569, 326);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblFiyat);
            this.panel1.Controls.Add(this.lblPara);
            this.panel1.Controls.Add(this.txtKonu);
            this.panel1.Controls.Add(this.txtOyunAdi);
            this.panel1.Controls.Add(this.pbOyunResim);
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 142);
            this.panel1.TabIndex = 2;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblFiyat.Location = new System.Drawing.Point(465, 59);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(23, 25);
            this.lblFiyat.TabIndex = 19;
            this.lblFiyat.Text = "0";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.lblPara.Location = new System.Drawing.Point(465, 28);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(56, 25);
            this.lblPara.TabIndex = 19;
            this.lblPara.Text = "Fiyat";
            // 
            // txtKonu
            // 
            this.txtKonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtKonu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKonu.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.txtKonu.Location = new System.Drawing.Point(295, 28);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.ReadOnly = true;
            this.txtKonu.Size = new System.Drawing.Size(137, 79);
            this.txtKonu.TabIndex = 18;
            this.txtKonu.Text = "Oyun Konu";
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
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArama.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.txtArama.Location = new System.Drawing.Point(61, 49);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(156, 23);
            this.txtArama.TabIndex = 12;
            this.txtArama.Text = "Oyun Adı";
            this.txtArama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            this.txtArama.Enter += new System.EventHandler(this.txtArama_Enter);
            this.txtArama.Leave += new System.EventHandler(this.txtArama_Leave);
            // 
            // frmFirmaOyunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFirmaOyunListele";
            this.Text = "frmFirmaOyunListele";
            this.Load += new System.EventHandler(this.frmFirmaOyunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.RichTextBox txtKonu;
        private System.Windows.Forms.RichTextBox txtOyunAdi;
        private System.Windows.Forms.PictureBox pbOyunResim;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblFiyat;
    }
}