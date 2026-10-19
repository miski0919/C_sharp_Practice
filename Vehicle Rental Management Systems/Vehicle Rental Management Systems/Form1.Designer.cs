namespace Vehicle_Rental_Management_Systems
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblexperience = new System.Windows.Forms.Label();
            this.GroupboxCustomerinfo = new System.Windows.Forms.GroupBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.GroupVehicleType = new System.Windows.Forms.GroupBox();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.rdsuv = new System.Windows.Forms.RadioButton();
            this.rdeconomy = new System.Windows.Forms.RadioButton();
            this.Groupinsuranceoption = new System.Windows.Forms.GroupBox();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.Groupboxresult = new System.Windows.Forms.GroupBox();
            this.lstresult = new System.Windows.Forms.ListBox();
            this.GroupboxCustomerinfo.SuspendLayout();
            this.GroupVehicleType.SuspendLayout();
            this.Groupinsuranceoption.SuspendLayout();
            this.Groupboxresult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(30, 61);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(149, 22);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Customer Name :";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(30, 108);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(134, 22);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "Customer Age :";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Location = new System.Drawing.Point(30, 156);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(206, 22);
            this.lbldays.TabIndex = 2;
            this.lbldays.Text = "Number of Rental Days :";
            // 
            // lblexperience
            // 
            this.lblexperience.AutoSize = true;
            this.lblexperience.Location = new System.Drawing.Point(30, 203);
            this.lblexperience.Name = "lblexperience";
            this.lblexperience.Size = new System.Drawing.Size(243, 22);
            this.lblexperience.TabIndex = 3;
            this.lblexperience.Text = "Years of Driving Experience :";
            // 
            // GroupboxCustomerinfo
            // 
            this.GroupboxCustomerinfo.Controls.Add(this.txtexperience);
            this.GroupboxCustomerinfo.Controls.Add(this.txtdays);
            this.GroupboxCustomerinfo.Controls.Add(this.txtage);
            this.GroupboxCustomerinfo.Controls.Add(this.txtname);
            this.GroupboxCustomerinfo.Controls.Add(this.lbldays);
            this.GroupboxCustomerinfo.Controls.Add(this.lblexperience);
            this.GroupboxCustomerinfo.Controls.Add(this.lblname);
            this.GroupboxCustomerinfo.Controls.Add(this.lblage);
            this.GroupboxCustomerinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupboxCustomerinfo.Location = new System.Drawing.Point(51, 12);
            this.GroupboxCustomerinfo.Name = "GroupboxCustomerinfo";
            this.GroupboxCustomerinfo.Size = new System.Drawing.Size(517, 277);
            this.GroupboxCustomerinfo.TabIndex = 4;
            this.GroupboxCustomerinfo.TabStop = false;
            this.GroupboxCustomerinfo.Text = "Customer Information";
            // 
            // txtexperience
            // 
            this.txtexperience.Location = new System.Drawing.Point(281, 203);
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(185, 28);
            this.txtexperience.TabIndex = 7;
            this.txtexperience.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(281, 150);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(185, 28);
            this.txtdays.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(281, 105);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(185, 28);
            this.txtage.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(281, 55);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(185, 28);
            this.txtname.TabIndex = 4;
            // 
            // GroupVehicleType
            // 
            this.GroupVehicleType.Controls.Add(this.rdoluxury);
            this.GroupVehicleType.Controls.Add(this.rdsuv);
            this.GroupVehicleType.Controls.Add(this.rdeconomy);
            this.GroupVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupVehicleType.Location = new System.Drawing.Point(51, 305);
            this.GroupVehicleType.Name = "GroupVehicleType";
            this.GroupVehicleType.Size = new System.Drawing.Size(517, 120);
            this.GroupVehicleType.TabIndex = 5;
            this.GroupVehicleType.TabStop = false;
            this.GroupVehicleType.Text = "VehicleType";
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.Location = new System.Drawing.Point(352, 50);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(89, 26);
            this.rdoluxury.TabIndex = 2;
            this.rdoluxury.TabStop = true;
            this.rdoluxury.Text = "Luxury";
            this.rdoluxury.UseVisualStyleBackColor = true;
            // 
            // rdsuv
            // 
            this.rdsuv.AutoSize = true;
            this.rdsuv.Location = new System.Drawing.Point(188, 50);
            this.rdsuv.Name = "rdsuv";
            this.rdsuv.Size = new System.Drawing.Size(72, 26);
            this.rdsuv.TabIndex = 1;
            this.rdsuv.TabStop = true;
            this.rdsuv.Text = "SUV";
            this.rdsuv.UseVisualStyleBackColor = true;
            // 
            // rdeconomy
            // 
            this.rdeconomy.AutoSize = true;
            this.rdeconomy.Location = new System.Drawing.Point(34, 50);
            this.rdeconomy.Name = "rdeconomy";
            this.rdeconomy.Size = new System.Drawing.Size(109, 26);
            this.rdeconomy.TabIndex = 0;
            this.rdeconomy.TabStop = true;
            this.rdeconomy.Text = "Economy";
            this.rdeconomy.UseVisualStyleBackColor = true;
            // 
            // Groupinsuranceoption
            // 
            this.Groupinsuranceoption.Controls.Add(this.chkinsurance);
            this.Groupinsuranceoption.Location = new System.Drawing.Point(51, 448);
            this.Groupinsuranceoption.Name = "Groupinsuranceoption";
            this.Groupinsuranceoption.Size = new System.Drawing.Size(509, 83);
            this.Groupinsuranceoption.TabIndex = 6;
            this.Groupinsuranceoption.TabStop = false;
            this.Groupinsuranceoption.Text = "Insurance Option";
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Location = new System.Drawing.Point(51, 35);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(236, 24);
            this.chkinsurance.TabIndex = 0;
            this.chkinsurance.Text = "Add Insurance ($15 per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(124, 553);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(214, 56);
            this.btncalculate.TabIndex = 7;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(664, 553);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(186, 56);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(413, 553);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(171, 56);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // Groupboxresult
            // 
            this.Groupboxresult.Controls.Add(this.lstresult);
            this.Groupboxresult.Location = new System.Drawing.Point(608, 12);
            this.Groupboxresult.Name = "Groupboxresult";
            this.Groupboxresult.Size = new System.Drawing.Size(463, 535);
            this.Groupboxresult.TabIndex = 11;
            this.Groupboxresult.TabStop = false;
            this.Groupboxresult.Text = "Rental Information and Results";
            this.Groupboxresult.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstresult
            // 
            this.lstresult.FormattingEnabled = true;
            this.lstresult.ItemHeight = 20;
            this.lstresult.Location = new System.Drawing.Point(27, 25);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(415, 504);
            this.lstresult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 634);
            this.Controls.Add(this.Groupboxresult);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.Groupinsuranceoption);
            this.Controls.Add(this.GroupVehicleType);
            this.Controls.Add(this.GroupboxCustomerinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupboxCustomerinfo.ResumeLayout(false);
            this.GroupboxCustomerinfo.PerformLayout();
            this.GroupVehicleType.ResumeLayout(false);
            this.GroupVehicleType.PerformLayout();
            this.Groupinsuranceoption.ResumeLayout(false);
            this.Groupinsuranceoption.PerformLayout();
            this.Groupboxresult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblexperience;
        private System.Windows.Forms.GroupBox GroupboxCustomerinfo;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox GroupVehicleType;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.RadioButton rdsuv;
        private System.Windows.Forms.RadioButton rdeconomy;
        private System.Windows.Forms.GroupBox Groupinsuranceoption;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.GroupBox Groupboxresult;
        private System.Windows.Forms.ListBox lstresult;
    }
}

