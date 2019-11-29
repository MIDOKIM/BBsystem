using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBsystem
{
    enum City
    {
        Alexandria,
        Cairo,
        Asyut,
        Suez,
        Faiyum,
        Matruh,
        Qena,
        Portsaid,
        Gharbia,
        Giza,
        Ismailia,
        Minya
    }
    public partial class ViewProfile : Form
    {
        User donor;
        public ViewProfile(User don)
        {
            donor = don;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
            foreach (var textBox in this.Controls.OfType<TextBox>())
                textBox.ReadOnly = true;
            comboBox1.Enabled = false;

            var cmd = new SqlCommand("SELECT * FROM [USER] where userid="+donor.userid, Start.connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = donor.fName;
                textBox8.Text = donor.lName;
                textBox2.Text = donor.phone;
                comboBox1.Text= donor.city;
                textBox5.Text = donor.age.ToString();
                textBox6.Text = donor.bloodtype.ToString();
                textBox7.Text = donor.gender.ToString();
                textBox4.Text = donor.email;
                textBox10.Text = donor.username;
                textBox9.Text = donor.password;
                       
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var textBox in this.Controls.OfType<TextBox>())
                textBox.ReadOnly = false;
            comboBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("UPDATE [USER] SET password='" + textBox9.Text + "'" + " WHERE userid=" + donor.userid, Start.connection);
            var reader = cmd.ExecuteReader();
            reader.Close();
            var cmd1 = new SqlCommand("UPDATE [USER] SET phone='" + textBox2.Text + "'" + " WHERE userid=" + donor.userid, Start.connection);
            var reader1 = cmd1.ExecuteReader();
            reader1.Close();
            var cmd2 = new SqlCommand("UPDATE [USER] SET age='" + textBox5.Text + "'" + " WHERE userid=" + donor.userid, Start.connection);
            var reader2 = cmd2.ExecuteReader();
            reader2.Close();
            var cmd3 = new SqlCommand("UPDATE [USER] SET email='" + textBox4.Text + "'" + " WHERE userid=" + donor.userid, Start.connection);
            var reader3 = cmd3.ExecuteReader();
            reader3.Close();
             donor.fName= textBox1.Text;
             donor.lName= textBox8.Text;
            donor.phone = textBox2.Text;
             donor.city= comboBox1.Text;
             donor.age = Convert.ToInt32(textBox5.Text);
             donor.bloodtype=Convert.ToByte(textBox6.Text);
             donor.gender= Convert.ToChar(textBox7.Text);
            donor.email= textBox4.Text;
            donor.username= textBox10.Text;
            donor.password=textBox9.Text ;
            MessageBox.Show("Info Saved");
            Form1_Load(sender, e);
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
            start.home_Load(sender, e);
            Close();
        }

        private void ViewProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void ViewProfile_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

    }
}
