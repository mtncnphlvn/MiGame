namespace MiGame
{
    partial class frmDil
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
            this.cmbDiller = new System.Windows.Forms.ComboBox();
            this.lblDil = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCarpi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDiller
            // 
            this.cmbDiller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiller.FormattingEnabled = true;
            this.cmbDiller.Location = new System.Drawing.Point(104, 91);
            this.cmbDiller.Name = "cmbDiller";
            this.cmbDiller.Size = new System.Drawing.Size(121, 21);
            this.cmbDiller.TabIndex = 0;
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(0)))));
            this.lblDil.Location = new System.Drawing.Point(102, 51);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(123, 28);
            this.lblDil.TabIndex = 1;
            this.lblDil.Text = "Dil Seçiniz :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKaydet.BackgroundImage = global::MiGame.Properties.Resources.buton_giris;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.btnKaydet.Location = new System.Drawing.Point(116, 126);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 40);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            this.btnKaydet.MouseLeave += new System.EventHandler(this.btnKaydet_MouseLeave);
            this.btnKaydet.MouseHover += new System.EventHandler(this.btnKaydet_MouseHover);
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
            this.btnCarpi.Location = new System.Drawing.Point(323, 12);
            this.btnCarpi.Name = "btnCarpi";
            this.btnCarpi.Size = new System.Drawing.Size(20, 20);
            this.btnCarpi.TabIndex = 8;
            this.btnCarpi.UseVisualStyleBackColor = false;
            this.btnCarpi.Click += new System.EventHandler(this.btnCarpi_Click);
            this.btnCarpi.MouseLeave += new System.EventHandler(this.btnCarpi_MouseLeave);
            this.btnCarpi.MouseHover += new System.EventHandler(this.btnCarpi_MouseHover);
            // 
            // frmDil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(20)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(355, 213);
            this.Controls.Add(this.btnCarpi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblDil);
            this.Controls.Add(this.cmbDiller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDil";
            this.Text = "frmDil";
            this.Load += new System.EventHandler(this.frmDil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDiller;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCarpi;
    }
}