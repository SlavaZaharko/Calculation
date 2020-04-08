using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc.Calc_Int;

namespace Calc
{
    public partial class Form1 : Form
    {
        float tmp1, tmp2;
        ICalc Calc;
        bool znak=true;


        public Form1()
        {
            InitializeComponent();
        }

        public void AddToTextboxMain(string a)
        {
            textBoxMain.Text += a;
        }

        private void buttonNumber1_Click_1(object sender, EventArgs e)
        {
            AddToTextboxMain("1");
            textBoxAdd.Text = textBoxAdd.Text + 1;
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            AddToTextboxMain("2");
            textBoxAdd.Text = textBoxAdd.Text + 2;
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            AddToTextboxMain("3");
            textBoxAdd.Text = textBoxAdd.Text + 3;
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            AddToTextboxMain("4");
            textBoxAdd.Text = textBoxAdd.Text + 4;
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            AddToTextboxMain("5");
            textBoxAdd.Text = textBoxAdd.Text + 5;
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            AddToTextboxMain("6");
            textBoxAdd.Text = textBoxAdd.Text + 6;
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            AddToTextboxMain("7");
            textBoxAdd.Text = textBoxAdd.Text + 7;
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            AddToTextboxMain("8");
            textBoxAdd.Text = textBoxAdd.Text + 8;
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            AddToTextboxMain("9");
            textBoxAdd.Text = textBoxAdd.Text + 9;
        }

        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            AddToTextboxMain("0");
            textBoxAdd.Text = textBoxAdd.Text + 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxMain.Text != "")
            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, float.Parse(textBoxMain.Text));
                }
                else 
                { 
                    tmp1 = float.Parse(textBoxMain.Text); 
                }
                textBoxMain.Text = " ";
                textBoxAdd.Text = textBoxAdd.Text + "+";
                Calc = new Adder();
                znak = true;
            }
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (textBoxMain.Text != "")
            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, float.Parse(textBoxMain.Text));
                }
                else
                {
                    tmp1 = float.Parse(textBoxMain.Text);
                }
                textBoxMain.Text = " ";
                textBoxAdd.Text = textBoxAdd.Text + "-";
                Calc = new Subtraction();
                znak = true;
            }

        }

        private void buttonMultiplicat_Click(object sender, EventArgs e)
        {
            if (textBoxMain.Text != "")
            {
                if (Calc != null)
                {
                    tmp1 = Calc.DoMath(tmp1, float.Parse(textBoxMain.Text));
                }
                else
                {
                    tmp1 = float.Parse(textBoxMain.Text);
                }
                textBoxMain.Text = " ";
                textBoxAdd.Text = textBoxAdd.Text + "*";
                Calc = new Multiplication();
                znak = true;
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (textBoxMain.Text != "")
            {

                if (textBoxMain.Text != "")
                {
                    if (Calc != null)
                    {
                        tmp1 = Calc.DoMath(tmp1, float.Parse(textBoxMain.Text));
                    }
                    else
                    {
                        tmp1 = float.Parse(textBoxMain.Text);
                    }
                }
                textBoxMain.Text = " ";
                textBoxAdd.Text = textBoxAdd.Text + "/";
                Calc = new Division();
                znak = true;
            }
        }

        private void buttonSolution_Click(object sender, EventArgs e)
        {
            tmp2= float.Parse(textBoxMain.Text);
            textBoxMain.Text= Calc.DoMath(tmp1, tmp2)+"";
            textBoxAdd.Text = textBoxAdd.Text + "=";

        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            AddToTextboxMain(",");
            textBoxAdd.Text = textBoxAdd.Text + ",";
        }

        private void buttonСhangeOfSing_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBoxMain.Text = "-" + textBoxMain.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBoxMain.Text = textBoxMain.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmp1 = 0;
            tmp2 = 0;
            Calc = null;
            textBoxMain.Text = "";
            textBoxAdd.Text = "";
        }
    }
}
