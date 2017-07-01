namespace Jadeite.Administrator
{
    partial class UsersListForm
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
            this.btn_Search = new Telerik.WinControls.UI.RadButton();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.usersListBox1 = new Telerik.WinControls.UI.RadListControl();
            this.fullNameTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.radGroupBox1.Controls.Add(this.fullNameTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.usersListBox1);
            this.radGroupBox1.Controls.Add(this.usersListBox);
            this.radGroupBox1.Controls.Add(this.btn_Search);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Mitra", 12F);
            this.radGroupBox1.HeaderText = "لیست";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(547, 482);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "لیست";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("B Mitra", 12F);
            this.btn_Search.Location = new System.Drawing.Point(115, 55);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 35);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "جستجو";
            this.btn_Search.ThemeName = "TelerikMetroBlue";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(273, 147);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(217, 290);
            this.usersListBox.TabIndex = 3;
            this.usersListBox.DoubleClick += new System.EventHandler(this.usersListBox_DoubleClick);
            // 
            // usersListBox1
            // 
            this.usersListBox1.Location = new System.Drawing.Point(37, 147);
            this.usersListBox1.Name = "usersListBox1";
            this.usersListBox1.Size = new System.Drawing.Size(219, 290);
            this.usersListBox1.TabIndex = 4;
            this.usersListBox1.Text = "radListControl1";
            this.usersListBox1.ThemeName = "TelerikMetroBlue";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(251, 55);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(164, 35);
            this.fullNameTextBox.TabIndex = 7;
            this.fullNameTextBox.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(421, 64);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(92, 26);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "نام و نام خانوادگی:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 482);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "UsersListForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "لیست کاربران سیستم";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersListForm_FormClosed);
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadListControl usersListBox1;
        private System.Windows.Forms.ListBox usersListBox;
        private Telerik.WinControls.UI.RadButton btn_Search;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadTextBoxControl fullNameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
