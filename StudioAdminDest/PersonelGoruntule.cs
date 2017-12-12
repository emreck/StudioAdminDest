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
    public partial class PersonelGoruntule : Form
    {
        
        public PersonelGoruntule()
        {
            InitializeComponent();
        }

        private void PersonelGoruntule_Load(object sender, EventArgs e)
        {
            verilerigoster();
           



        }
        public void verilerigoster()// Veritabanındaki verileri listview'de gösterir.
        {
            PersonelListe.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("Select KulAdi,AdSoyad,TelNo,YakinTelNo,Adres,KanGrubu,TopKazanc,CekimBasiKazanc,Alacaklari,KullaniciTipi from Kullanicilar where AjansNo='" + Form1.ajansID.ToString() + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["KulAdi"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["TelNo"].ToString());
                ekle.SubItems.Add(oku["YakinTelNo"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["KanGrubu"].ToString());
                ekle.SubItems.Add(oku["TopKazanc"].ToString());
                ekle.SubItems.Add(oku["CekimBasiKazanc"].ToString());
                ekle.SubItems.Add(oku["Alacaklari"].ToString());
                ekle.SubItems.Add(oku["KullaniciTipi"].ToString());
                PersonelListe.Items.Add(ekle);


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            PersonelListe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            PersonelListe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void arama_MouseClick(object sender, MouseEventArgs e)
        {
            arama.Clear();
        }
        public void aramayap()
        {
            PersonelListe.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("Select KulAdi,AdSoyad,TelNo,YakinTelNo,Adres,KanGrubu,TopKazanc,CekimBasiKazanc,Alacaklari,KullaniciTipi from Kullanicilar where AdSoyad Like '%" + arama.Text + "%' and AjansNo='" + Form1.ajansID.ToString() + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["KulAdi"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["TelNo"].ToString());
                ekle.SubItems.Add(oku["YakinTelNo"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["KanGrubu"].ToString());
                ekle.SubItems.Add(oku["TopKazanc"].ToString());
                ekle.SubItems.Add(oku["CekimBasiKazanc"].ToString());
                ekle.SubItems.Add(oku["Alacaklari"].ToString());
                ekle.SubItems.Add(oku["KullaniciTipi"].ToString());
                PersonelListe.Items.Add(ekle);


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            PersonelListe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            PersonelListe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            aramayap();
        }

        private void verileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verilerigoster();
            arama.Clear();
        }
        
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (PersonelListe.SelectedItems.Count >0)
            {
                DialogResult uyari = MessageBox.Show("'" + PersonelListe.SelectedItems[0].Text + "' Kullanıcısını Silmek istediğinize Eminmisiniz ? ", "Uyarı !", MessageBoxButtons.YesNo);
                if (uyari == DialogResult.Yes)
                {
                                        
                    MySqlConnection baglanti;
                    SqlBaglanti baglan = new SqlBaglanti();
                    baglanti = baglan.baglanti();
                    MySqlCommand komut = new MySqlCommand("delete from Kullanicilar where KulAdi='" + PersonelListe.SelectedItems[0].Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Personel Başarıyla Silinmiştir.");
                    verilerigoster();

                }
               
              
            }
        }
       
 
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PersonelListe.SelectedItems.Count > 0)
            {
                PersonelDuzen duzenle = new PersonelDuzen();

                duzenle.kuladii = PersonelListe.SelectedItems[0].SubItems[0].Text;
                duzenle.adSoyad = PersonelListe.SelectedItems[0].SubItems[1].Text;
                duzenle.telefon = PersonelListe.SelectedItems[0].SubItems[2].Text;
                duzenle.yakintelefon = PersonelListe.SelectedItems[0].SubItems[3].Text;
                duzenle.adresi = PersonelListe.SelectedItems[0].SubItems[4].Text;
                duzenle.kangrubuu = PersonelListe.SelectedItems[0].SubItems[5].Text;
                duzenle.cekimkazanci = PersonelListe.SelectedItems[0].SubItems[7].Text;
                duzenle.ShowDialog();
                verilerigoster();
            }
        }
    }
}
