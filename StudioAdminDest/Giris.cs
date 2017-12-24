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
using System.Security.Cryptography;

namespace StudioAdminDest
{
    public partial class Giris : Form
    {
       public static int kullaniciID;

        public Giris()
        {
            InitializeComponent();
        }
        public static string EncryptWithMD5(string ClearString)
        {
            System.Text.UnicodeEncoding objUE = new System.Text.UnicodeEncoding();

            byte[] bytClearString = objUE.GetBytes(ClearString);

            MD5CryptoServiceProvider objProv = new MD5CryptoServiceProvider();

            byte[] hash = objProv.ComputeHash(bytClearString);
            return Convert.ToBase64String(hash);
        }

        public bool tehlike(string veri)
        {
            string[] strList = veri.Split(' ');
            List<string> yasakKelime = new List<string>
                (new string[]
                {"select","where","from","drop","alter table","table","insert into",
                    "insert","or","OR","join","update","set","script","body","alert","delete"});
            for (int i = 0; i < strList.Length; i++)
            {
                if (yasakKelime.Find(n => n == strList[i].ToString()) != null) return false;
            }

            return true;
        }
        private void girisYapButton_Click(object sender, EventArgs e)
        {   MySqlConnection baglanti;
            SqlBaglanti con = new SqlBaglanti();
            baglanti = con.baglanti();

            if (tehlike(kullaniciAdi.Text)==true || tehlike(passwordText.Text)==true)
            {
                try
                {
                    MySqlCommand find = new MySqlCommand("select KulAdi,sifre,ID from Kullanicilar where Kuladi='" + kullaniciAdi.Text + "' and sifre='" + EncryptWithMD5(passwordText.Text) + "' ", baglanti);
                    MySqlDataReader userRead = find.ExecuteReader();
                    if (userRead.HasRows)
                    {
                        while (userRead.Read())
                        {
                            kullaniciID = Convert.ToInt32(userRead["ID"].ToString());
                        }
                        baglanti.Close();
                        this.Hide();
                        Form1 defaultPage = new Form1();
                        defaultPage.Show();

                    }
                    else
                    {
                        baglanti.Close();
                        MessageBox.Show("Hatalı kullanıcı adı yada şifre");
                    }





                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                    kullaniciAdi.Focus();
                }

            }

            else
            {
                MessageBox.Show("Uygunsuz girdi !");
            }
          
           
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            kullaniciAdi.Focus();
        }

        
    }
}
