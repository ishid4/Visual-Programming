using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomListBox
{
    public partial class Form1 : Form
    {
        int[] x = new int[10];
        List<int> selected = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ras = new Random();
            int uretilen_sayi = 0;
            uretilen_sayi = ras.Next(10, 100);
            for (int i=0; i < 10; i++)
            {
                uretilen_sayi = ras.Next(10, 100);
                listBox1.Items.Add(uretilen_sayi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[selected[i]]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // add new selection:
            foreach (int index in listBox1.SelectedIndices)
                if (!selected.Contains(index)) selected.Add(index);
            // remove unselected items:
            for (int i = selected.Count - 1; i >= 0; i--)
                if (!listBox1.SelectedIndices.Contains(selected[i])) selected.Remove(i);
        }

    }
}