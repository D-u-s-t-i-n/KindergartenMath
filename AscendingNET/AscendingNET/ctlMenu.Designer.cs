namespace AscendingNET
{
    partial class ctlMenu
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
            this.lblOption1 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.rdoOption1 = new System.Windows.Forms.RadioButton();
            this.rdoOption2 = new System.Windows.Forms.RadioButton();
            this.rdoOption3 = new System.Windows.Forms.RadioButton();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.lblOption4 = new System.Windows.Forms.Label();
            this.rdoOption4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.Location = new System.Drawing.Point(569, 9);
            this.lblOption1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(197, 73);
            this.lblOption1.TabIndex = 0;
            this.lblOption1.Text = "Begin";
            this.lblOption1.Visible = false;
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.BackColor = System.Drawing.SystemColors.Control;
            this.lblOption2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblOption2.Location = new System.Drawing.Point(569, 92);
            this.lblOption2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(265, 73);
            this.lblOption2.TabIndex = 0;
            this.lblOption2.Text = "Addition";
            // 
            // rdoOption1
            // 
            this.rdoOption1.AutoSize = true;
            this.rdoOption1.Location = new System.Drawing.Point(232, 9);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(215, 77);
            this.rdoOption1.TabIndex = 1;
            this.rdoOption1.TabStop = true;
            this.rdoOption1.Text = "Begin";
            this.rdoOption1.UseVisualStyleBackColor = true;
            // 
            // rdoOption2
            // 
            this.rdoOption2.AutoSize = true;
            this.rdoOption2.Location = new System.Drawing.Point(232, 92);
            this.rdoOption2.Name = "rdoOption2";
            this.rdoOption2.Size = new System.Drawing.Size(211, 77);
            this.rdoOption2.TabIndex = 1;
            this.rdoOption2.TabStop = true;
            this.rdoOption2.Text = "Mode";
            this.rdoOption2.UseVisualStyleBackColor = true;
            this.rdoOption2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoOption3
            // 
            this.rdoOption3.AutoSize = true;
            this.rdoOption3.Location = new System.Drawing.Point(232, 175);
            this.rdoOption3.Name = "rdoOption3";
            this.rdoOption3.Size = new System.Drawing.Size(204, 77);
            this.rdoOption3.TabIndex = 1;
            this.rdoOption3.TabStop = true;
            this.rdoOption3.Text = "Level";
            this.rdoOption3.UseVisualStyleBackColor = true;
            this.rdoOption3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblOption3
            // 
            this.lblOption3.AutoSize = true;
            this.lblOption3.BackColor = System.Drawing.SystemColors.Control;
            this.lblOption3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblOption3.Location = new System.Drawing.Point(569, 175);
            this.lblOption3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(68, 73);
            this.lblOption3.TabIndex = 0;
            this.lblOption3.Text = "1";
            // 
            // lblOption4
            // 
            this.lblOption4.AutoSize = true;
            this.lblOption4.BackColor = System.Drawing.SystemColors.Control;
            this.lblOption4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblOption4.Location = new System.Drawing.Point(569, 258);
            this.lblOption4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOption4.Name = "lblOption4";
            this.lblOption4.Size = new System.Drawing.Size(214, 73);
            this.lblOption4.TabIndex = 0;
            this.lblOption4.Text = "Nitsud";
            // 
            // rdoOption4
            // 
            this.rdoOption4.AutoSize = true;
            this.rdoOption4.Location = new System.Drawing.Point(232, 258);
            this.rdoOption4.Name = "rdoOption4";
            this.rdoOption4.Size = new System.Drawing.Size(273, 77);
            this.rdoOption4.TabIndex = 1;
            this.rdoOption4.TabStop = true;
            this.rdoOption4.Text = "Student";
            this.rdoOption4.UseVisualStyleBackColor = true;
            this.rdoOption4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ctlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(37F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdoOption4);
            this.Controls.Add(this.rdoOption3);
            this.Controls.Add(this.rdoOption2);
            this.Controls.Add(this.lblOption4);
            this.Controls.Add(this.rdoOption1);
            this.Controls.Add(this.lblOption3);
            this.Controls.Add(this.lblOption2);
            this.Controls.Add(this.lblOption1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.Name = "ctlMenu";
            this.Size = new System.Drawing.Size(1000, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.RadioButton rdoOption1;
        private System.Windows.Forms.RadioButton rdoOption2;
        private System.Windows.Forms.RadioButton rdoOption3;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.Label lblOption4;
        private System.Windows.Forms.RadioButton rdoOption4;
    }
}
