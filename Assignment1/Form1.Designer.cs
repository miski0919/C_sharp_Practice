namespace Assignment1
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
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(198, 415);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(179, 62);
            this.btnshowinfo.TabIndex = 0;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(460, 71);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(276, 26);
            this.txtname.TabIndex = 1;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(460, 132);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(276, 26);
            this.txtstudentid.TabIndex = 2;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(460, 189);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(276, 26);
            this.txtdepartment.TabIndex = 3;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(460, 245);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(276, 26);
            this.txtsemester.TabIndex = 4;
            this.txtsemester.TextChanged += new System.EventHandler(this.txtsemester_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the student name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Location = new System.Drawing.Point(128, 131);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(154, 20);
            this.lblstudentid.TabIndex = 6;
            this.lblstudentid.Text = "Enter the student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(121, 189);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(161, 20);
            this.lbldepartment.TabIndex = 7;
            this.lbldepartment.Text = "Enter the department";
            this.lbldepartment.Click += new System.EventHandler(this.lbldepartment_Click);
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(128, 245);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(137, 20);
            this.lblsemester.TabIndex = 8;
            this.lblsemester.Text = "Enter the semeter";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(422, 415);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(192, 62);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(125, 320);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(628, 74);
            this.lbloutput.TabIndex = 10;
            this.lbloutput.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 505);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnshowinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lbloutput;
    }
}

