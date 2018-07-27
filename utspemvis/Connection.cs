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
        //random function
        static Random rand = new Random();

        //get random into int
        public static int a = rand.Next(2, 51);
        
        //connection to database, DO NOT MESS WITH THIS
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/Database.mdb");
        
        //querry for database, DO NOT MESS IF U DONT UNDERSTAND
        public static OleDbCommand cmd = new OleDbCommand("SELECT Jawaban, Resource FROM Table1 WHERE ID = '" + a + "'", con);

    }
}
