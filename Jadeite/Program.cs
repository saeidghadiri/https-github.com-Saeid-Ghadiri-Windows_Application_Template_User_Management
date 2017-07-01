using System;
using System.Linq;
using System.Windows.Forms;

namespace Jadeite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // **************************************************
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            // **************************************************

            // **************************************************
            Forms.SplashScreenForLoginForm startupForm = new Forms.SplashScreenForLoginForm();
            //Forms.LoginForm startupForm = new Forms.LoginForm();
            //Forms.RegisterForm startupForm = new Forms.RegisterForm();
            //Forms.ErrorHandeling startupForm = new Forms.ErrorHandeling();


            System.Windows.Forms.Application.Run(startupForm);

            if (startupForm != null)
            {
                if (startupForm.IsDisposed == false)
                {
                    startupForm.Dispose();
                }

                startupForm = null;
            }
            // **************************************************
        }
    }
}