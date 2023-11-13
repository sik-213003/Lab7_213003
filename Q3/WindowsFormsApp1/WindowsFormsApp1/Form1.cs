using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Number: \t\t Square\n");
            for (int i = 1; i <= 10; i++)
            {
                int square = i * i;
                richTextBox1.AppendText($"{i}: \t\t  {square}\n");
            }
        }
    }
}
