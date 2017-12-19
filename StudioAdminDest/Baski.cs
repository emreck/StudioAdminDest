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
    public partial class Baski : Form
    {
        public Baski()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void musteriGoster()// Veritabanındaki verileri listview'de gösterir.
        {
             //verilerin tekrarını gösterme !
            MySqlConnection baglanti;

            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("SELECT AdSoyad FROM Isler where AjansID ='"+Form1.ajansID+"' ORDER BY Tarih ASC", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                musteri.Items.Add(oku["AdSoyad"].ToString());

               
            }
            baglanti.Close();          

        }
        public void personelGoster()// Veritabanındaki verileri listview'de gösterir.
        {
            //verilerin tekrarını gösterme !
            MySqlConnection baglanti;

            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("SELECT AdSoyad FROM Kullanicilar where AjansNo ='" + Form1.ajansID + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                Personel.Items.Add(oku["AdSoyad"].ToString());


            }
            baglanti.Close();

        }

        private void Baski_Load(object sender, EventArgs e)
        {
            musteriGoster();
            personelGoster();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(musteri.Text))
            {
                errorProvider1.SetError(musteri, "Müşteri Seçiniz !");
            }
            else if (string.IsNullOrWhiteSpace(Personel.Text))
            {
                errorProvider1.SetError(Personel, "Personel Seçiniz !");
            }
            else if (string.IsNullOrWhiteSpace(ucret.Text))
            {
                errorProvider1.SetError(ucret, "Toplam ücreti giriniz !");
            }
            else
            {
                DateTime tarih = DateTime.Now;
                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();

                MySqlCommand ekle = new MySqlCommand("insert into Baski (MusAdSoy,PerAdSoy,KartonCer,PlastikCer,LuksCer,UcretsizCer,ToplamBaski,Ucret,Tarih,AjansID) values ('" +musteri.Text + "','" +Personel.Text + "','" + karton.Text + "','" + plastik.Text + "','" +luks.Text + "','" + ucretsiz.Text + "','" + toplam.Text + "','" + ucret.Text + "','" + tarih.ToString() + "','" +Form1.ajansID + "') ", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı !");
                DialogResult uyari = MessageBox.Show("Kaydedilen Baskıyı Görüntülemek istermisiniz ?", "Uyarı !", MessageBoxButtons.YesNo);
                if (uyari == DialogResult.Yes)
                {
                    BaskiGoruntule gor = new BaskiGoruntule();
                    gor.Show();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
