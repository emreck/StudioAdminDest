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
    public partial class Analiz : Form
    {
        public int aylikIslKazanc;
        public int aylikIslGider;
        SqlBaglanti con = new SqlBaglanti();
        public Analiz()
        {
            InitializeComponent();
        }
        public int giderBul()
        {
            int toplamgider = 0;
            MySqlConnection baglanti = con.baglanti();

            try
            {
                MySqlCommand komut = new MySqlCommand("Select SUM(Gider.GiderTutar) toplam from Gider where AjansID='" + Form1.ajansID + "'", baglanti);
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    toplamgider += Convert.ToInt32(oku["toplam"].ToString());
                }
                baglanti.Close();

            }
            catch (MySqlException)
            {
                baglanti.Close();
                MessageBox.Show("Sunucu hatası !");

            }
            catch(Exception exp)
            {
                baglanti.Close();
                MessageBox.Show("Bilinmeyen bir hata !"+exp.ToString());
            }
            return toplamgider;
        }
        public void aylikGonder()
        {
            DateTime ayKontrol = new DateTime();
            ayKontrol = DateTime.Now.AddHours(-1);

            MySqlConnection baglanti = con.baglanti();
            string onay = "ALINDI";
            try
            {
                MySqlCommand kazancBul = new MySqlCommand("select SUM(Isler.Fiyat) toplam ,Tarih from Isler where UcretDurumu='"+onay+"' and ajansID='" + Form1.ajansID + "'  ", baglanti);
                MySqlDataReader kazancOku = kazancBul.ExecuteReader();
                while (kazancOku.Read())
                {
                    if (Convert.ToDateTime(kazancOku["Tarih"]) > ayKontrol)
                    {
                        //   aylikIslKazanc = Convert.ToInt32(kazancOku["toplam"].ToString());
                        aylikIsletmeKazanc.Text = kazancOku["toplam"].ToString();
                    }
                   
                }
                baglanti.Close();
                aylikIslKazanc = Convert.ToInt32(aylikIsletmeKazanc.Text);
              


                //-------------

                baglanti.Open();
                MySqlCommand giderBul = new MySqlCommand("select SUM(Gider.GiderTutar) toplam,Tarih from Gider where  ajansID='" + Form1.ajansID + "'  ", baglanti);
                MySqlDataReader giderOku = giderBul.ExecuteReader();
                while (giderOku.Read())
                {
                    if (Convert.ToDateTime(giderOku["Tarih"]) > ayKontrol)
                    {
                       aylikIslGider = Convert.ToInt32(kazancOku["toplam"].ToString());
                    }
                }
               aylikIsletmeGider.Text=aylikIslGider.ToString();
                baglanti.Close();
                
            }
            catch (MySqlException exp)
            {
                MessageBox.Show("Sunucu hatası !"+exp.ToString());
                baglanti.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Bilinmeyen bir hata !"+exp.ToString());
                baglanti.Close();
            }
        }
        public void grafikCizdir()
        {
            int persGider = personelGiderBul();
            int isletmeGider = giderBul();
            int toplamIsKazanc = isKazanc();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.Series["veriler"].Points.Add(persGider);
            chart1.Series["veriler"].Points.Add(isletmeGider);
            chart1.Series["veriler"].Points.Add(toplamIsKazanc);

            chart1.Series["veriler"].Points[0].AxisLabel = "PERSONEL GİDERİ";
            chart1.Series["veriler"].Points[1].AxisLabel = "iŞLETME GİDERİ";
            chart1.Series["veriler"].Points[2].AxisLabel = "İŞ KAZANCI";

            chart1.Series["veriler"].Points[0].Color = Color.Red;
            chart1.Series["veriler"].Points[1].Color = Color.Black;
            chart1.Series["veriler"].Points[2].Color = Color.Green;

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -70;

            chart1.BackColor = Color.YellowGreen;
        }
        private int isKazanc()
        {
            int toplamİsKazanc = 0;

            MySqlConnection baglanti = con.baglanti();
            try
            {
                MySqlCommand toplamIsKazanBul = new MySqlCommand("select SUM(Isler.Fiyat)toplam from Isler where UcretDurumu='ALINDI' and ajansID='"+Form1.ajansID+"' ", baglanti);
                MySqlDataReader toplamIsKazancOku = toplamIsKazanBul.ExecuteReader();
                while (toplamIsKazancOku.Read())
                {
                    toplamİsKazanc = Convert.ToInt32(toplamIsKazancOku["toplam"].ToString());
                }
                baglanti.Close();
            }
            catch (MySqlException)
            {
                baglanti.Close();
                MessageBox.Show("Sunucu hatası;");
            }
            catch(Exception exp)
            {
                baglanti.Close();
                MessageBox.Show("Bilinmeyen bir hata!"+exp.ToString());
            }
            return toplamİsKazanc;
        }
        private int personelGiderBul()
        {
            int personelGider = 0;
            MySqlConnection baglanti = con.baglanti();

            try
            {
                MySqlCommand persGiderBul = new MySqlCommand("Select SUM(Kullanicilar.TopKazanc) toplam from Kullanicilar where AjansNo='" + Form1.ajansID + "' ", baglanti);
                MySqlDataReader persGiderOku = persGiderBul.ExecuteReader();
                while (persGiderOku.Read())
                {
                    personelGider = Convert.ToInt32(persGiderOku["toplam"].ToString());
                }
                baglanti.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show("Sunucu hatası !"+exp.ToString());
                baglanti.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Bilinmeyen bir hata !"+exp.ToString());
                baglanti.Close();
            }

            return personelGider;
        }
        private void Analiz_Load(object sender, EventArgs e)
        {
            aylikGonder();
            grafikCizdir();
         
        }

        private void analizYenile_Click(object sender, EventArgs e)
        {
            aylikGonder();
            grafikCizdir();
    
        }
    }
}
