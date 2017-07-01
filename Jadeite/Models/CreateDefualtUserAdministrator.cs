using System;
using System.Linq;
using System.Windows.Forms;
using Telerik;
using Telerik.WinControls;
using Jadeite.Forms;


namespace Models
{
    public class CreateDefualtUserAdministrator
    {

        public CreateDefualtUserAdministrator() : base()
        { }

        public void CDUA()
        {
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


                    //Telerik.WinControls.RadMessageBox.Show(
                    //    this,
                    //    text: "",
                    //    caption: "",
                    //    buttons: MessageBoxButtons.OK,
                    //    icon: RadMessageIcon.Info,
                    //    defaultBtn: MessageBoxDefaultButton.Button1,
                    //    rtl: RightToLeft.Yes);

                    System.Windows.Forms.DialogResult enmResult =
                        MessageBox.Show(
                            text: "آیا کاربر پیش فرض برای مدیرسیستم ساخته شود؟",
                            caption:"سوال",
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
    }
}
