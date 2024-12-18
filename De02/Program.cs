using System;
using System.Windows.Forms;

namespace De02
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSanpham());  // Đảm bảo tên class là frmSanpham (chữ f thường)
        }
    }
}
