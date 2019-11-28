namespace BBsystem
{
    partial class UserControl3
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbsearch = new System.Windows.Forms.ComboBox();
            this.m1 = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.u1 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Sybject Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(234, 381);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbsearch
            // 
            this.cbsearch.FormattingEnabled = true;
            this.cbsearch.Location = new System.Drawing.Point(359, 62);
            this.cbsearch.Name = "cbsearch";
            this.cbsearch.Size = new System.Drawing.Size(121, 21);
            this.cbsearch.TabIndex = 13;
            this.cbsearch.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // m1
            // 
            this.m1.Location = new System.Drawing.Point(348, 222);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(300, 200);
            this.m1.TabIndex = 96;
            this.m1.Text = " ";
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Location = new System.Drawing.Point(348, 181);
            this.e1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(13, 13);
            this.e1.TabIndex = 95;
            this.e1.Text = "  ";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(272, 222);
            this.message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(53, 13);
            this.message.TabIndex = 94;
            this.message.Text = "Message:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(272, 181);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 93;
            this.email.Text = "E-mail:";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(272, 106);
            this.fname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(58, 13);
            this.fname.TabIndex = 97;
            this.fname.Text = "First name:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(272, 142);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(58, 13);
            this.username.TabIndex = 98;
            this.username.Text = "Username:";
            // 
            // u1
            // 
            this.u1.AutoSize = true;
            this.u1.Location = new System.Drawing.Point(348, 142);
            this.u1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.u1.Name = "u1";
            this.u1.Size = new System.Drawing.Size(13, 13);
            this.u1.TabIndex = 99;
            this.u1.Text = "  ";
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Location = new System.Drawing.Point(350, 106);
            this.f1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(10, 13);
            this.f1.TabIndex = 100;
            this.f1.Text = " ";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.f1);
            this.Controls.Add(this.u1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cbsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(834, 568);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbsearch;
        private System.Windows.Forms.Label m1;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label u1;
        private System.Windows.Forms.Label f1;
    }
}
