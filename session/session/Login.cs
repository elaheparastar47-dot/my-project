using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session
{
    public partial class Login : Form
    {
        List<string> str = new List<string>();
        string PanelValue;
        AirPlaneEntities1 _context = new AirPlaneEntities1();
        int i;
        int sec = 30;
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lockEndTime > DateTime.Now)
            {
                UsrTXT.Enabled = false;
                PassTXT.Enabled = false;
                EmailTXT.Enabled = false;
                CodeTXT.Enabled = false;
                codebtn.Enabled = false;
                logbtn.Enabled = false;
                timer_login.Enabled = true;
            }
        }

        Image[] capcha(int input)
        {
            Bitmap bitmap = new Bitmap(CodeP.Width, CodeP.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(BackColor);
            Random random = new Random();
            string rand = "";
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
            Pen pen = new Pen(Color.FromArgb(255, random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
            char[] list = "qwertyuiopasdfghjklzxcvbnm1234567890QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();
            for (int i = 0; i < 6; i++)
            {
                rand += list[random.Next(0, 60)];
            }
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 16);
            graphics.DrawString(rand, font, solidBrush, 50, 20);
            byte[] buffer = new byte[rand.Length];
            int y = 0;
            foreach (var item in rand.ToCharArray())
            {
                buffer[y] = (byte)item;
                y++;
            }
            MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider();
            string s = BitConverter.ToString(mD5.ComputeHash(buffer)).Replace("-", "");
            str.Add(s);
            for (int i = 0; i < 6; i++)
            {
                int j = random.Next(0, 3);
                if (j == 0)
                {
                    graphics.DrawEllipse(pen, random.Next(0, 125), random.Next(0, 95), random.Next(0, 125), random.Next(0, 95));
                }
                else if (j == 1)
                {
                    graphics.DrawRectangle(pen, random.Next(0, 125), random.Next(0, 95), random.Next(0, 125), random.Next(0, 95));
                }
                else if (j == 2)
                {
                    graphics.DrawLine(pen, random.Next(0, 125), random.Next(0, 95), random.Next(0, 125), random.Next(0, 95));
                }
                pen.Color = Color.FromArgb(255, random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            }
            PanelValue = rand;
            Graphics graphics1 = CodeP.CreateGraphics();
            graphics1.DrawImage(bitmap, 0, 0);
            return null;
        }

        private void CodeP_Paint(object sender, PaintEventArgs e)
        {
            capcha(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capcha(0);
        }

        private void UsrTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            string ustxt = UsrTXT.Text;
            string pastxt = function.funMD5(PassTXT.Text);
            if (UsrTXT.Text == "" && PassTXT.Text == "")
            {
                Register register = new Register();
                register.ShowDialog();
                return;
            }
            var ch = _context.Users.FirstOrDefault(u => u.UserName == ustxt && u.Passwords == pastxt);
            if (ch != null)
            {
                var email = _context.Users.FirstOrDefault(EM => EM.Email == EmailTXT.Text);
                if (email != null)
                {
                    if (PanelValue == CodeTXT.Text)
                    {
                        AirPlaneForm airPlane = new AirPlaneForm();
                        airPlane.ShowDialog();

                        Log log = new Log();
                        log.UserName = ustxt;
                        log.Action = "login";
                        log.ActionTime = DateTime.Now;
                        _context.Logs.Add(log);
                        _context.SaveChanges();
                        this.Close();
                        sessionC.CurrnetUserName = ustxt;
                    }
                    else
                    {
                        MessageBox.Show("کدامنیتی شما نادرست است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        capcha(0);

                    }
                }
                else
                {
                    MessageBox.Show("ایمیل شما نادرست است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if ((UsrTXT.Text == "Admin") && (PassTXT.Text == "Admin" || PassTXT.Text == function.funMD5("Admin")))
            {
                AdminPage admin = new AdminPage();
                admin.ShowDialog();
                this.Close();
            }
            else if (ch == null)
            {
                var airline = _context.Airlines.FirstOrDefault(u => u.UserName == ustxt && u.Password == pastxt);
                if (airline != null)
                {

                    var email = _context.Airlines.FirstOrDefault(EM => EM.Email == EmailTXT.Text);
                    if (email != null)
                    {
                        if (PanelValue == CodeTXT.Text)
                        {
                            pilot_and_flight_attendant pilot = new pilot_and_flight_attendant();
                            pilot.ShowDialog();

                            Log log = new Log();
                            log.UserName = ustxt;
                            log.Action = "login";
                            log.ActionTime = DateTime.Now;
                            _context.Logs.Add(log);
                            _context.SaveChanges();
                            this.Close();
                            sessionC.CurrnetUserName = ustxt;
                        }
                        else
                        {
                            MessageBox.Show("کدامنیتی شما نادرست است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            capcha(0);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ایمیل شما نادرست است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (!(UsrTXT.Text == "" && PassTXT.Text == "") || (ch == null) || (airline == null))
                {
                    MessageBox.Show("رمز یا نام کاربری شما نادرست است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    i++;
                    PassTXT.Text = "";
                    UsrTXT.Text = "";
                }
            }

            if (i > 2)
            {
                MessageBox.Show("لطفا 30 ثانیه صبر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UsrTXT.Enabled = false;
                PassTXT.Enabled = false;
                EmailTXT.Enabled = false;
                CodeTXT.Enabled = false;
                codebtn.Enabled = false;
                logbtn.Enabled = false;
                timer_login.Enabled = true;
                Properties.Settings.Default.lockEndTime = DateTime.Now.AddSeconds(30);
                Properties.Settings.Default.Save();

            }



        }

        private void timer_login_Tick(object sender, EventArgs e)
        {
            if (timer_login.Enabled == true)
            {

                if (Properties.Settings.Default.lockEndTime > DateTime.Now)
                {
                    TimeSpan time = Properties.Settings.Default.lockEndTime - DateTime.Now;
                    sec -= 1;
                    seclbl.Text = sec.ToString();
                    sec = (int)time.TotalSeconds;
                    seclbl.Text = $"ثانیه باقی مانده:{sec}لطفا صبر کنید";

                }
                else
                {
                    seclbl.Text = "";
                    UsrTXT.Enabled = true;
                    PassTXT.Enabled = true;
                    EmailTXT.Enabled = true;
                    CodeTXT.Enabled = true;
                    codebtn.Enabled = true;
                    logbtn.Enabled = true;
                    timer_login.Enabled = false;
                    i = 0;
                }


            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (!(UsrTXT.Text == ""))
            {
                var ch = _context.Users.FirstOrDefault(n => n.UserName == UsrTXT.Text);
                var ch1 = _context.Airlines.FirstOrDefault(n => n.UserName == UsrTXT.Text);
                if (ch != null || ch1 != null)
                {
                    Log log = new Log();
                    log.UserName = UsrTXT.Text;
                    log.Action = "logout";
                    log.ActionTime = DateTime.Now;
                    _context.Logs.Add(log);
                    _context.SaveChanges();
                    Main main = new Main();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("کاربر وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UsrTXT.Text = "";
                }

            }
            else
            {
                MessageBox.Show("لطفا اول نام کاربری خود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked == true)
            {
                PassTXT.PasswordChar = '\0';
            }
            else
            {
                PassTXT.PasswordChar = '*';
            }
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            UsrTXT.Text = "";
            PassTXT.Text = "";
            EmailTXT.Text = "";
            CodeTXT.Text = "";
            codebtn.Text = "";
            capcha(0);

        }
    }
}
