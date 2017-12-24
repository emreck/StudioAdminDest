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
    public partial class Tanimlama : Form
    {
        public Tanimlama()
        {
            InitializeComponent();
        }

        private void iskaydet_Click(object sender, EventArgs e)
        {
        
            DialogResult secenek = MessageBox.Show("İş türünü eklemek için emin misiniz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();

                MySqlCommand komut = new MySqlCommand("insert into Tanimlama(IsTuru,AjansID) values('" + ısturu2.Text + "',AjansID='" + Form1.ajansID + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(ısturu2.Text + " iş Türü Başarıyla eklenmiştir.");
                ısturu2.Clear();
                baglanti.Close();
            }
        }

        private void fotografekle_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Fotoğraf çekim türünü eklemek için emin misiniz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();

                MySqlCommand komut = new MySqlCommand("insert into Tanimlama(FotografAlt,AjansID) values('" + fotograf.Text + "',AjansID='" + Form1.ajansID + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(ısturu2.Text + " Fotoğraf Çekim Türü Başarıyla eklenmiştir.");
                fotograf.Clear();
                baglanti.Close();
            }
        }

        private void videoEkle_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Video çekim türünü eklemek için emin misiniz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();

                MySqlCommand komut = new MySqlCommand("insert into Tanimlama(VideoAlt,AjansID) values('" + video.Text + "',AjansID='" + Form1.ajansID + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(ısturu2.Text + " Video Çekim Türü Başarıyla eklenmiştir.");
                video.Clear();
                baglanti.Close();
            }
        }

        private void cekimekle_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Çekim yeri eklemek için emin misiniz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();

                MySqlCommand komut = new MySqlCommand("insert into Tanimlama(CekimYeri,AjansID) values('" + cekimyer2.Text + "',AjansID='" + Form1.ajansID + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(ısturu2.Text + " Çekim yeri Başarıyla eklenmiştir.");
                cekimyer2.Clear();
                baglanti.Close();
            }
        }
    }
}
