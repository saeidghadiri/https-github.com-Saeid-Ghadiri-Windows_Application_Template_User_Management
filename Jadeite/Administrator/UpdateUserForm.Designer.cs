namespace Jadeite.Administrator
{
    partial class UpdateUserForm
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.fullNameTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.descriptionTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.isActiveCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.isAdminCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdminCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.radGroupBox1.Controls.Add(this.btn_Save);
            this.radGroupBox1.Controls.Add(this.isAdminCheckBox);
            this.radGroupBox1.Controls.Add(this.isActiveCheckBox);
            this.radGroupBox1.Controls.Add(this.fullNameTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.descriptionTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Mitra", 12F);
            this.radGroupBox1.HeaderText = "پروفایل کاربر";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(547, 482);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "پروفایل کاربر";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(253, 61);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(164, 26);
            this.fullNameTextBox.TabIndex = 5;
            this.fullNameTextBox.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(423, 61);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(92, 26);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "نام و نام خانوادگی:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(28, 93);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(389, 197);
            this.descriptionTextBox.TabIndex = 7;
            this.descriptionTextBox.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(423, 93);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(49, 26);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "یادداشت:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.Font = new System.Drawing.Font("B Mitra", 12F);
            this.isActiveCheckBox.Location = new System.Drawing.Point(343, 300);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(74, 26);
            this.isActiveCheckBox.TabIndex = 8;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.ThemeName = "TelerikMetroBlue";
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.Font = new System.Drawing.Font("B Mitra", 12F);
            this.isAdminCheckBox.Location = new System.Drawing.Point(341, 328);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(76, 26);
            this.isAdminCheckBox.TabIndex = 8;
            this.isAdminCheckBox.Text = "Admin";
            this.isAdminCheckBox.ThemeName = "TelerikMetroBlue";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("B Mitra", 12F);
            this.btn_Save.Location = new System.Drawing.Point(28, 384);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 42);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "ذخیره داده ها";
            this.btn_Save.ThemeName = "TelerikMetroBlue";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 482);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "UpdateUserForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "بروز رسانی اطلاعات پروفایل کاربران";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAdminCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadTextBoxControl fullNameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBoxControl descriptionTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btn_Save;
        private Telerik.WinControls.UI.RadCheckBox isAdminCheckBox;
        private Telerik.WinControls.UI.RadCheckBox isActiveCheckBox;
    }
}
