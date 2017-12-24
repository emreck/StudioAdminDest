namespace StudioAdminDest
{
    partial class Giris
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
            this.girisGroupBox = new System.Windows.Forms.GroupBox();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.kulLabel = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.sifremiUnuttumLinkLabel = new System.Windows.Forms.LinkLabel();
            this.girisGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisGroupBox
            // 
            this.girisGroupBox.Controls.Add(this.sifremiUnuttumLinkLabel);
            this.girisGroupBox.Controls.Add(this.girisYapButton);
            this.girisGroupBox.Controls.Add(this.passwordText);
            this.girisGroupBox.Controls.Add(this.sifreLabel);
            this.girisGroupBox.Controls.Add(this.kulLabel);
            this.girisGroupBox.Controls.Add(this.kullaniciAdi);
            this.girisGroupBox.Location = new System.Drawing.Point(21, 23);
            this.girisGroupBox.Name = "girisGroupBox";
            this.girisGroupBox.Size = new System.Drawing.Size(302, 137);
            this.girisGroupBox.TabIndex = 0;
            this.girisGroupBox.TabStop = false;
            this.girisGroupBox.Text = "Giriş Yap";
            // 
            // girisYapButton
            // 
            this.girisYapButton.Location = new System.Drawing.Point(105, 78);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(100, 41);
            this.girisYapButton.TabIndex = 4;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = true;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(105, 52);
            this.passwordText.MaxLength = 18;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 3;
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Location = new System.Drawing.Point(7, 59);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(28, 13);
            this.sifreLabel.TabIndex = 2;
            this.sifreLabel.Text = "Şifre";
            // 
            // kulLabel
            // 
            this.kulLabel.AutoSize = true;
            this.kulLabel.Location = new System.Drawing.Point(7, 25);
            this.kulLabel.Name = "kulLabel";
            this.kulLabel.Size = new System.Drawing.Size(64, 13);
            this.kulLabel.TabIndex = 1;
            this.kulLabel.Text = "Kullanıcı Adı";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(105, 18);
            this.kullaniciAdi.MaxLength = 18;
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.kullaniciAdi.TabIndex = 0;
            // 
            // sifremiUnuttumLinkLabel
            // 
            // 
            // Giris
            // 
            this.AcceptButton = this.girisYapButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 199);
            this.Controls.Add(this.girisGroupBox);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.girisGroupBox.ResumeLayout(false);
            this.girisGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox girisGroupBox;
        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label kulLabel;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.LinkLabel sifremiUnuttumLinkLabel;
    }
}