using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Test_Average
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用視覺化樣式，使應用程式的控制項外觀符合作業系統主題
            Application.EnableVisualStyles();
            // 設定文字呈現方式為預設值，確保文字顯示正常
            Application.SetCompatibleTextRenderingDefault(false);
            // 執行主表單（Form1）
            Application.Run(new Form1());
        }
    }
}
