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
    public partial class UserControl3 : UserControl

    {
        private static UserControl3 _instance;
        public static UserControl3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl3();
                return _instance;
            }

        }
        DataTable dbdataset;
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
            cc();
            SqlCommand cmd = new SqlCommand("select subject,recivedate from contactMSG ORDER BY recivedate DESC;", Start.connection);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                 dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cc()
        {
            cbsearch.Items.Clear();
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * From contactMSG";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbsearch.Items.Add(dr["subject"].ToString());
                
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * From contactMSG where msgID='" + (cbsearch.SelectedIndex+1) + "'";
            SqlCommand cl = Start.connection.CreateCommand();
           
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                e1.Text = dr["email"].ToString();
                m1.Text = dr["message"].ToString();
                f1.Text = dr["fname"].ToString();
                cl.CommandType = CommandType.Text;
                cl.CommandText = "Select* from [User] where email = '" + e1.Text + "'";
                SqlDataAdapter d = new SqlDataAdapter("Select email from [User] where email='" + e1.Text + "'", Start.connection);
                DataTable t = new DataTable();
                d.Fill(t);
                if (t.Rows.Count > 0)
                {
                    SqlDataReader readd = cl.ExecuteReader();
                    if (readd.Read())
                    {
                        u1.Text = (readd["username"].ToString());
                    }
                    readd.Close();
                }
                else

                {
                    u1.Text = "not registed";
                }
            }
        }
    }
}
