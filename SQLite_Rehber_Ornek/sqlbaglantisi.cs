using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteRehberOrnek
{
    class sqlbaglantisi
    {
        public SQLiteConnection baglanti()
        {
            SQLiteConnection baglan = new SQLiteConnection(@"Data Source = DbRehber.db;Version=3;");
            baglan.Open();
            return baglan;
        }
    }
}
