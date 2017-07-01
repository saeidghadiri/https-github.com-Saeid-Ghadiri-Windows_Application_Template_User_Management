using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using Telerik.WinControls;
using Telerik.WinControls.Themes;


namespace Models
{
    class AppMessageBox
    {

        public AppMessageBox() : base()
        { }

        #region Exit Application
        public void Exit()
        {
            System.Windows.Forms.DialogResult enmResult =
                System.Windows.Forms.MessageBox.Show
                (text: "آیا به خروج از برنامه اطمینان دارید؟",
                caption: "سوال",
                buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                icon: System.Windows.Forms.MessageBoxIcon.Question,
                defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                options: System.Windows.Forms.MessageBoxOptions.RightAlign |
                System.Windows.Forms.MessageBoxOptions.RtlReading);

            if (enmResult == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }



            //RadMessageBox.SetThemeName("Desert");

            //RadMessageBox.Instance.ThemeName = "Desert";

            //System.Windows.Forms.DialogResult dr =
            //    Telerik.WinControls.RadMessageBox.Show(
            //        IWin32Window parent,
            //        text: "آیا به خروج از برنامه اطمینان دارید؟",
            //        caption: "سوال",
            //        buttons: MessageBoxButtons.YesNo,
            //        icon: RadMessageIcon.Question,
            //        defaultBtn: MessageBoxDefaultButton.Button2,
            //        rtl: RightToLeft.Yes);

            //this.text = dr.ToString();

            //*******************************************************************************************

            //using Telerik.WinControls.Themes;


            //new TelerikMetroBlueTheme();
            //Telerik.WinControls.RadMessageBox.ThemeName =
            //    "TelerikMetroBlue";

            //Font myFont =
            //    new Font(new FontFamily("B Mitra"), 12.0F, FontStyle.Bold);

            //RadMessageBox.Instance.Font = myFont;

            //System.Windows.Forms.DialogResult enmResult =
            //    Telerik.WinControls.RadMessageBox
            //        .Show(
            //        IWin32Window owner,
            //        text: "آیا به خروج از برنامه اطمینان دارید؟",
            //        caption: "سوال :: خروج",
            //        buttons: MessageBoxButtons.YesNo,
            //        icon: RadMessageIcon.Question,
            //        defaultBtn: MessageBoxDefaultButton.Button3,
            //        rtl: RightToLeft.Yes);

            //if (enmResult == System.Windows.Forms.DialogResult.Yes)
            //{
            //    System.Windows.Forms.Application.Exit();
            //}

            //*******************************************************************************************

        }
        #endregion  / Exit Application

        #region

        public void X()
        {
            
        }

        #endregion

    }
}