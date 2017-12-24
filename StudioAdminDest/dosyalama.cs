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
using excel = Microsoft.Office.Interop.Excel;

namespace StudioAdminDest
{
    public partial class dosyalama : Form
    {
        public dosyalama()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {



        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        public void isturugosterimi()
        {
            isView.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("Select * from Isler where AjansID='" + Form1.ajansID.ToString() + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["TelNo"].ToString());
                ekle.SubItems.Add(oku["IsTuru"].ToString());
                ekle.SubItems.Add(oku["CekimTuru"].ToString());
                ekle.SubItems.Add(oku["Ekstralar"].ToString());
                ekle.SubItems.Add(oku["CekimYeri"].ToString());
                ekle.SubItems.Add(oku["Referans"].ToString());
                ekle.SubItems.Add(oku["IsiYapanlar"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["TeslimTarihi"].ToString());
                ekle.SubItems.Add(oku["UcretDurumu"].ToString());
                ekle.SubItems.Add(oku["Notlar"].ToString());
                ekle.SubItems.Add(oku["teslimDurumu"].ToString());

                isView.Items.Add(ekle);


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            isView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            isView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        public void baskiGoster()
        {
            baskiView.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("Select MusAdSoy,PerAdSoy,KartonCer,PlastikCer,LuksCer,UcretsizCer,ToplamBaski,Ucret,Tarih from Baski where AjansID='" + Form1.ajansID.ToString() + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusAdSoy"].ToString();
                ekle.SubItems.Add(oku["PerAdSoy"].ToString());
                ekle.SubItems.Add(oku["KartonCer"].ToString());
                ekle.SubItems.Add(oku["PlastikCer"].ToString());
                ekle.SubItems.Add(oku["LuksCer"].ToString());
                ekle.SubItems.Add(oku["UcretsizCer"].ToString());
                ekle.SubItems.Add(oku["ToplamBaski"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());

                baskiView.Items.Add(ekle);


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            baskiView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            baskiView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void dosyalama_Load(object sender, EventArgs e)
        {

            isturugosterimi();
            baskiGoster();
            giderGoster();
        }

        private void isAktar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            for (int k = 0; k < isView.Columns.Count; k++)
            {
                // alanları manuel olarak yazıyoruz
                ws.Cells[1, k + 1] = isView.Columns[k].Text.ToString();
            }

            int i = 3;
            int j = 1;
            foreach (ListViewItem item in isView.Items)
            {
                //ws.Cells[i, j] = item.Text.ToString();
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    ws.Cells[i, j] = subitem.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            for (int k = 0; k < baskiView.Columns.Count; k++)
            {
                // alanları manuel olarak yazıyoruz
                ws.Cells[1, k + 1] = baskiView.Columns[k].Text.ToString();
            }

            int i = 3;
            int j = 1;
            foreach (ListViewItem item in baskiView.Items)
            {
                //ws.Cells[i, j] = item.Text.ToString();
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    ws.Cells[i, j] = subitem.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }
        }
        public void giderGoster()
        {
            GiderView.Items.Clear(); //verilerin tekrarını gösterme !
            MySqlConnection baglanti;
            SqlBaglanti baglan = new SqlBaglanti();
            baglanti = baglan.baglanti();

            MySqlCommand komut = new MySqlCommand("Select GiderTipi,GiderAdi,HarcamayiYapan,GiderTutar,Tarih,AjansID from Gider where AjansID='" + Form1.ajansID.ToString() + "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["GiderTipi"].ToString();
                ekle.SubItems.Add(oku["GiderAdi"].ToString());
                ekle.SubItems.Add(oku["HarcamayiYapan"].ToString());
                ekle.SubItems.Add(oku["GiderTutar"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());

                GiderView.Items.Add(ekle);


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            GiderView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            GiderView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            for (int k = 0; k < GiderView.Columns.Count; k++)
            {
                // alanları manuel olarak yazıyoruz
                ws.Cells[1, k + 1] = GiderView.Columns[k].Text.ToString();
            }

            int i = 3;
            int j = 1;
            foreach (ListViewItem item in GiderView.Items)
            {
                //ws.Cells[i, j] = item.Text.ToString();
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    ws.Cells[i, j] = subitem.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }

        }
    }
}