namespace Hotel_Room_Booking_System
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
            this.listBookingdetails = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.GboxAditionalOption = new System.Windows.Forms.GroupBox();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.GboxRoomType = new System.Windows.Forms.GroupBox();
            this.radioHight = new System.Windows.Forms.RadioButton();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.GboxPersonalinformation = new System.Windows.Forms.GroupBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNumberofGuest = new System.Windows.Forms.Label();
            this.lblNumberofNights = new System.Windows.Forms.Label();
            this.lblGuestAge = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.GboxAditionalOption.SuspendLayout();
            this.GboxRoomType.SuspendLayout();
            this.GboxPersonalinformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBookingdetails
            // 
            this.listBookingdetails.FormattingEnabled = true;
            this.listBookingdetails.ItemHeight = 20;
            this.listBookingdetails.Location = new System.Drawing.Point(614, 26);
            this.listBookingdetails.Name = "listBookingdetails";
            this.listBookingdetails.Size = new System.Drawing.Size(484, 504);
            this.listBookingdetails.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(654, 563);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 53);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(452, 563);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 53);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(244, 563);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 53);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // GboxAditionalOption
            // 
            this.GboxAditionalOption.Controls.Add(this.chkBreakfast);
            this.GboxAditionalOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxAditionalOption.Location = new System.Drawing.Point(90, 434);
            this.GboxAditionalOption.Name = "GboxAditionalOption";
            this.GboxAditionalOption.Size = new System.Drawing.Size(473, 82);
            this.GboxAditionalOption.TabIndex = 11;
            this.GboxAditionalOption.TabStop = false;
            this.GboxAditionalOption.Text = "Aditional Options";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(49, 38);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(320, 26);
            this.chkBreakfast.TabIndex = 3;
            this.chkBreakfast.Text = "BreakFast(10 Per Guest per nights)";
            this.chkBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // GboxRoomType
            // 
            this.GboxRoomType.Controls.Add(this.radioHight);
            this.GboxRoomType.Controls.Add(this.radioNormal);
            this.GboxRoomType.Controls.Add(this.radioStandard);
            this.GboxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxRoomType.Location = new System.Drawing.Point(67, 302);
            this.GboxRoomType.Name = "GboxRoomType";
            this.GboxRoomType.Size = new System.Drawing.Size(496, 100);
            this.GboxRoomType.TabIndex = 10;
            this.GboxRoomType.TabStop = false;
            this.GboxRoomType.Text = "Room Type";
            // 
            // radioHight
            // 
            this.radioHight.AutoSize = true;
            this.radioHight.Location = new System.Drawing.Point(315, 42);
            this.radioHight.Name = "radioHight";
            this.radioHight.Size = new System.Drawing.Size(77, 26);
            this.radioHight.TabIndex = 3;
            this.radioHight.TabStop = true;
            this.radioHight.Text = "Hight";
            this.radioHight.UseVisualStyleBackColor = true;
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Location = new System.Drawing.Point(152, 42);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Size = new System.Drawing.Size(92, 26);
            this.radioNormal.TabIndex = 2;
            this.radioNormal.TabStop = true;
            this.radioNormal.Text = "Normal";
            this.radioNormal.UseVisualStyleBackColor = true;
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Location = new System.Drawing.Point(18, 42);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(108, 26);
            this.radioStandard.TabIndex = 0;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // GboxPersonalinformation
            // 
            this.GboxPersonalinformation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GboxPersonalinformation.Controls.Add(this.txtGuests);
            this.GboxPersonalinformation.Controls.Add(this.txtNights);
            this.GboxPersonalinformation.Controls.Add(this.txtAge);
            this.GboxPersonalinformation.Controls.Add(this.txtName);
            this.GboxPersonalinformation.Controls.Add(this.lblNumberofGuest);
            this.GboxPersonalinformation.Controls.Add(this.lblNumberofNights);
            this.GboxPersonalinformation.Controls.Add(this.lblGuestAge);
            this.GboxPersonalinformation.Controls.Add(this.lblGuestName);
            this.GboxPersonalinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxPersonalinformation.Location = new System.Drawing.Point(32, 26);
            this.GboxPersonalinformation.Name = "GboxPersonalinformation";
            this.GboxPersonalinformation.Size = new System.Drawing.Size(496, 254);
            this.GboxPersonalinformation.TabIndex = 9;
            this.GboxPersonalinformation.TabStop = false;
            this.GboxPersonalinformation.Text = "Personal information";
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(248, 198);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(195, 28);
            this.txtGuests.TabIndex = 7;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(248, 150);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(195, 28);
            this.txtNights.TabIndex = 6;
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
            // lblNumberofGuest
            // 
            this.lblNumberofGuest.AutoSize = true;
            this.lblNumberofGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofGuest.Location = new System.Drawing.Point(31, 198);
            this.lblNumberofGuest.Name = "lblNumberofGuest";
            this.lblNumberofGuest.Size = new System.Drawing.Size(156, 22);
            this.lblNumberofGuest.TabIndex = 3;
            this.lblNumberofGuest.Text = "Number of Guest :";
            // 
            // lblNumberofNights
            // 
            this.lblNumberofNights.AutoSize = true;
            this.lblNumberofNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofNights.Location = new System.Drawing.Point(45, 150);
            this.lblNumberofNights.Name = "lblNumberofNights";
            this.lblNumberofNights.Size = new System.Drawing.Size(159, 22);
            this.lblNumberofNights.TabIndex = 2;
            this.lblNumberofNights.Text = "Number of Nights :";
            // 
            // lblGuestAge
            // 
            this.lblGuestAge.AutoSize = true;
            this.lblGuestAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestAge.Location = new System.Drawing.Point(64, 101);
            this.lblGuestAge.Name = "lblGuestAge";
            this.lblGuestAge.Size = new System.Drawing.Size(105, 22);
            this.lblGuestAge.TabIndex = 1;
            this.lblGuestAge.Text = "Guest Age :";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(51, 53);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(120, 22);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 628);
            this.Controls.Add(this.listBookingdetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.GboxAditionalOption);
            this.Controls.Add(this.GboxRoomType);
            this.Controls.Add(this.GboxPersonalinformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GboxAditionalOption.ResumeLayout(false);
            this.GboxAditionalOption.PerformLayout();
            this.GboxRoomType.ResumeLayout(false);
            this.GboxRoomType.PerformLayout();
            this.GboxPersonalinformation.ResumeLayout(false);
            this.GboxPersonalinformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBookingdetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox GboxAditionalOption;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.GroupBox GboxRoomType;
        private System.Windows.Forms.RadioButton radioHight;
        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.GroupBox GboxPersonalinformation;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNumberofGuest;
        private System.Windows.Forms.Label lblNumberofNights;
        private System.Windows.Forms.Label lblGuestAge;
        private System.Windows.Forms.Label lblGuestName;
    }
}

