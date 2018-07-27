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

        

        //endless connection function
        public void endlessConnection()
        {
            //get random to var a for search ID
            a = rand.Next(2, 51);

            //passing value to var c
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
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //level connection function
        int level = 2; //2 means the begining(lowest value) of DB => ID column
        public void levelConnection()
        {
            
            //get val to val c to search ID
            int c = level;

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
            cmd.ExecuteNonQuery();
            con.Close();

            //state level
            level = level + 1;
        }




    }
}
