using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            richTextBox1.Text = a + "\n" + richTextBox1.Text + "\n" + a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0; i <= richTextBox1.Lines.Count(); i++)
            {
                richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(i), richTextBox1.Lines[i].Count());
                richTextBox1.SelectionColor = Color.Yellow;
                richTextBox1.SelectionBackColor = Color.Black;
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                comboBox1.Items.Add(i+1 + ". satirda " + richTextBox1.Lines[i].Count() + " Karakter");
            }
        }
    }
}
