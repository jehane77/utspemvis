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

        
        int score, life = 5;

        //function for calling (something) from Form2
        Form2 form2 = new Form2();
        Connection con = new Connection();

        //initialize 
        void init()
        {
            con.b();

            //load pict from (path)
            pictureBox1.Refresh();
            pictureBox1.Load(con.fullPath + con.resSoal);
            pictureBox1.Refresh();
            label1.Text = Convert.ToString(con.soal);
            label2.Text = "Jumlah Hati "+life;
            textBox1.Text = "";
        }

        void delete()
        {
            //pictureBox1.Image = null;
            con.resSoal = "";
            con.soal = "";
            label1.Text = "";
            label2.Text = "";
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
            con.jawab = textBox1.Text.ToLower();
            //label1.Text = con.jawab;

            
            //error handling
            if(con.jawab == "")
            {
                MessageBox.Show("Jawaban Tidak Boleh Kosong");
            }

            //game logic
            else
            {
                if (con.jawab == con.soal)
                {
                    MessageBox.Show("Jawaban Benar");
                    score = score + 1;
                    label3.Text = "Jumlah Score " + score;

                    delete();
                    //con.b();
                    //InitializeComponent();
                    init();
                }
                else
                {
                    //false condition
                    life = life - 1;
                    label2.Text = "Jumlah Hati " + life;
                    //has life
                    if (life > 0)
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
}
