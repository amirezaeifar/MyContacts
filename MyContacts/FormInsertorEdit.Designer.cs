namespace MyContacts
{
    partial class FormInsertorEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lyAddress = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lyEmail = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.lyBirthday = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lyNumber = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.lyFname = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.lyLname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.lyAddress);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.lyEmail);
            this.groupBox1.Controls.Add(this.tbBirthday);
            this.groupBox1.Controls.Add(this.lyBirthday);
            this.groupBox1.Controls.Add(this.tbNumber);
            this.groupBox1.Controls.Add(this.lyNumber);
            this.groupBox1.Controls.Add(this.tbLname);
            this.groupBox1.Controls.Add(this.lyFname);
            this.groupBox1.Controls.Add(this.tbFname);
            this.groupBox1.Controls.Add(this.lyLname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Contact";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(543, 286);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(114, 199);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(504, 62);
            this.tbAddress.TabIndex = 11;
            // 
            // lyAddress
            // 
            this.lyAddress.AutoSize = true;
            this.lyAddress.Location = new System.Drawing.Point(21, 202);
            this.lyAddress.Name = "lyAddress";
            this.lyAddress.Size = new System.Drawing.Size(64, 16);
            this.lyAddress.TabIndex = 10;
            this.lyAddress.Text = "Address :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(109, 138);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(513, 22);
            this.tbEmail.TabIndex = 9;
            // 
            // lyEmail
            // 
            this.lyEmail.AutoSize = true;
            this.lyEmail.Location = new System.Drawing.Point(21, 141);
            this.lyEmail.Name = "lyEmail";
            this.lyEmail.Size = new System.Drawing.Size(47, 16);
            this.lyEmail.TabIndex = 8;
            this.lyEmail.Text = "Email :";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(419, 82);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(199, 22);
            this.tbBirthday.TabIndex = 7;
            // 
            // lyBirthday
            // 
            this.lyBirthday.AutoSize = true;
            this.lyBirthday.Location = new System.Drawing.Point(336, 85);
            this.lyBirthday.Name = "lyBirthday";
            this.lyBirthday.Size = new System.Drawing.Size(62, 16);
            this.lyBirthday.TabIndex = 6;
            this.lyBirthday.Text = "Birthday :";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(109, 82);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(199, 22);
            this.tbNumber.TabIndex = 5;
            // 
            // lyNumber
            // 
            this.lyNumber.AutoSize = true;
            this.lyNumber.Location = new System.Drawing.Point(21, 85);
            this.lyNumber.Name = "lyNumber";
            this.lyNumber.Size = new System.Drawing.Size(61, 16);
            this.lyNumber.TabIndex = 4;
            this.lyNumber.Text = "Number :";
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(419, 35);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(199, 22);
            this.tbLname.TabIndex = 3;
            // 
            // lyFname
            // 
            this.lyFname.AutoSize = true;
            this.lyFname.Location = new System.Drawing.Point(21, 38);
            this.lyFname.Name = "lyFname";
            this.lyFname.Size = new System.Drawing.Size(78, 16);
            this.lyFname.TabIndex = 2;
            this.lyFname.Text = "First Name :";
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(109, 35);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(199, 22);
            this.tbFname.TabIndex = 1;
            // 
            // lyLname
            // 
            this.lyLname.AutoSize = true;
            this.lyLname.Location = new System.Drawing.Point(336, 38);
            this.lyLname.Name = "lyLname";
            this.lyLname.Size = new System.Drawing.Size(78, 16);
            this.lyLname.TabIndex = 0;
            this.lyLname.Text = "Last Name :";
            // 
            // FormInsertorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 351);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInsertorEdit";
            this.Load += new System.EventHandler(this.FormInsertorEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lyAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lyEmail;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.Label lyBirthday;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lyNumber;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Label lyFname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label lyLname;
    }
}