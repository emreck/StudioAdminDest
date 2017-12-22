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
    public partial class Mesaj : Form
    {
        public Mesaj()
        {
            InitializeComponent();
        }

        private void Mesaj_Load(object sender, EventArgs e)
        {
            verilerigoster();
            mesajgoster.Items[mesajgoster.Items.Count - 1].EnsureVisible();
        }
        string adminID = "0";
        public void verilerigoster()// Veritabanındaki verileri listview'de gösterir.
        {
            mesajgoster.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();
            
            MySqlCommand komut = new MySqlCommand("SELECT tarih,Ajanslar.ajansAdi as ajans , Mesajlar.mesaj as mesaj FROM Mesajlar INNER JOIN Ajanslar on Mesajlar.kime=Ajanslar.ID INNER JOIN Ajanslar as ajans2 on Mesajlar.kimden=ajans2.ID WHERE (Mesajlar.kime='" +adminID.ToString() + "' and Mesajlar.kimden='" + Form1.ajansID.ToString() + "') or (Mesajlar.kime='" +Form1.ajansID.ToString() + "' and Mesajlar.kimden='" +adminID.ToString() + "') ORDER BY tarih ASC", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            int i = 0;
            while (oku.Read())
            {
               

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ajans"].ToString();
                ekle.SubItems.Add(oku["mesaj"].ToString());
                ekle.SubItems.Add(oku["tarih"].ToString());
             
                mesajgoster.Items.Add(ekle);
                if (mesajgoster.Items[i].SubItems[0].Text == "admin")
                {
                    mesajgoster.Items[i].SubItems[0].BackColor = Color.LightBlue;

                }
                i++;


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            mesajgoster.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            mesajgoster.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        
        }

        private void mesajYolla_Click(object sender, EventArgs e)
        {
            string durum = "okunmadi";
            DateTime tarih = DateTime.Now;
            if (string.IsNullOrWhiteSpace(mesajicerik.Text))
            {
                errorProvider1.SetError(mesajicerik, "Boş Mesaj Atılamaz !");
            }
            else
            {
                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();
                MySqlCommand ekle = new MySqlCommand("insert into Mesajlar (kimden,kime,mesaj,tarih,okundu) values ('" + adminID.ToString() + "','" + Form1.ajansID.ToString() + "','" + mesajicerik.Text + "','" + tarih.ToString() + "','" + durum.ToString() + "') ", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Mesajınız Başarıyla iletişmiştir.");
                mesajicerik.Text = string.Empty;
                verilerigoster();
                mesajgoster.Items[mesajgoster.Items.Count - 1].EnsureVisible();
            }
        }
    }
}
