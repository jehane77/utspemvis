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
        Form2 form2 = new Form2();

        void init()
        {
            string fullPath;
            string path1 = @"../../Resources/";
            fullPath = Path.GetFullPath(path1);

            Connection.con.Open();
            OleDbDataReader dr = Connection.cmd.ExecuteReader();
            dr.Read();

            soal = dr.GetString(0);
            resSoal = dr.GetString(1);
            dr.Close();
            Connection.cmd.Connection = Connection.con;
            Connection.cmd.ExecuteNonQuery();
            Connection.con.Close();

            pictureBox1.Load(fullPath + resSoal);
            label1.Text = Convert.ToString(life);
            textBox1.Text = "";
        }

        public Endless()
        {
            InitializeComponent();
            init();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }




        private void button1_Click(object sender, EventArgs e)
        {
            
            jawab = textBox1.Text.ToLower();
            label1.Text = jawab;
            if (jawab == soal)
            {
                MessageBox.Show("Jawaban Benar");
                score = score + 1;
                init();
            }
            else
            {
                life = life-1;
                if(life > 0)
                {
                    MessageBox.Show("Jawaban Salah, Coba Lagi");
                }
                else
                {
                    MessageBox.Show("Anda Kalah");
                    this.Close();
                    form2.Visible = true;
                }
                
            }
        }
    }
}
