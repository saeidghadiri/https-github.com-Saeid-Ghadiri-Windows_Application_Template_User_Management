using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using mgh;

namespace Jadeite
{
    public partial class MainForm : Telerik.WinControls.UI.RadRibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            

            THEME();
            SettingRibbonForm();
        }

        public void THEME()
        {
            // Right using Telerik.WinControls.Themes;
            new Office2013LightTheme();
            ThemeResolutionService.ApplicationThemeName = "Office2013Light";
        }

        public void SettingRibbonForm()
        {
            this.AllowAero = false;
            this.RightToLeft = RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.radRibbonBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radRibbonBar1.Text = "سامانه الکترونیک سعید غدیری";
            this.Font = new System.Drawing.Font("B Mitra", 12F);
        }

        public void Exit()
        {
            //Models. exit =
            //new Models.AplicationExit();

            //exit.Exit();
            Models.AppMessageBox msg =
                new Models.AppMessageBox();

            msg.Exit();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
            //{
            //    adminToolStripMenuItem.Visible = true;
            //}
            //else
            //{
            //    adminToolStripMenuItem.Visible = false;
            //}

            ////usernameToolStripStatusLabel.Text =
            ////	"Welcome " + Infrastructure.Utility.AuthenticatedUser.Username + "!";

            //usernameToolStripStatusLabel.Text =
            //    string.Format("Welcome {0}!", Infrastructure.Utility.AuthenticatedUser.Username);
        }

        //*******************
        #region Codes DateTimePersian
        public void DateTimePersian()
        {
            /*
            this.KeyPreview = true;
            try
            {
                System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
                lbldate.Text = p.GetYear(DateTime.Now).ToString() + "/" + p.GetMonth(DateTime.Now).ToString("0#") + "/" + p.GetDayOfMonth(DateTime.Now).ToString("0#");


                Language.ChangeCurrentLanguage("fa");

                switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                        lblday.Text = "جمعه";
                        break;
                    case DayOfWeek.Monday:
                        lblday.Text = "دوشنبه";
                        break;
                    case DayOfWeek.Saturday:
                        lblday.Text = "شنبه";
                        break;
                    case DayOfWeek.Sunday:
                        lblday.Text = "یکشنبه";
                        break;
                    case DayOfWeek.Thursday:
                        lblday.Text = "پنجشنبه";
                        break;
                    case DayOfWeek.Tuesday:
                        lblday.Text = "سه شنبه";
                        break;
                    case DayOfWeek.Wednesday:
                        lblday.Text = "چهارشنبه";
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }



        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    lbltime.Text = DateTime.Now.Second.ToString("0#");
        //    lbltime.Text += " : ";
        //    lbltime.Text += DateTime.Now.Minute.ToString("0#");
        //    lbltime.Text += " : ";
        //    lbltime.Text += DateTime.Now.Hour.ToString("0#");
        //}



        #endregion
        //*******************

        private void backstagetab_Exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void frmmenu_UpdateUserProfile_Click(object sender, EventArgs e)
        {
            Forms.UpdateProfileUserForm f = new Forms.UpdateProfileUserForm();
            f.Show();
        }

        private void frmmenu_ChangePassword_Click(object sender, EventArgs e)
        {
            Forms.ChangePasswordForm f = new Forms.ChangePasswordForm();
            f.Show();
        }

        private void frmmenu_UserListAdmin_Click(object sender, EventArgs e)
        {
            Administrator.UsersListForm f = new Administrator.UsersListForm();
            f.Show();
        }

        private void frmmenu_UpdateProfileUserAdmin_Click(object sender, EventArgs e)
        {
            Administrator.UpdateUserForm f = new Administrator.UpdateUserForm();
            f.Show();
        }
    }
}
