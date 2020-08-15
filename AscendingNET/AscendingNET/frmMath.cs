using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ascension;

namespace AscendingNET
{
    public partial class frmMath : Form
    {
        ctlMath _ctlMath;
        ctlMenu _ctlMenu;
        UserControl[] _userControls;
        //UserControl _ctrlMain;
        Ascension.AscensionMath _Ascension = new AscensionMath();

        int _Number1, _Number2, _Answer;

        public frmMath()
        {
            InitializeComponent();
            _ctlMath = new ctlMath(_Ascension);
            //_ctrlMain = new ctlMenu();
            this.pnlTop.Controls.Add(_ctlMath);

            //this.Controls.Add(_ctlMath);
            //_ctlMath.BringToFront();

            //void ctlMath_Load(object sender, EventArgs e)
            KeyDown += (frmMain_KeyDown);
            Functions.RegisterControl(this.rtxtStatus);
            Functions.DisplayMessage("Welcome!");

            _userControls = new UserControl[] { _ctlMath, _ctlMenu };

        }

        public void Initialize()
        {
            
            //this.KeyDown += (frmPartEntry_KeyDown);
            
            //_UserControlTabs[x] = new TabUserControl();
            //_UserControlTabs[x].Dock = DockStyle.Fill;
            ////uc.Dock = DockStyle.Fill;
            //TabPage tp = new TabPage();
            //tp.Controls.Add(_UserControlTabs[x]);
            //tabControl.TabPages.Add(tp);
        }

        internal void SwitchView(Global.UserControls enumUserControl)
        {
            try
            {
                UserControl userControlTemp;

                foreach (UserControl userCtl in _userControls)
                {
                    userCtl.Enabled = false;
                    userCtl.Visible = false;
                }

                switch (enumUserControl)
                {
                    case Global.UserControls.Math: userControlTemp = _ctlMath; break;
                    //case Global.UserControls.UserEdit: UserControl = 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        internal void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) // Debug Tools
            {
                _Ascension.GenerateProblem(Global.MathOperators.Add, 1, ref _Number1, ref _Number2, ref _Answer);
                //if (_ctrlMain.GetType() == typeof(ctlMath))
                    
                        _ctlMath.SetProblem(_Number1, _Number2, Global.MathOperators.Add);
                
            }
            if (e.KeyCode == Keys.Enter)
            {
                
            }

            if (_ctlMath != null)
                _ctlMath.EventKeyPress(sender, e);
            if (_ctlMenu != null)
                _ctlMenu.EventKeyPress(sender, e);

            //if (_ctlMath.Visible == true)
            //    _ctlMath.EventKeyPress(sender, e);
            //if (_ctlMenu.Visible == true)
            //    _ctlMenu.EventKeyPress(sender, e);

            //_ctlMath.EventKeyPress(sender, e);
        }
    }
}
