using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listcheckbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                textBox1.Text = checkBox1.Text;
            if (checkBox2.Checked == false)
                textBox1.Text = checkBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                checkedListBox2.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
            textBox1.Text = comboBox1.Text;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = checkedListBox1.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }
    }
}
