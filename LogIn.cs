using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BBsystem
{
    //kooooo
    public partial class LogIn : Form
    {
        private readonly User donor;
        public LogIn() { 
            InitializeComponent();
            donor = new User();
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if(Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Start.connection.Close();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var start = (Start)Tag;
            start.Show();
            Close();
        }

        private void Form7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.connection.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
            var query = "select count(*)from [user] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
            var command = new SqlCommand(query, Start.connection);
            var x = Convert.ToInt32(command.ExecuteScalar());
            if (x == 0) { 
                MessageBox.Show("wrong email or password");
                textBox1.Focus();
                return;
            }

            query = "select * from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
            command = new SqlCommand(query, Start.connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                donor.username = textBox1.Text;
                donor.password = textBox2.Text;
                donor.email= reader["email"].ToString();
                donor.fName = reader["FirstName"].ToString();
                donor.lName = reader["LastName"].ToString();
                donor.usertype = (int)reader["usertype"];
                donor.userid= (int)reader["userID"];
                donor.bloodtype = (byte) reader["BloodType"];
                donor.phone= reader["phone"].ToString();
                donor.city= reader["city"].ToString();
                donor.gender = Convert.ToChar(reader["gender"]);
                donor.age = (int)reader["age"];

            }
            reader.Close();
            if(donor.userid!=3)
                MessageBox.Show("welcome Back "+donor.fName);
            else
                MessageBox.Show("welcome Back Admin");


            var form5 = new home(donor);
            form5.Tag = this;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox1.Focus();
            form5.Show(this);
            Hide();
            /*  else {

                  MessageBox.Show("welcome");
                  donor.username = textBox1.Text;
                  donor.password = textBox2.Text;
                  query = "select usertype from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.usertype = reader.GetInt32(0);
                  }
                  reader.Close();
                  query = "select userID from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.userid = reader.GetInt32(0);
                  }
                  reader.Close();
                  query = "select bloodtype from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.bloodtype = reader.GetByte(0);
                  }
                  reader.Close();
                  query = "select FirstName from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.fName = reader.GetString(0);
                  }
                  reader.Close();
                  query = "select LastName from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.lName = reader.GetString(0);
                  }
                  reader.Close();
                  query = "select phone from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.phone = reader.GetString(0);
                  }
                  reader.Close();
                  query = "select city from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.city = reader.GetString(0);
                  }
                  reader.Close();
                  query = "select email from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.email = reader.GetString(0);
                  }
                  reader.Close();
                  query = "select gender from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.gender = reader.GetByte(0);
                  }
                  reader.Close();
                  query = "select age from [User] where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                  command = new SqlCommand(query, Start.connection);
                  reader = command.ExecuteReader();
                  while (reader.Read())
                  {
                      donor.age = reader.GetInt32(0);
                  }
                  reader.Close();
                  home form5 = new home(donor);
                  form5.Tag = this;
                  textBox1.Text = null;
                  textBox2.Text = null;
                  textBox1.Focus();
                  form5.Show(this);
                  Hide();

              }*/
        }

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox3_Click(sender,e);
            }
        }

    }
    public class User
    {
        public int usertype, userid,age;
        public byte bloodtype;
        public char gender;
        public string fName,lName,phone,city,email,username,password;
        public void delete()
        {
            usertype = userid = age = 0;
            bloodtype =0;
            gender = ' ';
        }
      public User()
        {
            usertype = userid = age = 0;
            bloodtype =  0;
            gender = ' ';

        }
    }
}
