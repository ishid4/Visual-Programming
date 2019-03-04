using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxteksayicikarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void yap_Click(object sender, EventArgs e)
        {
            int sayi = 0;

            for (int i = 0; i < 10; i++)
            {
                sayi = rnd.Next(int.Parse(giris.Text), int.Parse(cikis.Text));
                listBox1.Items.Add(sayi);
            }
        }

        private void yap2_Click(object sender, EventArgs e)
        {
            int sayi = 0, sayi1 = 0, sayi2 = 0;
            if(Convert.ToInt32(listBox1.SelectedItems[0]) > Convert.ToInt32(listBox1.SelectedItems[1]))
            {
                sayi1 = Convert.ToInt32(listBox1.SelectedItems[1]);
                sayi2 = Convert.ToInt32(listBox1.SelectedItems[0]);
            }
            else
            {
                sayi1 = Convert.ToInt32(listBox1.SelectedItems[0]);
                sayi2 = Convert.ToInt32(listBox1.SelectedItems[1]);
            }
            for(int i = 0; i < 5; i++)
            {
                sayi = rnd.Next(sayi1, sayi2);
                listBox2.Items.Add(sayi);
            }
        }

        private void yap3_Click(object sender, EventArgs e)
        {
            int adet = listBox2.Items.Count;

            for(int i = 0; i < adet; i++)
            {
                if(int.Parse(listBox2.Items[i].ToString()) % 2 == 1)
                {
                    listBox2.Items.RemoveAt(i);
                    adet--;
                    i--;
                }
            }

        }

        private void yap4_Click(object sender, EventArgs e)
        {
            int adet = listBox2.Items.Count, toplam = 0;

            for (int i = 0; i < adet; i++)
            {
                toplam += Convert.ToInt32(listBox2.Items[i]);
            }
            sonuc.Text = toplam.ToString();
        }
    }
}
