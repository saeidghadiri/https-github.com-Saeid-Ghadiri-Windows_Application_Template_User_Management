namespace Jadeite.Forms
{
    partial class SplashScreenForLoginForm
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
            this.components = new System.ComponentModel.Container();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.dotsLineWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement();
            this.tmrCheckTime = new System.Windows.Forms.Timer(this.components);
            this.lblSeconds = new Telerik.WinControls.UI.RadLabel();
            this.Checking_SQL = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checking_SQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Calibri", 9F);
            this.radLabel2.ForeColor = System.Drawing.Color.White;
            this.radLabel2.Location = new System.Drawing.Point(12, 147);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(125, 18);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "Copyright © 2013-2017";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(12, 103);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(404, 24);
            this.radWaitingBar1.TabIndex = 12;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.ThemeName = "TelerikMetroBlue";
            this.radWaitingBar1.WaitingIndicators.Add(this.dotsLineWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingSpeed = 100;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsLine;
            // 
            // dotsLineWaitingBarIndicatorElement1
            // 
            this.dotsLineWaitingBarIndicatorElement1.AccelerationSpeed = 8D;
            this.dotsLineWaitingBarIndicatorElement1.DistanceBetweenDots = 6D;
            this.dotsLineWaitingBarIndicatorElement1.DotRadius = 6;
            this.dotsLineWaitingBarIndicatorElement1.ElementColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.dotsLineWaitingBarIndicatorElement1.ElementCount = 7;
            this.dotsLineWaitingBarIndicatorElement1.Name = "dotsLineWaitingBarIndicatorElement1";
            // 
            // tmrCheckTime
            // 
            this.tmrCheckTime.Interval = 1000;
            this.tmrCheckTime.Tick += new System.EventHandler(this.tmrCheckTime_Tick);
            // 
            // lblSeconds
            // 
            this.lblSeconds.Font = new System.Drawing.Font("B Mitra", 12F);
            this.lblSeconds.Location = new System.Drawing.Point(382, 139);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(2, 2);
            this.lblSeconds.TabIndex = 13;
            this.lblSeconds.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Checking_SQL
            // 
            this.Checking_SQL.BackColor = System.Drawing.Color.Transparent;
            this.Checking_SQL.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold);
            this.Checking_SQL.ForeColor = System.Drawing.Color.DarkGreen;
            this.Checking_SQL.Location = new System.Drawing.Point(132, 22);
            this.Checking_SQL.Name = "Checking_SQL";
            this.Checking_SQL.Size = new System.Drawing.Size(284, 28);
            this.Checking_SQL.TabIndex = 11;
            this.Checking_SQL.Text = "در حال بررسی بانک اطلاعاتی لطفا منتظر بمانید....";
            this.Checking_SQL.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // SplashScreenForLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(428, 177);
            this.ControlBox = false;
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.Checking_SQL);
            this.Controls.Add(this.radLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenForLoginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Load += new System.EventHandler(this.SplashScreenForLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checking_SQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.DotsLineWaitingBarIndicatorElement dotsLineWaitingBarIndicatorElement1;
        private System.Windows.Forms.Timer tmrCheckTime;
        private Telerik.WinControls.UI.RadLabel lblSeconds;
        private Telerik.WinControls.UI.RadLabel Checking_SQL;
    }
}
