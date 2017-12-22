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
    public partial class GiderDuzen : Form
    {
        public GiderDuzen()
        {
            InitializeComponent();
        }
       
        public string gideradi2 { get; set; }
        public string gidertutari2 { get; set; }
        public string tarih { get; set; }
        public string pers { get; set; }

        public string tipi { get; set; }

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

                personel.Items.Add(oku["AdSoyad"].ToString());


            }
            baglanti.Close();

        }
        private void guncel_Click(object sender, EventArgs e)
        {
            string Gideradi = giderAdi.Text.ToString();
            string gidertutar = GiderTutar.Text.ToString();        




            if (giderTip.Text == "" || GiderTutar.Text == "" || giderAdi.Text == "" || personel.Text=="")
            {
                if (giderTip.Text == "")
                    errorProvider1.SetError(giderTip, "Bu Alan Boş Geçilemez!");
                if (GiderTutar.Text == "")
                    errorProvider1.SetError(GiderTutar, "Bu Alan Boş Geçilemez!");
                if (giderAdi.Text == "")
                    errorProvider1.SetError(giderAdi, "Bu Alan Boş Geçilemez!");
                if (personel.Text == "")
                    errorProvider1.SetError(personel, "Bu Alan Boş Geçilemez!");

            }
          
            else
            {
                

                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();
                MySqlCommand komut = new MySqlCommand("update Gider set HarcamayiYapan='" + personel.Text + "',GiderTipi='" +giderTip.Text + "',GiderAdi='" + giderAdi.Text + "',GiderTutar='" + GiderTutar.Text + "' where Tarih='" + tarih.ToString() + "' and AjansID='" + Form1.ajansID + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Başarıyla Tamamamlanmıştır !");
                this.Close();
            }
        }
        public void toplamucret()
        {
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();
            MySqlCommand komut = new MySqlCommand("Select SUM(Gider.GiderTutar) toplam from Gider where AjansID='" + Form1.ajansID + "'AND HarcamayiYapan='"+pers.ToString()+"'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label7.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
        }
        private void GiderDuzen_Load(object sender, EventArgs e)
        {
            label6.Text = pers.ToString();
            personel.Text = pers.ToString();
            giderTip.Text = tipi.ToString();
            giderAdi.Text = gideradi2.ToString();
            GiderTutar.Text = gidertutari2.ToString();
            personelGoster();
            toplamucret();
            errorProvider1.Clear();
           
        }
    }
}
