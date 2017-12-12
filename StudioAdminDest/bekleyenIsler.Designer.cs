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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevuTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevuSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yenile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.adsoyad,
            this.telno,
            this.randevuTarih,
            this.randevuSaat});
            this.listView1.Location = new System.Drawing.Point(29, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(437, 213);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // 
            // bekleyenIsler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 323);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.listView1);
            this.Name = "bekleyenIsler";
            this.Text = "Bekleyen İşler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader adsoyad;
        private System.Windows.Forms.ColumnHeader telno;
        private System.Windows.Forms.ColumnHeader randevuTarih;
        private System.Windows.Forms.ColumnHeader randevuSaat;
        private System.Windows.Forms.Button yenile;
    }
}