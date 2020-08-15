namespace AscendingNET
{
    partial class ctlUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstboxUsers = new System.Windows.Forms.ListBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstboxUsers
            // 
            this.lstboxUsers.FormattingEnabled = true;
            this.lstboxUsers.ItemHeight = 73;
            this.lstboxUsers.Location = new System.Drawing.Point(148, 23);
            this.lstboxUsers.Name = "lstboxUsers";
            this.lstboxUsers.Size = new System.Drawing.Size(374, 296);
            this.lstboxUsers.TabIndex = 0;
            this.lstboxUsers.SelectedIndexChanged += new System.EventHandler(this.lstboxUsers_SelectedIndexChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(555, 46);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(280, 80);
            this.txtUserName.TabIndex = 1;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(555, 164);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(280, 82);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "Register";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // ctlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(37F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lstboxUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.Name = "ctlUser";
            this.Size = new System.Drawing.Size(1000, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxUsers;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button cmdOK;
    }
}
