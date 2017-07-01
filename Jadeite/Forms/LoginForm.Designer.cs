namespace Jadeite.Forms
{
    partial class LoginForm
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
            this.usernameTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.passwordTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.btn_Reset = new Telerik.WinControls.UI.RadButton();
            this.btn_Exit = new Telerik.WinControls.UI.RadButton();
            this.btn_Login = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btn_Register = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.usernameTextBox.Location = new System.Drawing.Point(222, 296);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(298, 34);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.ThemeName = "TelerikMetroBlue";
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.passwordTextBox.Location = new System.Drawing.Point(222, 336);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(298, 34);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.ThemeName = "TelerikMetroBlue";
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("B Mitra", 12F);
            this.btn_Reset.Image = global::Jadeite.Properties.Resources.refresh;
            this.btn_Reset.Location = new System.Drawing.Point(180, 525);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(124, 53);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "تکمیل مجدد";
            this.btn_Reset.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.ThemeName = "TelerikMetroBlue";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Font = new System.Drawing.Font("B Mitra", 12F);
            this.btn_Exit.Image = global::Jadeite.Properties.Resources.exit;
            this.btn_Exit.Location = new System.Drawing.Point(29, 525);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(119, 53);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "خروج از سامانه";
            this.btn_Exit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.ThemeName = "TelerikMetroBlue";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("B Mitra", 12F);
            this.btn_Login.Image = global::Jadeite.Properties.Resources.success;
            this.btn_Login.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.Location = new System.Drawing.Point(530, 525);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(124, 53);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "ورود به سامانه";
            this.btn_Login.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.ThemeName = "TelerikMetroBlue";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Image = global::Jadeite.Properties.Resources.key;
            this.radLabel1.Location = new System.Drawing.Point(182, 336);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(34, 34);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Image = global::Jadeite.Properties.Resources.man;
            this.radLabel2.Location = new System.Drawing.Point(182, 296);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(34, 34);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("B Mitra", 12F);
            this.btn_Register.Image = global::Jadeite.Properties.Resources.user3;
            this.btn_Register.Location = new System.Drawing.Point(350, 525);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(131, 53);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "ایجاد کاربر جدید";
            this.btn_Register.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Register.ThemeName = "TelerikMetroBlue";
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::Jadeite.Properties.Resources.LoginForm;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(687, 658);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "فرم ورود به سامانه";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBoxControl usernameTextBox;
        private Telerik.WinControls.UI.RadTextBoxControl passwordTextBox;
        private Telerik.WinControls.UI.RadButton btn_Login;
        private Telerik.WinControls.UI.RadButton btn_Register;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btn_Reset;
        private Telerik.WinControls.UI.RadButton btn_Exit;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}
