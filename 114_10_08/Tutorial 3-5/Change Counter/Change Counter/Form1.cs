using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS = 5.0m;
        const decimal TEN_CENTS = 10.0m;
        const decimal TWENTY_FIVE_CENTS = 25.0m;
        const decimal FIFTY_CENTS = 50.0m;



        private decimal total;

        public Form1()
        {
            InitializeComponent();
        }

        // 新增：硬幣點擊事件與 Exit 按鈕事件
      
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //decimal total = 0;
            total += 5;
            totalLabel.Text = total.ToString();
        }
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            //decimal total = 0;
            total  += 10;
            totalLabel.Text = total.ToString();
        }
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //decimal total = 0;
            total += 25;
            totalLabel.Text = total.ToString();
        }
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            //decimal total = 0;
            total += 50;
            totalLabel.Text = total.ToString();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
