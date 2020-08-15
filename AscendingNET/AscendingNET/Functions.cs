using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ascension;

namespace AscendingNET
{
    public static class Functions
    {
        static Control _control = new Control();
        static UserControl[] _userControls = new UserControl[] { };

        public static void RegisterControl(Control control)
        {
            _control = control;
        }

        //public static void RegisterUserControls(UserControl[] userControls)
        //{
        //    _userControls = userControls;
        //}

        //internal static void RegisterUserControls(Global.UserControls userControls)
        //{
        //    _userControls = new UserControl[(int)Global.UserControls.Count];
        //    _userControls[0] = new ctlMath();
        //}

        public static void DisplayMessage(string sErrMsg)
        {
            _control.Text = sErrMsg;
            _control.ForeColor = System.Drawing.Color.Black;
        }

        public static void DisplayError(string sErrMsg)
        {
            _control.Text = sErrMsg;
            _control.ForeColor = System.Drawing.Color.Red;
        }

        //public static void SwitchView(UserControl userControl)
        //{
        //    foreach (UserControl userCtl in _userControls)
        //    {
        //        userCtl.Visible = false;
        //        userCtl.Enabled = false;
        //    }
        //    userControl.Visible = true; userControl.Enabled = true;
                
        //}

        //internal static void SwitchView(Global.UserControls userControl)
        //{
        //    foreach (UserControl userCtl in _userControls)
        //    {
        //        userCtl.Visible = false;
        //        userCtl.Enabled = false;
        //    }
            

        //    //userControl.Visible = true; userControl.Enabled = true;

        //}

    }
}
