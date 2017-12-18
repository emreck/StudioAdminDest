namespace StudioAdminDest
{
    partial class Notlar
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
            this.NotYaz = new System.Windows.Forms.TextBox();
            this.NotGoster = new System.Windows.Forms.ListView();
            this.notPaylas = new System.Windows.Forms.Button();
            this.kullanici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotYaz
            // 
            this.NotYaz.Location = new System.Drawing.Point(12, 198);
            this.NotYaz.Multiline = true;
            this.NotYaz.Name = "NotYaz";
            this.NotYaz.Size = new System.Drawing.Size(438, 76);
            this.NotYaz.TabIndex = 0;
            // 
            // NotGoster
            // 
            this.NotGoster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.NotGoster.Location = new System.Drawing.Point(12, 12);
            this.NotGoster.Name = "NotGoster";
            this.NotGoster.Size = new System.Drawing.Size(438, 135);
            this.NotGoster.TabIndex = 1;
            this.NotGoster.UseCompatibleStateImageBehavior = false;
            this.NotGoster.View = System.Windows.Forms.View.Details;
            // 
            // notPaylas
            // 
            this.notPaylas.Location = new System.Drawing.Point(12, 280);
            this.notPaylas.Name = "notPaylas";
            this.notPaylas.Size = new System.Drawing.Size(102, 46);
            this.notPaylas.TabIndex = 2;
            this.notPaylas.Text = "Not Paylaş";
            this.notPaylas.UseVisualStyleBackColor = true;
            this.notPaylas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kullanici
            // 
            this.kullanici.Location = new System.Drawing.Point(12, 172);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(100, 20);
            this.kullanici.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Not Yazan Kullanıcı ";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Notu Paylaşan";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçerik";
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 120;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanici);
            this.Controls.Add(this.notPaylas);
            this.Controls.Add(this.NotGoster);
            this.Controls.Add(this.NotYaz);
            this.Name = "Notlar";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.Notlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NotYaz;
        private System.Windows.Forms.ListView NotGoster;
        private System.Windows.Forms.Button notPaylas;
        private System.Windows.Forms.TextBox kullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}