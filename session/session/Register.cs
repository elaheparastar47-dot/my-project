using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace session
{
    public partial class Register : Form
    {
        AirPlaneEntities1 _context = new AirPlaneEntities1();

        public Register()
        {
            InitializeComponent();
        }

        private void Utxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            string user = Utxt.Text;
            string pass = Ptxt.Text;
            string pattern = @"^\w{3,}@[a-zA-z0-9]{2,}\.com$";
            string EmailT = etxt.Text;
            string[] path = Btxt.Text.Split('/');
            int year = 0, month = 0, day = 0;
            var US = _context.Users.FirstOrDefault(u => u.UserName == user);

            try
            {
                try
                {
                    if (path.Length != 3 && !(Btxt.Text == ""))
                    {
                        MessageBox.Show("روش صحیح ورود تاریخ تولد برای مثال:1386/08/04", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((!int.TryParse(path[0], out year) || !int.TryParse(path[1], out month) || !int.TryParse(path[2], out day)) && !(Btxt.Text == ""))
                    {
                        MessageBox.Show("اعداد وارد شده معتبر نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    PersianCalendar persian = new PersianCalendar();

                    DateTime dateTime = persian.ToDateTime(year, month, day, 0, 0, 0, 0);
                    int age = DateTime.Now.Year - dateTime.Year;

                    if (DateTime.Now.Month < dateTime.Month || (DateTime.Now.Day < dateTime.Day))
                    {
                        age--;
                    }
                    if (age < 18 && !(Btxt.Text == ""))
                    {
                        MessageBox.Show("سن شما باید حداقل 18 سال باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch
                {
                    if (!(Btxt.Text == ""))
                    {
                        MessageBox.Show("تاریخ تولد وارد شده معتبر نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (Utxt.Text == "")
                {
                    Utxt.BackColor = Color.Red;
                }
                if (Ptxt.Text == "")
                {
                    Ptxt.BackColor = Color.Red;

                }
                if (Ntxt.Text == "")
                {
                    Ntxt.BackColor = Color.Red;

                }
                if (Ftxt.Text == "")
                {
                    Ftxt.BackColor = Color.Red;

                }
                if (etxt.Text == "")
                {
                    etxt.BackColor = Color.Red;

                }
                if (PassAgain.Text == "")
                {
                    PassAgain.BackColor = Color.Red;
                }
                if (Btxt.Text == "")
                {
                    Btxt.BackColor = Color.Red;
                }
                else if (US != null && !(Utxt.Text == ""))
                {
                    MessageBox.Show("لطفا نام کاربری دیگری انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Utxt.Text = "";
                }
                else if (user.Length < 5)
                {
                    MessageBox.Show("لطفا نام کاربری دیگری انتخاب کنید که بیشتر از 5 حرف باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Utxt.Text = "";
                }
                else if (!(Regex.IsMatch(EmailT, pattern)) && !(etxt.Text == ""))
                {
                    MessageBox.Show("ایمیل شما معتبر نیست لطفا ایمیل معتبر وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.Text = "";
                }
        
                else if (pass.Length < 8 && !(Ptxt.Text == ""))
                {
                    MessageBox.Show("لطفا نام پسورد دیگری انتخاب کنید که بیشتر از 8 حرف باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Ptxt.Text = "";
                    PassAgain.Text = "";
                }
                else if (ch_passnum(pass) && !(Ptxt.Text == ""))
                {
                    MessageBox.Show("در رمز اعداد پشت سر هم وارد شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Ptxt.Text = "";
                    PassAgain.Text = "";
                }
                else if (ch_passchar(pass) && !(Ptxt.Text == ""))
                {
                    MessageBox.Show("در رمز الگوی تکراری وارد شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Ptxt.Text = "";
                    PassAgain.Text = "";
                }
                else if (!(Ptxt.Text == PassAgain.Text) && !(Ptxt.Text == "") && !(PassAgain.Text == ""))
                {
                    MessageBox.Show("رمز تکراری درست وارد نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Ptxt.Text = "";
                    PassAgain.Text = "";
                }
                else if (pictureP.Tag == null || string.IsNullOrWhiteSpace(pictureP.Tag.ToString()))
                {
                    MessageBox.Show("لطفا عکس خود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    user1.UserName = Utxt.Text;
                    user1.firstName = Ntxt.Text;
                    user1.LastName = Ftxt.Text;
                    user1.Email = etxt.Text;
                    user1.Birthday = Btxt.Text;
                    user1.Passwords = function.funMD5(Ptxt.Text);
                    user1.img = File.ReadAllBytes(pictureP.Tag.ToString());
                    _context.Users.Add(user1);
                    _context.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("اطلاعات با موفقیت ثبت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Ptxt_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Ptxt_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void Ptxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control&&(e.KeyCode==Keys.C|| e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Ptxt.ContextMenu = new ContextMenu();
            PassAgain.ContextMenu = new ContextMenu();

        }

        bool ch_passnum(string input)
        {
            for (int i = 0; i < input.Length-1; i++)
            {
                if (char.IsDigit(input[i]) && char.IsDigit(input[i + 1]))
                {
                    int c = input[i] - '0';
                    int next = input[i + 1] - '0';
                    if (next == c + 1 || next == c - 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool ch_passchar(string input)
        {
            for (int len = 2; len < input.Length / 2; len++)
            {
                for (int i = 0; i < input.Length - len; i++)
                {
                    string sub = input.Substring(i, len);
                    int index = 0;
                    int count = 0;
                    while ((index = input.IndexOf(sub, index)) != -1)
                    {
                        
                        count++;
                        index += 1;
                        if (count >= 2)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void airlinebtn_Click(object sender, EventArgs e)
        {
            AirlineRegister airlineRegister = new AirlineRegister();
            airlineRegister.ShowDialog();
        }

        private void PassAgain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void ppicbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.png;*.jpg;*.bmp";

            if (openFile.ShowDialog()==DialogResult.OK)
            {
                pictureP.Image = Image.FromFile(openFile.FileName);
                pictureP.Tag = openFile.FileName;
            }
        }

        private void show1_CheckedChanged(object sender, EventArgs e)
        {
            if (show1.Checked==true)
            {
                Ptxt.PasswordChar = '\0';
            }
            else
            {
                Ptxt.PasswordChar = '*';
            }
        }

        private void show2_CheckedChanged(object sender, EventArgs e)
        {
            if (show2.Checked == true)
            {
                PassAgain.PasswordChar = '\0';
            }
            else
            {
                PassAgain.PasswordChar = '*';
            }
        }

        private void backbtnR_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
