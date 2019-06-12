using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findbiggestnumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] nm = new int[10];
        int biggest = 0, timeCount = 30;

        public static int scoreCount = 0;

        public void randomNumberGenerator()
        {
            number1.Text = "";
            biggest = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                nm[i] = rnd.Next(1, 100);

                number1.Text += nm[i].ToString() + " ";

                if (nm[i] > biggest)
                    biggest = nm[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumberGenerator();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeCount == 0)
            {
                timer1.Stop();
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
            else
            {
                timeCount--;
                timerLabel.Text = timeCount.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);
            if (input == biggest)
                scoreCount += 10;
            else
                scoreCount -= 5;

            randomNumberGenerator();

            score.Text = scoreCount.ToString();
        }
    }
}
