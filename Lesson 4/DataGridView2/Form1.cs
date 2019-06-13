using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(329, 200);
            dataGridView1.Columns.Add("adi", "Adı");
            dataGridView1.Columns.Add("soyadi", "Soyadı");
            dataGridView1.Columns.Add("yas", "Yaş");
            dataGridView1.Columns["adi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Rows.Add("Fatih", "Kazdal", "30");
            dataGridView1.Rows.Add("Eren", "Gunduz", "20");
            dataGridView1.Rows.Add("Fuat", "Keke", "31");
            dataGridView1.Rows.Add("Fatih", "Karı", "69");

            dataGridView2.Size = new Size(329, 200);
            dataGridView2.Columns.Add("adi", "Adı");
            dataGridView2.Columns.Add("soyadi", "Soyadı");
            dataGridView2.Columns.Add("yas", "Yaş");
            dataGridView2.Columns["adi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(), dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(), dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(), dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(), dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString());
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.CurrentCell.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < dataGridView1.Rows.Count - 1 ; i++)
            {
                a += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            textBox1.Text = a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                b += Convert.ToInt32(dataGridView1.SelectedCells[i].Value);
            }
            b /= dataGridView1.SelectedCells.Count;
            textBox2.Text = b.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["adi"], ListSortDirection.Ascending);
        }
    }
}
