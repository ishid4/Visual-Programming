using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string words;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(listBox1.Items.Count.ToString());
            for (int i = 0; i < a; i++)
            {
                foreach (char c in listBox1.Items[i].ToString())
                {
                    listBox2.Items.Insert(i, listBox1.Items[i] + "" + c);

                }
            }
        }
    }
}
