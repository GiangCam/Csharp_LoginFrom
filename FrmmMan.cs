using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_LoginFrom
{
    public partial class FrmmMan : Form
    {
        public FrmmMan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         listBox1.Items.Clear();
            int a;
            a = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= a; i++)
            {
                if (a%1 == 0)
                {
                   listBox1.Items.Add(i).ToString();
                }    
            }
        }
    }
}
