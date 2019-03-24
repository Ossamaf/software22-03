using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            int getalinvoer;
            
            //waarde is 0
             string som="";
            //converteer naar int omdat textbox string is
            getalinvoer = Convert.ToInt32(textBox1.Text);

            int result=0;
            //eerste getal is 1
            // je rekent door tot het ingevoerde getal door i++
            for (int i = 1; i <= getalinvoer; i++)
            {
               // convert i to string omdat het int is
               //som structuur
               som = som+ " " + Convert.ToString(i)+"+";
                //i is het gene wat telkens optelt
                //a.k.a het antwoord
                result = result + i;

                //hij stopt pas wanneer de som heeft gerekend tot het ingevoerde getal (conditie)
                if (getalinvoer== i)
                {
                    //laat som en antwoord zien 
                    MessageBox.Show(som + "=" + Convert.ToString(result));

                }
          

                


            }



        }
    }
}
