namespace StudioAdminDest
{
    partial class Giderler
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
            this.giderTip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.giderAdi = new System.Windows.Forms.TextBox();
            this.giderTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gidergor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listele = new System.Windows.Forms.ListBox();
            this.Kayit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.aramaText = new System.Windows.Forms.TextBox();
            this.Arama = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // giderTip
            // 
            this.giderTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.giderTip.FormattingEnabled = true;
            this.giderTip.Items.AddRange(new object[] {
            "Fotoğraf Ekipman Gideri",
            "Video Ekipman Gideri",
            "Baskı Giderleri",
            "Kırtasiye Gideri",
            "Diğer"});
            this.giderTip.Location = new System.Drawing.Point(76, 12);
            this.giderTip.Name = "giderTip";
            this.giderTip.Size = new System.Drawing.Size(121, 21);
            this.giderTip.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gider Tipi";
            // 
            // giderAdi
            // 
            this.giderAdi.Location = new System.Drawing.Point(76, 51);
            this.giderAdi.MaxLength = 20;
            this.giderAdi.Name = "giderAdi";
            this.giderAdi.Size = new System.Drawing.Size(121, 20);
            this.giderAdi.TabIndex = 3;
            this.giderAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giderAdi_KeyPress);
            // 
            // giderTutar
            // 
            this.giderTutar.Location = new System.Drawing.Point(76, 93);
            this.giderTutar.MaxLength = 4;
            this.giderTutar.Name = "giderTutar";
            this.giderTutar.Size = new System.Drawing.Size(121, 20);
            this.giderTutar.TabIndex = 4;
            this.giderTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giderTutar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gider Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gider Tutarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Harcamayı Yapan";
            // 
            // gidergor
            // 
            this.gidergor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.gidergor.ContextMenuStrip = this.contextMenuStrip1;
            this.gidergor.FullRowSelect = true;
            this.gidergor.Location = new System.Drawing.Point(235, 46);
            this.gidergor.Name = "gidergor";
            this.gidergor.Size = new System.Drawing.Size(542, 277);
            this.gidergor.TabIndex = 8;
            this.gidergor.UseCompatibleStateImageBehavior = false;
            this.gidergor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gider Tipi";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gider Adı";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Harcamayı Yapan";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Gider Tutarı";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 70);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.listele);
            this.panel1.Controls.Add(this.Kayit);
            this.panel1.Controls.Add(this.giderTip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.giderAdi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.giderTutar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 311);
            this.panel1.TabIndex = 10;
            // 
            // listele
            // 
            this.listele.FormattingEnabled = true;
            this.listele.Location = new System.Drawing.Point(76, 152);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(120, 95);
            this.listele.TabIndex = 11;
            // 
            // Kayit
            // 
            this.Kayit.Location = new System.Drawing.Point(76, 268);
            this.Kayit.Name = "Kayit";
            this.Kayit.Size = new System.Drawing.Size(87, 31);
            this.Kayit.TabIndex = 10;
            this.Kayit.Text = "Kaydet";
            this.Kayit.UseVisualStyleBackColor = true;
            this.Kayit.Click += new System.EventHandler(this.Kayit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // aramaText
            // 
            this.aramaText.Location = new System.Drawing.Point(65, 5);
            this.aramaText.MaxLength = 10;
            this.aramaText.Name = "aramaText";
            this.aramaText.Size = new System.Drawing.Size(103, 20);
            this.aramaText.TabIndex = 11;
            this.aramaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aramaText_KeyPress);
            // 
            // Arama
            // 
            this.Arama.Location = new System.Drawing.Point(3, 3);
            this.Arama.Name = "Arama";
            this.Arama.Size = new System.Drawing.Size(56, 23);
            this.Arama.TabIndex = 12;
            this.Arama.Text = "Ara";
            this.Arama.UseVisualStyleBackColor = true;
            this.Arama.Click += new System.EventHandler(this.Arama_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Arama);
            this.panel2.Controls.Add(this.aramaText);
            this.panel2.Location = new System.Drawing.Point(235, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 28);
            this.panel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giderlerin Toplam Tutarı :";
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 335);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gidergor);
            this.Name = "Giderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Giderler_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox giderTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox giderAdi;
        private System.Windows.Forms.TextBox giderTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView gidergor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Kayit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ListBox listele;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Arama;
        private System.Windows.Forms.TextBox aramaText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}