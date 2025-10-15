using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        // 建構函式：初始化表單元件
        public Form1()
        {
            InitializeComponent();

            // 設定元件的繁體中文 Text 與字型大小
            calculateButton.Text = "計算";
            

            clearButton.Text = "清除";
            

            exitButton.Text = "離開";
            

            
            

            grossPayLabel.Text = "總薪資";
            
        }

        // 當使用者點擊「計算」按鈕時觸發此事件
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 此處可加入計算薪資的邏輯
            const decimal BASE_HOURS = 40m; 
            const decimal OT_MULTIPLIER = 1.5m;

            decimal hoursWorked;
            decimal hourlyPayRate;
            decimal grossPay;

            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    grossPay = (BASE_HOURS * hourlyPayRate) +
                        ((hoursWorked -BASE_HOURS) * hourlyPayRate * OT_MULTIPLIER);
                }
                grossPayLabel.TextAlign = ContentAlignment.MiddleRight;
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 當使用者點擊「清除」按鈕時觸發此事件
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空工時、時薪輸入框及總薪資標籤
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標焦點設回工時輸入框，方便再次輸入
            hoursWorkedTextBox.Focus();
        }

        // 當使用者點擊「離開」按鈕時觸發此事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void grossPayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
