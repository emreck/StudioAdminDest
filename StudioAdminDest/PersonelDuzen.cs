﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace StudioAdminDest
{
    public partial class PersonelDuzen : Form
    {
        public PersonelDuzen()
        {
            InitializeComponent();
        }
        public string kuladii { get; set; }
        public string adSoyad { get; set; }
        public string telefon { get; set; }
        public string yakintelefon { get; set; }
        public string adresi { get; set; }
        public string kangrubuu { get; set; }
        public string cekimkazanci { get; set; }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sifre.Text))
            {
                errorProvider1.SetError(sifre, "Bu alan boş geçilemez !");
            }
            else if (string.IsNullOrWhiteSpace(sifretekrar.Text))
            {
                errorProvider1.SetError(sifretekrar, "Bu alan boş geçilemez !");

            }
            else if (sifre.Text != sifretekrar.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor,Tekrar Deneyiniz !");
                errorProvider1.SetError(sifre, "!");
                errorProvider1.SetError(sifretekrar, "!");

            }
            else
            {
                System.Text.UnicodeEncoding objUE = new System.Text.UnicodeEncoding();
                byte[] bytClearString = objUE.GetBytes(sifre.Text);
                MD5CryptoServiceProvider objProv = new MD5CryptoServiceProvider();
                byte[] hash = objProv.ComputeHash(bytClearString);
                string sifreli = Convert.ToBase64String(hash);
                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();

                MySqlCommand komut = new MySqlCommand("update Kullanicilar set Sifre='" + sifreli.ToString() + "',AdSoyad='" + adiSoyadi.Text + "',TelNo='" + telnumara.Text + "' ,YakinTelNo='" + yakintelnum.Text + "',Adres='" + adres.Text + "',CekimBasiKazanc='" + cekimkazanc.Text + "' where KulAdi='" + kulad.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Başarıyla Tamamamlanmıştır !");
                this.Close();
            }
            

        }

        private void PersonelDuzen_Load(object sender, EventArgs e)
        {
            sifre.PasswordChar = '*';
            sifretekrar.PasswordChar = '*';

            kulad.Enabled = false;
            kulad.Text = kuladii.ToString();
            adiSoyadi.Text = adSoyad.ToString();
            telnumara.Text = telefon.ToString();
            yakintelnum.Text = yakintelefon.ToString();
            adres.Text = adresi.ToString();
            kangrubu.Text = kangrubuu.ToString();
            cekimkazanc.Text = cekimkazanci.ToString();
        }

        private void adiSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void telnumara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sayısal
        }

        private void yakintelnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sayısal
        }

        private void cekimkazanc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sayısal
        }
    }
}
