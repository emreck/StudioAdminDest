namespace StudioAdminDest
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelislemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsteriIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapılacakİşlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiyatlandirmaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baskiIsleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beklemedeList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevuTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevuSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yenile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelislemleriToolStripMenuItem,
            this.müsteriIslemleriToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.fiyatlandirmaIslemleriToolStripMenuItem,
            this.baskiIsleriToolStripMenuItem,
            this.kasaIslemleriToolStripMenuItem,
            this.dosyaIslemleriToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelislemleriToolStripMenuItem
            // 
            this.personelislemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelKayitToolStripMenuItem,
            this.personelGoruntuleToolStripMenuItem});
            this.personelislemleriToolStripMenuItem.Name = "personelislemleriToolStripMenuItem";
            this.personelislemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelislemleriToolStripMenuItem.Text = "Personel işlemleri";
            // 
            // personelKayitToolStripMenuItem
            // 
            this.personelKayitToolStripMenuItem.Name = "personelKayitToolStripMenuItem";
            this.personelKayitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.personelKayitToolStripMenuItem.Text = "Personel Kayıt";
            this.personelKayitToolStripMenuItem.Click += new System.EventHandler(this.personelKayitToolStripMenuItem_Click);
            // 
            // personelGoruntuleToolStripMenuItem
            // 
            this.personelGoruntuleToolStripMenuItem.Name = "personelGoruntuleToolStripMenuItem";
            this.personelGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.personelGoruntuleToolStripMenuItem.Text = "Personel Görüntüle";
            this.personelGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.personelGoruntuleToolStripMenuItem_Click);
            // 
            // müsteriIslemleriToolStripMenuItem
            // 
            this.müsteriIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işOluşturToolStripMenuItem,
            this.yapılacakİşlerToolStripMenuItem,
            this.bToolStripMenuItem});
            this.müsteriIslemleriToolStripMenuItem.Name = "müsteriIslemleriToolStripMenuItem";
            this.müsteriIslemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.müsteriIslemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.müsteriIslemleriToolStripMenuItem.Click += new System.EventHandler(this.müşteriİşlemleriToolStripMenuItem_Click);
            // 
            // işOluşturToolStripMenuItem
            // 
            this.işOluşturToolStripMenuItem.Name = "işOluşturToolStripMenuItem";
            this.işOluşturToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.işOluşturToolStripMenuItem.Text = "İş oluştur";
            // 
            // yapılacakİşlerToolStripMenuItem
            // 
            this.yapılacakİşlerToolStripMenuItem.Name = "yapılacakİşlerToolStripMenuItem";
            this.yapılacakİşlerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.yapılacakİşlerToolStripMenuItem.Text = "Yapılacak İşler";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.bToolStripMenuItem.Text = "Biten İşler";
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // fiyatlandirmaIslemleriToolStripMenuItem
            // 
            this.fiyatlandirmaIslemleriToolStripMenuItem.Name = "fiyatlandirmaIslemleriToolStripMenuItem";
            this.fiyatlandirmaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.fiyatlandirmaIslemleriToolStripMenuItem.Text = "Fiyatlandırma İşlemleri";
            // 
            // baskiIsleriToolStripMenuItem
            // 
            this.baskiIsleriToolStripMenuItem.Name = "baskiIsleriToolStripMenuItem";
            this.baskiIsleriToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.baskiIsleriToolStripMenuItem.Text = "Baskı İşleri";
            // 
            // kasaIslemleriToolStripMenuItem
            // 
            this.kasaIslemleriToolStripMenuItem.Name = "kasaIslemleriToolStripMenuItem";
            this.kasaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.kasaIslemleriToolStripMenuItem.Text = "Kasa işlemleri";
            // 
            // dosyaIslemleriToolStripMenuItem
            // 
            this.dosyaIslemleriToolStripMenuItem.Name = "dosyaIslemleriToolStripMenuItem";
            this.dosyaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.dosyaIslemleriToolStripMenuItem.Text = "Dosya İşlemleri";
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            // 
            // beklemedeList
            // 
            this.beklemedeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.adsoyad,
            this.telno,
            this.randevuTarih,
            this.randevuSaat});
            this.beklemedeList.Location = new System.Drawing.Point(12, 72);
            this.beklemedeList.Name = "beklemedeList";
            this.beklemedeList.Size = new System.Drawing.Size(707, 202);
            this.beklemedeList.TabIndex = 1;
            this.beklemedeList.UseCompatibleStateImageBehavior = false;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // adsoyad
            // 
            this.adsoyad.Text = "AD  - SOYAD";
            // 
            // telno
            // 
            this.telno.DisplayIndex = 4;
            this.telno.Text = "TELEFON";
            this.telno.Width = 120;
            // 
            // randevuTarih
            // 
            this.randevuTarih.DisplayIndex = 2;
            this.randevuTarih.Text = "Randevu Tarih";
            this.randevuTarih.Width = 120;
            // 
            // randevuSaat
            // 
            this.randevuSaat.DisplayIndex = 3;
            this.randevuSaat.Text = "Randevu Saati";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Randevu Kabul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Web üzerinden gelen işler ";
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(163, 281);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(121, 37);
            this.yenile.TabIndex = 4;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 330);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.beklemedeList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelislemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGoruntuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsteriIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapılacakİşlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiyatlandirmaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baskiIsleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ListView beklemedeList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader adsoyad;
        private System.Windows.Forms.ColumnHeader randevuTarih;
        private System.Windows.Forms.ColumnHeader randevuSaat;
        private System.Windows.Forms.ColumnHeader telno;
        private System.Windows.Forms.Button yenile;
    }
}

