namespace MiGame
{
    partial class frmKullaniciKutuphane
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYorum = new System.Windows.Forms.Button();
            this.btnPuan = new System.Windows.Forms.Button();
            this.txtKonu = new System.Windows.Forms.RichTextBox();
            this.txtOyunAdi = new System.Windows.Forms.RichTextBox();
            this.pbOyunResim = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnYorum);
            this.panel1.Controls.Add(this.btnPuan);
            this.panel1.Controls.Add(this.txtKonu);
            this.panel1.Controls.Add(this.txtOyunAdi);
            this.panel1.Controls.Add(this.pbOyunResim);
            this.panel1.Location = new System.Drawing.Point(1, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 142);
            this.panel1.TabIndex = 17;
            // 
            // btnYorum
            // 
            this.btnYorum.BackgroundImage = global::MiGame.Properties.Resources.buton_mor;
            this.btnYorum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYorum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnYorum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnYorum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnYorum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYorum.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYorum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnYorum.Location = new System.Drawing.Point(569, 62);
            this.btnYorum.Name = "btnYorum";
            this.btnYorum.Size = new System.Drawing.Size(100, 45);
            this.btnYorum.TabIndex = 20;
            this.btnYorum.Text = "Yorum Yap";
            this.btnYorum.UseVisualStyleBackColor = true;
            this.btnYorum.Click += new System.EventHandler(this.btnYorum_Click);
            this.btnYorum.MouseLeave += new System.EventHandler(this.btnYorum_MouseLeave);
            this.btnYorum.MouseHover += new System.EventHandler(this.btnYorum_MouseHover);
            // 
            // btnPuan
            // 
            this.btnPuan.BackgroundImage = global::MiGame.Properties.Resources.buton_mor;
            this.btnPuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPuan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnPuan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnPuan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnPuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuan.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.btnPuan.Location = new System.Drawing.Point(463, 62);
            this.btnPuan.Name = "btnPuan";
            this.btnPuan.Size = new System.Drawing.Size(100, 45);
            this.btnPuan.TabIndex = 20;
            this.btnPuan.Text = "Puan Ver";
            this.btnPuan.UseVisualStyleBackColor = true;
            this.btnPuan.Click += new System.EventHandler(this.btnPuan_Click);
            this.btnPuan.MouseLeave += new System.EventHandler(this.btnPuan_MouseLeave);
            this.btnPuan.MouseHover += new System.EventHandler(this.btnPuan_MouseHover);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(621, 326);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmKullaniciKutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullaniciKutuphane";
            this.Text = "frmKullaniciKutuphane";
            this.Load += new System.EventHandler(this.frmKullaniciKutuphane_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYorum;
        private System.Windows.Forms.Button btnPuan;
        private System.Windows.Forms.RichTextBox txtKonu;
        private System.Windows.Forms.RichTextBox txtOyunAdi;
        private System.Windows.Forms.PictureBox pbOyunResim;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}