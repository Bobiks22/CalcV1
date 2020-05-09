using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CalcV1
{
    public partial class Calc : Form
    {
        char decimalSeperator;
        public Calc()
        {
            InitializeComponent();
            InitCalc();
        }

        public void InitCalc()
        {
            decimalSeperator = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            tbDisplay.Text = "0";
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
            if (tbDisplay.Text == "0")
            {
                tbDisplay.Text = button.Text;
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
    }
}
