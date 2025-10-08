﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算平均的邏輯可根據需求補上
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
            double test1, test2, test3:

            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                double average = (test1 + test2 + test3) / 3;

                averageLabel.Text = average.ToString("n2");

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "例外發生!");

                    test1TextBox.Text = "";
                    test2TextBox.Text = "";
                    test3TextBox.Text = "";
                    averageLabel.Text = "";

                    test1TextBox.Focus();
            }
            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = ""; 
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            test1TextBox.Focus();
        }
    }
}
