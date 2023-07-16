namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbasic = new System.Windows.Forms.TextBox();
            this.txtallowance = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblbasic = new System.Windows.Forms.Label();
            this.lblallow = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbasic
            // 
            this.txtbasic.BackColor = System.Drawing.SystemColors.Info;
            this.txtbasic.Location = new System.Drawing.Point(417, 114);
            this.txtbasic.Name = "txtbasic";
            this.txtbasic.Size = new System.Drawing.Size(204, 22);
            this.txtbasic.TabIndex = 0;
            // 
            // txtallowance
            // 
            this.txtallowance.BackColor = System.Drawing.SystemColors.Info;
            this.txtallowance.Location = new System.Drawing.Point(417, 171);
            this.txtallowance.Name = "txtallowance";
            this.txtallowance.Size = new System.Drawing.Size(204, 22);
            this.txtallowance.TabIndex = 1;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(387, 282);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(80, 16);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "Total Salary";
            // 
            // lblbasic
            // 
            this.lblbasic.AutoSize = true;
            this.lblbasic.Location = new System.Drawing.Point(264, 114);
            this.lblbasic.Name = "lblbasic";
            this.lblbasic.Size = new System.Drawing.Size(41, 16);
            this.lblbasic.TabIndex = 3;
            this.lblbasic.Text = "Basic";
            // 
            // lblallow
            // 
            this.lblallow.AutoSize = true;
            this.lblallow.Location = new System.Drawing.Point(267, 171);
            this.lblallow.Name = "lblallow";
            this.lblallow.Size = new System.Drawing.Size(69, 16);
            this.lblallow.TabIndex = 4;
            this.lblallow.Text = "Allowance";
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalculate.Location = new System.Drawing.Point(160, 367);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 5;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclear.Location = new System.Drawing.Point(356, 366);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnexit.Location = new System.Drawing.Point(545, 366);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblallow);
            this.Controls.Add(this.lblbasic);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtallowance);
            this.Controls.Add(this.txtbasic);
            this.Name = "Form1";
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbasic;
        private System.Windows.Forms.TextBox txtallowance;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblbasic;
        private System.Windows.Forms.Label lblallow;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

