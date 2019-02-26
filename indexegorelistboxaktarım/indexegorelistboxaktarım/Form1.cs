using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indexegorelistboxaktarım
{
	public partial class Form1 : Form
	{
		int[] inx = new int[200];
		int i = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			for (int i = 0; i < 10; i++)
			{
				int randomS = random.Next(10, 100);
				listBox1.Items.Add(randomS);
			}
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
            for (int i = 0; i < listBox1.SelectedIndices.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            //https://docs.microsoft.com/tr-tr/dotnet/api/system.windows.forms.listbox.objectcollection.add?view=netframework-4.7.2
            MessageBox.Show(listBox1.SelectedItems[0].ToString());
        }
    }
}
