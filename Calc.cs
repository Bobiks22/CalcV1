using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CalcV1
{
    public partial class Calc : Form
    {
        char decimalSeperator;
        double numOne = 0;
        double numTwo = 0;
        string operation;
        int usedLenght;
        bool isResult = false;

        bool scientificMode = false;
        const int widthSmall = 390;
        const int widthLarge = 600;

        public Calc()
        {
            InitializeComponent();
            InitCalc();
        }

        public void InitCalc()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            decimalSeperator = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            tbDisplay.Text = "0";
            this.Width = widthSmall;

            string buttonName = null;
            Button button = null; 
            for (int i = 0; i <= 9; i++)
            {
                buttonName = "button" + i;
                button = (Button)this.Controls[buttonName];
                button.Text = i.ToString();
            }
        }

        private void NumpadClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (tbDisplay.Text == "0" || isResult)
            {
                tbDisplay.Text = button.Text;
                isResult = false;
            }
            else
            {
                tbDisplay.Text += button.Text;
            }
            
        }

        private void bttDec_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Text.Contains(decimalSeperator))
            {
                if (!tbDisplay.Text.Substring(tbDisplay.Text.Length - 1).All(Char.IsDigit))
                {
                    tbDisplay.Text += ("0" + decimalSeperator);
                    return;
                }

                tbDisplay.Text += decimalSeperator;
            }

        }

        private void bttBackspace_Click(object sender, EventArgs e)
        {
            string s = tbDisplay.Text;
            char[] c = s.ToCharArray(0, s.Length);

            if (s.Length > 1)
            {
                if((s.Contains("-")) && (s.Length == 2))
                {
                    s = "0";
                    goto SkipToEnd;
                }

                if (c[c.Length - 2] == decimalSeperator)
                {
                    s = s.Substring(0, (s.Length - 2));
                    goto SkipToEnd;
                }
                s = s.Substring(0, (s.Length - 1));
            }
            else
            {
                s = "0";
            }

            SkipToEnd:
            tbDisplay.Text = s;
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(tbDisplay.Text);
                number *= -1;
                tbDisplay.Text = Convert.ToString(number);
            }
            catch
            {

            }
        }

        private void bttResult_Click(object sender, EventArgs e)
        {
            if (operation == string.Empty)
            {
                MessageBox.Show("ERROR 47, no opereation is used");
                return;
            }

            string s = tbDisplay.Text;

            if (usedLenght == s.Length)
            {
                tbDisplay.Text = tbDisplay.Text.Substring(0, tbDisplay.Text.Length - 1);
                operation = String.Empty;
                numOne = 0;
                usedLenght = 0;
                return;
            }

            numTwo = Convert.ToDouble(s.Substring(usedLenght, s.Length - usedLenght));
            double result = 0;

            if (operation == "+")
            {
                result = numOne + numTwo;
            } 
            else if (operation == "-")
            {
                result = numOne - numTwo;
            }
            else if (operation == "x")
            {
                result = numOne * numTwo;
            }
            else if (operation == "/")
            {
                result = numOne / numTwo;
            }
            else if (operation == "^")
            {
                result = Math.Pow(numOne, numTwo);
            }

            operation = string.Empty;
            tbDisplay.Text = result.ToString();
            isResult = true;

        }

       private void Operation_Click(object sender, EventArgs e)
        {
            try
            {
                numOne = Convert.ToDouble(tbDisplay.Text);
                operation = ((Button)sender).Text;

                if (operation == "Sqrt")
                {
                    tbDisplay.Text = Math.Sqrt(numOne).ToString();
                    return;
                }
                tbDisplay.Text += operation;
                usedLenght = tbDisplay.Text.Length;
            }
            catch
            {

            }
        }

        private void tbDisplay_Click(object sender, EventArgs e)
        {
            if (scientificMode)
            {
                this.Width = widthSmall;
            }
            else
            {
                this.Width = widthLarge;
            }
            scientificMode = !scientificMode;

        }
    }
}
