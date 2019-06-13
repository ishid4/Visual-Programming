using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("satirnumarasi", "SATIR NUMARASI");
            dataGridView1.Columns.Add("satirverisi", "SATIR VERİSİ");
            dataGridView1.Columns.Add("harf", "HARF SAYISI");
            dataGridView1.Columns.Add("kelime", "KELİME SAYISI");
            dataGridView2.Columns.Add("rakam", "RAKAM SAYISI");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                int digitsCount = 0, wordCount = 1;
                foreach (char c in richTextBox1.Lines[i].ToString())
                {
                    if (Char.IsDigit(c))
                        digitsCount++;
                    if (Char.IsWhiteSpace(c))
                        wordCount++;
                }

                dataGridView1.Rows.Add(i + 1 + ". SATIR", richTextBox1.Lines[i].ToString(), (richTextBox1.Lines[i].Count() - wordCount + 1).ToString(), wordCount.ToString());
                dataGridView2.Rows.Add(digitsCount.ToString());
            }
        }
    }
}
