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
    public partial class IsEkle : Form
    {
        public static  string ajansAdi;

        public IsEkle()
        {
            InitializeComponent();
        }
        public bool alanKontrol()
        {
            if (string.IsNullOrWhiteSpace(isAdSoyad.Text) || string.IsNullOrEmpty(isAdSoyad.Text))
            {
                errorProvider1.SetError(isAdSoyad, "Lütfen adı soyadı giriniz");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(isTel.Text) || string.IsNullOrEmpty(isTel.Text))
            {
                errorProvider1.SetError(isTel, "Lütfen telefon no giriniz");
                return false;
            }
            else if (string.IsNullOrEmpty(fiyatTextbox.Text) || string.IsNullOrWhiteSpace(fiyatTextbox.Text))
            {
                errorProvider1.SetError(fiyatTextbox, "Lütfen telefon no giriniz");
                return false;
            }
            else { return true; } 
        }
        private void IsEkle_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(+1);
            dateTimePicker1.CustomFormat = "d/M/yyyy";

            
            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();
            MySqlCommand ajansBul = new MySqlCommand("select ajansAdi from Ajanslar where ID='" + Form1.ajansID + "' ", baglanti);
            MySqlDataReader ajansOku = ajansBul.ExecuteReader();
            if (ajansOku.HasRows)
            {
                if (ajansOku.Read())
                {
                    ajansAdi = ajansOku["ajansAdi"].ToString();
                    baglanti.Close();
                }

            }
            else
            {
                baglanti.Close();
                MessageBox.Show("BEKLENMEYEN BİR HATA");
            }
            
        }

        private void isiEkle_Click(object sender, EventArgs e)
        {

            string onay = "ONAYLANDI";
            string teslim = "Teslim Edilmedi";
            try
            {
                string saat = comboBox1.SelectedItem.ToString() +":"+ comboBox2.SelectedItem.ToString();
                

                if (alanKontrol()==false)
                {
                    MessageBox.Show("Lütfen degerleri bos bırakmadan giriniz");
                }
                else
                {
                    

                    SqlBaglanti con = new SqlBaglanti();
                    MySqlConnection baglanti = con.baglanti();

                    MySqlCommand randBul = new MySqlCommand("select ajansID,Tarih,Saat from Isler where ajansID='"+Form1.ajansID+"' and Tarih='"+dateTimePicker1.Text+"' and Saat='"+saat+"'  ",baglanti);
                    MySqlDataReader randOku = randBul.ExecuteReader();
                    if (randOku.HasRows)
                    {
                        MessageBox.Show("Seçtiğiniz tarih-saat dolu! Tekrar deneyiniz");
                        baglanti.Close();
                    }
                    else
                    {
                        baglanti.Close();

                        baglanti.Open();
                        MySqlCommand randEkle = new MySqlCommand("insert into Isler(AdSoyad,TelNo,ajansID,Tarih,Saat,onay,AjansAdi,CekimYeri,Fiyat,teslimDurumu) values('"+isAdSoyad.Text+"','"+isTel.Text+"','"+Form1.ajansID+"','"+dateTimePicker1.Text+"','"+saat+"','"+onay+"','"+ajansAdi+"','"+adresRichTextbox.Text+"','"+fiyatTextbox.Text+"','"+teslim+"') ",baglanti);
                        randEkle.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("İŞ BAŞARIYLA EKLENDİ");

                        //-----------------finish

                        isAdSoyad.Text = "";
                        isTel.Text = "";
                        fiyatTextbox.Text = "";
                        adresRichTextbox.Text = "";
                        isReferans.Text = "";

                    }
                }


            }
            catch(NullReferenceException exp)
            {
                MessageBox.Show("HATA : Saat ve diğer değerleri girdiğinize emin olun ");
            }
            catch
            {
                MessageBox.Show("Doğru değerler girdiğinize emin olun");
            }
        }

        private void fiyatTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void isTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }
    }
}
