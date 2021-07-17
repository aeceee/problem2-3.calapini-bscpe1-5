using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem2_3.calapini_bscpe1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //declare variables
            int num = 1; 
            int count, sum = 0;

            //read num from textbox
            num = int.Parse(textBox1.Text);

            for (count = 1; count <= num; count ++)
            {
                if (count % 2 != 0)
                {
                    sum = sum + count;
                    listBox1.Items.Add("Odd Integer: " + count + "  Total Sum: " + sum);
                }
            }
        }
    }
}
