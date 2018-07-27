using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utspemvis
{
    public partial class Level_1 : Form
    {
        int score, life = 5;
        int count = 0;
        Connection con = new Connection();
        
        //initialize 
        void init()
        {
            //call connection function
            con.levelConnection();

            //load pict from (path)
            pictureBox1.Refresh();
            pictureBox1.Load(con.fullPath + con.resSoal); //DONT MESS WITH THIS
            pictureBox1.Refresh();

            //for debuging
            label1.Text = Convert.ToString(con.soal); //feel free to delete

            //display current life
            label2.Text = "Jumlah Hati " + life;

            textBox1.Text = "";
        }

        //reset component
        void delete()
        {
            con.resSoal = "";
            con.soal = "";
            label1.Text = "";
            label2.Text = "";
            textBox1.Text = "";
        }

        public Level_1()
        {
            //happend before Form load
            InitializeComponent();

            //call init function
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Call Something From Form2 
            Form2 form2 = new Form2();

            

            //lowercase text from textbox
            con.jawab = textBox1.Text.ToLower();

            //error handling
            if (con.jawab == "")
            {
                MessageBox.Show("Jawaban Tidak Boleh Kosong");
            }

            //game logic
            else
            {
                //true condition
                if (con.jawab == con.soal) //compare soal with jawab
                {
                    MessageBox.Show("Jawaban Benar");
                    score = score + 1;
                    label3.Text = "Jumlah Score " + score;

                    count = count + 1;
                    
                    //proceed to next level
                    if(count < 5)
                    {
                        //call reset component
                        delete();

                        //re initialize
                        init();
                    }

                    //level finnished
                    else
                    {
                        MessageBox.Show("Level Selesai");

                        //closing form level
                        this.Close();
                        form2.Visible = true;
                    }
                    
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

                        //closing form level
                        this.Close();
                        form2.Visible = true;
                    }
                }
            }
        }
    }
}
