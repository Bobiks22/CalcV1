using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcV1
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
            InitCalc();
        }

        public void InitCalc()
        {
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
            tbDisplay.Text += button.Text;
        }
    }
}
