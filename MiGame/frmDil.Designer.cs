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
            this.SuspendLayout();
            // 
            // cmbDiller
            // 
            this.cmbDiller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiller.FormattingEnabled = true;
            this.cmbDiller.Location = new System.Drawing.Point(277, 201);
            this.cmbDiller.Name = "cmbDiller";
            this.cmbDiller.Size = new System.Drawing.Size(121, 21);
            this.cmbDiller.TabIndex = 0;
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.Location = new System.Drawing.Point(274, 185);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(62, 13);
            this.lblDil.TabIndex = 1;
            this.lblDil.Text = "Dil Seçiniz :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(295, 249);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmDil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblDil);
            this.Controls.Add(this.cmbDiller);
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
    }
}