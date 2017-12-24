namespace StudioAdminDest
{
    partial class Baski
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
            this.karton = new System.Windows.Forms.TextBox();
            this.plastik = new System.Windows.Forms.TextBox();
            this.luks = new System.Windows.Forms.TextBox();
            this.ucretsiz = new System.Windows.Forms.TextBox();
            this.toplam = new System.Windows.Forms.TextBox();
            this.musteri = new System.Windows.Forms.ComboBox();
            this.Personel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ucret = new System.Windows.Forms.TextBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Seçim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baskı Personeli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Karton Çerçeve";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plastik Çerçeve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lüks Çerçeve";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ücretsiz Verilen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Toplam Baskı";
            // 
            // karton
            // 
            this.karton.Location = new System.Drawing.Point(144, 90);
            this.karton.MaxLength = 3;
            this.karton.Name = "karton";
            this.karton.Size = new System.Drawing.Size(121, 20);
            this.karton.TabIndex = 9;
            this.karton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.karton_KeyPress);
            // 
            // plastik
            // 
            this.plastik.Location = new System.Drawing.Point(144, 116);
            this.plastik.MaxLength = 3;
            this.plastik.Name = "plastik";
            this.plastik.Size = new System.Drawing.Size(121, 20);
            this.plastik.TabIndex = 10;
            this.plastik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.plastik_KeyPress);
            // 
            // luks
            // 
            this.luks.Location = new System.Drawing.Point(144, 142);
            this.luks.MaxLength = 3;
            this.luks.Name = "luks";
            this.luks.Size = new System.Drawing.Size(121, 20);
            this.luks.TabIndex = 11;
            this.luks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.luks_KeyPress);
            // 
            // ucretsiz
            // 
            this.ucretsiz.Location = new System.Drawing.Point(144, 168);
            this.ucretsiz.MaxLength = 3;
            this.ucretsiz.Name = "ucretsiz";
            this.ucretsiz.Size = new System.Drawing.Size(121, 20);
            this.ucretsiz.TabIndex = 12;
            this.ucretsiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucretsiz_KeyPress);
            // 
            // toplam
            // 
            this.toplam.Location = new System.Drawing.Point(144, 194);
            this.toplam.MaxLength = 3;
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(121, 20);
            this.toplam.TabIndex = 13;
            this.toplam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toplam_KeyPress);
            // 
            // musteri
            // 
            this.musteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musteri.FormattingEnabled = true;
            this.musteri.Location = new System.Drawing.Point(144, 33);
            this.musteri.Name = "musteri";
            this.musteri.Size = new System.Drawing.Size(121, 21);
            this.musteri.TabIndex = 14;
            // 
            // Personel
            // 
            this.Personel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Personel.FormattingEnabled = true;
            this.Personel.Location = new System.Drawing.Point(144, 63);
            this.Personel.Name = "Personel";
            this.Personel.Size = new System.Drawing.Size(121, 21);
            this.Personel.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ücret";
            // 
            // ucret
            // 
            this.ucret.Location = new System.Drawing.Point(144, 222);
            this.ucret.MaxLength = 5;
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(121, 20);
            this.ucret.TabIndex = 17;
            this.ucret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucret_KeyPress);
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(162, 257);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(83, 29);
            this.Kaydet.TabIndex = 18;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Baski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 319);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.ucret);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Personel);
            this.Controls.Add(this.musteri);
            this.Controls.Add(this.toplam);
            this.Controls.Add(this.ucretsiz);
            this.Controls.Add(this.luks);
            this.Controls.Add(this.plastik);
            this.Controls.Add(this.karton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Baski";
            this.Text = "Baski";
            this.Load += new System.EventHandler(this.Baski_Load);
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
        private System.Windows.Forms.TextBox karton;
        private System.Windows.Forms.TextBox plastik;
        private System.Windows.Forms.TextBox luks;
        private System.Windows.Forms.TextBox ucretsiz;
        private System.Windows.Forms.TextBox toplam;
        private System.Windows.Forms.ComboBox musteri;
        private System.Windows.Forms.ComboBox Personel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ucret;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}