using System;
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
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }

        private void PersonelKayit_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
  
        private bool kullaniciKontrol(String kullanici)
        {
            bool durum = false;
      
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();
            
            MySqlCommand komut = new MySqlCommand("Select KulAdi from Kullanicilar where KulAdi='" + kullanici + "'", baglanti);
            
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KulAdi"].ToString() == kullanici)
                {
                    durum = true;
                }
            }

            baglanti.Close();

            return durum;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int topkazanc = 0, alacak = 0;
            string kullanicitipi = "personel";
            string ajansid = Form1.ajansID.ToString();

            if (string.IsNullOrWhiteSpace(AdSoyad.Text))
            {
                errorProvider1.SetError(kulAdi, "Bu alan boş geçilemez !");
            }
            else if (Sifre.Text == "")
            {

                errorProvider1.SetError(Sifre, "Bu alan boş geçilemez !");
            }
            else if (AdSoyad.Text == "")
            {
                errorProvider1.SetError(AdSoyad, "Bu alan boş geçilemez !");
            }
            else if (Tel.Text == "")
            {

                errorProvider1.SetError(Tel, "Bu alan boş geçilemez !");
            }
            else if (Sifre.Text != sifretek.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor,Tekrar Deneyiniz !");
                errorProvider1.SetError(Sifre, "!");
                errorProvider1.SetError(sifretek, "!");

            }
            else
            {
                bool durum = kullaniciKontrol(kulAdi.Text);
                System.Text.UnicodeEncoding objUE = new System.Text.UnicodeEncoding();
                byte[] bytClearString = objUE.GetBytes(Sifre.Text);
                MD5CryptoServiceProvider objProv = new MD5CryptoServiceProvider();
                byte[] hash = objProv.ComputeHash(bytClearString);
                string sifreli = Convert.ToBase64String(hash);
                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();
                MySqlCommand komut = new MySqlCommand("insert into Kullanicilar(KulAdi,Sifre,AdSoyad,TelNo,YakinTelNo,Adres,KanGrubu,TopKazanc,CekimBasiKazanc,Alacaklari,KullaniciTipi,AjansNo) values('" + kulAdi.Text + "','" + sifreli.ToString() + "','" + AdSoyad.Text + "','" + Tel.Text + "','" + YakinTel.Text + "','" + Adres.Text + "','" + Kan.Text + "','" + topkazanc.ToString() + "','" + Kazanc.Text + "','" + alacak.ToString() + "','" + kullanicitipi.ToString() + "','" + ajansid.ToString() + "')", baglan.baglanti());
                if (durum)
                {
                    errorProvider1.SetError(kulAdi, "Farklı bir kullanıcı adı alınız!");
                    MessageBox.Show("Ayni kullanici adi var('" + kulAdi.Text + "' ). Kayit olamaz!");
                    kulAdi.Clear();
                    kulAdi.Focus();

                }
                else
                {
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla kayıt yapıldı !");
                    PersonelKayit yenile = new PersonelKayit();
                    yenile.Refresh();
                    this.Hide();

                }

            }

           
        }

        private void AdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);//karakter
        }

        private void Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sayısal
        }

        private void YakinTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Kazanc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
