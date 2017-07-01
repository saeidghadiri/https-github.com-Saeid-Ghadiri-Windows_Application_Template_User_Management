using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Jadeite.Administrator
{
    //public partial class UpdateUserForm : Telerik.WinControls.UI.RadForm
    public partial class UpdateUserForm : Infrastructure.RadBaseForm
    {
        public Guid UserId { get; set; }

        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            FormLoad();
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
                    .Where(current => current.Id == UserId)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such a user!");

                    Close();
                }

                oUser.IsAdmin = isAdminCheckBox.Checked;
                oUser.IsActive = isActiveCheckBox.Checked;

                oUser.FullName = fullNameTextBox.Text;
                oUser.Description = descriptionTextBox.Text;

                oDatabaseContext.SaveChanges();

                Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                Close();
            }
            finally
            {
            }
        }



        public void FormLoad()
        {
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                    oDatabaseContext.Users
                    .Where(current => current.Id == UserId)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such a user!");

                    Close();
                }

                isAdminCheckBox.Checked = oUser.IsAdmin;
                isActiveCheckBox.Checked = oUser.IsActive;

                fullNameTextBox.Text = oUser.FullName;
                descriptionTextBox.Text = oUser.Description;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                Close();
            }
            finally
            {
            }
        }
    }
}
