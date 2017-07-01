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


namespace Jadeite.Forms
{
    //public partial class RegisterForm : RadForm 
    public partial class RegisterForm : Infrastructure.RadBaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
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

                //System.Windows.Forms.MessageBox.Show("Username and Password is requied!");

                //-------------------------------------------------------------------------
                new TelerikMetroBlueTheme();
                Telerik.WinControls.RadMessageBox.ThemeName = "TelerikMetroBlue";

                Font myFont = new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);
                RadMessageBox.Instance.Font = myFont;

                Telerik.WinControls.RadMessageBox
                    .Show(this,
                    text: "کاربر محترم:: لطفا نام کاربری و گذرواژه را وارد نمایید.",
                    caption: "اطلاع رسانی",
                    buttons: MessageBoxButtons.OK,
                    icon: RadMessageIcon.Error,
                    defaultBtn: MessageBoxDefaultButton.Button2,
                    rtl: RightToLeft.Yes);
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

            string strErrorMessages = string.Empty;

            if (usernameTextBox.Text.Length < 6)
            {
                strErrorMessages =
                    "کاربر محترم:: حداقل تعداد کارکترهای نام کاربری باید 5 حرف باشد.";
            }

            if (passwordTextBox.Text.Length < 8)
            {
                if (strErrorMessages != string.Empty)
                {
                    strErrorMessages +=
                        System.Environment.NewLine;
                }

                strErrorMessages +=
                    "کاربر محترم:: حداقل تعداد کارکترهای گذرواژه باید 6 حرف باشد. ";
            }

            // اگر خطایی وجود داشت
            if (strErrorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(strErrorMessages);

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

                if (oUser != null)
                {
                    System.Windows.Forms.MessageBox.Show
                        ("کاربر محترم:: نام کاربری که درج نموده اید در سامانه وجود دارد! لطفا نام دیگری را انتخاب نمایید.");

                    usernameTextBox.Focus();

                    return;
                }

                oUser = new Models.User();

                
                oUser.FullName = fullNameTextBox.Text;
                oUser.Password = passwordTextBox.Text;
                oUser.Username = usernameTextBox.Text;

                //اگر بخواهیم کاربر جدید که ایجاد میشود فعال نباشد این آیتم باید false باشد.
                oUser.IsActive = true;

                oDatabaseContext.Users.Add(oUser);

                oDatabaseContext.SaveChanges();

                //System.Windows.Forms.MessageBox.Show("Registration Done!");

                //-------------------------------------------------------------------------
                new TelerikMetroBlueTheme();
                Telerik.WinControls.RadMessageBox.ThemeName = "TelerikMetroBlue";

                Font myFont = new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);
                RadMessageBox.Instance.Font = myFont;

                Telerik.WinControls.RadMessageBox
                    .Show(this,
                    text: "کاربر محترم:: ثبت نام کاربری شما با موفقیت انجام شد.",
                    caption: "اطلاع رسانی",
                    buttons: MessageBoxButtons.OK,
                    icon: RadMessageIcon.Error,
                    defaultBtn: MessageBoxDefaultButton.Button2,
                    rtl: RightToLeft.Yes);
                //-------------------------------------------------------------------------

                fullNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                usernameTextBox.Text = string.Empty;

                usernameTextBox.Focus();
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
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            fullNameTextBox.Text = string.Empty;

            usernameTextBox.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //this.Hide();

            //Forms.LoginForm f = new Forms.LoginForm();

            //f.ShowDialog();

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
    }
}
