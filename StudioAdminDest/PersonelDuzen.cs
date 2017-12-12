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
    public partial class PersonelDuzen : Form
    {
        public PersonelGoruntule personel;
        public PersonelDuzen()
        {
            InitializeComponent();
        }
        public string kuladi { get; set; }
        public string adSoyad { get; set; }
        public string telefon { get; set; }
        public string yakintelefon { get; set; }
        public string adresi { get; set; }
        public string kangrubu { get; set; }
        public string cekimkazanci { get; set; }
        private void PersonelDuzen_Load(object sender, EventArgs e)
        {


            kulAdi.Enabled = false;
            kulAdi.Text = kuladi.ToString();
            adsoyad.Text = adSoyad.ToString();
            tel.Text = yakintelefon.ToString();
            yakintel.Text = yakintelefon.ToString();
            adres.Text = adresi.ToString();
            kan.Text = kangrubu.ToString();
            kazanc.Text = cekimkazanci.ToString();


        }
        public static string durum;
        private void guncel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sifre.Text))
            {
                MessageBox.Show("Bu alan boş geçilemez !");
                errorProvider1.SetError(sifre, "Bu alan boş geçilemez !");
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
                MySqlCommand komut = new MySqlCommand("update Kullanicilar set Sifre='" + sifreli.ToString() + "',AdSoyad='" + adsoyad.Text + "',TelNo='" + tel.Text + "',YakinTelNo='" + yakintel.Text + "',Adres='" + adres.Text + "',KanGrubu='" + kan.Text + "',CekimBasiKazanc='" + kazanc.Text + "' where KulAdi='" + kuladi.ToString() + "' ", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Güncellenmiştir.");
                baglanti.Close();
                durum = "aktif";
                this.Hide();
                
            }


        }
    }
}
