using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.IO;
namespace session
{
    public partial class AirlineRegister : Form
    {

        AirPlaneEntities1 _context = new AirPlaneEntities1();
        public AirlineRegister()
        {
            InitializeComponent();
        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode==Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || !(e.KeyChar == 'a' && e.KeyChar == 'z')))
            {
                e.Handled = true;
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                logopic.Image = Image.FromFile(openFile.FileName);
                logopic.Tag = openFile.FileName;
            }
        }

        private void AirlineRegister_Load(object sender, EventArgs e)
        {
            passtxt.ContextMenu = new ContextMenu();
            passA.ContextMenu = new ContextMenu();
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Airline airline = new Airline();
                string user = usertxt.Text;
                string pass = passtxt.Text;
                string pattern = @"^\w{3,}@[a-zA-z0-9]{2,}\.com$";
                string EmailT = emailtxt.Text;
                var US = _context.Airlines.FirstOrDefault(u => u.UserName == user);
                if (usertxt.Text == "")
                {
                    usertxt.BackColor = Color.Red;
                }
                if (AirNameF.Text == "")
                {
                    usertxt.BackColor = Color.Red;
                }
                if (passtxt.Text == "")
                {
                    passtxt.BackColor = Color.Red;

                }
                if (passA.Text == "")
                {
                    passA.BackColor = Color.Red;

                }
                if (emailtxt.Text == "")
                {
                    emailtxt.BackColor = Color.Red;

                }
                else if (US != null)
                {
                    MessageBox.Show("لطفا نام کاربری دیگری انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usertxt.Text = "";
                }
                else if (user.Length < 5)
                {
                    MessageBox.Show("لطفا نام کاربری دیگری انتخاب کنید که بیشتر از 5 حرف باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usertxt.Text = "";
                }
                else if (!(Regex.IsMatch(EmailT, pattern)))
                {
                    MessageBox.Show("ایمیل شما معتبر نیست لطفا ایمیل معتبر وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailtxt.Text = "";
                }
             
                else if (pass.Length < 8)
                {
                    MessageBox.Show("لطفا نام پسورد دیگری انتخاب کنید که بیشتر از 8 حرف باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passtxt.Text = "";
                    passA.Text = "";
                }
                else if (ch_passnum(pass))
                {
                    MessageBox.Show("در رمز اعداد پشت سر هم وارد شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passtxt.Text = "";
                    passA.Text = "";
                }
                else if (ch_passchar(pass))
                {
                    MessageBox.Show("در رمز الگوی تکراری وارد شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passtxt.Text = "";
                    passA.Text = "";
                }
                else if (!(passtxt.Text == passA.Text) && !(passtxt.Text == "") && !(passA.Text == ""))
                {
                    MessageBox.Show("رمز تکراری درست وارد نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passtxt.Text = "";
                    passA.Text = "";
                }
                else if (logopic.Tag == null || string.IsNullOrWhiteSpace(logopic.Tag.ToString()))
                {
                    MessageBox.Show("لطفا لوگوی شرکت هواپیمایی خود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if ((AirNameF.Text==null))
                {
                    MessageBox.Show("لطفا نام شرکت هواپیمایی را به فارسی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    airline.Password = function.funMD5(passtxt.Text);
                    airline.Email = emailtxt.Text;
                    airline.UserName = usertxt.Text;
                    airline.logo = File.ReadAllBytes(logopic.Tag.ToString());
                    airline.NameF = AirNameF.Text;
                    _context.Airlines.Add(airline);
                    _context.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login login = new Login();
                    login.Show();
                    this.Close();

                }
            }
            catch 
            {
                MessageBox.Show("اطلاعات با موفقیت ثبت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        bool ch_passnum(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
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

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SHOWB1_CheckedChanged(object sender, EventArgs e)
        {
            if (SHOWB1.Checked==true)
            {
                passtxt.PasswordChar = '\0';
            }
            else
            {
                passtxt.PasswordChar = '*';

            }
        }

        private void SHOWB2_CheckedChanged(object sender, EventArgs e)
        {
            if (SHOWB2.Checked == true)
            {
                passA.PasswordChar = '\0';
            }
            else
            {
                passA.PasswordChar = '*';

            }
        }

        private void logopic_Click(object sender, EventArgs e)
        {

        }

        private void AirNameF_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control &&(e.KeyCode==Keys.X) || (e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void passA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.X) || (e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void backbtnair_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
