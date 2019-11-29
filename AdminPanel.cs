using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBsystem
{
    public partial class AdminPanel : Form
    {
        DataTable dbdataset;
        public AdminPanel()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Start.connection.Close();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var start = (home)Tag;
            start.Show();
            Close();
        }

        private void AdminPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void AdminPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void AdminPanel_Load(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand c = new SqlCommand("select username,email,registerdate from [user] ORDER BY registerdate DESC;", Start.connection);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = c;
                DataTable tb = new DataTable();
                da.Fill(tb);
                BindingSource source = new BindingSource();
                source.DataSource = tb;
                dataGridView2.DataSource = source;
                da.Update(tb);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            
            if (Start.connection.State == System.Data.ConnectionState.Open)
            {
                if ((txt_FirstName.Text == "") || (txt_LastName.Text == "") || (text_email.Text == "") || (text_username.Text == "") || (text_password.Text == "") || (text_age.Text == "")  || (cbbloodtype.Text == "") || (cbusertype.Text == ""))
                {
                    MessageBox.Show("Please enter all the information required!");
                }
                int gender;
                if (rbfemale.Checked)
                { gender = 1; }
                else { gender = 2; }

                string q = $"INSERT INTO [User] VALUES ('{txt_FirstName.Text}','{txt_LastName.Text}','{text_phone.Text}','{cbcity.Text}',{text_age.Text},{cbbloodtype.Text},{gender},'{text_email.Text}','{text_username.Text}','{text_password.Text}',{cbusertype.Text},GETDATE());";
                SqlCommand cmd = new SqlCommand(q, Start.connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The values has inserted");
            }

          
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            text_phone.Text = "";
            text_email.Text = "";
            text_username.Text = "";
            text_password.Text = "";
            text_age.Text = "";
            cbcity.Text = "";
            cbbloodtype.Text = "";
            cbusertype.Text = "";
        }

        private void remove_Click(object sender, EventArgs e)
        {

            
            SqlDataAdapter d = new SqlDataAdapter("Select username from [User] where username='" + usertxt.Text + "'", Start.connection);
            DataTable t = new DataTable();
            d.Fill(t);
            if (t.Rows.Count == 0)
            {
                MessageBox.Show("please enter a valid username!");


            }
            else
            {
                SqlCommand cmd = Start.connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete from [User] where username='" + usertxt.Text + "'";
                cmd.ExecuteNonQuery();

                Fn.Text = "";
                ln.Text = "";
                phone.Text = "";
                mail.Text = "";
                usernam.Text = "";
                password.Text = "";
                age.Text = "";
                city.Text = "";
                usertxt.Text = "";
                usertype.Text = "";



                MessageBox.Show("record is deleted successfully!");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

          
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update [User] set FirstName='" + Fn.Text + "' ,LastName='" + ln.Text + "',phone='" +phone.Text + "' ,city='" + city.Text + "',age=" + age.Text + ",email='" + mail.Text + "',username='" + usernam.Text + "',password='" + password.Text + "',usertype=" + usertype.Text + " where username='" + usertxt.Text + "'";
            cmd.ExecuteNonQuery();
            Fn.Text = "";
            ln.Text = "";
            phone.Text = "";
            mail.Text = "";
            usernam.Text = "";
            password.Text = "";
            age.Text = "";
            city.Text = "";
            usertype.Text = "";
            MessageBox.Show("record is updated successfully!");
        }

        private void search_Click(object sender, EventArgs e) { 
        

            string sqlselectquery = "select * From [User] where username='" + usertxt.Text.ToString() + "'";
            SqlDataAdapter d = new SqlDataAdapter("Select username from [User] where username='" + usertxt.Text + "'", Start.connection);
            DataTable t = new DataTable();
            d.Fill(t);
            if (t.Rows.Count == 0)
            {
                MessageBox.Show("Please enter a valid username!");
             
            }
            else
            {
                SqlCommand cmd = new SqlCommand(sqlselectquery, Start.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Fn.Text = (dr["FirstName"].ToString());
                    ln.Text = (dr["LastName"].ToString());
                    phone.Text = (dr["phone"].ToString());
                    mail.Text = dr["email"].ToString();
                    usernam.Text = dr["username"].ToString();
                    password.Text = dr["password"].ToString();
                    age.Text = dr["age"].ToString();
                    city.Text = dr["city"].ToString();
                    usertype.Text = dr["usertype"].ToString();

                    dr.Close();
                }
            }
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

            Fn.Text = "";
            ln.Text = "";
            phone.Text = "";
            mail.Text = "";
            usernam.Text = "";
            password.Text = "";
            age.Text = "";
            city.Text = "";
            usertype.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
         
            SqlDataAdapter dadapter = new SqlDataAdapter("Select requestId from [DonationRequest] where requestId=" + int.Parse(Id.Text), Start.connection);
            DataTable t = new DataTable();
            dadapter.Fill(t);
            if (t.Rows.Count == 0)
            {
                MessageBox.Show("Please enter a valid ID!");


            }
            else
            {
                string sqlselectquery = " SELECT * FROM DonationRequest WHERE requestId=" + int.Parse(Id.Text);
                SqlCommand cmd = new SqlCommand(sqlselectquery, Start.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    donorid.Text = (dr["donorId"].ToString());
                    bloodtype.Text = (dr["bloodtype"].ToString());
                    redate.Text = (dr["requestdate"].ToString());
                    complete.Text = (dr["completed"].ToString());

                }
                dr.Close();
                SqlCommand cm = Start.connection.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = " SELECT * FROM [user] WHERE UserID=" + int.Parse(donorid.Text);
                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);

                foreach (DataRow d in dt.Rows)
                {

                    username.Text = d["username"].ToString();


                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update DonationRequest set completed='" + cbcom.Text + "' WHERE requestId=" + int.Parse(Id.Text);
            cmd.ExecuteNonQuery();
            if (cbcom.SelectedItem.ToString() == "1")
            {
                cmd.CommandText = "update DonationRequest  set donatedate=GETDATE() WHERE requestId=" + int.Parse(Id.Text);
            }

            cmd.ExecuteNonQuery();

            cbcom.Text = "";

            MessageBox.Show("record is updated successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter dadapter = new SqlDataAdapter("Select requestId from [DonationRequest] where requestId=" + int.Parse(Id.Text), Start.connection);
            DataTable t = new DataTable();
            dadapter.Fill(t);
            if (t.Rows.Count == 0)
            {
                MessageBox.Show("please enter a valid ID!");


            }
            else
            {
                SqlCommand cmd = Start.connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete from DonationRequest where requestId=" + int.Parse(Id.Text);
                cmd.ExecuteNonQuery();

                donorid.Text = "";
                bloodtype.Text = "";
                redate.Text = "";
                complete.Text = "";
                username.Text = "";
                Id.Text = "";



                MessageBox.Show("record is deleted successfully!");
            }
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {
            donorid.Text = "";
            bloodtype.Text = "";
            redate.Text = "";
            complete.Text = "";
            username.Text = "";
        }

        private void cbcom_SelectedIndexChanged(object sender, EventArgs e)
        {
            complete.Text = cbcom.Text;
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

        private void Contact_Click(object sender, EventArgs e)
        {

        }

        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = Start.connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * From contactMSG where msgID='" +( cbsearch.SelectedIndex+1) + "'";
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
