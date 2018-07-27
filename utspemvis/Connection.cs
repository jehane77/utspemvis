using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace utspemvis
{
    public class Connection
    {
        //random function
        static Random rand = new Random();
        public static int a;
        
        public string soal = "";
        public string jawab = "";
        public string resSoal;
        public string fullPath;

        public void b()
        {

            a = rand.Next(2, 51);
            int c = a;
            //connection to database, DO NOT MESS WITH THIS
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/Database.mdb");

            //querry for database, DO NOT MESS IF U DONT UNDERSTAND
            OleDbCommand cmd = new OleDbCommand("SELECT Jawaban, Resource FROM Table1 WHERE ID = '" + c + "'", con);

            //get path to image
            
            string path1 = @"../../Resources/";
            fullPath = Path.GetFullPath(path1);

            //open connection
            con.Open();

            //read from database
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //insert data from database to var
            soal = dr.GetString(0);
            resSoal = dr.GetString(1);

            //close read and connection
            dr.Close();
            //cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        



    }
}
