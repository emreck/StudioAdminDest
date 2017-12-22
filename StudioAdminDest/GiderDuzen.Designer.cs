namespace StudioAdminDest
{
    partial class GiderDuzen
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
            this.guncel = new System.Windows.Forms.Button();
            this.personel = new System.Windows.Forms.ComboBox();
            this.giderTip = new System.Windows.Forms.ComboBox();
            this.giderAdi = new System.Windows.Forms.TextBox();
            this.GiderTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guncel
            // 
            this.guncel.Location = new System.Drawing.Point(114, 142);
            this.guncel.Name = "guncel";
            this.guncel.Size = new System.Drawing.Size(86, 29);
            this.guncel.TabIndex = 8;
            this.guncel.Text = "Güncelle";
            this.guncel.UseVisualStyleBackColor = true;
            this.guncel.Click += new System.EventHandler(this.guncel_Click);
            // 
            // personel
            // 
            this.personel.FormattingEnabled = true;
            this.personel.Location = new System.Drawing.Point(98, 24);
            this.personel.Name = "personel";
            this.personel.Size = new System.Drawing.Size(121, 21);
            this.personel.TabIndex = 9;
            // 
            // giderTip
            // 
            this.giderTip.FormattingEnabled = true;
            this.giderTip.Items.AddRange(new object[] {
            "Fotoğraf Ekipman Gideri",
            "Video Ekipman Gideri",
            "Baskı Giderleri",
            "Kırtasiye Gideri",
            "Diğer"});
            this.giderTip.Location = new System.Drawing.Point(98, 51);
            this.giderTip.Name = "giderTip";
            this.giderTip.Size = new System.Drawing.Size(121, 21);
            this.giderTip.TabIndex = 10;
            // 
            // giderAdi
            // 
            this.giderAdi.Location = new System.Drawing.Point(98, 79);
            this.giderAdi.Name = "giderAdi";
            this.giderAdi.Size = new System.Drawing.Size(121, 20);
            this.giderAdi.TabIndex = 11;
            // 
            // GiderTutar
            // 
            this.GiderTutar.Location = new System.Drawing.Point(98, 105);
            this.GiderTutar.Name = "GiderTutar";
            this.GiderTutar.Size = new System.Drawing.Size(121, 20);
            this.GiderTutar.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gider Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gider Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Personeline Ait Toplam Gider :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GiderDuzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 234);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GiderTutar);
            this.Controls.Add(this.giderAdi);
            this.Controls.Add(this.giderTip);
            this.Controls.Add(this.personel);
            this.Controls.Add(this.guncel);
            this.Name = "GiderDuzen";
            this.Text = "GiderDuzen";
            this.Load += new System.EventHandler(this.GiderDuzen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guncel;
        private System.Windows.Forms.ComboBox personel;
        private System.Windows.Forms.ComboBox giderTip;
        private System.Windows.Forms.TextBox giderAdi;
        private System.Windows.Forms.TextBox GiderTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}