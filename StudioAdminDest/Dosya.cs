using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
namespace StudioAdminDest
{
    public partial class Dosya : Form
    {
        public Dosya()
        {
            InitializeComponent();
        }

        private void Dosya_Load(object sender, EventArgs e)
        {
            giderGoster();
        }
        public void giderGoster()
        {
            gidergor.Items.Clear(); //verilerin tekrarını gösterme !
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

                gidergor.Items.Add(ekle);


                // buraya kadar veritabanından okuduğu yerleri listview'de sırayla yazdı.
            }
            baglanti.Close();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gidergor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            gidergor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void aktar_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
            //uygulama.Visible = true;
            //Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
            //Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            //Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[2, 5]; // kaçıncı hücre olduğu ilki satır ikincisi sütun
            //alan.Value2 = textBox1.Text;


            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

            for (int k = 0; k < gidergor.Columns.Count; k++)
            {
                // alanları manuel olarak yazıyoruz
                ws.Cells[1, k+1] = gidergor.Columns[k].Text.ToString();
            }
            int i = 2;
            int j = 2;
          // kaçıncı hücre olduğu ilki satır ikincisi sütun

            foreach (ListViewItem item in gidergor.Items)
            {
                ws.Cells[i, j] = item.Text.ToString();
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
