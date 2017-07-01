using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Themes;
using Telerik.WinControls.WindowAnimation;
using Telerik.WinControls.Drawing;



namespace Jadeite.Forms
{
    //public partial class LoginForm : RadForm
    public partial class LoginForm : Infrastructure.RadBaseForm
    {
        public LoginForm() : base()
        {
            InitializeComponent();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        
         public void btnTheme()
         {
            Telerik.WinControls.UI.RadButton btn = new RadButton();
            new TelerikMetroTheme();
            btn.ThemeName = "TelerikMetro";
            //this.btn.ButtonElement.EnableRippleAnimation = true;
            //this.btn.ButtonElement.RippleAnimationColor = Color.FromArgb(55, 144, 238, 144);
         }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Hide();

            //MainForm Main = new MainForm();

            //Models.Alert alert = new Models.Alert();
            //alert.AlertLogin();

            //Main.Show();


            // **************************************************
            if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) ||
                (string.IsNullOrWhiteSpace(passwordTextBox.Text)))
            {
                //usernameTextBox.Text =
                //	usernameTextBox.Text.Trim();

                //passwordTextBox.Text =
                //	passwordTextBox.Text.Trim();

                usernameTextBox.Text =
                    usernameTextBox.Text.Replace(" ", string.Empty);

                passwordTextBox.Text =
                    passwordTextBox.Text.Replace(" ", string.Empty);
                //-------------------------------------------------------------------------
                new TelerikMetroBlueTheme();
                Telerik.WinControls.RadMessageBox.ThemeName = "TelerikMetroBlue";

                Font myFont = new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);
                RadMessageBox.Instance.Font = myFont;

                Telerik.WinControls.RadMessageBox
                    .Show(this,
                    text: "نام کاربری و یا گذر واژه اشتباه است!",
                    caption: "خطای ورود به سامانه",
                    buttons: MessageBoxButtons.OK,
                    icon: RadMessageIcon.Error,
                    defaultBtn: MessageBoxDefaultButton.Button2,
                    rtl: RightToLeft.Yes,
                    detailsText: "دقت نمایید!! بعد از تکرار 5 بار ورود اشتباه اطلاعات به سیستم، به صورت خودکار تا 1 ساعت سیستم غیر فعال می شود.");
                //-------------------------------------------------------------------------

                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Focus();
                }

                return;
            }
            // **************************************************

            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                    oDatabaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    //System.Windows.Forms.MessageBox
                    //	.Show("Username is not correct!");

                    //System.Windows.Forms.MessageBox
                    //    .Show("Username and/or Password is not correct!");

                    //-------------------------------------------------------------------------
                    new TelerikMetroBlueTheme();
                    Telerik.WinControls.RadMessageBox.ThemeName = "TelerikMetroBlue";

                    Font myFont = new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);
                    RadMessageBox.Instance.Font = myFont;

                    Telerik.WinControls.RadMessageBox
                        .Show(this,
                        text: "نام کاربری و یا گذر واژه اشتباه است!",
                        caption: "خطای ورود به سامانه",
                        buttons: MessageBoxButtons.OK,
                        icon: RadMessageIcon.Error,
                        defaultBtn: MessageBoxDefaultButton.Button2,
                        rtl: RightToLeft.Yes,
                        detailsText: "دقت نمایید!! بعد از تکرار 5 بار ورود اشتباه اطلاعات به سیستم، به صورت خودکار تا 1 ساعت سیستم غیر فعال می شود.");
                    //-------------------------------------------------------------------------

                    usernameTextBox.Focus();

                    return;
                }

                if (string.Compare(oUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
                {
                    //System.Windows.Forms.MessageBox
                    //	.Show("Password is not correct!");

                    //System.Windows.Forms.MessageBox
                    //    .Show("Username and/or Password is not correct!");

                    //-------------------------------------------------------------------------
                    new TelerikMetroBlueTheme();
                    Telerik.WinControls.RadMessageBox.ThemeName = "TelerikMetroBlue";

                    Font myFont = new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);
                    RadMessageBox.Instance.Font = myFont;

                    Telerik.WinControls.RadMessageBox
                        .Show(this,
                        text: "نام کاربری و یا گذر واژه اشتباه است!",
                        caption: "خطای ورود به سامانه",
                        buttons: MessageBoxButtons.OK,
                        icon: RadMessageIcon.Error,
                        defaultBtn: MessageBoxDefaultButton.Button2,
                        rtl: RightToLeft.Yes,
                        detailsText: "دقت نمایید!! بعد از تکرار 5 بار ورود اشتباه اطلاعات به سیستم، به صورت خودکار تا 1 ساعت سیستم غیر فعال می شود.");
                    //-------------------------------------------------------------------------

                    usernameTextBox.Focus();

                    return;
                }

                if (oUser.IsActive == false)
                {
                    //System.Windows.Forms.MessageBox
                    //    .Show("You can not login to this application! Please contact support.");

                    //-------------------------------------------------------------------------
                    new TelerikMetroBlueTheme();
                    Telerik.WinControls.RadMessageBox.ThemeName = "TelerikMetroBlue";

                    Font myFont = new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);
                    RadMessageBox.Instance.Font = myFont;

                    Telerik.WinControls.RadMessageBox
                        .Show(this,
                        text: "شما نمی توانید به سامانه وارد شوید! لطفا با پشتیبانی سیستم تماس حاص فرمایید.",
                        caption: "خطا :: تماس با پشتیبانی",
                        buttons: MessageBoxButtons.OK,
                        icon: RadMessageIcon.Error,
                        defaultBtn: MessageBoxDefaultButton.Button2,
                        rtl: RightToLeft.Yes
                        /*detailsText: ""*/);
                    //-------------------------------------------------------------------------

                    usernameTextBox.Focus();

                    return;
                }

                Infrastructure.Utility.AuthenticatedUser = oUser;


                Hide();

                MainForm mainForm = new MainForm();

                Models.Alert alert = new Models.Alert();
                alert.AlertLogin();

                mainForm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Hide();

            Forms.RegisterForm registerForm = new Forms.RegisterForm();

            registerForm.ShowDialog();
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;

            usernameTextBox.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Models.AplicationExit exit = 
            //    new Models.AplicationExit();

            //exit.Exit();

            //------------------------------------------------------------
            new TelerikMetroBlueTheme();
            Telerik.WinControls.RadMessageBox.ThemeName =
                "TelerikMetroBlue";

            Font myFont =
                new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);

            RadMessageBox.Instance.Font = myFont;

            System.Windows.Forms.DialogResult enmResult =
                Telerik.WinControls.RadMessageBox
                    .Show(
                    this,
                    text: "آیا به خروج از برنامه اطمینان دارید؟",
                    caption: "سوال :: خروج",
                    buttons: MessageBoxButtons.YesNo,
                    icon: RadMessageIcon.Question,
                    defaultBtn: MessageBoxDefaultButton.Button3,
                    rtl: RightToLeft.Yes);

            if (enmResult == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            //------------------------------------------------------------
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }
    }
}
