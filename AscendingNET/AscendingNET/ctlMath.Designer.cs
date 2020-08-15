namespace AscendingNET
{
    partial class ctlMath
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
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.lblHint1 = new System.Windows.Forms.Label();
            this.lblHint2 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Location = new System.Drawing.Point(355, 75);
            this.lblOperand2.Margin = new System.Windows.Forms.Padding(74, 0, 74, 0);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(98, 108);
            this.lblOperand2.TabIndex = 1;
            this.lblOperand2.Text = "5";
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Location = new System.Drawing.Point(129, 75);
            this.lblOperand1.Margin = new System.Windows.Forms.Padding(74, 0, 74, 0);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(98, 108);
            this.lblOperand1.TabIndex = 2;
            this.lblOperand1.Text = "5";
            // 
            // lblHint1
            // 
            this.lblHint1.AutoSize = true;
            this.lblHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint1.Location = new System.Drawing.Point(97, 213);
            this.lblHint1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblHint1.Name = "lblHint1";
            this.lblHint1.Size = new System.Drawing.Size(0, 37);
            this.lblHint1.TabIndex = 3;
            // 
            // lblHint2
            // 
            this.lblHint2.AutoSize = true;
            this.lblHint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint2.Location = new System.Drawing.Point(467, 213);
            this.lblHint2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblHint2.Name = "lblHint2";
            this.lblHint2.Size = new System.Drawing.Size(0, 37);
            this.lblHint2.TabIndex = 3;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(239, 75);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(74, 0, 74, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(101, 108);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "÷";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(640, 69);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(226, 116);
            this.txtAnswer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(74, 0, 74, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            // 
            // ctlMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(56F, 108F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblHint2);
            this.Controls.Add(this.lblHint1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.lblOperand1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(28, 23, 28, 23);
            this.Name = "ctlMath";
            this.Size = new System.Drawing.Size(1000, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.Label lblHint1;
        private System.Windows.Forms.Label lblHint2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
    }
}
