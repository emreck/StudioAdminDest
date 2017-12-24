namespace StudioAdminDest
{
    partial class borcOdeme
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
            this.kullaniciListesi = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topkazanc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cekimBasiKazanc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.persAlacak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cekimOdeme = new System.Windows.Forms.Button();
            this.alacakOde = new System.Windows.Forms.Button();
            this.alacak = new System.Windows.Forms.Label();
            this.odemeMiktar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kullaniciListesi
            // 
            this.kullaniciListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.adsoyad,
            this.tel,
            this.topkazanc,
            this.cekimBasiKazanc,
            this.persAlacak});
            this.kullaniciListesi.FullRowSelect = true;
            this.kullaniciListesi.Location = new System.Drawing.Point(12, 12);
            this.kullaniciListesi.Name = "kullaniciListesi";
            this.kullaniciListesi.Size = new System.Drawing.Size(711, 237);
            this.kullaniciListesi.TabIndex = 0;
            this.kullaniciListesi.UseCompatibleStateImageBehavior = false;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // adsoyad
            // 
            this.adsoyad.Text = "ADI SOYADI";
            this.adsoyad.Width = 100;
            // 
            // tel
            // 
            this.tel.Text = "TELEFON NO";
            this.tel.Width = 100;
            // 
            // topkazanc
            // 
            this.topkazanc.Text = "TOPLAM KAZANÇ";
            this.topkazanc.Width = 100;
            // 
            // cekimBasiKazanc
            // 
            this.cekimBasiKazanc.Text = "ÇEKİM BAŞI KAZANÇ";
            this.cekimBasiKazanc.Width = 130;
            // 
            // persAlacak
            // 
            this.persAlacak.Text = "ALACAK";
            this.persAlacak.Width = 100;
            // 
            // cekimOdeme
            // 
            this.cekimOdeme.Location = new System.Drawing.Point(729, 12);
            this.cekimOdeme.Name = "cekimOdeme";
            this.cekimOdeme.Size = new System.Drawing.Size(75, 81);
            this.cekimOdeme.TabIndex = 1;
            this.cekimOdeme.Text = "ÇEKİM ÖDEMESİ YAP";
            this.cekimOdeme.UseVisualStyleBackColor = true;
            this.cekimOdeme.Click += new System.EventHandler(this.cekimOdeme_Click);
            // 
            // alacakOde
            // 
            this.alacakOde.Location = new System.Drawing.Point(729, 174);
            this.alacakOde.Name = "alacakOde";
            this.alacakOde.Size = new System.Drawing.Size(75, 75);
            this.alacakOde.TabIndex = 2;
            this.alacakOde.Text = "ALACAK ÖDEME";
            this.alacakOde.UseVisualStyleBackColor = true;
            this.alacakOde.Click += new System.EventHandler(this.alacakOde_Click);
            // 
            // alacak
            // 
            this.alacak.AutoSize = true;
            this.alacak.Location = new System.Drawing.Point(730, 131);
            this.alacak.Name = "alacak";
            this.alacak.Size = new System.Drawing.Size(68, 13);
            this.alacak.TabIndex = 3;
            this.alacak.Text = "Alacak Tutar";
            // 
            // odemeMiktar
            // 
            this.odemeMiktar.Location = new System.Drawing.Point(729, 148);
            this.odemeMiktar.MaxLength = 11;
            this.odemeMiktar.Name = "odemeMiktar";
            this.odemeMiktar.Size = new System.Drawing.Size(75, 20);
            this.odemeMiktar.TabIndex = 4;
            this.odemeMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.odemeMiktar_KeyPress);
            // 
            // borcOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 259);
            this.Controls.Add(this.odemeMiktar);
            this.Controls.Add(this.alacak);
            this.Controls.Add(this.alacakOde);
            this.Controls.Add(this.cekimOdeme);
            this.Controls.Add(this.kullaniciListesi);
            this.Name = "borcOdeme";
            this.Text = "BORÇ ÖDEME";
            this.Load += new System.EventHandler(this.borcOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView kullaniciListesi;
        private System.Windows.Forms.Button cekimOdeme;
        private System.Windows.Forms.Button alacakOde;
        private System.Windows.Forms.Label alacak;
        private System.Windows.Forms.TextBox odemeMiktar;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader adsoyad;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader topkazanc;
        private System.Windows.Forms.ColumnHeader cekimBasiKazanc;
        private System.Windows.Forms.ColumnHeader persAlacak;
    }
}