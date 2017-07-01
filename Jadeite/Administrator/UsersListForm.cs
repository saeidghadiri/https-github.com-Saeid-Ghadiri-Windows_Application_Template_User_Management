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
    //public partial class UsersListForm : Telerik.WinControls.UI.RadForm
    public partial class UsersListForm : Infrastructure.RadBaseForm
    {
        public UsersListForm()
        {
            InitializeComponent();
        }

        private Models.DatabaseContext _myDatabaseContext;

        private void btn_Search_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<Models.User> oUsers = null;

            fullNameTextBox.Text = 
                fullNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
            {
                oUsers =
                    _myDatabaseContext.Users
                    .OrderBy(current => current.FullName)
                    .ToList()
                    ;
            }
            else
            {
                //contains:: برای این است که طرف هرچی وارد فیلد تکس باکس کرد سرچ کند به اول و آخر و وسط نگاه میکند.
                oUsers =
                    _myDatabaseContext.Users
                    .Where(current => current.FullName.Contains(fullNameTextBox.Text))
                    .OrderBy(current => current.FullName)
                    .ToList()
                    ;
            }

            usersListBox.ValueMember = "Id";
            usersListBox.DisplayMember = "FullName";
            usersListBox.DataSource = oUsers;

            if (oUsers.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("کاربر محترم:: هیچ کاربری با این مشخصات وجود ندارد.");
            }
        }

        private void usersListBox_DoubleClick(object sender, EventArgs e)
        {
            Models.User oSelectedUser =
                usersListBox.SelectedItem as Models.User;

            if (oSelectedUser != null)
            {
                Administrator.UpdateUserForm updateUserForm = 
                    new Administrator.UpdateUserForm();

                updateUserForm.UserId = oSelectedUser.Id;

                updateUserForm.ShowDialog();
            }
        }

        private void UsersListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DBContext بسته شود و حافظه آن تخلیه شود.

            if (_myDatabaseContext != null)
            {
                _myDatabaseContext.Dispose();
                _myDatabaseContext = null;
            }
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            // DBContext شروع به کار کند
           _myDatabaseContext = 
                new Models.DatabaseContext();
        }
    }
}