using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace StudioAdminDest
{
    class SqlBaglanti
    {
        public MySqlConnection baglanti() {
           
            MySqlConnection baglan = new MySqlConnection("Server=furkanalniak.com;Database=furkanal_fotomasyon;Convert Zero Datetime=True;Uid=furkanal_foto;Pwd='emreali23';");
            baglan.Open();
            return baglan;

        }
    }
}
