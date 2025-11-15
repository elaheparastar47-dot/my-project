using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session
{
    public partial class Main : Form
    {
        AirPlaneEntities1 _context = new AirPlaneEntities1();
        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Start();
            Time.Text = DateTime.Now.ToString("HH:mm:ss");
            Date.Text = DateTime.Now.ToString("yyyy:MMM:dd");

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void Ebtn_Click(object sender, EventArgs e)
        {
            var pass = _context.Users.ToList();

            foreach (var item in pass)
            {
                string passP = item.Passwords;
                item.Passwords = function.funMD5(passP);
            }
            _context.SaveChanges();

        }
    }
}
