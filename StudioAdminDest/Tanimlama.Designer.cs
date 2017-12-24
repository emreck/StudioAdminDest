namespace StudioAdminDest
{
    partial class Tanimlama
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
            this.istur = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iskaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ısturu2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.videoEkle = new System.Windows.Forms.Button();
            this.fotografekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.video = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fotograf = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cekimyer2 = new System.Windows.Forms.TextBox();
            this.cekimekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.istur.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // istur
            // 
            this.istur.Controls.Add(this.tabPage1);
            this.istur.Controls.Add(this.tabPage2);
            this.istur.Controls.Add(this.tabPage3);
            this.istur.Location = new System.Drawing.Point(2, 3);
            this.istur.Name = "istur";
            this.istur.SelectedIndex = 0;
            this.istur.Size = new System.Drawing.Size(354, 229);
            this.istur.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.iskaydet);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ısturu2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İş Türü Tanımla";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // iskaydet
            // 
            this.iskaydet.Location = new System.Drawing.Point(118, 115);
            this.iskaydet.Name = "iskaydet";
            this.iskaydet.Size = new System.Drawing.Size(78, 35);
            this.iskaydet.TabIndex = 2;
            this.iskaydet.Text = "Kaydet";
            this.iskaydet.UseVisualStyleBackColor = true;
            this.iskaydet.Click += new System.EventHandler(this.iskaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İş türü oluştur";
            // 
            // ısturu2
            // 
            this.ısturu2.Location = new System.Drawing.Point(109, 72);
            this.ısturu2.Name = "ısturu2";
            this.ısturu2.Size = new System.Drawing.Size(100, 20);
            this.ısturu2.TabIndex = 0;
            this.ısturu2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ısturu2_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.videoEkle);
            this.tabPage2.Controls.Add(this.fotografekle);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.video);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.fotograf);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çekim Türü Tanımla";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // videoEkle
            // 
            this.videoEkle.Location = new System.Drawing.Point(229, 114);
            this.videoEkle.Name = "videoEkle";
            this.videoEkle.Size = new System.Drawing.Size(75, 23);
            this.videoEkle.TabIndex = 7;
            this.videoEkle.Text = "Ekle";
            this.videoEkle.UseVisualStyleBackColor = true;
            this.videoEkle.Click += new System.EventHandler(this.videoEkle_Click);
            // 
            // fotografekle
            // 
            this.fotografekle.Location = new System.Drawing.Point(229, 49);
            this.fotografekle.Name = "fotografekle";
            this.fotografekle.Size = new System.Drawing.Size(75, 23);
            this.fotografekle.TabIndex = 6;
            this.fotografekle.Text = "Ekle";
            this.fotografekle.UseVisualStyleBackColor = true;
            this.fotografekle.Click += new System.EventHandler(this.fotografekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video";
            // 
            // video
            // 
            this.video.Location = new System.Drawing.Point(107, 116);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(100, 20);
            this.video.TabIndex = 4;
            this.video.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.video_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fotoğraf";
            // 
            // fotograf
            // 
            this.fotograf.Location = new System.Drawing.Point(107, 51);
            this.fotograf.Name = "fotograf";
            this.fotograf.Size = new System.Drawing.Size(100, 20);
            this.fotograf.TabIndex = 0;
            this.fotograf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fotograf_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cekimyer2);
            this.tabPage3.Controls.Add(this.cekimekle);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(346, 203);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Çekim Yeri Tanımla";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cekimyer2
            // 
            this.cekimyer2.Location = new System.Drawing.Point(108, 77);
            this.cekimyer2.Name = "cekimyer2";
            this.cekimyer2.Size = new System.Drawing.Size(100, 20);
            this.cekimyer2.TabIndex = 2;
            this.cekimyer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cekimyer2_KeyPress);
            // 
            // cekimekle
            // 
            this.cekimekle.Location = new System.Drawing.Point(120, 114);
            this.cekimekle.Name = "cekimekle";
            this.cekimekle.Size = new System.Drawing.Size(75, 26);
            this.cekimekle.TabIndex = 1;
            this.cekimekle.Text = "Ekle";
            this.cekimekle.UseVisualStyleBackColor = true;
            this.cekimekle.Click += new System.EventHandler(this.cekimekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Çekim Yeri Ekle";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Tanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 235);
            this.Controls.Add(this.istur);
            this.Name = "Tanimlama";
            this.Text = "Tanimlama";
            this.istur.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl istur;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button iskaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ısturu2;
        private System.Windows.Forms.Button videoEkle;
        private System.Windows.Forms.Button fotografekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox video;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fotograf;
        private System.Windows.Forms.TextBox cekimyer2;
        private System.Windows.Forms.Button cekimekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}