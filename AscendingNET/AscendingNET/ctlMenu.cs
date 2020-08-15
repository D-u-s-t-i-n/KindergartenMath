using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ascension;

namespace AscendingNET
{
    public partial class ctlMenu : UserControl
    {
        RadioButton[] _radioButtons;
        RadioButton _radioButtonSelected;
        frmMath _parent;

        public ctlMenu()
        {
            InitializeComponent();
            _radioButtons = new RadioButton[] { this.rdoOption1, this.rdoOption2, this.rdoOption3, this.rdoOption4 };
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rb in _radioButtons)
            {
                rb.ForeColor = Color.Black;
                if (rb.Focused == true)
                    rb.ForeColor = Color.Purple;
                _radioButtonSelected = rb;
            }

        }
        internal void EventKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_radioButtonSelected == this.rdoOption1)
                    _parent.SwitchView(Global.UserControls.Math);
                        //Functions.SwitchView()

                //foreach (RadioButton rb in _radioButtons)
                //{
                //    if (rb.Focused == true)
                //    {

                //    }
                //        //rb.ForeColor = Color.Purple;
                //}
            }
            
        }
    }
}
