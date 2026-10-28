namespace SoftwareSales
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNumberofPackages = new System.Windows.Forms.Label();
            this.lblPriceperPackage = new System.Windows.Forms.Label();
            this.txtNumberofPackages = new System.Windows.Forms.TextBox();
            this.txtPriceperPackage = new System.Windows.Forms.TextBox();
            this.listSoftware = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(223, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 51);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(31, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 51);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblNumberofPackages
            // 
            this.lblNumberofPackages.AutoSize = true;
            this.lblNumberofPackages.Location = new System.Drawing.Point(18, 61);
            this.lblNumberofPackages.Name = "lblNumberofPackages";
            this.lblNumberofPackages.Size = new System.Drawing.Size(165, 20);
            this.lblNumberofPackages.TabIndex = 3;
            this.lblNumberofPackages.Text = "Number of Packages :";
            // 
            // lblPriceperPackage
            // 
            this.lblPriceperPackage.AutoSize = true;
            this.lblPriceperPackage.Location = new System.Drawing.Point(18, 118);
            this.lblPriceperPackage.Name = "lblPriceperPackage";
            this.lblPriceperPackage.Size = new System.Drawing.Size(145, 20);
            this.lblPriceperPackage.TabIndex = 4;
            this.lblPriceperPackage.Text = "Price per Package :";
            // 
            // txtNumberofPackages
            // 
            this.txtNumberofPackages.Location = new System.Drawing.Point(300, 61);
            this.txtNumberofPackages.Name = "txtNumberofPackages";
            this.txtNumberofPackages.Size = new System.Drawing.Size(232, 26);
            this.txtNumberofPackages.TabIndex = 0;
            // 
            // txtPriceperPackage
            // 
            this.txtPriceperPackage.Location = new System.Drawing.Point(300, 118);
            this.txtPriceperPackage.Name = "txtPriceperPackage";
            this.txtPriceperPackage.Size = new System.Drawing.Size(232, 26);
            this.txtPriceperPackage.TabIndex = 1;
            // 
            // listSoftware
            // 
            this.listSoftware.FormattingEnabled = true;
            this.listSoftware.ItemHeight = 20;
            this.listSoftware.Location = new System.Drawing.Point(586, 40);
            this.listSoftware.Name = "listSoftware";
            this.listSoftware.Size = new System.Drawing.Size(310, 384);
            this.listSoftware.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 522);
            this.Controls.Add(this.listSoftware);
            this.Controls.Add(this.txtPriceperPackage);
            this.Controls.Add(this.txtNumberofPackages);
            this.Controls.Add(this.lblPriceperPackage);
            this.Controls.Add(this.lblNumberofPackages);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNumberofPackages;
        private System.Windows.Forms.Label lblPriceperPackage;
        private System.Windows.Forms.TextBox txtNumberofPackages;
        private System.Windows.Forms.TextBox txtPriceperPackage;
        private System.Windows.Forms.ListBox listSoftware;
    }
}

