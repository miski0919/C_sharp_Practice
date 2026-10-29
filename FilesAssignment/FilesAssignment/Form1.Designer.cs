namespace FilesAssignment
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
            this.btnReadingotherfunction = new System.Windows.Forms.Button();
            this.btnDeletetheitemfile = new System.Windows.Forms.Button();
            this.btnDeletethefile = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReadingotherfunction
            // 
            this.btnReadingotherfunction.Location = new System.Drawing.Point(36, 45);
            this.btnReadingotherfunction.Name = "btnReadingotherfunction";
            this.btnReadingotherfunction.Size = new System.Drawing.Size(228, 115);
            this.btnReadingotherfunction.TabIndex = 0;
            this.btnReadingotherfunction.Text = "Reading other fucntion";
            this.btnReadingotherfunction.UseVisualStyleBackColor = true;
            this.btnReadingotherfunction.Click += new System.EventHandler(this.btnReadingotherfunction_Click);
            // 
            // btnDeletetheitemfile
            // 
            this.btnDeletetheitemfile.Location = new System.Drawing.Point(289, 45);
            this.btnDeletetheitemfile.Name = "btnDeletetheitemfile";
            this.btnDeletetheitemfile.Size = new System.Drawing.Size(260, 115);
            this.btnDeletetheitemfile.TabIndex = 1;
            this.btnDeletetheitemfile.Text = "Delete the item file";
            this.btnDeletetheitemfile.UseVisualStyleBackColor = true;
            this.btnDeletetheitemfile.Click += new System.EventHandler(this.btnDeletetheitemfile_Click);
            // 
            // btnDeletethefile
            // 
            this.btnDeletethefile.Location = new System.Drawing.Point(36, 232);
            this.btnDeletethefile.Name = "btnDeletethefile";
            this.btnDeletethefile.Size = new System.Drawing.Size(228, 112);
            this.btnDeletethefile.TabIndex = 2;
            this.btnDeletethefile.Text = "Delete the file";
            this.btnDeletethefile.UseVisualStyleBackColor = true;
            this.btnDeletethefile.Click += new System.EventHandler(this.btnDeletethefile_Click);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 20;
            this.lst.Location = new System.Drawing.Point(350, 174);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(417, 264);
            this.lst.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.btnDeletethefile);
            this.Controls.Add(this.btnDeletetheitemfile);
            this.Controls.Add(this.btnReadingotherfunction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadingotherfunction;
        private System.Windows.Forms.Button btnDeletetheitemfile;
        private System.Windows.Forms.Button btnDeletethefile;
        private System.Windows.Forms.ListBox lst;
    }
}

