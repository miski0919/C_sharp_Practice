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
            this.lbldatoftheweek = new System.Windows.Forms.Label();
            this.lblnameofthemonth = new System.Windows.Forms.Label();
            this.lblNumericofthemonth = new System.Windows.Forms.Label();
            this.lbltheyear = new System.Windows.Forms.Label();
            this.lbloutbut = new System.Windows.Forms.Label();
            this.txtDayoftheweek = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtofthemonth = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldatoftheweek
            // 
            this.lbldatoftheweek.AutoSize = true;
            this.lbldatoftheweek.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatoftheweek.Location = new System.Drawing.Point(137, 56);
            this.lbldatoftheweek.Name = "lbldatoftheweek";
            this.lbldatoftheweek.Size = new System.Drawing.Size(249, 26);
            this.lbldatoftheweek.TabIndex = 0;
            this.lbldatoftheweek.Text = "Enter day of the week :";
            // 
            // lblnameofthemonth
            // 
            this.lblnameofthemonth.AutoSize = true;
            this.lblnameofthemonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofthemonth.Location = new System.Drawing.Point(99, 115);
            this.lblnameofthemonth.Name = "lblnameofthemonth";
            this.lblnameofthemonth.Size = new System.Drawing.Size(288, 26);
            this.lblnameofthemonth.TabIndex = 1;
            this.lblnameofthemonth.Text = "Enter Name of the Month :";
            // 
            // lblNumericofthemonth
            // 
            this.lblNumericofthemonth.AutoSize = true;
            this.lblNumericofthemonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumericofthemonth.Location = new System.Drawing.Point(39, 170);
            this.lblNumericofthemonth.Name = "lblNumericofthemonth";
            this.lblNumericofthemonth.Size = new System.Drawing.Size(348, 26);
            this.lblNumericofthemonth.TabIndex = 2;
            this.lblNumericofthemonth.Text = "Enter the numeric of the month :";
            // 
            // lbltheyear
            // 
            this.lbltheyear.AutoSize = true;
            this.lbltheyear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltheyear.Location = new System.Drawing.Point(212, 223);
            this.lbltheyear.Name = "lbltheyear";
            this.lbltheyear.Size = new System.Drawing.Size(175, 26);
            this.lbltheyear.TabIndex = 3;
            this.lbltheyear.Text = "Enter the year :";
            // 
            // lbloutbut
            // 
            this.lbloutbut.BackColor = System.Drawing.SystemColors.Control;
            this.lbloutbut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutbut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbloutbut.Location = new System.Drawing.Point(30, 306);
            this.lbloutbut.Name = "lbloutbut";
            this.lbloutbut.Size = new System.Drawing.Size(925, 77);
            this.lbloutbut.TabIndex = 4;
            // 
            // txtDayoftheweek
            // 
            this.txtDayoftheweek.Location = new System.Drawing.Point(456, 59);
            this.txtDayoftheweek.Name = "txtDayoftheweek";
            this.txtDayoftheweek.Size = new System.Drawing.Size(379, 26);
            this.txtDayoftheweek.TabIndex = 5;
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.Location = new System.Drawing.Point(457, 172);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(379, 26);
            this.txtdayofthemonth.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(456, 226);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(379, 26);
            this.txtYear.TabIndex = 8;
            // 
            // txtofthemonth
            // 
            this.txtofthemonth.Location = new System.Drawing.Point(456, 114);
            this.txtofthemonth.Name = "txtofthemonth";
            this.txtofthemonth.Size = new System.Drawing.Size(379, 26);
            this.txtofthemonth.TabIndex = 9;
            this.txtofthemonth.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(123, 412);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(181, 93);
            this.btnshow.TabIndex = 10;
            this.btnshow.Text = "show Date";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(377, 412);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(185, 93);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(636, 412);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(186, 93);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 570);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtofthemonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtDayoftheweek);
            this.Controls.Add(this.lbloutbut);
            this.Controls.Add(this.lbltheyear);
            this.Controls.Add(this.lblNumericofthemonth);
            this.Controls.Add(this.lblnameofthemonth);
            this.Controls.Add(this.lbldatoftheweek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldatoftheweek;
        private System.Windows.Forms.Label lblnameofthemonth;
        private System.Windows.Forms.Label lblNumericofthemonth;
        private System.Windows.Forms.Label lbltheyear;
        private System.Windows.Forms.Label lbloutbut;
        private System.Windows.Forms.TextBox txtDayoftheweek;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtofthemonth;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

