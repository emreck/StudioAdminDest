namespace StudioAdminDest
{
    partial class Mesaj
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
            this.mesajgoster = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mesajicerik = new System.Windows.Forms.TextBox();
            this.mesajYolla = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mesajgoster
            // 
            this.mesajgoster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.mesajgoster.Location = new System.Drawing.Point(12, 12);
            this.mesajgoster.Name = "mesajgoster";
            this.mesajgoster.Size = new System.Drawing.Size(536, 166);
            this.mesajgoster.TabIndex = 0;
            this.mesajgoster.UseCompatibleStateImageBehavior = false;
            this.mesajgoster.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kişiler";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mesaj İçeriği";
            this.columnHeader2.Width = 211;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih-Saat";
            this.columnHeader3.Width = 147;
            // 
            // mesajicerik
            // 
            this.mesajicerik.Location = new System.Drawing.Point(12, 184);
            this.mesajicerik.MaxLength = 200;
            this.mesajicerik.Multiline = true;
            this.mesajicerik.Name = "mesajicerik";
            this.mesajicerik.Size = new System.Drawing.Size(536, 65);
            this.mesajicerik.TabIndex = 1;
            // 
            // mesajYolla
            // 
            this.mesajYolla.Location = new System.Drawing.Point(12, 255);
            this.mesajYolla.Name = "mesajYolla";
            this.mesajYolla.Size = new System.Drawing.Size(85, 40);
            this.mesajYolla.TabIndex = 2;
            this.mesajYolla.Text = "Mesajı Yolla";
            this.mesajYolla.UseVisualStyleBackColor = true;
            this.mesajYolla.Click += new System.EventHandler(this.mesajYolla_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 310);
            this.Controls.Add(this.mesajYolla);
            this.Controls.Add(this.mesajicerik);
            this.Controls.Add(this.mesajgoster);
            this.Name = "Mesaj";
            this.Text = "Mesaj";
            this.Load += new System.EventHandler(this.Mesaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView mesajgoster;
        private System.Windows.Forms.TextBox mesajicerik;
        private System.Windows.Forms.Button mesajYolla;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}