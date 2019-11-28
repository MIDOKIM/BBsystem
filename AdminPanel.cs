using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBsystem
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            panel1.Controls.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl1.Instance))
            {
            }
            else
                UserControl1.Instance.BringToFront();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl2.Instance))
            {
                panel1.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
                UserControl2.Instance.BringToFront();

            }
            else
                UserControl2.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl4.Instance))
            {
                panel1.Controls.Add(UserControl4.Instance);
                UserControl4.Instance.Dock = DockStyle.Fill;
                UserControl4.Instance.BringToFront();

            }
            else
                UserControl4.Instance.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if (!panel1.Controls.Contains(UserControl3.Instance))
            {
                var con = UserControl3.Instance;
                panel1.Controls.Add(con);
                con.Dock = DockStyle.Fill;
                con.BringToFront();

            }
            else
                UserControl3.Instance.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Start.connection.Close();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminPanel_Load(sender, e);
            home home = (home)Tag;
                home.Show();
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
        }

    }
}
