using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioAdminDest
{
    public partial class Form1 : Form
    {
        public static int ajansID;
         
        public Form1()
        {
            InitializeComponent();
        }
        
        private void listele()
        {
            beklemedeList.Items.Clear();
               string yetki = "admin";
             string onay = "BEKLEMEDE";


            try
            {
                beklemedeList.View = View.Details;
                MySqlConnection baglanti;
                SqlBaglanti con = new SqlBaglanti();


                baglanti = con.baglanti();
                MySqlCommand ajansBul = new MySqlCommand("select AjansNo from Kullanicilar where ID='" + Giris.kullaniciID + "'", baglanti);
                MySqlDataReader ajansOku = ajansBul.ExecuteReader();
                if (ajansOku.HasRows)
                {
                    while (ajansOku.Read())
                    {
                        ajansID =Convert.ToInt32(ajansOku["AjansNo"].ToString());
                    }
                }
                baglanti.Close();

                baglanti.Open();
                MySqlCommand find = new MySqlCommand("select ID,AdSoyad,TelNo,Tarih,Saat from Isler where ajansID='"+ajansID+"' and onay='" + onay + "' ", baglanti);
                MySqlDataReader reader = find.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem randevular = new ListViewItem();
                        randevular.Text = reader["ID"].ToString();
                        randevular.SubItems.Add(reader["AdSoyad"].ToString());
                        randevular.SubItems.Add(reader["TelNo"].ToString());
                        randevular.SubItems.Add(reader["Tarih"].ToString());
                        randevular.SubItems.Add(reader["Saat"].ToString());
                        beklemedeList.Items.Add(randevular);
                    }
                    baglanti.Close();
                }
                else
                {
                    baglanti.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Beklemede olan randevu bulunamadı!");
                }


                baglanti.Open();
                MySqlCommand authorityFind = new MySqlCommand("select KullaniciTipi from Kullanicilar where ID='" + Giris.kullaniciID + "' and KullaniciTipi='" + yetki + "'  ", baglanti);
                MySqlDataReader authorityRead = authorityFind.ExecuteReader();

                if (!authorityRead.HasRows)
                {
                    personelislemleriToolStripMenuItem.Visible = false;
                    fiyatlandirmaIslemleriToolStripMenuItem.Visible = false;
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();   
        }

       

        private void yenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void personelKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelKayit personelkayit = new PersonelKayit();
            personelkayit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accept = "ONAYLANDI";
            try
            {
                if (beklemedeList.SelectedItems.Count==1)
                {
                    int seciliID = Convert.ToInt32(beklemedeList.SelectedItems[0].Text);

                    MySqlConnection baglanti;
                    SqlBaglanti con = new SqlBaglanti();
                    baglanti = con.baglanti();
                    MySqlCommand guncelle = new MySqlCommand("update Isler set onay='" + accept + "' where ID='"+seciliID+"' ", baglanti);
                    guncelle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Seçili randevular onaylandı!");
                    listele();
                }
                else if (beklemedeList.SelectedItems.Count>1)
                {
                    MessageBox.Show("Birden fazla randevu seçmeyiniz");
                }
                else
                {
                    MessageBox.Show("Lütfen randevu seçtiğinize emin olunuz");
                }
              
            }
            catch(Exception exp)
            {
                MessageBox.Show("HATA : DAHA SONRA TEKRAR DENEYİNİZ "+exp.ToString());
            }
        }
    }
}
