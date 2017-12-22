namespace StudioAdminDest
{
    partial class bitenIsler
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
            this.bitenIslerListView = new System.Windows.Forms.ListView();
            this.bitenIslerYenile = new System.Windows.Forms.Button();
            this.odemeTamamla = new System.Windows.Forms.Button();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevuTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teslimTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucretDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isiYapanlar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teslimDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.referans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CekimYeri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bitenIslerListView
            // 
            this.bitenIslerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.adSoyad,
            this.telNo,
            this.teslimTarihi,
            this.teslimDurumu,
            this.randevuTarihi,
            this.saat,
            this.referans,
            this.CekimYeri,
            this.isiYapanlar,
            this.fiyat,
            this.ucretDurumu});
            this.bitenIslerListView.Location = new System.Drawing.Point(3, 12);
            this.bitenIslerListView.Name = "bitenIslerListView";
            this.bitenIslerListView.Size = new System.Drawing.Size(741, 221);
            this.bitenIslerListView.TabIndex = 0;
            this.bitenIslerListView.UseCompatibleStateImageBehavior = false;
            // 
            // bitenIslerYenile
            // 
            this.bitenIslerYenile.Location = new System.Drawing.Point(750, 12);
            this.bitenIslerYenile.Name = "bitenIslerYenile";
            this.bitenIslerYenile.Size = new System.Drawing.Size(75, 78);
            this.bitenIslerYenile.TabIndex = 1;
            this.bitenIslerYenile.Text = "YENİLE";
            this.bitenIslerYenile.UseVisualStyleBackColor = true;
            this.bitenIslerYenile.Click += new System.EventHandler(this.bitenIslerYenile_Click);
            // 
            // odemeTamamla
            // 
            this.odemeTamamla.Location = new System.Drawing.Point(750, 151);
            this.odemeTamamla.Name = "odemeTamamla";
            this.odemeTamamla.Size = new System.Drawing.Size(75, 78);
            this.odemeTamamla.TabIndex = 2;
            this.odemeTamamla.Text = "ÖDEME TAMAMLA";
            this.odemeTamamla.UseVisualStyleBackColor = true;
            this.odemeTamamla.Click += new System.EventHandler(this.odemeTamamla_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // adSoyad
            // 
            this.adSoyad.Text = "ADI SOYADI";
            this.adSoyad.Width = 120;
            // 
            // randevuTarihi
            // 
            this.randevuTarihi.Text = "RANDEVU TARİHİ";
            this.randevuTarihi.Width = 100;
            // 
            // teslimTarihi
            // 
            this.teslimTarihi.Text = "TESLİM TARİHİ";
            this.teslimTarihi.Width = 110;
            // 
            // ucretDurumu
            // 
            this.ucretDurumu.Text = "ÜCRET DURUMU";
            this.ucretDurumu.Width = 120;
            // 
            // fiyat
            // 
            this.fiyat.Text = "FİYAT";
            // 
            // isiYapanlar
            // 
            this.isiYapanlar.Text = "İŞİ YAPANLAR";
            this.isiYapanlar.Width = 100;
            // 
            // telNo
            // 
            this.telNo.Text = "TELEFON";
            this.telNo.Width = 120;
            // 
            // teslimDurumu
            // 
            this.teslimDurumu.Text = "TESLİM DURUMU";
            this.teslimDurumu.Width = 250;
            // 
            // saat
            // 
            this.saat.Text = "SAAT";
            // 
            // referans
            // 
            this.referans.Text = "REFERANS";
            // 
            // CekimYeri
            // 
            this.CekimYeri.Text = "ÇEKİM YERİ";
            this.CekimYeri.Width = 100;
            // 
            // bitenIsler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 241);
            this.Controls.Add(this.odemeTamamla);
            this.Controls.Add(this.bitenIslerYenile);
            this.Controls.Add(this.bitenIslerListView);
            this.Name = "bitenIsler";
            this.Text = "bitenIsler";
            this.Load += new System.EventHandler(this.bitenIsler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bitenIslerListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader adSoyad;
        private System.Windows.Forms.ColumnHeader randevuTarihi;
        private System.Windows.Forms.ColumnHeader teslimTarihi;
        private System.Windows.Forms.ColumnHeader ucretDurumu;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.ColumnHeader isiYapanlar;
        private System.Windows.Forms.Button bitenIslerYenile;
        private System.Windows.Forms.Button odemeTamamla;
        private System.Windows.Forms.ColumnHeader telNo;
        private System.Windows.Forms.ColumnHeader teslimDurumu;
        private System.Windows.Forms.ColumnHeader saat;
        private System.Windows.Forms.ColumnHeader referans;
        private System.Windows.Forms.ColumnHeader CekimYeri;
    }
}