namespace HomeAssignment
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
            this.lblTestScore1 = new System.Windows.Forms.Label();
            this.lblTestScore2 = new System.Windows.Forms.Label();
            this.lblTestScore3 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTestScore1
            // 
            this.lblTestScore1.AutoSize = true;
            this.lblTestScore1.Location = new System.Drawing.Point(95, 74);
            this.lblTestScore1.Name = "lblTestScore1";
            this.lblTestScore1.Size = new System.Drawing.Size(99, 20);
            this.lblTestScore1.TabIndex = 0;
            this.lblTestScore1.Text = "Test Score 1";
            // 
            // lblTestScore2
            // 
            this.lblTestScore2.AutoSize = true;
            this.lblTestScore2.Location = new System.Drawing.Point(95, 135);
            this.lblTestScore2.Name = "lblTestScore2";
            this.lblTestScore2.Size = new System.Drawing.Size(99, 20);
            this.lblTestScore2.TabIndex = 1;
            this.lblTestScore2.Text = "Test Score 2";
            // 
            // lblTestScore3
            // 
            this.lblTestScore3.AutoSize = true;
            this.lblTestScore3.Location = new System.Drawing.Point(95, 198);
            this.lblTestScore3.Name = "lblTestScore3";
            this.lblTestScore3.Size = new System.Drawing.Size(99, 20);
            this.lblTestScore3.TabIndex = 2;
            this.lblTestScore3.Text = "Test Score 3";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(300, 266);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(68, 20);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average";
            this.lblAverage.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(267, 74);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(227, 26);
            this.txtScore1.TabIndex = 4;
            // 
            // txtScore4
            // 
            this.txtScore4.Location = new System.Drawing.Point(212, 305);
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.Size = new System.Drawing.Size(251, 26);
            this.txtScore4.TabIndex = 5;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(267, 198);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(227, 26);
            this.txtScore3.TabIndex = 6;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(267, 135);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(227, 26);
            this.txtScore2.TabIndex = 7;
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(67, 365);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(162, 54);
            this.btnCalculateAverage.TabIndex = 8;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(471, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 54);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(271, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 54);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore4);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTestScore3);
            this.Controls.Add(this.lblTestScore2);
            this.Controls.Add(this.lblTestScore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestScore1;
        private System.Windows.Forms.Label lblTestScore2;
        private System.Windows.Forms.Label lblTestScore3;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore4;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

