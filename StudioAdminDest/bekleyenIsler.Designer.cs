﻿namespace StudioAdminDest
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
            this.referans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teslimDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isiYapanlar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yenile = new System.Windows.Forms.Button();
            this.isAtama = new System.Windows.Forms.Button();
            this.isAtamaGroupbox = new System.Windows.Forms.GroupBox();
            this.personelAta = new System.Windows.Forms.CheckedListBox();
            this.ucretlendirme = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ucret = new System.Windows.Forms.Label();
            this.ucretKontrol = new System.Windows.Forms.TextBox();
            this.personelCb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.isAtamaGroupbox.SuspendLayout();
            this.ucretlendirme.SuspendLayout();
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
            this.referans,
            this.adres,
            this.teslimDurumu,
            this.isiYapanlar});
            this.onayliListe.Location = new System.Drawing.Point(29, 22);
            this.onayliListe.Name = "onayliListe";
            this.onayliListe.Size = new System.Drawing.Size(601, 213);
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
            // referans
            // 
            this.referans.Text = "Referans";
            // 
            // adres
            // 
            this.adres.Text = "Adres";
            // 
            // teslimDurumu
            // 
            this.teslimDurumu.Text = "TESLİM DURUMU";
            // 
            // isiYapanlar
            // 
            this.isiYapanlar.Text = "İŞİ YAPANLAR";
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(636, 173);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(89, 62);
            this.yenile.TabIndex = 1;
            this.yenile.Text = "İŞLERİ YENİLE";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // isAtama
            // 
            this.isAtama.Location = new System.Drawing.Point(201, 72);
            this.isAtama.Name = "isAtama";
            this.isAtama.Size = new System.Drawing.Size(83, 39);
            this.isAtama.TabIndex = 2;
            this.isAtama.Text = "İŞİ GÖNDER";
            this.isAtama.UseVisualStyleBackColor = true;
            this.isAtama.Click += new System.EventHandler(this.isAtama_Click);
            // 
            // isAtamaGroupbox
            // 
            this.isAtamaGroupbox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.isAtamaGroupbox.Controls.Add(this.personelAta);
            this.isAtamaGroupbox.Controls.Add(this.isAtama);
            this.isAtamaGroupbox.Location = new System.Drawing.Point(29, 250);
            this.isAtamaGroupbox.Name = "isAtamaGroupbox";
            this.isAtamaGroupbox.Size = new System.Drawing.Size(290, 134);
            this.isAtamaGroupbox.TabIndex = 3;
            this.isAtamaGroupbox.TabStop = false;
            this.isAtamaGroupbox.Text = "İŞ ATAMA";
            // 
            // personelAta
            // 
            this.personelAta.FormattingEnabled = true;
            this.personelAta.Location = new System.Drawing.Point(18, 19);
            this.personelAta.Name = "personelAta";
            this.personelAta.Size = new System.Drawing.Size(148, 94);
            this.personelAta.TabIndex = 3;
            this.personelAta.SelectedIndexChanged += new System.EventHandler(this.personelAta_SelectedIndexChanged);
            // 
            // ucretlendirme
            // 
            this.ucretlendirme.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucretlendirme.Controls.Add(this.button3);
            this.ucretlendirme.Controls.Add(this.button2);
            this.ucretlendirme.Controls.Add(this.ucret);
            this.ucretlendirme.Controls.Add(this.ucretKontrol);
            this.ucretlendirme.Controls.Add(this.personelCb);
            this.ucretlendirme.Location = new System.Drawing.Point(390, 250);
            this.ucretlendirme.Name = "ucretlendirme";
            this.ucretlendirme.Size = new System.Drawing.Size(240, 134);
            this.ucretlendirme.TabIndex = 4;
            this.ucretlendirme.TabStop = false;
            this.ucretlendirme.Text = "ÜCRETLENDİRME";
            this.ucretlendirme.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "DAHA SONRA ÖDE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "ÖDEME YAP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ucret
            // 
            this.ucret.AutoSize = true;
            this.ucret.Location = new System.Drawing.Point(15, 49);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(50, 13);
            this.ucret.TabIndex = 2;
            this.ucret.Text = "ÜCRET :";
            // 
            // ucretKontrol
            // 
            this.ucretKontrol.Location = new System.Drawing.Point(99, 46);
            this.ucretKontrol.Name = "ucretKontrol";
            this.ucretKontrol.Size = new System.Drawing.Size(135, 20);
            this.ucretKontrol.TabIndex = 1;
            this.ucretKontrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucretKontrol_KeyPress);
            // 
            // personelCb
            // 
            this.personelCb.FormattingEnabled = true;
            this.personelCb.Location = new System.Drawing.Point(18, 19);
            this.personelCb.Name = "personelCb";
            this.personelCb.Size = new System.Drawing.Size(216, 21);
            this.personelCb.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "SEÇİLİ İŞİN TESLİMİNİ ONAYLA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bekleyenIsler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucretlendirme);
            this.Controls.Add(this.isAtamaGroupbox);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.onayliListe);
            this.Name = "bekleyenIsler";
            this.Text = " ";
            this.Load += new System.EventHandler(this.bekleyenIsler_Load);
            this.isAtamaGroupbox.ResumeLayout(false);
            this.ucretlendirme.ResumeLayout(false);
            this.ucretlendirme.PerformLayout();
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
        private System.Windows.Forms.Button isAtama;
        private System.Windows.Forms.ColumnHeader adres;
        private System.Windows.Forms.GroupBox isAtamaGroupbox;
        private System.Windows.Forms.GroupBox ucretlendirme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader teslimDurumu;
        private System.Windows.Forms.ColumnHeader isiYapanlar;
        private System.Windows.Forms.CheckedListBox personelAta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ucret;
        private System.Windows.Forms.TextBox ucretKontrol;
        private System.Windows.Forms.ComboBox personelCb;
    }
}