using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
          
            int top = 0;
            int left=0;
            
            //Dizi iki boyutlu olduğundan aşağıdaki GetUpperBound ile 0.boyutun en büyük alabileceği değer anlamına gelir.
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
             //Dizi iki boyutlu olduğundan aşağıdaki GetUpperBound ile 1.boyutun en büyük alabileceği değer anlamına gelir.
            for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);//Controls, buttonun ekrana koyma işleminde kulllanılır.

                }
                top += 50;
                left = 0;

            }
            
        }
    }
}
