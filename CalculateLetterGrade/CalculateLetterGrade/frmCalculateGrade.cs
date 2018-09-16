using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e) 
        {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);  // Converts txtNumberGrade input to decimal value

            string letterGrade = " ";  // names letterGrade value as string and default text if no numberGrade input as blank space

            if (numberGrade >= 88) // if statement causes letterGrade to display A for any value of 88 or more
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87) // if statement causes letterGrade to display B for any between and including 87 to 80
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79) // if statement causes letterGrade to display C for any value between and including 68 to 79
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67) // if statement causes letterGrade to display D for any value between and including 60 and 67
            {
                letterGrade = "D";
            }
            else // if statement causes lettterGrade to display F for any value below 60
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade; // assigns the value letterGrade from above else/if statements to the Letter Grade text box

            txtNumberGrade.Focus(); // returns cusor to Number Grade text box after calculation complete

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // event handler for when Exit button is chosen, it closes them form
        }
    }
}
