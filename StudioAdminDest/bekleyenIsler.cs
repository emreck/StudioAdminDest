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
            bugun = DateTime.Now;
            try
            {
                
                MySqlCommand find = new MySqlCommand("select ID,AdSoyad,TelNo,Tarih,Saat,Referans,CekimYeri,teslimDurumu,IsiYapanlar from Isler where ajansID='" + Form1.ajansID + "' and onay='" + onay + "'  ", baglanti);
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
                int i = 0;
                ucretlendirme.Visible = true;
                foreach (var item in personelAta.CheckedItems)
                {

                }
            }
            catch(Exception exp)
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
    }
}
