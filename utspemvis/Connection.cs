using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace utspemvis
{
    public class Connection
    {
        static Random rand = new Random();
        public static int a = rand.Next(2, 51);
        
        
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/Database.mdb");
        
        public static OleDbCommand cmd = new OleDbCommand("SELECT Jawaban, Resource FROM Table1 WHERE ID = '" + a + "'", con);

    }
}
