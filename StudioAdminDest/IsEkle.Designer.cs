namespace StudioAdminDest
{
    partial class IsEkle
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
            this.isiEkle = new System.Windows.Forms.Button();
            this.isAdSoyad = new System.Windows.Forms.TextBox();
            this.isTel = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saatLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.adSoyadlbl = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.tarihLabel = new System.Windows.Forms.Label();
            this.saatLbl = new System.Windows.Forms.Label();
            this.isReferans = new System.Windows.Forms.TextBox();
            this.referansLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.adresRichTextbox = new System.Windows.Forms.RichTextBox();
            this.fiyatTextbox = new System.Windows.Forms.TextBox();
            this.fiyatLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // isiEkle
            // 
            this.isiEkle.Location = new System.Drawing.Point(146, 289);
            this.isiEkle.Name = "isiEkle";
            this.isiEkle.Size = new System.Drawing.Size(100, 62);
            this.isiEkle.TabIndex = 0;
            this.isiEkle.Text = "İŞ EKLE";
            this.isiEkle.UseVisualStyleBackColor = true;
            this.isiEkle.Click += new System.EventHandler(this.isiEkle_Click);
            // 
            // isAdSoyad
            // 
            this.isAdSoyad.Location = new System.Drawing.Point(148, 12);
            this.isAdSoyad.MaxLength = 20;
            this.isAdSoyad.Name = "isAdSoyad";
            this.isAdSoyad.Size = new System.Drawing.Size(141, 20);
            this.isAdSoyad.TabIndex = 1;
            // 
            // isTel
            // 
            this.isTel.Location = new System.Drawing.Point(148, 39);
            this.isTel.MaxLength = 11;
            this.isTel.Name = "isTel";
            this.isTel.Size = new System.Drawing.Size(141, 20);
            this.isTel.TabIndex = 2;
            this.isTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isTel_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.comboBox1.Location = new System.Drawing.Point(148, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // saatLabel
            // 
            this.saatLabel.AutoSize = true;
            this.saatLabel.Location = new System.Drawing.Point(195, 102);
            this.saatLabel.Name = "saatLabel";
            this.saatLabel.Size = new System.Drawing.Size(10, 13);
            this.saatLabel.TabIndex = 6;
            this.saatLabel.Text = ":";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBox2.Location = new System.Drawing.Point(211, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(37, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // adSoyadlbl
            // 
            this.adSoyadlbl.AutoSize = true;
            this.adSoyadlbl.Location = new System.Drawing.Point(38, 19);
            this.adSoyadlbl.Name = "adSoyadlbl";
            this.adSoyadlbl.Size = new System.Drawing.Size(62, 13);
            this.adSoyadlbl.TabIndex = 8;
            this.adSoyadlbl.Text = "AD SOYAD";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(38, 42);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(56, 13);
            this.Telefon.TabIndex = 9;
            this.Telefon.Text = "TELEFON";
            // 
            // tarihLabel
            // 
            this.tarihLabel.AutoSize = true;
            this.tarihLabel.Location = new System.Drawing.Point(38, 72);
            this.tarihLabel.Name = "tarihLabel";
            this.tarihLabel.Size = new System.Drawing.Size(85, 13);
            this.tarihLabel.TabIndex = 11;
            this.tarihLabel.Text = " TESLİM TARİH";
            // 
            // saatLbl
            // 
            this.saatLbl.AutoSize = true;
            this.saatLbl.Location = new System.Drawing.Point(38, 102);
            this.saatLbl.Name = "saatLbl";
            this.saatLbl.Size = new System.Drawing.Size(35, 13);
            this.saatLbl.TabIndex = 12;
            this.saatLbl.Text = "SAAT";
            // 
            // isReferans
            // 
            this.isReferans.Location = new System.Drawing.Point(148, 238);
            this.isReferans.MaxLength = 20;
            this.isReferans.Name = "isReferans";
            this.isReferans.Size = new System.Drawing.Size(136, 20);
            this.isReferans.TabIndex = 13;
            this.isReferans.Text = " ";
            // 
            // referansLbl
            // 
            this.referansLbl.AutoSize = true;
            this.referansLbl.Location = new System.Drawing.Point(38, 245);
            this.referansLbl.Name = "referansLbl";
            this.referansLbl.Size = new System.Drawing.Size(68, 13);
            this.referansLbl.TabIndex = 14;
            this.referansLbl.Text = " REFERANS";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ADRES";
            // 
            // adresRichTextbox
            // 
            this.adresRichTextbox.Location = new System.Drawing.Point(146, 172);
            this.adresRichTextbox.MaxLength = 120;
            this.adresRichTextbox.Name = "adresRichTextbox";
            this.adresRichTextbox.Size = new System.Drawing.Size(138, 46);
            this.adresRichTextbox.TabIndex = 16;
            this.adresRichTextbox.Text = "";
            // 
            // fiyatTextbox
            // 
            this.fiyatTextbox.Location = new System.Drawing.Point(146, 132);
            this.fiyatTextbox.MaxLength = 4;
            this.fiyatTextbox.Name = "fiyatTextbox";
            this.fiyatTextbox.Size = new System.Drawing.Size(43, 20);
            this.fiyatTextbox.TabIndex = 17;
            this.fiyatTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiyatTextbox_KeyPress);
            // 
            // fiyatLbl
            // 
            this.fiyatLbl.AutoSize = true;
            this.fiyatLbl.Location = new System.Drawing.Point(38, 132);
            this.fiyatLbl.Name = "fiyatLbl";
            this.fiyatLbl.Size = new System.Drawing.Size(37, 13);
            this.fiyatLbl.TabIndex = 18;
            this.fiyatLbl.Text = "FİYAT";
            // 
            // IsEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 363);
            this.Controls.Add(this.fiyatLbl);
            this.Controls.Add(this.fiyatTextbox);
            this.Controls.Add(this.adresRichTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.referansLbl);
            this.Controls.Add(this.isReferans);
            this.Controls.Add(this.saatLbl);
            this.Controls.Add(this.tarihLabel);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.adSoyadlbl);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.saatLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.isTel);
            this.Controls.Add(this.isAdSoyad);
            this.Controls.Add(this.isiEkle);
            this.Name = "IsEkle";
            this.Text = "İŞ EKLE";
            this.Load += new System.EventHandler(this.IsEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button isiEkle;
        private System.Windows.Forms.TextBox isAdSoyad;
        private System.Windows.Forms.TextBox isTel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label saatLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label adSoyadlbl;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label tarihLabel;
        private System.Windows.Forms.Label saatLbl;
        private System.Windows.Forms.TextBox isReferans;
        private System.Windows.Forms.Label referansLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label fiyatLbl;
        private System.Windows.Forms.TextBox fiyatTextbox;
        private System.Windows.Forms.RichTextBox adresRichTextbox;
        private System.Windows.Forms.Label label1;
    }
}