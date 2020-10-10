﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            GetAnswer mdAdd = new GetAnswer(Formula.getSum);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(mdAdd(num1,num2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAnswer mdDifference = new GetAnswer(Formula.getDifference);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(mdDifference(num1, num2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetAnswer mdProduct = new GetAnswer(Formula.getProduct);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(mdProduct(num1, num2).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAnswer mdQuotient = new GetAnswer(Formula.getQuotient);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(mdQuotient(num1, num2).ToString());
        }

       
    }
}
