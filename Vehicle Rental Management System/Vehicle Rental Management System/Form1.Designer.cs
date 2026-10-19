namespace Vehicle_Rental_Management_System
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
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblCusAge = new System.Windows.Forms.Label();
            this.lblNumberRentalDays = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtCusAge = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblBasicCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSurcharge = new System.Windows.Forms.Label();
            this.lblFinalCost = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(88, 51);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(154, 25);
            this.lblCusName.TabIndex = 0;
            this.lblCusName.Text = "Customer Name";
            // 
            // lblCusAge
            // 
            this.lblCusAge.AutoSize = true;
            this.lblCusAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusAge.Location = new System.Drawing.Point(88, 98);
            this.lblCusAge.Name = "lblCusAge";
            this.lblCusAge.Size = new System.Drawing.Size(143, 25);
            this.lblCusAge.TabIndex = 1;
            this.lblCusAge.Text = "Customer Age ";
            // 
            // lblNumberRentalDays
            // 
            this.lblNumberRentalDays.AutoSize = true;
            this.lblNumberRentalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberRentalDays.Location = new System.Drawing.Point(88, 149);
            this.lblNumberRentalDays.Name = "lblNumberRentalDays";
            this.lblNumberRentalDays.Size = new System.Drawing.Size(212, 25);
            this.lblNumberRentalDays.TabIndex = 2;
            this.lblNumberRentalDays.Text = "Number of Rental Days";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYears.Location = new System.Drawing.Point(88, 199);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(252, 25);
            this.lblYears.TabIndex = 3;
            this.lblYears.Text = "Years of Driving Experience";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(88, 252);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(363, 25);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Vehicle Type: Economy, SUV, or Luxury";
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsurance.Location = new System.Drawing.Point(88, 305);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(257, 25);
            this.lblInsurance.TabIndex = 5;
            this.lblInsurance.Text = "insurance Option: Yes or No";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(501, 50);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(283, 26);
            this.txtCusName.TabIndex = 6;
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(501, 251);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(283, 26);
            this.txtVehicle.TabIndex = 7;
            this.txtVehicle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtInsurance
            // 
            this.txtInsurance.Location = new System.Drawing.Point(501, 304);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(283, 26);
            this.txtInsurance.TabIndex = 8;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(501, 198);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(283, 26);
            this.txtYears.TabIndex = 9;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(501, 146);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(283, 26);
            this.txtNumber.TabIndex = 10;
            // 
            // txtCusAge
            // 
            this.txtCusAge.Location = new System.Drawing.Point(501, 97);
            this.txtCusAge.Name = "txtCusAge";
            this.txtCusAge.Size = new System.Drawing.Size(283, 26);
            this.txtCusAge.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(167, 414);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 94);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(392, 414);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(130, 94);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(603, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 94);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerName.Location = new System.Drawing.Point(901, 31);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(250, 33);
            this.lblCustomerName.TabIndex = 15;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleType.Location = new System.Drawing.Point(901, 80);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(250, 30);
            this.lblVehicleType.TabIndex = 16;
            // 
            // lblBasicCost
            // 
            this.lblBasicCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBasicCost.Location = new System.Drawing.Point(901, 125);
            this.lblBasicCost.Name = "lblBasicCost";
            this.lblBasicCost.Size = new System.Drawing.Size(250, 30);
            this.lblBasicCost.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(901, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 30);
            this.label4.TabIndex = 18;
            // 
            // lblSurcharge
            // 
            this.lblSurcharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSurcharge.Location = new System.Drawing.Point(901, 219);
            this.lblSurcharge.Name = "lblSurcharge";
            this.lblSurcharge.Size = new System.Drawing.Size(250, 30);
            this.lblSurcharge.TabIndex = 19;
            // 
            // lblFinalCost
            // 
            this.lblFinalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinalCost.Location = new System.Drawing.Point(901, 265);
            this.lblFinalCost.Name = "lblFinalCost";
            this.lblFinalCost.Size = new System.Drawing.Size(250, 30);
            this.lblFinalCost.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(901, 308);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(250, 30);
            this.lblStatus.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 644);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFinalCost);
            this.Controls.Add(this.lblSurcharge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBasicCost);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCusAge);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblNumberRentalDays);
            this.Controls.Add(this.lblCusAge);
            this.Controls.Add(this.lblCusName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblCusAge;
        private System.Windows.Forms.Label lblNumberRentalDays;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtCusAge;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblBasicCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSurcharge;
        private System.Windows.Forms.Label lblFinalCost;
        private System.Windows.Forms.Label lblStatus;
    }
}

