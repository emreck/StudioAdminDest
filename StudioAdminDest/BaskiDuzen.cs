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
    public partial class BaskiDuzen : Form
    {
        public BaskiDuzen()
        {
            InitializeComponent();
        }
        public string baskiKullanici{ get; set; }
        public string baskiPersonel { get; set; }
        public string kartoncer { get; set; }
        public string plastikcer { get; set; }
        public string lukscer { get; set; }
        public string ucretsizcer { get; set; }
        public string toplamcer { get; set; }
        public string ucrett { get; set; }
        public string tarh { get; set; }

        public void musteriGoster()// Veritabanındaki verileri listview'de gösterir.
        {
            //verilerin tekrarını gösterme !
            MySqlConnection baglanti;

            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("SELECT AdSoyad FROM Isler where AjansID ='" + Form1.ajansID + "' ORDER BY Tarih ASC", baglanti);
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
        private void BaskiDuzen_Load(object sender, EventArgs e)
        {
            musteriGoster();
            personelGoster();
            musteri.Text = baskiKullanici.ToString();
            Personel.Text = baskiPersonel.ToString();
            karton.Text = kartoncer.ToString();
            plastik.Text = plastikcer.ToString();
            luks.Text = lukscer.ToString();
            ucretsiz.Text = ucretsizcer.ToString();
            toplam.Text = toplamcer.ToString();
            ucret.Text = ucrett.ToString();
            
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();
            DateTime tarih = DateTime.Now;
            MySqlCommand komut = new MySqlCommand("update Baski set MusAdSoy='" + musteri.Text + "',PerAdSoy='" + Personel.Text + "',KartonCer='" + karton.Text + "' ,PlastikCer='" + plastik.Text + "',LuksCer='" + luks.Text + "',UcretsizCer='" + ucretsiz.Text + "',ToplamBaski='" + toplam.Text + "',Ucret='" + ucret.Text + "',Tarih='" +tarih.ToString() + "' where Tarih='" +tarh.ToString() + "' and AjansID='"+Form1.ajansID+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarıyla Tamamamlanmıştır !");
            this.Close();
        }

        private void karton_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void plastik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void luks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ucretsiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void toplam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
