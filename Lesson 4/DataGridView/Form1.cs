using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(400, 200);
            dataGridView1.Columns.Add("adi", "Adı");
            dataGridView1.Columns.Add("soyadi", "Soyadı");
            dataGridView1.Columns.Add("tel", "TEL");
            dataGridView1.Columns["adi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Rows.Add("Fatih", "Kazdal", "123456");
            dataGridView1.Rows.Add("Eren", "Gunduz", "3214");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(Convert.ToInt32(textBox1.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                str.Append(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value.ToString());
                //dataGridView1.Rows[0];
                str.Append(" ");
            }
            MessageBox.Show(str.ToString());
        }
    }
}
