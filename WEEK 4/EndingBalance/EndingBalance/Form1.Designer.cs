namespace EndingBalance
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartingBalance = new System.Windows.Forms.Label();
            this.lblNumberofMonths = new System.Windows.Forms.Label();
            this.txtStartingBal = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnRandomNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // lblStartingBalance
            // 
            this.lblStartingBalance.AutoSize = true;
            this.lblStartingBalance.Location = new System.Drawing.Point(43, 66);
            this.lblStartingBalance.Name = "lblStartingBalance";
            this.lblStartingBalance.Size = new System.Drawing.Size(135, 20);
            this.lblStartingBalance.TabIndex = 1;
            this.lblStartingBalance.Text = "Starting Balance :";
            // 
            // lblNumberofMonths
            // 
            this.lblNumberofMonths.AutoSize = true;
            this.lblNumberofMonths.Location = new System.Drawing.Point(43, 149);
            this.lblNumberofMonths.Name = "lblNumberofMonths";
            this.lblNumberofMonths.Size = new System.Drawing.Size(148, 20);
            this.lblNumberofMonths.TabIndex = 2;
            this.lblNumberofMonths.Text = "Number of Months :";
            // 
            // txtStartingBal
            // 
            this.txtStartingBal.Location = new System.Drawing.Point(261, 75);
            this.txtStartingBal.Name = "txtStartingBal";
            this.txtStartingBal.Size = new System.Drawing.Size(198, 26);
            this.txtStartingBal.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(261, 149);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(198, 26);
            this.txtMonth.TabIndex = 4;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(512, 30);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(255, 284);
            this.lstOutput.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(50, 359);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 59);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(385, 359);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(137, 59);
            this.btnReadFile.TabIndex = 7;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(221, 359);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(137, 59);
            this.btnSaveFile.TabIndex = 8;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnRandomNumbers
            // 
            this.btnRandomNumbers.Location = new System.Drawing.Point(567, 359);
            this.btnRandomNumbers.Name = "btnRandomNumbers";
            this.btnRandomNumbers.Size = new System.Drawing.Size(163, 59);
            this.btnRandomNumbers.TabIndex = 9;
            this.btnRandomNumbers.Text = "Random Numbers";
            this.btnRandomNumbers.UseVisualStyleBackColor = true;
            this.btnRandomNumbers.Click += new System.EventHandler(this.btnRandomNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandomNumbers);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtStartingBal);
            this.Controls.Add(this.lblNumberofMonths);
            this.Controls.Add(this.lblStartingBalance);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStartingBalance;
        private System.Windows.Forms.Label lblNumberofMonths;
        private System.Windows.Forms.TextBox txtStartingBal;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnRandomNumbers;
    }
}

