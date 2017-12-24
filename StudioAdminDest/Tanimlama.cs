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
            if (string.IsNullOrWhiteSpace(ısturu2.Text))
            {
                errorProvider1.SetError(ısturu2, "Bu alan boş geçilemez !");
            }
            else
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
                    errorProvider1.Clear();
                }
            }
        }

        private void fotografekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fotograf.Text))
            {
                errorProvider1.SetError(fotograf, "Bu alan boş geçilemez !");
            }
            else
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
                    errorProvider1.Clear();
                }
            }
        }

        private void videoEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(video.Text))
            {
                errorProvider1.SetError(video, "Bu alan boş geçilemez !");
            }
            else
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
                    errorProvider1.Clear();
                }
            }
        }

        private void cekimekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cekimyer2.Text))
            {
                errorProvider1.SetError(cekimyer2, "Bu alan boş geçilemez !");
            }
            else
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
                    errorProvider1.Clear();
                }
            }
        }

        private void ısturu2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void fotograf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void video_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void cekimyer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
