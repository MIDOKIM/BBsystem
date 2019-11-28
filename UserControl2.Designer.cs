namespace BBsystem
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbusertype = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbcity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_age = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbsearch = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Username:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbusertype);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbcity);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.text_age);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.text_password);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.text_username);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.text_phone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.text_email);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_LastName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_FirstName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(58, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 378);
            this.panel2.TabIndex = 4;
            // 
            // cbusertype
            // 
            this.cbusertype.FormattingEnabled = true;
            this.cbusertype.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbusertype.Location = new System.Drawing.Point(114, 209);
            this.cbusertype.Margin = new System.Windows.Forms.Padding(2);
            this.cbusertype.Name = "cbusertype";
            this.cbusertype.Size = new System.Drawing.Size(92, 21);
            this.cbusertype.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 209);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "User type:";
            // 
            // cbcity
            // 
            this.cbcity.FormattingEnabled = true;
            this.cbcity.Location = new System.Drawing.Point(114, 184);
            this.cbcity.Margin = new System.Windows.Forms.Padding(2);
            this.cbcity.Name = "cbcity";
            this.cbcity.Size = new System.Drawing.Size(92, 21);
            this.cbcity.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "city:";
            // 
            // text_age
            // 
            this.text_age.Location = new System.Drawing.Point(116, 158);
            this.text_age.Margin = new System.Windows.Forms.Padding(2);
            this.text_age.Name = "text_age";
            this.text_age.Size = new System.Drawing.Size(39, 20);
            this.text_age.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "password:";
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(117, 136);
            this.text_password.Margin = new System.Windows.Forms.Padding(2);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(98, 20);
            this.text_password.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "age:";
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(117, 113);
            this.text_username.Margin = new System.Windows.Forms.Padding(2);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(98, 20);
            this.text_username.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "UserName:";
            // 
            // text_phone
            // 
            this.text_phone.Location = new System.Drawing.Point(117, 68);
            this.text_phone.Margin = new System.Windows.Forms.Padding(2);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(98, 20);
            this.text_phone.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "phone:";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(117, 91);
            this.text_email.Margin = new System.Windows.Forms.Padding(2);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(152, 20);
            this.text_email.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "E-mail:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(117, 45);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(98, 20);
            this.txt_LastName.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "LastName:";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(117, 20);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(98, 20);
            this.txt_FirstName.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "FirstName:";
            // 
            // cbsearch
            // 
            this.cbsearch.FormattingEnabled = true;
            this.cbsearch.Location = new System.Drawing.Point(176, 36);
            this.cbsearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbsearch.Name = "cbsearch";
            this.cbsearch.Size = new System.Drawing.Size(92, 21);
            this.cbsearch.TabIndex = 70;
            this.cbsearch.SelectedIndexChanged += new System.EventHandler(this.cbsearch_SelectedIndexChanged);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(487, 532);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbcity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbusertype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbsearch;
    }
}
