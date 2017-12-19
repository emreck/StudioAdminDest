namespace StudioAdminDest
{
    partial class BaskiGoruntule
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
            this.baski = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.baskisilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baskiDuzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baskiAra = new System.Windows.Forms.TextBox();
            this.baskiAraButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baski
            // 
            this.baski.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.baski.ContextMenuStrip = this.contextMenuStrip1;
            this.baski.FullRowSelect = true;
            this.baski.Location = new System.Drawing.Point(15, 36);
            this.baski.Name = "baski";
            this.baski.Size = new System.Drawing.Size(804, 171);
            this.baski.TabIndex = 0;
            this.baski.UseCompatibleStateImageBehavior = false;
            this.baski.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri Adı";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Personel Adı";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Karton Çerçeve";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Plastik Çerçeve";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lüks Çerçeve";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ucretsiz Çerçeve";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Toplam Baskı";
            this.columnHeader7.Width = 83;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ücret";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tarih";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baskisilToolStripMenuItem,
            this.baskiDuzenToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // baskisilToolStripMenuItem
            // 
            this.baskisilToolStripMenuItem.Name = "baskisilToolStripMenuItem";
            this.baskisilToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.baskisilToolStripMenuItem.Text = "Baskı Sil";
            this.baskisilToolStripMenuItem.Click += new System.EventHandler(this.baskisilToolStripMenuItem_Click);
            // 
            // baskiDuzenToolStripMenuItem
            // 
            this.baskiDuzenToolStripMenuItem.Name = "baskiDuzenToolStripMenuItem";
            this.baskiDuzenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.baskiDuzenToolStripMenuItem.Text = "Baskı Düzenle";
            this.baskiDuzenToolStripMenuItem.Click += new System.EventHandler(this.baskiDuzenToolStripMenuItem_Click);
            // 
            // baskiAra
            // 
            this.baskiAra.Location = new System.Drawing.Point(12, 10);
            this.baskiAra.Name = "baskiAra";
            this.baskiAra.Size = new System.Drawing.Size(100, 20);
            this.baskiAra.TabIndex = 1;
            // 
            // baskiAraButon
            // 
            this.baskiAraButon.Location = new System.Drawing.Point(118, 7);
            this.baskiAraButon.Name = "baskiAraButon";
            this.baskiAraButon.Size = new System.Drawing.Size(38, 23);
            this.baskiAraButon.TabIndex = 2;
            this.baskiAraButon.Text = "ARA";
            this.baskiAraButon.UseVisualStyleBackColor = true;
            this.baskiAraButon.Click += new System.EventHandler(this.baskiAraButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam Baskı Ücreti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // BaskiGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baskiAraButon);
            this.Controls.Add(this.baskiAra);
            this.Controls.Add(this.baski);
            this.Name = "BaskiGoruntule";
            this.Text = "BaskiGoruntule";
            this.Load += new System.EventHandler(this.BaskiGoruntule_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView baski;
        private System.Windows.Forms.TextBox baskiAra;
        private System.Windows.Forms.Button baskiAraButon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem baskisilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baskiDuzenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}