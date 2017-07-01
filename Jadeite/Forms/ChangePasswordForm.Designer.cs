namespace Jadeite.Forms
{
    partial class ChangePasswordForm
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.oldPasswordTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.newPasswordTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.confirmNewPasswordTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.btn_ChangePassword = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmNewPasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Mitra", 12F);
            this.radLabel1.Location = new System.Drawing.Point(334, 44);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(78, 26);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "گذرواژه قدیمی:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("B Mitra", 12F);
            this.radLabel2.Location = new System.Drawing.Point(334, 85);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(71, 26);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "گذرواژه جدید:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Mitra", 12F);
            this.radLabel3.Location = new System.Drawing.Point(334, 126);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(71, 26);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "تکرار گذرواژه:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(101, 35);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(227, 35);
            this.oldPasswordTextBox.TabIndex = 1;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(101, 76);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(227, 35);
            this.newPasswordTextBox.TabIndex = 3;
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(101, 117);
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(227, 35);
            this.confirmNewPasswordTextBox.TabIndex = 5;
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Font = new System.Drawing.Font("B Mitra", 12F);
            this.btn_ChangePassword.Location = new System.Drawing.Point(325, 211);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(129, 48);
            this.btn_ChangePassword.TabIndex = 6;
            this.btn_ChangePassword.Text = "ثبت داده";
            this.btn_ChangePassword.ThemeName = "TelerikMetroBlue";
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(495, 292);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.confirmNewPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "ChangePasswordForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "تغییر گذرواژه کاربر";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmNewPasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChangePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBoxControl oldPasswordTextBox;
        private Telerik.WinControls.UI.RadTextBoxControl newPasswordTextBox;
        private Telerik.WinControls.UI.RadTextBoxControl confirmNewPasswordTextBox;
        private Telerik.WinControls.UI.RadButton btn_ChangePassword;
    }
}
