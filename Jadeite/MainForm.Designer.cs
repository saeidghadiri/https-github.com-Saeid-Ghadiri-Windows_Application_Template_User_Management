namespace Jadeite
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.radRibbonBarBackstageView1 = new Telerik.WinControls.UI.RadRibbonBarBackstageView();
            this.backstageViewPage1 = new Telerik.WinControls.UI.BackstageViewPage();
            this.backstageViewPage2 = new Telerik.WinControls.UI.BackstageViewPage();
            this.backstageViewPage3 = new Telerik.WinControls.UI.BackstageViewPage();
            this.backstagetab_Exit = new Telerik.WinControls.UI.RadButton();
            this.backstageTabItem1 = new Telerik.WinControls.UI.BackstageTabItem();
            this.backstageTabItem2 = new Telerik.WinControls.UI.BackstageTabItem();
            this.bstab_ExitApplication = new Telerik.WinControls.UI.BackstageTabItem();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.tabmenu_Aministrator = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.frmmenu_UpdateUserProfile = new Telerik.WinControls.UI.RadButtonElement();
            this.frmmenu_ChangePassword = new Telerik.WinControls.UI.RadButtonElement();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.frmmenu_UserListAdmin = new Telerik.WinControls.UI.RadButtonElement();
            this.frmmenu_UpdateProfileUserAdmin = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBarBackstageView1)).BeginInit();
            this.radRibbonBarBackstageView1.SuspendLayout();
            this.backstageViewPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backstagetab_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
            this.radRibbonBar1.BackstageControl = this.radRibbonBarBackstageView1;
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2,
            this.tabmenu_Aministrator});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.Font = new System.Drawing.Font("B Mitra", 12F);
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.Size = new System.Drawing.Size(868, 163);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.ThemeName = "Office2013Light";
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Text = "";
            // 
            // radRibbonBarBackstageView1
            // 
            this.radRibbonBarBackstageView1.Controls.Add(this.backstageViewPage1);
            this.radRibbonBarBackstageView1.Controls.Add(this.backstageViewPage2);
            this.radRibbonBarBackstageView1.Controls.Add(this.backstageViewPage3);
            this.radRibbonBarBackstageView1.EnableKeyMap = true;
            this.radRibbonBarBackstageView1.Font = new System.Drawing.Font("B Mitra", 12F);
            this.radRibbonBarBackstageView1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.backstageTabItem1,
            this.backstageTabItem2,
            this.bstab_ExitApplication});
            this.radRibbonBarBackstageView1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBarBackstageView1.Name = "radRibbonBarBackstageView1";
            this.radRibbonBarBackstageView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radRibbonBarBackstageView1.SelectedItem = this.bstab_ExitApplication;
            this.radRibbonBarBackstageView1.Size = new System.Drawing.Size(868, 537);
            this.radRibbonBarBackstageView1.TabIndex = 2;
            this.radRibbonBarBackstageView1.ThemeName = "Office2013Light";
            // 
            // backstageViewPage1
            // 
            this.backstageViewPage1.BackColor = System.Drawing.Color.Transparent;
            this.backstageViewPage1.Font = new System.Drawing.Font("B Mitra", 12F);
            this.backstageViewPage1.Location = new System.Drawing.Point(1, 27);
            this.backstageViewPage1.Name = "backstageViewPage1";
            this.backstageViewPage1.Size = new System.Drawing.Size(662, 509);
            this.backstageViewPage1.TabIndex = 1;
            // 
            // backstageViewPage2
            // 
            this.backstageViewPage2.BackColor = System.Drawing.Color.Transparent;
            this.backstageViewPage2.Font = new System.Drawing.Font("B Mitra", 12F);
            this.backstageViewPage2.Location = new System.Drawing.Point(0, 1);
            this.backstageViewPage2.Name = "backstageViewPage2";
            this.backstageViewPage2.Size = new System.Drawing.Size(705, 541);
            this.backstageViewPage2.TabIndex = 3;
            // 
            // backstageViewPage3
            // 
            this.backstageViewPage3.BackColor = System.Drawing.Color.Transparent;
            this.backstageViewPage3.Controls.Add(this.backstagetab_Exit);
            this.backstageViewPage3.Font = new System.Drawing.Font("B Mitra", 12F);
            this.backstageViewPage3.Location = new System.Drawing.Point(1, 27);
            this.backstageViewPage3.Name = "backstageViewPage3";
            this.backstageViewPage3.Size = new System.Drawing.Size(662, 509);
            this.backstageViewPage3.TabIndex = 5;
            // 
            // backstagetab_Exit
            // 
            this.backstagetab_Exit.Font = new System.Drawing.Font("B Mitra", 12F);
            this.backstagetab_Exit.Location = new System.Drawing.Point(290, 192);
            this.backstagetab_Exit.Name = "backstagetab_Exit";
            this.backstagetab_Exit.Size = new System.Drawing.Size(202, 105);
            this.backstagetab_Exit.TabIndex = 0;
            this.backstagetab_Exit.Text = "خ&روج از سامانه";
            this.backstagetab_Exit.ThemeName = "TelerikMetroBlue";
            this.backstagetab_Exit.Click += new System.EventHandler(this.backstagetab_Exit_Click);
            // 
            // backstageTabItem1
            // 
            this.backstageTabItem1.Font = new System.Drawing.Font("B Mitra", 12F);
            this.backstageTabItem1.Name = "backstageTabItem1";
            this.backstageTabItem1.Page = this.backstageViewPage1;
            this.backstageTabItem1.Text = "backstageTabItem1";
            // 
            // backstageTabItem2
            // 
            this.backstageTabItem2.Font = new System.Drawing.Font("B Mitra", 12F);
            this.backstageTabItem2.Name = "backstageTabItem2";
            this.backstageTabItem2.Page = this.backstageViewPage2;
            this.backstageTabItem2.Text = "backstageTabItem2";
            // 
            // bstab_ExitApplication
            // 
            this.bstab_ExitApplication.Font = new System.Drawing.Font("B Mitra", 12F);
            this.bstab_ExitApplication.Name = "bstab_ExitApplication";
            this.bstab_ExitApplication.Page = this.backstageViewPage3;
            this.bstab_ExitApplication.Text = "خروج از سامانه";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Font = new System.Drawing.Font("B Mitra", 12F);
            this.ribbonTab1.IsSelected = false;
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "تنظیمات";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Font = new System.Drawing.Font("B Mitra", 12F);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "سامانه ها";
            // 
            // tabmenu_Aministrator
            // 
            this.tabmenu_Aministrator.IsSelected = true;
            this.tabmenu_Aministrator.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2});
            this.tabmenu_Aministrator.Name = "tabmenu_Aministrator";
            this.tabmenu_Aministrator.Text = "مدیریت";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.frmmenu_UpdateUserProfile,
            this.frmmenu_ChangePassword});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "مدیریت کاربران";
            // 
            // frmmenu_UpdateUserProfile
            // 
            this.frmmenu_UpdateUserProfile.Name = "frmmenu_UpdateUserProfile";
            this.frmmenu_UpdateUserProfile.Text = "بروز رسانی پروفایل کاربر";
            this.frmmenu_UpdateUserProfile.Click += new System.EventHandler(this.frmmenu_UpdateUserProfile_Click);
            // 
            // frmmenu_ChangePassword
            // 
            this.frmmenu_ChangePassword.Name = "frmmenu_ChangePassword";
            this.frmmenu_ChangePassword.Text = "تغییر رمز عبور کاربر";
            this.frmmenu_ChangePassword.Click += new System.EventHandler(this.frmmenu_ChangePassword_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Font = new System.Drawing.Font("B Mitra", 12F);
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 566);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radStatusStrip1.Size = new System.Drawing.Size(868, 34);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Office2013Light";
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.frmmenu_UserListAdmin,
            this.frmmenu_UpdateProfileUserAdmin});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "مدیر سیستم";
            // 
            // frmmenu_UserListAdmin
            // 
            this.frmmenu_UserListAdmin.Name = "frmmenu_UserListAdmin";
            this.frmmenu_UserListAdmin.Text = "نمایش لیست کاربران";
            this.frmmenu_UserListAdmin.Click += new System.EventHandler(this.frmmenu_UserListAdmin_Click);
            // 
            // frmmenu_UpdateProfileUserAdmin
            // 
            this.frmmenu_UpdateProfileUserAdmin.Name = "frmmenu_UpdateProfileUserAdmin";
            this.frmmenu_UpdateProfileUserAdmin.Text = "بروز رسانی پروفایل کاربران";
            this.frmmenu_UpdateProfileUserAdmin.Click += new System.EventHandler(this.frmmenu_UpdateProfileUserAdmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 600);
            this.Controls.Add(this.radRibbonBarBackstageView1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBarBackstageView1)).EndInit();
            this.radRibbonBarBackstageView1.ResumeLayout(false);
            this.backstageViewPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backstagetab_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadRibbonBarBackstageView radRibbonBarBackstageView1;
        private Telerik.WinControls.UI.BackstageViewPage backstageViewPage3;
        private Telerik.WinControls.UI.RadButton backstagetab_Exit;
        private Telerik.WinControls.UI.BackstageViewPage backstageViewPage2;
        private Telerik.WinControls.UI.BackstageViewPage backstageViewPage1;
        private Telerik.WinControls.UI.BackstageTabItem backstageTabItem1;
        private Telerik.WinControls.UI.BackstageTabItem backstageTabItem2;
        private Telerik.WinControls.UI.BackstageTabItem bstab_ExitApplication;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RibbonTab tabmenu_Aministrator;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadButtonElement frmmenu_UpdateUserProfile;
        private Telerik.WinControls.UI.RadButtonElement frmmenu_ChangePassword;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement frmmenu_UserListAdmin;
        private Telerik.WinControls.UI.RadButtonElement frmmenu_UpdateProfileUserAdmin;
    }
}
