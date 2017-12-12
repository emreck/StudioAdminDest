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
        public IsEkle()
        {
            InitializeComponent();
        }
        public bool alanKontrol()
        {
            if (string.IsNullOrWhiteSpace(isAdSoyad.Text)|| string.IsNullOrEmpty(isAdSoyad.Text))
            {
                errorProvider1.SetError(isAdSoyad, "Lütfen adı soyadı giriniz");
                return false;
            }
            if (string.IsNullOrWhiteSpace(isTel.Text) || string.IsNullOrEmpty(isTel.Text))
            {
                errorProvider1.SetError(isTel, "Lütfen telefon no giriniz");
                return false;
            }
            if (string.IsNullOrWhiteSpace(isMail.Text) || string.IsNullOrEmpty(isMail.Text))
            {
                errorProvider1.SetError(isMail, "Lütfen Mail Adresini Giriniz");
                return false;
            }
            return true;
        }
        private void IsEkle_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(+1);
            dateTimePicker1.CustomFormat = "d/M/yyyy";
        }

        private void isiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (alanKontrol()==false)
                {
                    MessageBox.Show("Lütfen degerleri bos bırakmadan giriniz");
                }
                else
                {
                    MessageBox.Show("BAŞARILI");
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
    }
}
