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
    public partial class UserControl4 : UserControl
    {
        private static UserControl4 _instance;
        public static UserControl4 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl4();
                return _instance;
            }
        }



        public UserControl4()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlselectquery = " SELECT * FROM DonationRequest WHERE requestId=" + int.Parse( Id.Text ) ;
            SqlCommand cmd = new SqlCommand(sqlselectquery, Start.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                donorid.Text = (dr["donorId"].ToString());
               bloodtype.Text = (dr["bloodtype"].ToString());

            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update DonationRequest set completed='" + cbcom.Text + "' WHERE requestId=" + int.Parse(Id.Text);
            cmd.ExecuteNonQuery();
            if (cbcom.SelectedItem.ToString()=="1")
            {
                cmd.CommandText = "update DonationRequest  set donatedate=GETDATE() WHERE requestId=" + int.Parse(Id.Text);
            }

            cmd.ExecuteNonQuery();
            cbcom.Text = "";

            MessageBox.Show("record is updated successfully!");
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
        }
    }
}
