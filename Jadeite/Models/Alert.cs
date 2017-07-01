using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Themes;

namespace Models
{
    class Alert : BaseEntity
    {
        public Alert() : base()
        { }

        #region FunctionAlter
        public void AlertLogin()
        {
            Telerik.WinControls.UI.RadDesktopAlert DeskAlert = new Telerik.WinControls.UI.RadDesktopAlert();
            DeskAlert.Show();
            new TelerikMetroBlueTheme();
            DeskAlert.ThemeName = "TelerikMetroBlue";
            DeskAlert.AutoCloseDelay = 1;
            DeskAlert.CanMove = false;
            DeskAlert.CaptionText = ".::::  خوش آمدید  ::::.";
            DeskAlert.ContentText = "با سلام، به سامانه ثبت اطلاعات خوش آمدید.";
            DeskAlert.PopupAnimation = true;
            DeskAlert.PopupAnimationDirection = Down;
            DeskAlert.PopupAnimationFrames = 5;
            DeskAlert.RightToLeft = yes;
            DeskAlert.IsPinned = false;
        }
        public RightToLeft yes { get; set; }
        public RadDirection Down { get; set; }

        #endregion
    }
}
