using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AscendingNET
{
    public partial class ctlUser : UserControl
    {
        public ctlUser(string[] sUsers)
        {
            InitializeComponent();
            this.lstboxUsers.Items.Clear();
            this.lstboxUsers.Items.Add(Ascension.Global.S_USER_ADDNEW);

            foreach (string s in sUsers)
                lstboxUsers.Items.Add(s);
        }

        private void lstboxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtUserName.Text != "")
                    if (this.lstboxUsers.Items.Contains(this.txtUserName.Text))
                    { throw new Exception("User exists");
                    }
                    else { this.lstboxUsers.Items.Add(this.txtUserName.Text); }
            }
            catch (Exception ex)
            {

                throw;
            }
                    
        }
    }
}
