namespace Airline_Ticket_Booking_System
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
            this.GboxPersonalinformation = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBaggageWeight = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.lblPassengerAge = new System.Windows.Forms.Label();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.GboxTravelClass = new System.Windows.Forms.GroupBox();
            this.radBusinessClass = new System.Windows.Forms.RadioButton();
            this.rdioNormalClass = new System.Windows.Forms.RadioButton();
            this.radFirstClass = new System.Windows.Forms.RadioButton();
            this.GboxAditionalOptions = new System.Windows.Forms.GroupBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listDisplayOutput = new System.Windows.Forms.ListBox();
            this.GboxPersonalinformation.SuspendLayout();
            this.GboxTravelClass.SuspendLayout();
            this.GboxAditionalOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // GboxPersonalinformation
            // 
            this.GboxPersonalinformation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GboxPersonalinformation.Controls.Add(this.txtWeight);
            this.GboxPersonalinformation.Controls.Add(this.txtTickets);
            this.GboxPersonalinformation.Controls.Add(this.txtAge);
            this.GboxPersonalinformation.Controls.Add(this.txtName);
            this.GboxPersonalinformation.Controls.Add(this.lblBaggageWeight);
            this.GboxPersonalinformation.Controls.Add(this.lblNumberOfTickets);
            this.GboxPersonalinformation.Controls.Add(this.lblPassengerAge);
            this.GboxPersonalinformation.Controls.Add(this.lblPassengerName);
            this.GboxPersonalinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxPersonalinformation.Location = new System.Drawing.Point(22, 28);
            this.GboxPersonalinformation.Name = "GboxPersonalinformation";
            this.GboxPersonalinformation.Size = new System.Drawing.Size(496, 254);
            this.GboxPersonalinformation.TabIndex = 0;
            this.GboxPersonalinformation.TabStop = false;
            this.GboxPersonalinformation.Text = "Personal information";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(248, 198);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(195, 28);
            this.txtWeight.TabIndex = 7;
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(248, 150);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(195, 28);
            this.txtTickets.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(248, 101);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(195, 28);
            this.txtAge.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 28);
            this.txtName.TabIndex = 4;
            // 
            // lblBaggageWeight
            // 
            this.lblBaggageWeight.AutoSize = true;
            this.lblBaggageWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaggageWeight.Location = new System.Drawing.Point(31, 198);
            this.lblBaggageWeight.Name = "lblBaggageWeight";
            this.lblBaggageWeight.Size = new System.Drawing.Size(180, 22);
            this.lblBaggageWeight.TabIndex = 3;
            this.lblBaggageWeight.Text = "Baggage weight(kg) :";
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTickets.Location = new System.Drawing.Point(45, 150);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(166, 22);
            this.lblNumberOfTickets.TabIndex = 2;
            this.lblNumberOfTickets.Text = "Number of Tickets :";
            // 
            // lblPassengerAge
            // 
            this.lblPassengerAge.AutoSize = true;
            this.lblPassengerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerAge.Location = new System.Drawing.Point(64, 101);
            this.lblPassengerAge.Name = "lblPassengerAge";
            this.lblPassengerAge.Size = new System.Drawing.Size(143, 22);
            this.lblPassengerAge.TabIndex = 1;
            this.lblPassengerAge.Text = "Passenger Age :";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerName.Location = new System.Drawing.Point(51, 53);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(158, 22);
            this.lblPassengerName.TabIndex = 0;
            this.lblPassengerName.Text = "Passenger Name :";
            // 
            // GboxTravelClass
            // 
            this.GboxTravelClass.Controls.Add(this.radBusinessClass);
            this.GboxTravelClass.Controls.Add(this.rdioNormalClass);
            this.GboxTravelClass.Controls.Add(this.radFirstClass);
            this.GboxTravelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxTravelClass.Location = new System.Drawing.Point(22, 329);
            this.GboxTravelClass.Name = "GboxTravelClass";
            this.GboxTravelClass.Size = new System.Drawing.Size(496, 100);
            this.GboxTravelClass.TabIndex = 1;
            this.GboxTravelClass.TabStop = false;
            this.GboxTravelClass.Text = "Travel Class";
            // 
            // radBusinessClass
            // 
            this.radBusinessClass.AutoSize = true;
            this.radBusinessClass.Location = new System.Drawing.Point(315, 42);
            this.radBusinessClass.Name = "radBusinessClass";
            this.radBusinessClass.Size = new System.Drawing.Size(158, 26);
            this.radBusinessClass.TabIndex = 3;
            this.radBusinessClass.TabStop = true;
            this.radBusinessClass.Text = "Business Class";
            this.radBusinessClass.UseVisualStyleBackColor = true;
            // 
            // rdioNormalClass
            // 
            this.rdioNormalClass.AutoSize = true;
            this.rdioNormalClass.Location = new System.Drawing.Point(152, 42);
            this.rdioNormalClass.Name = "rdioNormalClass";
            this.rdioNormalClass.Size = new System.Drawing.Size(142, 26);
            this.rdioNormalClass.TabIndex = 2;
            this.rdioNormalClass.TabStop = true;
            this.rdioNormalClass.Text = "Normal Class";
            this.rdioNormalClass.UseVisualStyleBackColor = true;
            // 
            // radFirstClass
            // 
            this.radFirstClass.AutoSize = true;
            this.radFirstClass.Location = new System.Drawing.Point(18, 42);
            this.radFirstClass.Name = "radFirstClass";
            this.radFirstClass.Size = new System.Drawing.Size(114, 26);
            this.radFirstClass.TabIndex = 0;
            this.radFirstClass.TabStop = true;
            this.radFirstClass.Text = "first Class";
            this.radFirstClass.UseVisualStyleBackColor = true;
            // 
            // GboxAditionalOptions
            // 
            this.GboxAditionalOptions.Controls.Add(this.chkInsurance);
            this.GboxAditionalOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxAditionalOptions.Location = new System.Drawing.Point(22, 458);
            this.GboxAditionalOptions.Name = "GboxAditionalOptions";
            this.GboxAditionalOptions.Size = new System.Drawing.Size(473, 82);
            this.GboxAditionalOptions.TabIndex = 2;
            this.GboxAditionalOptions.TabStop = false;
            this.GboxAditionalOptions.Text = "Aditional Options";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(49, 38);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(334, 26);
            this.chkInsurance.TabIndex = 3;
            this.chkInsurance.Text = "Add Travel insurance ($25 Per ticket)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(144, 590);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 53);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(352, 590);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 53);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(554, 590);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 53);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listDisplayOutput
            // 
            this.listDisplayOutput.FormattingEnabled = true;
            this.listDisplayOutput.ItemHeight = 20;
            this.listDisplayOutput.Location = new System.Drawing.Point(577, 47);
            this.listDisplayOutput.Name = "listDisplayOutput";
            this.listDisplayOutput.Size = new System.Drawing.Size(327, 504);
            this.listDisplayOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 674);
            this.Controls.Add(this.listDisplayOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.GboxAditionalOptions);
            this.Controls.Add(this.GboxTravelClass);
            this.Controls.Add(this.GboxPersonalinformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GboxPersonalinformation.ResumeLayout(false);
            this.GboxPersonalinformation.PerformLayout();
            this.GboxTravelClass.ResumeLayout(false);
            this.GboxTravelClass.PerformLayout();
            this.GboxAditionalOptions.ResumeLayout(false);
            this.GboxAditionalOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboxPersonalinformation;
        private System.Windows.Forms.Label lblBaggageWeight;
        private System.Windows.Forms.Label lblNumberOfTickets;
        private System.Windows.Forms.Label lblPassengerAge;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.GroupBox GboxTravelClass;
        private System.Windows.Forms.RadioButton radBusinessClass;
        private System.Windows.Forms.RadioButton rdioNormalClass;
        private System.Windows.Forms.RadioButton radFirstClass;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox GboxAditionalOptions;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listDisplayOutput;
    }
}

