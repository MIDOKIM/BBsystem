using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BBsystem
{
    public partial class home : Form
    {
        User donor ;

        public home(User donn)
        {
            donor = donn;
            InitializeComponent();
        }

        public void home_Load(object sender, EventArgs e)
        {
            if (Start.connection.State.Equals(ConnectionState.Closed))
            {
                Start.connection.Open();
            }
            if (donor.usertype == 1)
                pictureBox7.Hide();
            if (donor.usertype != 3)
                pictureBox8.Hide();
            else
                pictureBox8.Show();
            this.label4.Text = donor.fName;
            switch (donor.bloodtype)
            {
                case 0:
                    this.pictureBox2.Image = global::BBsystem.Properties.Resources.ap;
                    break;
                case 1:
                    this.pictureBox2.Image = global::BBsystem.Properties.Resources.an;
                    break;
                case 2:
                    this.pictureBox2.Image = global::BBsystem.Properties.Resources.bp;
                    break;
                case 3:
                    this.pictureBox2.Image = global::BBsystem.Properties.Resources.bn;
                    break;
                case 4:
                    this.pictureBox2.Image = global::BBsystem.Properties.Resources.op;
                    break;
                case 5:
                    this.pictureBox2.Image = global::BBsystem.Properties.Resources.on;
                    break;
                case 6:
                    this.pictureBox2.Image = global::BBsystem.Properties.Resources.abp;
                    break;
                case 7:
                    this.pictureBox2.Image = global::BBsystem.Properties.Resources.abn;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Start.connection.Close();
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var message = "Do you want to Log Out?";
            var title = "Log Out";
            var buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                donor.delete();
                var form1 = (LogIn)Tag;
                form1.Show();
                Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }
        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var vwprfl = new ViewProfile(donor);
            vwprfl.Tag = this;
            vwprfl.Show(this);
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var form2 = new ViewRequest(donor);
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var form2 = new ContactUs(donor);
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var admnpnl = new AdminPanel {Tag = this};
            Hide();
            admnpnl.ShowDialog(this);
            Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var vwdon = new ViewDonations(donor) {Tag = this};
            vwdon.Show(this);
            Hide();
        }
    }
}
