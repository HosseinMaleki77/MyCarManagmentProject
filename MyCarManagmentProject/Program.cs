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

            while (true)
            {
                using (frmSignin login = new frmSignin())
                {
                    var loginResult = login.ShowDialog();
                    // اگر کاربر لاگین نکرد یا فرم رو با X بست → خروج از برنامه
                    if (loginResult != DialogResult.OK)
                        break;

                    if (login.IsAdmin)
                    {
                        using (frmAdminMainPage admin = new frmAdminMainPage())
                        {
                            var adminResult = admin.ShowDialog();
                            if (adminResult == DialogResult.Abort)
                                continue; // برگرد به لاگین
                            break;        // غیر از این → خروج
                        }
                    }
                    else
                    {
                        using (frmUserMainPage user = new frmUserMainPage())
                        {
                            if (user.ShowDialog() == DialogResult.Abort)
                                continue; // برگرد به لاگین
                            break;
                        }
                    }
                }
            }
        }





    }


}
    



