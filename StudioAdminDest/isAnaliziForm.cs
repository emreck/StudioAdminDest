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
    public partial class isAnaliziForm : Form
    {
        public int aylikIslKazanc;
        public int aylikIslGider; 
        SqlBaglanti con = new SqlBaglanti();
        public isAnaliziForm()
        {
            InitializeComponent();
        }

        public int giderBul()
        {
            int toplamgider=0;
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
            catch(MySqlException)
            {
                baglanti.Close();
                MessageBox.Show("Sunucu hatası !");
                
            }
            catch
            {
                baglanti.Close();
                MessageBox.Show("Bilinmeyen bir hata !");
            }
            return toplamgider;
        }
        private int  personelGiderBul()
        {
            int personelGider=0;
            MySqlConnection baglanti = con.baglanti();

            try
            {
                MySqlCommand persGiderBul = new MySqlCommand("Select SUM(Kullanicilar.TopKazanc) toplam from Kullanicilar where AjansID='" + Form1.ajansID + "' ", baglanti);
                MySqlDataReader persGiderOku = persGiderBul.ExecuteReader();
                while (persGiderOku.Read())
                {
                    personelGider += Convert.ToInt32(persGiderOku["toplam"].ToString());
                }
                baglanti.Close();
            }
            catch(MySqlException)
            {
                MessageBox.Show("Sunucu hatası !");
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Bilinmeyen bir hata !");
                baglanti.Close();
            }

            return personelGider;
        }

        private int isKazanc()
        {
            int toplamİsKazanc = 0;
            
            MySqlConnection baglanti = con.baglanti();
            try
            {
                MySqlCommand toplamIsKazanBul = new MySqlCommand("select Sum(Isler.Fiyat)toplam from Isler where UcretDurumu='ALINDI' ", baglanti);
                MySqlDataReader toplamIsKazancOku = toplamIsKazanBul.ExecuteReader();
                while (toplamIsKazancOku.Read())
                {
                    toplamİsKazanc += Convert.ToInt32(toplamIsKazancOku["toplam"].ToString());
                }
                baglanti.Close();
            }
            catch(MySqlException)
            {
                baglanti.Close();
                MessageBox.Show("Sunucu hatası;");
            }
            catch
            {
                baglanti.Close();
                MessageBox.Show("Bilinmeyen bir hata!");
            }
            return toplamİsKazanc;
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

            chart1.Series["OGRENCI"].Points.Add(persGider);
            chart1.Series["OGRENCI"].Points.Add(isletmeGider);
            chart1.Series["OGRENCI"].Points.Add(toplamIsKazanc);

            chart1.Series["veriler"].Points[0].AxisLabel = "PERSONEL GİDERİ";
            chart1.Series["veriler"].Points[1].AxisLabel = "iŞLETME GİDERİ";
            chart1.Series["veriler"].Points[2].AxisLabel = "İŞ KAZANCI";

            chart1.Series["veriler"].Points[0].Color = Color.Red;
            chart1.Series["veriler"].Points[1].Color = Color.Black;
            chart1.Series["veriler"].Points[2].Color = Color.Green;

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -70;

            chart1.BackColor = Color.YellowGreen;
        }

        public void aylikGonder()
        {
            DateTime ayKontrol = new DateTime();
            ayKontrol = DateTime.Now.AddHours(-1);

            MySqlConnection baglanti = con.baglanti();

            try
            {
                MySqlCommand kazancBul = new MySqlCommand("select Fiyat,Tarih from Isler where UcretDurumu='ALINDI' and ajansID='"+Form1.ajansID+"'  ", baglanti);
                MySqlDataReader kazancOku = kazancBul.ExecuteReader();
                while (kazancOku.Read())
                {
                    if (Convert.ToDateTime(kazancOku["Tarih"]) > ayKontrol)
                    {
                        aylikIslKazanc += Convert.ToInt32(kazancOku["Fiyat"].ToString());
                    }
                }
                baglanti.Close();
                aylik.Text = aylikIslKazanc.ToString();

                //-------------

                baglanti.Open();
                MySqlCommand giderBul = new MySqlCommand("select GiderTutar,Tarih from Gider where  ajansID='" + Form1.ajansID + "'  ", baglanti);
                MySqlDataReader giderOku = giderBul.ExecuteReader();
                while (giderOku.Read())
                {
                    if (Convert.ToDateTime(giderOku["Tarih"]) > ayKontrol)
                    {
                        aylikIslGider += Convert.ToInt32(kazancOku["GiderTutar"].ToString());
                    }
                }
                baglanti.Close();
                aylikIsletmeGider.Text = aylikIslGider.ToString();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Sunucu hatası !");
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Bilinmeyen bir hata !");
                baglanti.Close();
            }
        }
        private void isAnaliziForm_Load(object sender, EventArgs e)
        {
            grafikCizdir();
            aylikGonder();
        }

        private void isAnalizYenile_Click(object sender, EventArgs e)
        {
            grafikCizdir();
            aylikGonder();
        }
    }
}
