﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int fact = 1;
            int number = int.Parse(textBox1.Text);

            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            textBox2.Text = fact.ToString();

        }
    }
}
