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
        public void alankontrol()
        {
            if (string.IsNullOrWhiteSpace(AdSoyad.Text))
            {
                errorProvider1.SetError(kulAdi, "Bu alan boş geçilemez !");
            }
            if (Sifre.Text == "")
            {

                errorProvider1.SetError(Sifre, "Bu alan boş geçilemez !");
            }
            if (AdSoyad.Text == "")
            {
                errorProvider1.SetError(AdSoyad, "Bu alan boş geçilemez !");
            }
            if (Tel.Text == "")
            {

                errorProvider1.SetError(Tel, "Bu alan boş geçilemez !");
            }
            

        }
      
       
        private void button1_Click(object sender, EventArgs e)
        {
         
          int topkazanc = 0, cekimbasikazanc=0,alacak=0;
            string kullanicitipi = "personel";
    
            alankontrol();
            
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();
                        MySqlCommand komut = new MySqlCommand("insert into Kullanicilar(KulAdi,Sifre,AdSoyad,Telno,YakininTelNo,Adres,KanGrubu,TopKazanc,CekimBasiKazanc,Alacaklari,KullaniciTipi,AjansNo) values('" + kulAdi.Text + "','" + Sifre.Text + "','" + AdSoyad.Text + "','" + Tel.Text + "','" + YakinTel.Text + "','" + Adres.Text + "','" + Kan.Text + "','" + topkazanc.ToString() + "','" + cekimbasikazanc.ToString() + "','" + alacak.ToString() + "','" + kullanicitipi.ToString() + "','" + kullanicitipi.ToString() + "')", baglan.baglanti());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
