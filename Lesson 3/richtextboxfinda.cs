using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richtextboxfinda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int Count = 0;
            char[] a = textBox1.Text.ToCharArray(0, textBox1.Text.Count());
            
            for (int i = 1; i <= richTextBox1.Lines.Count(); i++)
            {
                listBox1.Items.Add(i + ". satır");
                foreach (char c in richTextBox1.Lines[i-1].ToString())
                    if (c == a[0])
                        Count++;
                listBox2.Items.Add(Count.ToString() + " adet " + a[0] + " harfi var.");
                Count =  0;
            }
        }
    }
}
