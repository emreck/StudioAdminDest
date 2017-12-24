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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        public void giderGoster()
        {
            gidergor.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("Select GiderTipi,GiderAdi,HarcamayiYapan,GiderTutar,Tarih,AjansID from Gider where AjansID='" + Form1.ajansID.ToString() + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["GiderTipi"].ToString();
                ekle.SubItems.Add(oku["GiderAdi"].ToString());
                ekle.SubItems.Add(oku["HarcamayiYapan"].ToString());
                ekle.SubItems.Add(oku["GiderTutar"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());        

                gidergor.Items.Add(ekle);


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gidergor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            gidergor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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

                listele.Items.Add(oku["AdSoyad"].ToString());


            }
            baglanti.Close();

        }
        private void Giderler_Load(object sender, EventArgs e)
        {
            giderGoster();
            personelGoster();
            toplamucret();
        }
   
        private void Kayit_Click(object sender, EventArgs e)
        {
            String Gidertipi = giderTip.Text.ToString();
            String Gideradi = giderAdi.Text.ToString();
            string gidertutar = giderTutar.Text.ToString();
            DateTime tarih = DateTime.Now;

           


            if (giderTip.Text == "" || giderTutar.Text == "" || giderAdi.Text == "")
            {
                if (giderTip.Text == "")
                    errorProvider1.SetError(giderTip, "Bu Alan Boş Geçilemez!");
                if (giderTutar.Text == "")
                    errorProvider1.SetError(giderTutar, "Bu Alan Boş Geçilemez!");
                if (giderAdi.Text == "")
                    errorProvider1.SetError(giderAdi, "Bu Alan Boş Geçilemez!");

            }
           else if (listele.SelectedIndices.Count <= 0)
            {
                errorProvider1.SetError(listele, "Seçim yapınız !");
            }
            else
            {
                MySqlConnection baglanti;

                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();

                MySqlCommand komut = new MySqlCommand("insert into Gider(GiderTipi,GiderAdi,GiderTutar,HarcamayiYapan,Tarih,AjansID) values('" + giderTip.Text + "','" + giderAdi.Text + "','" + giderTutar.Text+ "','" + listele.SelectedItem + "','" + tarih.ToString() + "','"+Form1.ajansID+"' )", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                giderGoster();
                MessageBox.Show("Gider verileri kayıt edilmiştir.");
                listele.ClearSelected();
                toplamucret();
                giderTip.Text = string.Empty;
                giderTutar.Text = string.Empty;
                giderAdi.Text = string.Empty;
                errorProvider1.Clear();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gidergor.SelectedIndices.Count > 1)
            {
                MessageBox.Show("Toplu silme işlemi yapamazsınız!");
            }
            else {
                if (gidergor.SelectedItems.Count > 0)
                {
                    DialogResult uyari = MessageBox.Show("'" + gidergor.SelectedItems[0].SubItems[2].Text + "' Personelinin Harcamasını silmek için eminmisiniz ? ", "Uyarı !", MessageBoxButtons.YesNo);
                    if (uyari == DialogResult.Yes)
                    {

                        MySqlConnection baglanti;
                        SqlBaglanti baglan = new SqlBaglanti();
                        baglanti = baglan.baglanti();
                        MySqlCommand komut = new MySqlCommand("delete from Gider where Tarih='" + gidergor.SelectedItems[0].SubItems[4].Text + "'", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Baskı Kaydı Başarıyla Silinmiştir.");
                        giderGoster();
                        toplamucret();

                    }
                }

            }
        }
        public void aramayap()
        {
            gidergor.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("select GiderTipi,GiderAdi,HarcamayiYapan,GiderTutar,Tarih,AjansID from Gider where HarcamayiYapan Like '%" +aramaText.Text + "%' and AjansID='" + Form1.ajansID.ToString() + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
              
                ekle.Text = oku["GiderTipi"].ToString();
                ekle.SubItems.Add(oku["GiderAdi"].ToString());
                ekle.SubItems.Add(oku["HarcamayiYapan"].ToString());
                ekle.SubItems.Add(oku["GiderTutar"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());

                gidergor.Items.Add(ekle);


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gidergor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            gidergor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void Arama_Click(object sender, EventArgs e)
        {
            aramayap();

        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giderGoster();
            aramaText.Clear();
            
        }
        public void toplamucret()
        {
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();
            MySqlCommand komut = new MySqlCommand("Select SUM(Gider.GiderTutar) toplam from Gider where AjansID='" + Form1.ajansID + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label6.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gidergor.SelectedItems.Count > 0)
            {
                GiderDuzen duzen = new GiderDuzen();
                duzen.pers = gidergor.SelectedItems[0].SubItems[2].Text;
                duzen.gideradi2 = gidergor.SelectedItems[0].SubItems[1].Text;
                duzen.gidertutari2 = gidergor.SelectedItems[0].SubItems[3].Text;
                duzen.tarih = gidergor.SelectedItems[0].SubItems[4].Text;
                duzen.tipi = gidergor.SelectedItems[0].SubItems[0].Text;
                duzen.ShowDialog();
                giderGoster();
                toplamucret();

            }
        }

        private void giderAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
         
        }

        private void giderTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sayısal
        }

        private void aramaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
