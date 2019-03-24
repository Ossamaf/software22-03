using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobbelsteen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //genereer random getallen dobbelsteen
        Random dobbelsteen1 = new Random();



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // in het begin alle dobbelvlakken niet laten zien
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            // getallen van dobbelsteen zijn 1 tot en met 6
            int dobbelgetal = dobbelsteen1.Next(1, 7);


            //als dobbelgetal 1 is dan show picturebox van dobbelgetal1
            if (dobbelgetal == 1)
            {
                pictureBox1.Visible = true;

            }
         
            else if (dobbelgetal == 2)
            {
                pictureBox2.Visible = true;
            }

            else if (dobbelgetal == 3)
            {
                pictureBox3.Visible = true;
            }

            else if (dobbelgetal == 4)
            {
                pictureBox4.Visible = true;

            }
            else if (dobbelgetal == 5)
            {
                pictureBox5.Visible = true;

            }
            else if (dobbelgetal == 6)
            {
                pictureBox6.Visible = true;

            }





        }
    }
}
