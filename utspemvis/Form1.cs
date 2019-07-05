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
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }      

        private void roundButton3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form2 = new Form2();
            form2.Show();
            //this.Close();
            //oper tampilan form1 ke form2
        }

        private void tombolExit_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Yakin ingin keluar ??", "Question", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

            if (result == DialogResult.No)
            {
              
            }
            // nanti mau dibikin page konfirmasi "anda yakin mau keluar ?"
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            roundButton2.BackgroundImageLayout = ImageLayout.Stretch;
            System.Diagnostics.Process.Start("https://id-id.facebook.com/TebakGambarOfficial/");
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/tebakgambar_id/?hl=en");
        }

        private void roundButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tombolReview_Click(object sender, EventArgs e)
        {

        }
    }
}
