namespace StudioAdminDest
{
    partial class bekleyenIsler
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
            this.onayliListe = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevuTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevuSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yenile = new System.Windows.Forms.Button();
            this.referans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // onayliListe
            // 
            this.onayliListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.adsoyad,
            this.telno,
            this.randevuTarih,
            this.randevuSaat,
            this.referans});
            this.onayliListe.Location = new System.Drawing.Point(29, 22);
            this.onayliListe.Name = "onayliListe";
            this.onayliListe.Size = new System.Drawing.Size(550, 213);
            this.onayliListe.TabIndex = 0;
            this.onayliListe.UseCompatibleStateImageBehavior = false;
            // 
            // id
            // 
            this.id.Text = "İD";
            // 
            // adsoyad
            // 
            this.adsoyad.Text = "AD SOYAD";
            // 
            // telno
            // 
            this.telno.Text = "TELEFON ";
            // 
            // randevuTarih
            // 
            this.randevuTarih.Text = "RANDEVU TARİHİ";
            // 
            // randevuSaat
            // 
            this.randevuSaat.Text = "Randevu Saati";
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(126, 258);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(89, 39);
            this.yenile.TabIndex = 1;
            this.yenile.Text = "YENİLE";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // referans
            // 
            this.referans.Text = "Referans";
            // 
            // bekleyenIsler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 323);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.onayliListe);
            this.Name = "bekleyenIsler";
            this.Text = "Bekleyen İşler";
            this.Load += new System.EventHandler(this.bekleyenIsler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView onayliListe;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader adsoyad;
        private System.Windows.Forms.ColumnHeader telno;
        private System.Windows.Forms.ColumnHeader randevuTarih;
        private System.Windows.Forms.ColumnHeader randevuSaat;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.ColumnHeader referans;
    }
}