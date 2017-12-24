namespace StudioAdminDest
{
    partial class PersonelKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kulAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Kan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tel = new System.Windows.Forms.MaskedTextBox();
            this.YakinTel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Kazanc = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.sifretek = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullacı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yakınının Tel No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kan Grubu :";
            // 
            // kulAdi
            // 
            this.kulAdi.Location = new System.Drawing.Point(166, 12);
            this.kulAdi.Name = "kulAdi";
            this.kulAdi.Size = new System.Drawing.Size(159, 20);
            this.kulAdi.TabIndex = 8;
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(166, 39);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(159, 20);
            this.Sifre.TabIndex = 9;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Location = new System.Drawing.Point(166, 96);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(159, 20);
            this.AdSoyad.TabIndex = 10;
            this.AdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdSoyad_KeyPress);
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(166, 182);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(159, 20);
            this.Adres.TabIndex = 13;
            // 
            // Kan
            // 
            this.Kan.Location = new System.Drawing.Point(166, 214);
            this.Kan.Name = "Kan";
            this.Kan.Size = new System.Drawing.Size(159, 20);
            this.Kan.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(166, 128);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(159, 20);
            this.Tel.TabIndex = 17;
            this.Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tel_KeyPress);
            // 
            // YakinTel
            // 
            this.YakinTel.Location = new System.Drawing.Point(166, 156);
            this.YakinTel.Name = "YakinTel";
            this.YakinTel.Size = new System.Drawing.Size(159, 20);
            this.YakinTel.TabIndex = 18;
            this.YakinTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YakinTel_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Çekim Başı Kazanç :";
            // 
            // Kazanc
            // 
            this.Kazanc.Location = new System.Drawing.Point(166, 247);
            this.Kazanc.Name = "Kazanc";
            this.Kazanc.Size = new System.Drawing.Size(159, 20);
            this.Kazanc.TabIndex = 15;
            this.Kazanc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kazanc_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Şifre Tekrar :";
            // 
            // sifretek
            // 
            this.sifretek.Location = new System.Drawing.Point(166, 66);
            this.sifretek.Name = "sifretek";
            this.sifretek.Size = new System.Drawing.Size(159, 20);
            this.sifretek.TabIndex = 20;
            // 
            // PersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 326);
            this.Controls.Add(this.sifretek);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.YakinTel);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kazanc);
            this.Controls.Add(this.Kan);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.AdSoyad);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.kulAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonelKayit";
            this.Text = "PersonelKayit";
            this.Load += new System.EventHandler(this.PersonelKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kulAdi;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.TextBox AdSoyad;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox Kan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox Tel;
        private System.Windows.Forms.MaskedTextBox YakinTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Kazanc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox sifretek;
        private System.Windows.Forms.Label label9;
    }
}