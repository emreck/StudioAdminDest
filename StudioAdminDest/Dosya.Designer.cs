namespace StudioAdminDest
{
    partial class Dosya
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aktar = new System.Windows.Forms.Button();
            this.gidergor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // aktar
            // 
            this.aktar.Location = new System.Drawing.Point(137, 108);
            this.aktar.Name = "aktar";
            this.aktar.Size = new System.Drawing.Size(75, 23);
            this.aktar.TabIndex = 1;
            this.aktar.Text = "Excele Aktar";
            this.aktar.UseVisualStyleBackColor = true;
            this.aktar.Click += new System.EventHandler(this.aktar_Click);
            // 
            // gidergor
            // 
            this.gidergor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.gidergor.Location = new System.Drawing.Point(267, 12);
            this.gidergor.Name = "gidergor";
            this.gidergor.Size = new System.Drawing.Size(511, 146);
            this.gidergor.TabIndex = 2;
            this.gidergor.UseCompatibleStateImageBehavior = false;
            this.gidergor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "gider tip";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "gider ad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "harcama yapan";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "tutar";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "tarih";
            // 
            // Dosya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 229);
            this.Controls.Add(this.gidergor);
            this.Controls.Add(this.aktar);
            this.Controls.Add(this.textBox1);
            this.Name = "Dosya";
            this.Text = "Dosya";
            this.Load += new System.EventHandler(this.Dosya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button aktar;
        private System.Windows.Forms.ListView gidergor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}