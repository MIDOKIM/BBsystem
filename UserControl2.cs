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

    public partial class UserControl2 : UserControl
    {

        private static UserControl2 _instance;
        public static UserControl2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl2();
                return _instance;
            }
        }
        public UserControl2()
        {
            InitializeComponent();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update [User] set FirstName='" + txt_FirstName.Text + "' ,LastName='" + txt_LastName.Text + "',phone='" + text_phone.Text + "' ,city='" + cbcity.Text + "',age=" + text_age.Text + ",email='" + text_email.Text + "',username='" + text_username.Text + "',password='" + text_password.Text + "',usertype=" + cbusertype.Text + " where username='" + cbsearch.Text + "'";
            cmd.ExecuteNonQuery();
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            text_phone.Text = "";
            text_email.Text = "";
            text_username.Text = "";
            text_password.Text = "";
            text_age.Text = "";
            cbcity.Text = "";

            
            cc();

            MessageBox.Show("record is updated successfully!");

        }
        public void cc()
        {
            cbsearch.Items.Clear();
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * From [User]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbsearch.Items.Add(dr["username"].ToString());
            }

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
            cc();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from [User] where username='" + cbsearch.Text + "'";
            cmd.ExecuteNonQuery();
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            text_phone.Text = "";
            text_email.Text = "";
            text_username.Text = "";
            text_password.Text = "";
            text_age.Text = "";
            cbcity.Text = "";

            cc();


            MessageBox.Show("record is deleted successfully!");

        }




        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * From [User] where username='" + cbsearch.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {

                txt_FirstName.Text = (dr["FirstName"].ToString());
                txt_LastName.Text = (dr["LastName"].ToString());
                text_phone.Text = (dr["phone"].ToString());
                text_email.Text = dr["email"].ToString();
                text_username.Text = dr["username"].ToString();
                text_password.Text = dr["password"].ToString();
                text_age.Text = dr["age"].ToString();
                cbcity.Text = dr["city"].ToString();
                cbusertype.Text = dr["usertype"].ToString();


            }
        }
        
    }
}

