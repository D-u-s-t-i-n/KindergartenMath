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
    internal partial class ctlMath : UserControl
    {
        private Label[] _Hints;
        private bool _bHintEnabled;
        private int _Answer;
        private AscensionMath _ascensionMath;

        internal ctlMath(Ascension.AscensionMath ascensionMath)
        {
            InitializeComponent();
            _ascensionMath = ascensionMath;
            _Hints = new Label[2];
            _Hints[0] = this.lblHint1; _Hints[1] = this.lblHint2;
            this.txtAnswer.Focus();
        }

        internal void HintsToggle(bool bShow)
        {
            try
            {
                _bHintEnabled = bShow;
                for (int iIdx = 1; iIdx <= _Hints.Length; iIdx++)
                    _Hints[iIdx - 1].Visible = bShow;
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void SetProblem(int Number1, int Number2, Global.MathOperators mathOperator)
        {
            try
            {
                HintsToggle(false);
                this.txtAnswer.Text = "";

                lblOperand1.Text = Number1.ToString();
                lblOperand2.Text = Number2.ToString();

                switch (mathOperator)
                {
                    case Global.MathOperators.Add:
                        lblOperator.Text = "+"; _Answer = Number1 + Number2;
                        for (int iIdx = 1; iIdx <= Number1; iIdx++)
                            this.lblHint1.Text += " O";
                        for (int iIdx = 2; iIdx <= Number2; iIdx++)
                            this.lblHint2.Text += " O";
                        break;
                    case Global.MathOperators.Sub:
                        lblOperator.Text = "-"; _Answer = Number1 - Number2; break;
                    case Global.MathOperators.Mul:
                        lblOperator.Text = "x"; _Answer = Number1 * Number2; break;
                    case Global.MathOperators.Div:
                        lblOperator.Text = "÷"; _Answer = Number1 / Number2; break;
                    default:
                        throw new Exception("Invalid operator");
                }
                this.txtAnswer.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void AcceptAnswer()
        {
            //if (_Answer == int.Parse(this.txtAnswer.Text))
            //    _ascensionMath.
        }
        

        internal void EventKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                HintsToggle(!_bHintEnabled);
            }
            else if (e.KeyCode == Keys.Space)
            {

            }
        }
    }
}
