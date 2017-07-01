using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;

namespace Jadeite.Forms
{
    //public partial class SplashScreenForLoginForm : Telerik.WinControls.UI.RadForm
    public partial class SplashScreenForLoginForm : Infrastructure.RadBaseForm
    {
        public SplashScreenForLoginForm()
        {
            InitializeComponent();

            CreateDefualtUserAdministrator();
        }

        private void SplashScreenForLoginForm_Load(object sender, EventArgs e)
        {
            Waiting();


            //****** Last Timer ******
            tmrCheckTime.Enabled = true;
            //************************
        }

        #region Waiting
        public void Waiting()
        {
            radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsLine;
            this.Controls.Add(radWaitingBar1);
            radWaitingBar1.StartWaiting();

        }
        #endregion

        #region Count Down Time

        private DateTime EventDate = DateTime.Now + new TimeSpan(0, 0, 0, 10);
        private void tmrCheckTime_Tick(object sender, EventArgs e)
        {
            TimeSpan remaining = EventDate - DateTime.Now;
            if (remaining.TotalSeconds < 1)
            {
                tmrCheckTime.Enabled = false;

                this.Hide();

                Forms.LoginForm f =
                    new Forms.LoginForm();

                f.ShowDialog();



            }
            else
            {
                lblSeconds.Text = remaining.Seconds + " :ثانیه";
            }
        }
        #endregion

        #region CreateDefualtUserAdministrator
        public void CreateDefualtUserAdministrator()
        {
            //Models.CreateDefualtUserAdministrator cdua =
            //    new Models.CreateDefualtUserAdministrator();


            // **************************************************
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                int intAdminCount =
                    oDatabaseContext.Users
                    .Where(current => current.IsAdmin)
                    .Count();

                if (intAdminCount == 0)
                {

                    Models.User oAdminUser = new Models.User();

                    oAdminUser.IsAdmin = true;
                    oAdminUser.IsActive = true;

                    oAdminUser.Username = "Saeid";
                    oAdminUser.Password = "Oksaeid";
                    oAdminUser.FullName = "Mr. Saeid Ghadiri";

                    oDatabaseContext.Users.Add(oAdminUser);

                    oDatabaseContext.SaveChanges();

                    //*******************************************************************************************
                    Font myFont = 
                        new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);

                    
                    //MessageBox.Font = myFont;

                    System.Windows.Forms.DialogResult enmResult =
                        MessageBox.Show(
                            text: "آیا کاربر پیش فرض برای مدیرسیستم ساخته شود؟",
                            caption: "سوال",
                            buttons: MessageBoxButtons.YesNo,
                            icon: MessageBoxIcon.Question,
                            defaultButton: MessageBoxDefaultButton.Button3,
                            options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading
                            );

                    if (enmResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        LoginForm login = new LoginForm();
                        login.ShowDialog();
                    }
                    //*******************************************************************************************

                    //*******************************************************************************************
                    //new TelerikMetroBlueTheme();
                    //Telerik.WinControls.RadMessageBox.ThemeName = 
                    //    "TelerikMetroBlue";

                    //Font myFont = 
                    //    new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);

                    //RadMessageBox.Instance.Font = myFont;

                    //System.Windows.Forms.DialogResult enmResult = 
                    //    Telerik.WinControls.RadMessageBox
                    //        .Show(
                    //        this,
                    //        text: "آیا کاربر پیش فرض برای مدیرسیستم ساخته شود؟",
                    //        caption: "سوال :: ایجاد کاربر",
                    //        buttons: MessageBoxButtons.YesNo,
                    //        icon: RadMessageIcon.Question,
                    //        defaultBtn: MessageBoxDefaultButton.Button1,
                    //        rtl: RightToLeft.Yes);

                    //if (enmResult == System.Windows.Forms.DialogResult.Yes)
                    //{
                    //    LoginForm login = new LoginForm();
                    //    login.ShowDialog();
                    //}
                    //*******************************************************************************************
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                return;
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }
            // **************************************************

        }

        #endregion
    }
}
