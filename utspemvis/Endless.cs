using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

namespace utspemvis
{
    public partial class Endless : Form
    {
        
        string soal = "";
        string jawab = "";
        string resSoal;
        int score, life = 5;

        //function for calling (something) from Form2
        Form2 form2 = new Form2();

        //initialize 
        void init()
        {
            //get path to image
            string fullPath;
            string path1 = @"../../Resources/";
            fullPath = Path.GetFullPath(path1);

            //open connection
            Connection.con.Open();

            //read from database
            OleDbDataReader dr = Connection.cmd.ExecuteReader();
            dr.Read();

            //insert data from database to var
            soal = dr.GetString(0);
            resSoal = dr.GetString(1);

            //close read and connection
            dr.Close();
            Connection.cmd.Connection = Connection.con;
            Connection.cmd.ExecuteNonQuery();
            Connection.con.Close();

            //load pict from (path)
            pictureBox1.Load(fullPath + resSoal);
            label1.Text = Convert.ToString(life);

            textBox1.Text = "";
        }

        public Endless()
        {
            //happend before Form load
            InitializeComponent();
            init();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lowercase text from textbox
            jawab = textBox1.Text.ToLower();
            label1.Text = jawab;

            //game logic
            if (jawab == soal)
            {
                MessageBox.Show("Jawaban Benar");
                score = score + 1;
                init();
            }
            else
            {
                //false condition
                life = life-1;

                //has life
                if(life > 0)
                {
                    MessageBox.Show("Jawaban Salah, Coba Lagi");
                }

                //has no life
                else
                {
                    MessageBox.Show("Anda Kalah");

                    //closing form endless
                    this.Close();
                    form2.Visible = true;
                }
                
            }
        }
    }
}
