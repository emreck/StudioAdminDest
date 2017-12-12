namespace StudioAdminDest
{
    partial class PersonelGoruntule
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
            this.components = new System.ComponentModel.Container();
            this.PersonelListe = new System.Windows.Forms.ListView();
            this.Kuladi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yakintel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topkazanc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cekimkazanc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alacaklari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kultip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verileriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonelListe
            // 
            this.PersonelListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kuladi,
            this.adsoyad,
            this.tel,
            this.yakintel,
            this.adres,
            this.kan,
            this.topkazanc,
            this.cekimkazanc,
            this.alacaklari,
            this.kultip});
            this.PersonelListe.ContextMenuStrip = this.contextMenuStrip1;
            this.PersonelListe.FullRowSelect = true;
            this.PersonelListe.Location = new System.Drawing.Point(12, 41);
            this.PersonelListe.Name = "PersonelListe";
            this.PersonelListe.Size = new System.Drawing.Size(870, 230);
            this.PersonelListe.TabIndex = 0;
            this.PersonelListe.UseCompatibleStateImageBehavior = false;
            this.PersonelListe.View = System.Windows.Forms.View.Details;
            // 
            // Kuladi
            // 
            this.Kuladi.Text = "Kullanıcı Adı";
            this.Kuladi.Width = 93;
            // 
            // adsoyad
            // 
            this.adsoyad.Text = "Ad Soyad";
            this.adsoyad.Width = 77;
            // 
            // tel
            // 
            this.tel.Text = "Tel No";
            this.tel.Width = 87;
            // 
            // yakintel
            // 
            this.yakintel.Text = "Yakınının Tel No";
            this.yakintel.Width = 95;
            // 
            // adres
            // 
            this.adres.Text = "Adres";
            this.adres.Width = 99;
            // 
            // kan
            // 
            this.kan.Text = "Kan Grubu";
            this.kan.Width = 85;
            // 
            // topkazanc
            // 
            this.topkazanc.Text = "Toplam Kazanç";
            this.topkazanc.Width = 91;
            // 
            // cekimkazanc
            // 
            this.cekimkazanc.Text = "Çekim Başı Kazanç";
            this.cekimkazanc.Width = 99;
            // 
            // alacaklari
            // 
            this.alacaklari.Text = "Alacakları";
            this.alacaklari.Width = 76;
            // 
            // kultip
            // 
            this.kultip.Text = "Kullanıcı Tipi";
            this.kultip.Width = 103;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verileriGösterToolStripMenuItem,
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // verileriGösterToolStripMenuItem
            // 
            this.verileriGösterToolStripMenuItem.Name = "verileriGösterToolStripMenuItem";
            this.verileriGösterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verileriGösterToolStripMenuItem.Text = "Verileri Göster";
            this.verileriGösterToolStripMenuItem.Click += new System.EventHandler(this.verileriGösterToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(12, 10);
            this.arama.Multiline = true;
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(100, 20);
            this.arama.TabIndex = 2;
            this.arama.Text = "Ad-Soyad Araması";
            this.arama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arama.MouseClick += new System.Windows.Forms.MouseEventHandler(this.arama_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonelGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.PersonelListe);
            this.Name = "PersonelGoruntule";
            this.Text = "PersonelGoruntule";
            this.Load += new System.EventHandler(this.PersonelGoruntule_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PersonelListe;
        private System.Windows.Forms.ColumnHeader Kuladi;
        private System.Windows.Forms.ColumnHeader adsoyad;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader yakintel;
        private System.Windows.Forms.ColumnHeader adres;
        private System.Windows.Forms.ColumnHeader kan;
        private System.Windows.Forms.ColumnHeader topkazanc;
        private System.Windows.Forms.ColumnHeader cekimkazanc;
        private System.Windows.Forms.ColumnHeader alacaklari;
        private System.Windows.Forms.ColumnHeader kultip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem verileriGösterToolStripMenuItem;
    }
}