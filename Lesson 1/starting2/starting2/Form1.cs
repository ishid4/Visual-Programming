using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace starting2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yap_Click(object sender, EventArgs e)
        {
            int[] sayi = new int[10];
            int baslangic = 0, bitis = 0, gecici;
            baslangic = Convert.ToInt32(giris.Text);
            bitis = Convert.ToInt32(cikis.Text);

            Random rastgele = new Random();

            for (int i = 0; i < 10; i++)
            {
                sayi[i] = rastgele.Next(baslangic, bitis);
            }

            Array.Sort(sayi);
            Array.Reverse(sayi);

            /*for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (sayi[j] < sayi[i])
                    {
                        gecici = sayi[i];
                        sayi[i] = sayi[j];
                        sayi[j] = gecici;
                    }
                }
            }*/

            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(sayi[i]);
            }
        }
    }
}
