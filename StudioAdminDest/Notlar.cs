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
    public partial class Notlar : Form
    {
        public Notlar()
        {
            InitializeComponent();
        }
        public void verilerigoster()// Veritabanındaki verileri listview'de gösterir.
        {
            NotGoster.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;

            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("SELECT Kullanici,icerik,Tarih FROM Notlar where AjansID='"+Form1.ajansID+"' ORDER BY Tarih ASC", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
        
            while (oku.Read())
            {


                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kullanici"].ToString();            ;
                ekle.SubItems.Add(oku["icerik"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());

                NotGoster.Items.Add(ekle);
               

                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            NotGoster.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            NotGoster.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public bool tehlike(string veri)
        {
            string[] strList = veri.Split(' ');
            List<string> yasakKelime = new List<string>
                (new string[]
                {"select","where","from","drop","alter table","table","insert into",
                    "insert","or","OR","join","update","set","script","body","alert","delete,","'","''"});
            for (int i = 0; i < strList.Length; i++)
            {
                if (yasakKelime.Find(n => n == strList[i].ToString()) != null)
                    return false;
            }

            return true;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            if (string.IsNullOrWhiteSpace(NotYaz.Text) || tehlike(NotYaz.Text)==false )
            {
                errorProvider1.SetError(NotYaz, "Boş Not Bırakılamaz !");
            }
            else if (string.IsNullOrWhiteSpace(kullanici.Text) || tehlike(kullanici.Text) == false)
            {
                errorProvider1.SetError(kullanici, "Bir Kullanıcı adı giriniz !");
            }
            else
            {
                
                MySqlConnection baglanti;
                SqlBaglanti baglan = new SqlBaglanti();
                baglanti = baglan.baglanti();
                MySqlCommand ekle = new MySqlCommand("insert into Notlar (Kullanici,icerik,Tarih,AjansID) values ('" + kullanici.Text + "','" + NotYaz.Text + "','" + tarih.ToString() + "','" + Form1.ajansID + "') ", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Notunuz Eklenmiştir.");
                kullanici.Text = string.Empty;
                NotYaz.Text = string.Empty;
                verilerigoster();
                errorProvider1.Clear();
                
            }
        }

        private void Notlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotGoster.SelectedItems.Count > 0)
            {
                
                DialogResult uyari = MessageBox.Show("'" + NotGoster.SelectedItems[0].Text + "' Kullanıcısının Notunu silmek istemisiniz ? ", "Uyarı !", MessageBoxButtons.YesNo);
                if (uyari == DialogResult.Yes)
                {

                    MySqlConnection baglanti;
                    SqlBaglanti baglan = new SqlBaglanti();
                    baglanti = baglan.baglanti();
                    MySqlCommand komut = new MySqlCommand("delete from Notlar where Tarih='" + NotGoster.SelectedItems[0].SubItems[2].Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                    MessageBox.Show("Not Başarıyla Silinmiştir.");
                    

                }


            }
        }
    }
}
