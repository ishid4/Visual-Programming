using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richtextboxfindandcolorit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CheckKeyword(textBox1.Text);
        }

        private void CheckKeyword(string word)
        {
            if (this.richTextBox1.Text.Contains(word))
            {
                int index = -1;

                while ((index = this.richTextBox1.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.richTextBox1.Select((index), word.Length);
                    this.richTextBox1.SelectionColor = Color.White;
                    this.richTextBox1.SelectionBackColor = Color.Red;
                }
            }
        }
    }
}
