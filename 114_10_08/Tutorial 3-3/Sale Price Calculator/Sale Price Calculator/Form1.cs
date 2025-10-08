﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「計算特價」按鈕時觸發此事件
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 此處可加入計算特價的程式碼
            decimal originalPrice; // 原價
            decimal discountPercentage; // 折扣百分比
            decimal salePrice; // 特價

            
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            salePrice = originalPrice * (1 - discountPercentage / 100.0m);

            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 當使用者點擊「離開」按鈕時觸發此事件，關閉視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
