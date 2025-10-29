using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConditionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 新增按鈕事件處理
        private void btnJudge_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtScore.Text, out double score))
            {
                MessageBox.Show("請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string grade;
            if (score >= 90) grade = "A";
            else if (score >= 80) grade = "B";
            else if (score >= 70) grade = "C";
            else if (score >= 60) grade = "D";
            else grade = "F";

            MessageBox.Show($"成績：{score}，等級：{grade}", "等級判斷", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
