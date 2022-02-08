using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekooooo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d1, d2, d3, d4, d5, d6, d7, d8, d9, c1, c2;
            int islem, islem2;
            d1 = Convert.ToInt32(textBox1.Text.Substring(0, 1));
            d2 = Convert.ToInt32(textBox1.Text.Substring(1, 1));
            d3 = Convert.ToInt32(textBox1.Text.Substring(2, 1));
            d4 = Convert.ToInt32(textBox1.Text.Substring(3, 1));
            d5 = Convert.ToInt32(textBox1.Text.Substring(4, 1));
            d6 = Convert.ToInt32(textBox1.Text.Substring(5, 1));
            d7 = Convert.ToInt32(textBox1.Text.Substring(6, 1));
            d8 = Convert.ToInt32(textBox1.Text.Substring(7, 1));
            d9 = Convert.ToInt32(textBox1.Text.Substring(8, 1));


            c1 = Convert.ToInt32(textBox1.Text.Substring(9, 1));
            c2 = Convert.ToInt32(textBox1.Text.Substring(10, 1));


            islem = (d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + c1) % 10;
            if (islem == c2) 
            {
                label2.Visible = true ;
            }
            else
            {
            label3.Visible = true ; 
            }
            
        }
        
       
        

         } 
    }

