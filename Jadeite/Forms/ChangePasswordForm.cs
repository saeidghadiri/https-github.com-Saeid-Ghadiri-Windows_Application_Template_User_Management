using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Jadeite.Forms
{
    //public partial class ChangePasswordForm : Telerik.WinControls.UI.RadForm
    public partial class ChangePasswordForm : Infrastructure.RadBaseForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            string strErrorMessages = string.Empty;

            if (string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
            {
                strErrorMessages =
                    "کاربر محترم:: لطفا گذرواژه فعلی را وارد نمایید.";
            }
            else
            {
                if (oldPasswordTextBox.Text.Length < 8)
                {
                    strErrorMessages =
                        " کاربر محترم:: برای وارد نمودن گذرواژه فعلی حداقل باید 6 حرف داشته باشد.";
                }
            }

            if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
            {
                if (strErrorMessages != string.Empty)
                {
                    strErrorMessages += System.Environment.NewLine;
                }

                strErrorMessages +=
                    "کاربر محترم:: لطفا گذرواژه جدید خود را وارد نمایید.";
            }
            else
            {
                if (newPasswordTextBox.Text.Length < 8)
                {
                    if (strErrorMessages != string.Empty)
                    {
                        strErrorMessages += System.Environment.NewLine;
                    }

                    strErrorMessages +=
                        "کاربر محترم:: حداقل تعداد کارکترهای وارد شده برای گذرواژه جدید باید 6 حرف باشد.";
                }
            }

            if (string.IsNullOrWhiteSpace(confirmNewPasswordTextBox.Text))
            {
                if (strErrorMessages != string.Empty)
                {
                    strErrorMessages += System.Environment.NewLine;
                }

                strErrorMessages +=
                    "کاربر محترم:: لطفا گذرواژه جدید را مجدد وارد نمایید";
            }
            else
            {
                if (string.Compare(confirmNewPasswordTextBox.Text, newPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    if (strErrorMessages != string.Empty)
                    {
                        strErrorMessages += System.Environment.NewLine;
                    }

                    strErrorMessages +=
                        "کاربر محترم:: گذرواژه ای که وارد نموده اید با گذرواژه جدید مطابقت ندارد. لطفا مجدد وارد نمایید.";
                }
            }

            if (strErrorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(strErrorMessages);

                return;
            }

            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                    oDatabaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                if (string.Compare(oUser.Password, oldPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    System.Windows.Forms.MessageBox.Show("کاربر محترم:: گذرواژه فعلی صحیح نمی باشد.");

                    oldPasswordTextBox.Focus();

                    return;
                }

                oUser.Password = newPasswordTextBox.Text;

                oDatabaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("کاربر محترم:: گذرواژه شما با موفقیت تغییر یافت.");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
    }
}
