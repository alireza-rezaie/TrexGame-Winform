using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daynacor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            if (pictureBox4.Bottom > pictureBox1.Top && pictureBox4.Top < pictureBox1.Bottom && (pictureBox4.Left < pictureBox1.Right) && (pictureBox4.Right > pictureBox1.Left))

            {
                timer1.Enabled = false;
                timer5.Enabled = false;
                timer4.Enabled = false;
                MessageBox.Show("boom");
                Application.Restart();


            }
            if (timer1.Enabled == true&&timer1.Interval!=1)
            {
                pictureBox2.Left -= 10;
                pictureBox3.Left -= 10;
                pictureBox4.Left -= 10;
            }else {
                pictureBox2.Left -= 20;
                pictureBox3.Left -= 20;
                pictureBox4.Left -= 20;
                timer5.Interval = 100;
                timer4.Interval = 100;
            }


            if(pictureBox2.Right<0)
            {
                pictureBox2.Left = (this.Width - 15);
                pictureBox4.Left= (this.Width);

                if (timer1.Interval >1)
                    timer1.Interval -= 7;
      





            }
            if (pictureBox3.Right < 0)
            {
                pictureBox3.Left = (this.Width - 15);

            }
            
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        byte h, m, s;

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 100;
            timer3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                timer1.Enabled = true;
                timer2.Enabled = true;
            timer5.Enabled = true;

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer5.Enabled = false;
            timer4.Enabled = false;
            timer2.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void peropertisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
      
        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
   
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top == 292)
            {
                pictureBox1.ImageLocation = "daynasor/1.png";
                timer4.Enabled = true;
                timer5.Enabled = false;

            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top == 292)
            {
                pictureBox1.ImageLocation = "daynasor/2.png";
                timer5.Enabled = true;
                timer4.Enabled = false;

            }
        }


        bool b = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 60)
            {
                s = 0;
                m++;
            }
            if (m == 60)
            {
                h++;
                m = 0;

            }
            label1.Text = string.Format("{0:00}:{1:00}:{2:00}", h, m, s);
         
            if (s==30&&b==true)
            {
                this.BackColor = Color.Gray;
                b = false;
            }
      

            
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        //292baraye zamani ke dobar dokme zade mishavad balatar naravad
            if(e.KeyCode==Keys.Space&&pictureBox1.Top==292) {
                pictureBox1.Top -= 100;
                timer3.Enabled = true;
             
                
      
            }

        }
             private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
