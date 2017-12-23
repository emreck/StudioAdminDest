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
    public partial class borcOdeme : Form
    {
        private static int oncekiAlacaklari;
        private static int oncekiTopKazanc;
        private static int cekimKazanc;
        public borcOdeme()
        {
            InitializeComponent();
        }

        private void odemeMiktar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void oncekiAlacakKazancBul(int ID)
        {

            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();

            MySqlCommand find = new MySqlCommand("select TopKazanc,Alacaklari,CekimBasiKazanc from Kullanicilar where ID='" + ID + "' ", baglanti);
            MySqlDataReader ucretRead = find.ExecuteReader();
            if (ucretRead.HasRows)
            {
                while (ucretRead.Read())
                {
                    oncekiAlacaklari = Convert.ToInt32(ucretRead["Alacaklari"].ToString());
                    oncekiTopKazanc = Convert.ToInt32(ucretRead["TopKazanc"].ToString());
                    cekimKazanc = Convert.ToInt32(ucretRead["CekimBasiKazanc"].ToString());
                }
            }
        }
        private void borcOdemeListele()
        {
            kullaniciListesi.Items.Clear();
            kullaniciListesi.View = View.Details;

            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();

            try
            {
                MySqlCommand persList = new MySqlCommand("select  ID,AdSoyad,TelNo,TopKazanc,CekimBasiKazanc,Alacaklari from Kullanicilar", baglanti);
                MySqlDataReader persOku = persList.ExecuteReader();

                if (persOku.HasRows)
                {
                    while (persOku.Read())
                    {
                        ListViewItem personeller = new ListViewItem();

                        personeller.Text = persOku["ID"].ToString();
                        personeller.SubItems.Add(persOku["AdSoyad"].ToString());
                        personeller.SubItems.Add(persOku["TelNo"].ToString());
                        personeller.SubItems.Add(persOku["TopKazanc"].ToString());
                        personeller.SubItems.Add(persOku["CekimBasiKazanc"].ToString());
                        personeller.SubItems.Add(persOku["Alacaklari"].ToString());

                        kullaniciListesi.Items.Add(personeller);
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Personel Bulunamadı");
                    baglanti.Close();
                }
                
            }
            catch
            {
                MessageBox.Show("Bilinmeyen bir hata !");
                baglanti.Close();
            }
       

            
        }
        private void persAlacakOde  (int ID)
        {
            
            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();

            try
            {
                oncekiAlacakKazancBul(ID);
                int ucret = Convert.ToInt32(odemeMiktar.Text);
                int guncelAlacak;
                int guncelTopKazanc;
                if (ucret<=oncekiAlacaklari)
                {
                    guncelAlacak = oncekiAlacaklari - ucret;
                    guncelTopKazanc = ucret + oncekiTopKazanc;
                    MySqlCommand alacakOde = new MySqlCommand("update Kullanicilar set Alacaklari='"+guncelAlacak+"' , TopKazanc='"+guncelTopKazanc+"' where ID='"+ID+"' ", baglanti);
                    alacakOde.ExecuteNonQuery();
                    baglanti.Close();
                }
                else if(ucret>oncekiAlacaklari)
                {
                    MessageBox.Show("Alacaktan büyük ücret değeri girmediğinize emin olun !");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Bilinmeyen bir hata !");
                }
             
            }
            catch (MySqlException)
            {
                baglanti.Close();
                MessageBox.Show("Sunucu Hatası !");
            }
            catch
            {
                baglanti.Close();
                MessageBox.Show("Bilinmeyen bir hata !");
            }
        }
        private void persCekimOde   (int ID)
        {
            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();
            oncekiAlacakKazancBul(ID);
            int ucret = oncekiTopKazanc + cekimKazanc;
            try
            {
                MySqlCommand alacakOde = new MySqlCommand("update Kullanicilar set TopKazanc='" + ucret + "' where ID='"+ID+"' ", baglanti);
                alacakOde.ExecuteNonQuery();
                baglanti.Close();
            }
            catch(MySqlException)
            {
                MessageBox.Show("Sunucu Hatası");
            }
            catch
            {
                MessageBox.Show("Personelin çekim ücretini girdiğinize emin olun");
            }
        }
        private void borcOdeme_Load(object sender, EventArgs e)
        {
            borcOdemeListele();
        }

        private void cekimOdeme_Click(object sender, EventArgs e)
        {

            if (kullaniciListesi.SelectedItems.Count == 1)
            {
                persCekimOde(Convert.ToInt32(kullaniciListesi.SelectedItems[0].Text));
                MessageBox.Show("BAŞARILI !");
                borcOdemeListele();

            }
            else if (kullaniciListesi.SelectedItems.Count > 1)
            {
                MessageBox.Show("Lütfen birden fazla iş seçmeyiniz");
            }
            else
            {
                MessageBox.Show("Herhangi bir iş seçtiğinize emin olun");
            }
            
        }
        private void alacakOde_Click(object sender, EventArgs e)
        {
            if (kullaniciListesi.SelectedItems.Count == 1)
            {
                persAlacakOde(Convert.ToInt32(kullaniciListesi.SelectedItems[0].Text));
                MessageBox.Show("BAŞARILI !");
                borcOdemeListele();
            }
            else if (kullaniciListesi.SelectedItems.Count > 1)
            {
                MessageBox.Show("Lütfen birden fazla iş seçmeyiniz");
            }
            else
            {
                MessageBox.Show("Herhangi bir iş seçtiğinize emin olun");
            }
            borcOdemeListele();
        }

   
    }
}
