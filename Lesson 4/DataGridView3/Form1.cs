using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("adi", "Adı");
            dataGridView1.Columns.Add("soyadi", "Soyadı");
            dataGridView1.Columns.Add("vize", "Vize");
            dataGridView1.Columns.Add("final", "Final");
            dataGridView1.Columns.Add("ortalama", "Ortalama");
            dataGridView1.Columns.Add("sonuc", "Sonuç");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double vize = 0, final = 0, ortalama = 0;

            for(int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                vize = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                final = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                ortalama = (vize * 0.4) + (final * 0.6);
                dataGridView1.Rows[i].Cells[4].Value = ortalama.ToString();

                if(ortalama < Convert.ToDouble(textBox5.Text))
                {
                    dataGridView1.Rows[i].Cells[5].Value = "Kaldı";
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[5].Value = "Geçti";
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                }
            }
        }
    }
}
