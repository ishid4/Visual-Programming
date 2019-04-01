using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richtextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Lines.Count().ToString();
            richTextBox1.SelectionBackColor = Color.Red;
            richTextBox1.SelectionColor = Color.Yellow;
            richTextBox1.AppendText("\n");
            richTextBox1.Text += "\n" + textBox1.Text;
            richTextBox1.Font = new Font("Consolas", 18f, FontStyle.Bold);

            textBox1.Text = richTextBox1.Find("fatih").ToString();
            textBox1.Text = richTextBox1.Size.Height.ToString();
            textBox1.Text = richTextBox1.Text;
            textBox1.Text = richTextBox1.SelectionLength.ToString();
            textBox1.Text = richTextBox1.SelectedText.Count().ToString();
            textBox1.Text = richTextBox1.SelectedText.Insert(3, "fatih");
            textBox1.Text = richTextBox1.SelectedText.IndexOf('a').ToString();
            textBox1.Text = richTextBox1.SelectedText.Replace('q', 'e');
            textBox1.Text = richTextBox1.SelectedText.Remove(4);
            textBox1.Text = richTextBox1.SelectedText.Remove(4, 3);

            richTextBox1.Select(0, richTextBox1.Lines[0].Length);
            richTextBox1.SelectionColor = Color.Yellow;

            fontDialog1.ShowDialog();
            colorDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = colorDialog1.Color;
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1.FileName);
        }
    }
}
