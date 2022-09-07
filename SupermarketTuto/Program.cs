using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SupermarketTuto
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Splash());
            // new Form1
            // 引用HZH控件,准备使用HZH控件更改程序的UI
            Application.Run(new HZHDGVTest()); 
        }
    }
}
