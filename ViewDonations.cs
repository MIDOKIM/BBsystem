using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BBsystem
{
    public partial class ViewDonations : Form
    {
         User donor;

        public ViewDonations(User don)
        {
            InitializeComponent();
            donor = don;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
            LoadAll();
        }
        private void LoadAll()
        {
            var command = $"SELECT B.BloodName BloodType,U.gender,U.age,U.city,D.donatedate FROM DonationRequest as D INNER JOIN[User] as U ON U.userID = D.donorid INNER JOIN bloodID as B ON D.bloodtype = B.bloodTypeID ";
            if (donor.usertype == 2)
                command += " WHERE completed=1";
            command += " order by donatedate asc";
            using (var cmd = new SqlCommand(command, Start.connection))
            {
                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable("Requests");
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;
            var BloodType = Convert.ToInt32(Enum.Parse(typeof(bloodtype), comboBox1.Text.Replace("+", "Positive").Replace("-", "Negative")));
            var command =
                   $"SELECT B.BloodName BloodType,U.gender,U.age,U.city,D.donatedate FROM DonationRequest as D INNER JOIN[User] as U ON U.userID = D.donorid INNER JOIN bloodID as B ON D.bloodtype = B.bloodTypeID WHERE D.bloodtype = {BloodType}";
            if (donor.usertype == 2)
                command += " AND completed=1";
            command += " order by donatedate asc";
            using (var cmd = new SqlCommand(command, Start.connection))
            {
                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable("Requests");
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            LoadAll();
        }
    }
}
