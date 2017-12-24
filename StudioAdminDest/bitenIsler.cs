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
    public partial class bitenIsler : Form
    {
        public bitenIsler()
        {
            InitializeComponent();
        }

        public void bitenListele()
        {
            bitenIslerListView.Items.Clear();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            bitenIslerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            bitenIslerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            string teslimDurumu ="Teslim Edildi";
            DateTime bugun = new DateTime();
            bugun = DateTime.Now;

            bitenIslerListView.View = View.Details;
            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti = con.baglanti();

            MySqlCommand bitenBul = new MySqlCommand("select ID,AdSoyad,TelNo,TeslimTarihi,teslimDurumu,Tarih,Saat,Referans,CekimYeri,IsiYapanlar,Fiyat,UcretDurumu from Isler where teslimDurumu='Teslim Edildi' and ajansID='"+Form1.ajansID+"' ", baglanti);
            MySqlDataReader bitenAra = bitenBul.ExecuteReader();

            if (bitenAra.HasRows)
            {
                while (bitenAra.Read())
                {
                    
                        ListViewItem bitenler = new ListViewItem();

                        bitenler.Text = bitenAra["ID"].ToString();
                        bitenler.SubItems.Add(bitenAra["AdSoyad"].ToString());
                        bitenler.SubItems.Add(bitenAra["TelNo"].ToString());
                        bitenler.SubItems.Add(bitenAra["TeslimTarihi"].ToString());
                        bitenler.SubItems.Add(bitenAra["teslimDurumu"].ToString());
                        bitenler.SubItems.Add(bitenAra["Tarih"].ToString());
                        bitenler.SubItems.Add(bitenAra["Saat"].ToString());
                        bitenler.SubItems.Add(bitenAra["Referans"].ToString());
                        bitenler.SubItems.Add(bitenAra["CekimYeri"].ToString());
                        bitenler.SubItems.Add(bitenAra["IsiYapanlar"].ToString());
                        bitenler.SubItems.Add(bitenAra["Fiyat"].ToString());
                        bitenler.SubItems.Add(bitenAra["UcretDurumu"].ToString());

                    bitenIslerListView.Items.Add(bitenler);

                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Herhangi bir kayıt bulunamadi");
                baglanti.Close();
            }

        }
        
        private void bitenIsler_Load(object sender, EventArgs e)
        {
            bitenListele();
        }

        public void ucretOdeme(int ID)
        {
            try
            {
                if (bitenIslerListView.SelectedItems.Count == 1)
                {
                    string UCRETYENILEME = "ALINDI";
                    SqlBaglanti con = new SqlBaglanti();
                    MySqlConnection baglanti = con.baglanti();

                    MySqlCommand ucretOdemeYenile = new MySqlCommand("update Isler set UcretDurumu='" + UCRETYENILEME + "' where ID='" + ID + "' ", baglanti);
                    ucretOdemeYenile.ExecuteNonQuery();

                    baglanti.Close();
                }
                else if (bitenIslerListView.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Birden fazla iş seçmeyiniz !");
                }
                else
                {
                    MessageBox.Show("Herhangi bir iş seçtiğinize emin olun !");
                }
            }
            catch(MySqlException)
            {
                MessageBox.Show("Sunucu Hatası !");
            }
            catch
            {
                MessageBox.Show("Hata ! Herhangi bir iş seçtiğinize emin olun !");
            }
         
        }
        private void bitenIslerYenile_Click(object sender, EventArgs e)
        {
            try
            {
                bitenListele();
            }
            catch(MySqlException)
            {
                MessageBox.Show("Veritabanina bağlanılamıyor!");
            }
            catch
            {
                MessageBox.Show("Bilinmeyen hata !");
            }
          
        }

        private void odemeTamamla_Click(object sender, EventArgs e)
        {
            try
            {
                if (bitenIslerListView.SelectedItems[0].SubItems[11].Text == "ALINDI")
                {
                    MessageBox.Show("Alınan ucreti tıklamadıgına emin olun !");
                }
                else
                {
                    ucretOdeme(Convert.ToInt32(bitenIslerListView.SelectedItems[0].Text));
                    bitenListele();
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Herhangi bir iş seçtiğinize emin olun !");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Sunucu hatası !");
            }
            catch
            {
                MessageBox.Show("Bilinmeyen bir hata !");
            }
         
        }
    }
}
