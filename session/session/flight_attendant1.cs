using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace session
{
    public partial class flight_attendant1 : Form
    {
        AirPlaneEntities1 _context = new AirPlaneEntities1();
        string co = "";
        public static string name;
        public static byte[] photo;
        public static string Name1;
        public static string family;
        public static string code;
        public static string Char;
        private Image im;
        public flight_attendant1()
        {
            InitializeComponent();
        }

        private void yourpicbtn_Click(object sender, EventArgs e)
        {
               OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.png;*.jpg;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                im = Image.FromFile(openFile.FileName);
                yourpicp.Image = Image.FromFile(openFile.FileName);
                yourpicp.Tag = openFile.FileName;
            }
        }

        private void subbtn2_Click(object sender, EventArgs e)
        {
            flight_attendant p = new flight_attendant();
            string pattern = @"^\w{3,}@[a-zA-z0-9]{2,}\.com$";
            string EmailT = emtxt.Text;
            co = Codetxt.Text;
            string[] path = bithtxt.Text.Split('/');
            string[] paths = yeartxt.Text.Split('/');
            var ch = _context.flight_attendant.FirstOrDefault(u => u.Code ==co);
            int year = 0, month = 0, day = 0;
            try
            {
                try
                {
                    if (paths.Length != 3 && !(yeartxt.Text == ""))
                    {
                        MessageBox.Show("روش صحیح ورود تاریخ تولد برای مثال:1386/08/04", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((!int.TryParse(path[0], out year) || !int.TryParse(path[1], out month) || !int.TryParse(path[2], out day)) && !(yeartxt.Text == ""))
                    {
                        MessageBox.Show("اعداد وارد شده معتبر نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    PersianCalendar persian = new PersianCalendar();

                    DateTime dateTime = persian.ToDateTime(year, month, day, 0, 0, 0, 0);
                    if (DateTime.Now < dateTime.Date)
                    {
                        MessageBox.Show("تاریخ براي اينده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    if (!(yeartxt.Text == ""))
                    {
                        MessageBox.Show("تاریخ تولد وارد شده معتبر نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                try
                {
                    if (path.Length != 3 && !(bithtxt.Text == ""))
                    {
                        MessageBox.Show("روش صحیح ورود تاریخ تولد برای مثال:1386/08/04", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((!int.TryParse(path[0], out year) || !int.TryParse(path[1], out month) || !int.TryParse(path[2], out day)) && !(bithtxt.Text == ""))
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
                    if (age < 18 && !(bithtxt.Text == ""))
                    {
                        MessageBox.Show("سن شما باید حداقل 18 سال باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bithtxt.Text = "";
                    }

                }
                catch
                {
                    if (!(bithtxt.Text == ""))
                    {
                        MessageBox.Show("تاریخ تولد وارد شده معتبر نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (!(Regex.IsMatch(EmailT, pattern)) && !(emtxt.Text == ""))
                {
                    MessageBox.Show("ایمیل شما معتبر نیست لطفا ایمیل معتبر وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emtxt.Text = "";
                }
                else if (co.Length > 10 && !(Codetxt.Text == ""))
                {
                    MessageBox.Show("کدملی یا شماره پاسپورت شما معتبر نیست لطفا 10 رقم وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Codetxt.Text = "";
                }
                else if (ch != null)
                {
                    MessageBox.Show("كدملي يا شماره پاسپورت شما معتبر نيست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Codetxt.Text = "";
                }
                else if (Nametxt.Text == "")
                {
                    MessageBox.Show("لطفا نام و نام خانوادگي خود را وارد كنيد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Nametxt.Text = "";
                }
                else if (familytxt.Text == "")
                {
                    MessageBox.Show("لطفا نام و نام خانوادگي خود را وارد كنيد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    familytxt.Text = "";
                }
                else if ((yourpicp.Tag == null) || (string.IsNullOrWhiteSpace(yourpicp.Tag.ToString())))
                {
                    MessageBox.Show("لطفا عکس خود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (airlinetxt.Text==null)
                {
                    MessageBox.Show("لطفا شرکت هواپیمایی خود را در سیستم انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    p.Name = Nametxt.Text;
                    p.family = familytxt.Text;
                    p.Code =Codetxt.Text;
                    p.personal_img = File.ReadAllBytes(yourpicp.Tag.ToString());
                    p.birthday = bithtxt.Text;
                    p.year_employment = yeartxt.Text;
                    p.Email = emtxt.Text;
                    p.AirLineLogo = photo;
                    p.Airline = airlinetxt.Text;
                    Name = Nametxt.Text;
                    family = familytxt.Text;
                    code = Codetxt.Text;
                    Char = charactertxtfa.Text;
                    _context.flight_attendant.Add(p);
                    _context.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cardpage cardpage = new cardpage(im, Name, family, code,Char);
                    cardpage.ShowDialog();
                    Nametxt.Text = null;
                    yeartxt.Text = null;
                    emtxt.Text = null;
                    bithtxt.Text = null;
                    familytxt.Text = null;
                    Codetxt.Text = null;
                    yourpicp.Tag = null;
                    yourpicp.Image = null;
              
                }
        }
            catch (Exception)
            {

                MessageBox.Show("اطلاعات با موفقیت ثبت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

}

        private void backbtn_Click(object sender, EventArgs e)
        {
            pilot_and_flight_attendant pilot_And_Flight_Attendant = new pilot_and_flight_attendant();
            pilot_And_Flight_Attendant.ShowDialog();
        }

        private void NameFamilytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void list()
        {
            var users = _context.Airlines.Select(u => new { u.Id, u.NameF }).ToList();
            listair.DataSource = null;
            listair.DisplayMember = "NameF";
            listair.ValueMember = "Id";
            listair.DataSource = users;
        }

        private void listair_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listair.SelectedValue!=null)
            {
                int selecteId = (int)listair.SelectedValue;
                var user = _context.Airlines.FirstOrDefault(u => u.Id == selecteId);
                if (user!=null)
                {
                    name = user.NameF;
                    airlinetxt.Text = user.NameF;
                    photo = user.logo;
                    if (user.logo!=null)
                    {
                        using(var ms = new MemoryStream(user.logo))
                        {
                            logopic.Image = Image.FromStream(ms);
                            logopic.Tag = user.logo;
                        }
                    }
                    else
                    {
                        logopic.Image = null;
                    }
                }
            }
        }

        private void logopic_Click(object sender, EventArgs e)
        {

        }

        private void flight_attendant1_Load(object sender, EventArgs e)
        {
            list();
            timer_load.Enabled = true;
            
        }
    }
}
