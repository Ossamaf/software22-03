using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        int aantalworpen1 = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totaalogen = 0;


            for (int i = 0; i < aantalworpen1; i++)
            {
                //eyesamountupdown= numericupdown-ogen
                int randomNumber = random.Next(1, Convert.ToInt32(EyesAmountupdown.Value) + 1);

                //exportworbox=listbox
                ExportWorpBox.Items.Add(randomNumber);

                totaalListBox();

            }
            

            }


        private void totaalListBox()
        {
            int x = 0;

            //het zijn allemaal int
            
            foreach (int item in ExportWorpBox.Items)
            {
                x += item;
            }
            totaantal.Text = x.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



    
    private void worpen_Click(object sender, EventArgs e)
        {

        }

    }// 
}
