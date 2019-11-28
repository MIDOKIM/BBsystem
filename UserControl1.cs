using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBsystem
{

    public partial class UserControl1 : UserControl
    {
        private static UserControl1 _instance;
        public static UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }

        }
        public UserControl1()
        {
            InitializeComponent();
        }

     
    private void button1_Click(object sender, EventArgs e)
        {
          
                int gender;
                if (rbfemale.Checked)
                { gender = 1; } else { gender = 2; }

                string q = $"INSERT INTO [User] VALUES ('{txt_FirstName.Text}','{txt_LastName.Text}','{text_phone.Text}','{cbcity.Text}',{text_age.Text},{cbbloodtype.Text},{gender},'{text_email.Text}','{text_username.Text}','{text_password.Text}',{cbusertype.Text},GETDATE());";
                SqlCommand cmd = new SqlCommand(q, Start.connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The values has inserted");

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
        }
    }
}
    