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
    public partial class bekleyenIsler : Form
    {
        private static int oncekiTopKazanc;
        private static int oncekiAlacak;
        public bekleyenIsler()
        {
            InitializeComponent();
        }

        private void onayliListele()
        {
            string teslimDurumu = "Teslim Edilmedi";
            onayliListe.View = View.Details;
            onayliListe.Items.Clear();
            string onay = "ONAYLANDI";
            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti=con.baglanti();
            DateTime bugun = new DateTime();
            bugun = DateTime.Now;
            try
            {
                
                MySqlCommand find = new MySqlCommand("select ID,AdSoyad,TelNo,Tarih,Saat,Referans,CekimYeri,teslimDurumu,IsiYapanlar,UcretDurumu from Isler where ajansID='" + Form1.ajansID + "' and onay='" + onay + "' and teslimDurumu='"+teslimDurumu+"'  ", baglanti);
                MySqlDataReader reader = find.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (bugun < Convert.ToDateTime(reader["Tarih"].ToString()))
                        {
                            ListViewItem randevular = new ListViewItem();

                            randevular.Text = reader["ID"].ToString();
                            randevular.SubItems.Add(reader["AdSoyad"].ToString());
                            randevular.SubItems.Add(reader["TelNo"].ToString());
                            randevular.SubItems.Add(reader["Tarih"].ToString());
                            randevular.SubItems.Add(reader["Saat"].ToString());
                            randevular.SubItems.Add(reader["Referans"].ToString());
                            randevular.SubItems.Add(reader["CekimYeri"].ToString());
                            randevular.SubItems.Add(reader["teslimDurumu"].ToString());
                            randevular.SubItems.Add(reader["IsiYapanlar"].ToString());
                            randevular.SubItems.Add(reader["UcretDurumu"].ToString());

                            onayliListe.Items.Add(randevular);
                        }
                       
                    }
                    baglanti.Close();
                }
            }
            catch(Exception exp)
            {
                baglanti.Close();
                MessageBox.Show("HATA :" + exp.ToString());
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            onayliListe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            onayliListe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void personelListele()
        {
            try
            {
                SqlBaglanti con = new SqlBaglanti();
                MySqlConnection baglanti = con.baglanti();

                MySqlCommand personelAra = new MySqlCommand("select AdSoyad from Kullanicilar where ajansNo ='" + Form1.ajansID + "' ", baglanti);
                MySqlDataReader personelOku = personelAra.ExecuteReader();

                if (personelOku.HasRows)
                {
                    while (personelOku.Read())
                    {
                        personelAta.Items.Add(personelOku["AdSoyad"].ToString());
                    
                    }
                    baglanti.Close();
                }
            }
            catch (Exception personelExp)
            {
                MessageBox.Show(personelExp.ToString());


            }
      

            

        }
        private void bekleyenIsler_Load(object sender, EventArgs e)
        {
            onayliListele();
            personelListele();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            onayliListele();
        }
        
        private void personelAta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string eleman;

        private void isAtama_Click(object sender, EventArgs e)
        {
            try
            {
                if (onayliListe.SelectedItems.Count==1)
                {
                    int i = -1;
                    ucretlendirme.Visible = true;
                    foreach (var item in personelAta.CheckedItems)
                    {
                        eleman = eleman +"-"+ item.ToString();
                        i++;
                        personelCb.Items.Add(personelAta.CheckedItems[i].ToString());
                    }
                    SqlBaglanti con = new SqlBaglanti();
                    MySqlConnection baglanti = con.baglanti();
                    MySqlCommand guncelle = new MySqlCommand("update Isler set IsiYapanlar='"+eleman+"' where ID='"+onayliListe.SelectedItems[0].Text+"' ", baglanti);
                    guncelle.ExecuteNonQuery();
                    baglanti.Close();

                    onayliListele();
                    
                }

                else if(onayliListe.SelectedItems.Count >= 1)
                {
                    MessageBox.Show("Lütfen birden fazla iş seçmeyiniz");
                }

                else
                {
                    MessageBox.Show("Hata ! Herhangi bir iş seçtiğinize emin olun.");
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Lütfen değerleri boş bırakmayınız");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
       
        }

        private void ucretKontrol_KeyPress(object sender, KeyPressEventArgs e)
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

        private void odemeYap_Click(object sender, EventArgs e)
        {
          

            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();
            int ucret = Convert.ToInt32(ucretKontrol.Text);


            try
            {
                if (ucret > 0)
                {

                    string adSoyad = personelCb.SelectedItem.ToString();
                    oncekiUcret(adSoyad);
                    ucret += oncekiTopKazanc;
                    MySqlCommand fiyatEkle = new MySqlCommand("update Kullanicilar set TopKazanc ='" +ucret+ "' where AdSoyad like '%"+adSoyad+"%'  ", baglanti);
                    fiyatEkle.ExecuteNonQuery();
                    baglanti.Close();

                    ucretKontrol.Text = "";
                    MessageBox.Show("BAŞARILI");
                }
           
            }
            catch(NullReferenceException exp)
            {
                baglanti.Close();
                MessageBox.Show("Herhangi bir değer seçtiğinizden emin olun!");
            }
            catch(MySqlException exp)
            {
                baglanti.Close();
                MessageBox.Show("Hata !Sunucuya bağlanılamıyor ");
            }
            catch(Exception exp)
            {
                baglanti.Close();
                MessageBox.Show(exp.ToString());
            } 
        }

        private void dahasonraOdemeYap_Click(object sender, EventArgs e)
        {


            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();
            int ucret = Convert.ToInt32(ucretKontrol.Text);


            try
            {
                if (ucret > 0)
                {

                    string adSoyad = personelCb.SelectedItem.ToString();
                    oncekiUcret(adSoyad);
                    ucret += oncekiAlacak;
                    MySqlCommand fiyatEkle = new MySqlCommand("update Kullanicilar set Alacaklari ='" + ucret + "' ", baglanti);
                    fiyatEkle.ExecuteNonQuery();
                    baglanti.Close();

                    ucretKontrol.Text = "";
                    MessageBox.Show("BAŞARILI");
                }
                else
                {
                    MessageBox.Show("Değerleri boş bırakmadığınıza emin olun!");
                }

            }
            catch (NullReferenceException exp)
            {
                baglanti.Close();
                MessageBox.Show("Değerleri boş bırakmadığınıza emin olun!");
            }
            catch (MySqlException exp)
            {
                baglanti.Close();
                MessageBox.Show("Hata !Sunucuya bağlanılamıyor ");
            }
            catch (Exception exp)
            {
                baglanti.Close();
                MessageBox.Show(exp.ToString());
            }
        }
      
        public void oncekiUcret(string isimsoyisim)
        {
            
            
            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();

            MySqlCommand find = new MySqlCommand("select TopKazanc,Alacaklari from Kullanicilar where AdSoyad='"+isimsoyisim+"' ", baglanti);
            MySqlDataReader ucretRead = find.ExecuteReader();
            if (ucretRead.HasRows)
            {
                while (ucretRead.Read())
                {
                    oncekiAlacak = Convert.ToInt32(ucretRead["Alacaklari"].ToString());
                    oncekiTopKazanc = Convert.ToInt32(ucretRead["TopKazanc"].ToString());
                }
            }

        }

        public void odemeTamamla(int ID)
        {
            string guncelle = "ALINDI";
            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();

            MySqlCommand ucretAl = new MySqlCommand("update Isler set UcretDurumu='"+guncelle+"' where ID='"+ID+"' ",baglanti);
            ucretAl.ExecuteNonQuery();

            baglanti.Close();            
        }

        public void teslimEdildi(int ID)
        {

            string guncelle = "Teslim Edildi";
            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();

            MySqlCommand teslim = new MySqlCommand("update Isler set teslimDurumu='" + guncelle + "' where ID='" + ID + "' ", baglanti);
            teslim.ExecuteNonQuery();

            baglanti.Close();
        }

        private void ucretOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (onayliListe.SelectedItems.Count==1)
                {
                    odemeTamamla(Convert.ToInt32(onayliListe.SelectedItems[0].Text));
                    onayliListele();
                }
                else if (onayliListe.SelectedItems.Count >= 1)
                {
                    MessageBox.Show("Lütfen birden fazla iş seçmeyiniz");
                }
                else
                {
                    MessageBox.Show("Bilinmeyen bir hata !");
                }
            }
            catch(MySqlException mysqlexp)
            {
                MessageBox.Show("Sunucuya Bağlanılamıyor !");
            }
            catch(NullReferenceException nullexp)
            {
                MessageBox.Show("Değerleri doğru girdiğinize emin olun !");
            }
        }

        private void teslimEt_Click(object sender, EventArgs e)
        {
            try
            {
                if (onayliListe.SelectedItems.Count == 1)
                {
                    teslimEdildi(Convert.ToInt32(onayliListe.SelectedItems[0].Text));
                    onayliListele();
                    MessageBox.Show("Başarılı !");
                }
                else if (onayliListe.SelectedItems.Count>1)
                {
                    MessageBox.Show("Birden fazla değer seçtiğinize emin olun!");
                }
                else
                {
                    MessageBox.Show("Herhangi bir değer seçtiğinize emin olun!");
                }
            }
            catch(MySqlException)
            {
                MessageBox.Show("Sunucuya bağlanılamıyor");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Herhangi bir değer seçtiğinize emin olun!");
            }
        }
    }

}
