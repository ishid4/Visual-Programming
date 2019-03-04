using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxrandomkarakter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Random rnd = new Random();

            for(int i = 0; i < 5; i++)
            {
                string word = "";

                for (int j = 0; j < rnd.Next(2, 16); j++)
                {
                    int letter_num = rnd.Next(0, letters.Length - 1);
                    word += letters[letter_num];
                }

                listBox1.Items.Add(word);
                listBox2.Items.Add(word.Length);

            }
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            for(int i = 0; i < 5; i++)
            {
                listBox3.Items.Add(listBox2.Items[i]+""+ listBox1.Items[i]);
            }
        }
    }
}
