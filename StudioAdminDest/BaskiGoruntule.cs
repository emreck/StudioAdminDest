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
    public partial class BaskiGoruntule : Form
    {
        public BaskiGoruntule()
        {
            InitializeComponent();
        }

        private void baskiDuzenToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (baski.SelectedItems.Count > 0)
            {
                BaskiDuzen duzen = new BaskiDuzen();

                duzen.baskiKullanici = baski.SelectedItems[0].SubItems[0].Text;
                duzen.baskiPersonel = baski.SelectedItems[0].SubItems[1].Text;
                duzen.kartoncer = baski.SelectedItems[0].SubItems[2].Text;
                duzen.plastikcer = baski.SelectedItems[0].SubItems[3].Text;
                duzen.lukscer = baski.SelectedItems[0].SubItems[4].Text;
                duzen.ucretsizcer = baski.SelectedItems[0].SubItems[5].Text;
                duzen.toplamcer = baski.SelectedItems[0].SubItems[6].Text;
                duzen.ucrett = baski.SelectedItems[0].SubItems[7].Text;
                duzen.tarh = baski.SelectedItems[0].SubItems[8].Text;
                duzen.ShowDialog();
                baskiGoster();
                toplamucret();

            }
        }
        public void baskiGoster()
        {
            baski.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("Select MusAdSoy,PerAdSoy,KartonCer,PlastikCer,LuksCer,UcretsizCer,ToplamBaski,Ucret,Tarih from Baski where AjansID='" + Form1.ajansID.ToString() + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusAdSoy"].ToString();
                ekle.SubItems.Add(oku["PerAdSoy"].ToString());
                ekle.SubItems.Add(oku["KartonCer"].ToString());
                ekle.SubItems.Add(oku["PlastikCer"].ToString());
                ekle.SubItems.Add(oku["LuksCer"].ToString());
                ekle.SubItems.Add(oku["UcretsizCer"].ToString());
                ekle.SubItems.Add(oku["ToplamBaski"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());

                baski.Items.Add(ekle);


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            baski.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            baski.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        public void toplamucret()
        {
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();
            MySqlCommand komut = new MySqlCommand("Select SUM(Ucret) toplam from Baski where AjansID='"+Form1.ajansID+"'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label2.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
        }

        private void BaskiGoruntule_Load(object sender, EventArgs e)
        {
            baskiGoster();
            toplamucret();
        }

        private void baskisilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (baski.SelectedItems.Count > 0)
            {
                DialogResult uyari = MessageBox.Show("'" + baski.SelectedItems[0].Text + "' Müşterisinin Baskı Bilgilerini silmek için eminmisiniz ? ", "Uyarı !", MessageBoxButtons.YesNo);
                if (uyari == DialogResult.Yes)
                {

                    MySqlConnection baglanti;
                    SqlBaglanti baglan = new SqlBaglanti();
                    baglanti = baglan.baglanti();
                    MySqlCommand komut = new MySqlCommand("delete from Baski where MusAdSoy='" + baski.SelectedItems[0].Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Baskı Kaydı Başarıyla Silinmiştir.");
                    baskiGoster();
                    toplamucret();

                }


            }
        }
        public void aramayap()
        {
            baski.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("Select MusAdSoy,PerAdSoy,KartonCer,PlastikCer,LuksCer,UcretsizCer,ToplamBaski,Ucret,Tarih from Baski where PerAdSoy Like '%" + baskiAra.Text + "%' and AjansID='" + Form1.ajansID.ToString() + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusAdSoy"].ToString();
                ekle.SubItems.Add(oku["PerAdSoy"].ToString());
                ekle.SubItems.Add(oku["KartonCer"].ToString());
                ekle.SubItems.Add(oku["PlastikCer"].ToString());
                ekle.SubItems.Add(oku["LuksCer"].ToString());
                ekle.SubItems.Add(oku["UcretsizCer"].ToString());
                ekle.SubItems.Add(oku["ToplamBaski"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());

                baski.Items.Add(ekle);



                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            baski.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            baski.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void baskiAraButon_Click(object sender, EventArgs e)
        {
            aramayap();
            baskiAra.Clear();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baskiGoster();
        }

        private void baskiAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
