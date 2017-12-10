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
        public Form1()
        {
            InitializeComponent();
        }
        

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string yetki = "admin";
            try
            {
                beklemedeList.View = View.Details;
                MySqlConnection baglanti;
                SqlBaglanti con = new SqlBaglanti();
                baglanti = con.baglanti();

                MySqlCommand find = new MySqlCommand("select ID,AdSoyad,TelNo,Tarih,Saat from Isler where ajansID=(select AjansNo from Kullanicilar where ID='" + Giris.kullaniciID + "') ", baglanti);
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
                MySqlCommand authorityFind = new MySqlCommand("select KullaniciTipi from Kullanicilar where ID='"+Giris.kullaniciID+"' and KullaniciTipi='"+yetki+"'  ", baglanti);
                MySqlDataReader authorityRead = authorityFind.ExecuteReader();

                if (!authorityRead.HasRows)
                {
                    personelislemleriToolStripMenuItem.Visible = false;
                    fiyatlandirmaIslemleriToolStripMenuItem.Visible = false;
                }
             
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            
        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelKayit personelkayit = new PersonelKayit();
            personelkayit.Show();
        }
    }
}
