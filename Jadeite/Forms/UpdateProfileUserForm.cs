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
    //public partial class UpdateProfileUserForm : Telerik.WinControls.UI.RadForm 
    public partial class UpdateProfileUserForm : Infrastructure.RadBaseForm
    {
        public UpdateProfileUserForm()
        {
            InitializeComponent();
        }

        private void UpdateProfileUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
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
                    // می توانیم پیغام به کاربر نشان دیم که همچین نام کاربری دیگر وجود ندارد.
                    System.Windows.Forms.Application.Exit();
                }

                oUser.FullName = fullNameTextBox.Text;
                oUser.Description = fullNameTextBox.Text;

                oDatabaseContext.SaveChanges();

                //Infrastructure.Utility.AuthenticatedUser = oUser;
                Infrastructure.Utility.AuthenticatedUser = oUser;

                //System.Windows.Forms.MessageBox
                //    .Show("Your profile was updated successfully...");

                //-------------------------------------------------------------------------
                new TelerikMetroBlueTheme();
                Telerik.WinControls.RadMessageBox.ThemeName = "TelerikMetroBlue";

                Font myFont = new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);
                RadMessageBox.Instance.Font = myFont;

                Telerik.WinControls.RadMessageBox
                    .Show(this,
                    text: "پروفایل کاربری شما با موفقیا بروز رسانی شده است!",
                    caption: "اطلاع رسانی",
                    buttons: MessageBoxButtons.OK,
                    icon: RadMessageIcon.Error,
                    defaultBtn: MessageBoxDefaultButton.Button2,
                    rtl: RightToLeft.Yes);
                //-------------------------------------------------------------------------

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

        public void LoadForm()
        {
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

                descriptionTextBox.Text = oUser.FullName;
                descriptionTextBox.Text = oUser.Description;
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
    }
}
