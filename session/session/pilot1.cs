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
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Globalization;

namespace session
{
    public partial class pilot1 : Form
    {
        AirPlaneEntities1 _context = new AirPlaneEntities1();
        string co = "";
        public pilot1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pilot1_Load(object sender, EventArgs e)
        {
        }

        private void subbtn2_Click(object sender, EventArgs e)
        {
            pilot p = new pilot();
            string pattern = @"^\w{3,}@[a-zA-z0-9]{2,}\.com$";
            string EmailT = emtxt.Text;
            co = Codetxt.Text;
            string[] path = bithtxt.Text.Split('/');
            string[] paths = yeartxt.Text.Split('/');
            var ch = _context.pilots.FirstOrDefault(u => u.code == co);
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
                else if (NameFamilytxt.Text == "")
                {
                    MessageBox.Show("لطفا نام و نام خانوادگي خود را وارد كنيد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameFamilytxt.Text = "";
                }
                else if ((yourpicp.Tag == null) || (string.IsNullOrWhiteSpace(yourpicp.Tag.ToString())))
                {
                    MessageBox.Show("لطفا عکس خود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((yourscanpic.Tag == null) || (string.IsNullOrWhiteSpace(yourscanpic.Tag.ToString())))
                {
                    MessageBox.Show("لطفا اسكن مدارك خود را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    p.NameFamily = NameFamilytxt.Text;
                    p.code = Codetxt.Text;
                    p.personal_img = File.ReadAllBytes(yourpicp.Tag.ToString());
                    p.birthday = bithtxt.Text;
                    p.year_employment = yeartxt.Text;
                    p.Email = emtxt.Text;
                    FileInfo fileInfo = new FileInfo(yourscanpic.Tag.ToString());
                    if (fileInfo.Length > 1024 * 200)
                    {
                        MessageBox.Show("حجم فايل نبايد بيشتر از 200 كيلوبايت باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    p.Scan = File.ReadAllBytes(yourscanpic.Tag.ToString());
                    p.Des = destxt.Text;
                    _context.pilots.Add(p);
                    _context.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NameFamilytxt.Text = null;
                    yeartxt.Text = null;
                    emtxt.Text = null;
                    bithtxt.Text = null;
                    Codetxt.Text = null;
                    yourpicp.Tag = null;
                    destxt.Text = null;
                    yourpicp.Image = null;
                    yourscanpic.Tag = null;
                    yourscanpic.Image = null;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("اطلاعات با موفقیت ثبت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void yourpicbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.png;*.jpg;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                yourpicp.Image = Image.FromFile(openFile.FileName);
                yourpicp.Tag = openFile.FileName;
            }
        }

        private void yourscanbtn_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.png;*.jpg;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                yourscanpic.Image = Image.FromFile(openFile.FileName);
                yourscanpic.Tag = openFile.FileName;
            }
           
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            pilot_and_flight_attendant pilot_And_Flight_Attendant = new pilot_and_flight_attendant();
            pilot_And_Flight_Attendant.ShowDialog();
        }
    }
         
            
}
