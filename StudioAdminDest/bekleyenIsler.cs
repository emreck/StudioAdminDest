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
        public bekleyenIsler()
        {
            InitializeComponent();
        }

        private void onayliListele()
        {
            onayliListe.View = View.Details;
            onayliListe.Items.Clear();
            string onay = "ONAYLANDI";
            SqlBaglanti con = new SqlBaglanti();
            MySqlConnection baglanti=con.baglanti();
            DateTime bugun = new DateTime();
            bugun = DateTime.Now.AddDays(+1);
            try
            {
                
                MySqlCommand find = new MySqlCommand("select ID,AdSoyad,TelNo,Tarih,Saat from Isler where ajansID='" + Form1.ajansID + "' and onay='" + onay + "' ", baglanti);
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
        }

        private void bekleyenIsler_Load(object sender, EventArgs e)
        {
            onayliListele();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            onayliListele();
        }

    }
}
