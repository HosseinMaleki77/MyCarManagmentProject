using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCarManagmentProject
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

            frmSignin login = new frmSignin();

            if (login.ShowDialog() == DialogResult.OK)   // مثلا بعد از لاگین موفق
            {
                // حالا برنامه با فرم جدید ادامه پیدا می‌کنه
                if (login.IsAdmin)
                {
                    Application.Run(new frmAdminMainPage());
                }
                else
                {
                    Application.Run(new frmUserMainPage());

                }


            }


        }
    }
}

