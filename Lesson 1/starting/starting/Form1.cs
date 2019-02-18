using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace starting
{
    public partial class Form1 : Form
    {
        int main, events;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bclear_Click(object sender, EventArgs e)
        {
            input.Text = "";
            events = 0;
            main = 0;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            input.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            input.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            input.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            input.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            input.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            input.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            input.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            input.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            input.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            input.Text += "0";
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            input.Text += ",";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            if(events == 1)
            {
                input.Text = Convert.ToString(main + Convert.ToInt32(input.Text));
            }
            else if(events == 2)
            {
                input.Text = Convert.ToString(main - Convert.ToInt32(input.Text));
            }
            else if (events == 3)
            {
                input.Text = Convert.ToString(main * Convert.ToInt32(input.Text));
            }
            else if (events == 4)
            {
                input.Text = Convert.ToString(main / Convert.ToInt32(input.Text));
            }
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
                main = Convert.ToInt32(input.Text);
            
            input.Text = "";
            events = 1;
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
                main = Convert.ToInt32(input.Text);
            input.Text = "";
            events = 2;
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
                main = Convert.ToInt32(input.Text);
            input.Text = "";
            events = 3;
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
                main = Convert.ToInt32(input.Text);
            input.Text = "";
            events = 4;
        }
    }
}
