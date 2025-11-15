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
using System.Globalization;

namespace session
{
    public partial class AirPlaneForm : Form
    {
        AirPlaneEntities1 _context = new AirPlaneEntities1();
        public static string name;
        public static byte[] photo;
        public AirPlaneForm()
        {
            InitializeComponent();
        }

        private void picsearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.png;*.jpg;*.bmp";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                airpicP.Image = Image.FromFile(openFileDialog.FileName);
                airpicP.Tag = openFileDialog.FileName;
            }
        }

        private void subairbtn_Click(object sender, EventArgs e)
        {
            int value;
            AirPlaneT air = new AirPlaneT();
            var ch = _context.AirPlaneTs.FirstOrDefault(u => u.AirPlane_Name == airName1.Text);
            string[] path = YearMadetxt.Text.Split('/');
            int year = 0, month = 0, day = 0;
            try
            {
                try
                {
                    if (path.Length != 3 && !(YearMadetxt.Text == null))
                    {
                        MessageBox.Show("روش صحیح ورودسال ساخت برای مثال:1386/08/04", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!int.TryParse(path[0], out year) || !int.TryParse(path[1], out month) || !int.TryParse(path[2], out day) && !(YearMadetxt.Text == null))
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
                    if (!(YearMadetxt.Text == null))
                    {
                        MessageBox.Show("تاریخ تولد وارد شده معتبر نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (airName1txt.Text == "")
                {
                    airName1txt.BackColor = Color.Red;
                }
                if (AirPlaneNametxt.Text == "")
                {
                    AirPlaneNametxt.BackColor = Color.Red;

                }
                if (Capacitytxt.Text == "")
                {
                    Capacitytxt.BackColor = Color.Red;

                }
                if (SeriesNumbertxt.Text == "")
                {
                    SeriesNumbertxt.BackColor = Color.Red;

                }
                if (YearMadetxt.Text == "")
                {
                    YearMadetxt.BackColor = Color.Red;

                }
                if (!(airName1txt.Text == "") && (ch != null))
                {
                    MessageBox.Show("اسم این هواپیما موجود است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (int.TryParse(Capacitytxt.Text, out value))
                {
                    if (value < 20)
                    {
                        MessageBox.Show("ظرفیت باید بالای 20 یا مساوی با 20 باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    if (value > 350)
                    {
                        MessageBox.Show("ظرفیت باید کمتر از 350 یا مساوی با 350 باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (airpicP.Tag == null || string.IsNullOrWhiteSpace(airpicP.Tag.ToString()))
                {
                    MessageBox.Show("لطفا عکس هواپیما را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    air.AirPlane_Name = airName1txt.Text;
                    air.company_Name = AirPlaneNametxt.Text;
                    air.Logo = photo;
                    air.Capacity = int.Parse(Capacitytxt.Text);
                    air.YearMade = YearMadetxt.Text;
                    air.SeriesNumber = int.Parse(SeriesNumbertxt.Text);
                    air.img = File.ReadAllBytes(airpicP.Tag.ToString());
                    _context.AirPlaneTs.Add(air);
                    _context.SaveChanges();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {

                MessageBox.Show("اطلاعات با موفقیت ثبت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void airName1txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void airName1txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void list()
        {
            var air = _context.Airlines.Select(u => new { u.Id, u.NameF }).ToList();
            AirPlaneNamelist.DataSource = null;
            AirPlaneNamelist.DisplayMember = "NameF";
            AirPlaneNamelist.ValueMember = "Id";
            AirPlaneNamelist.DataSource = air;
        }
        private void AirPlaneForm_Load(object sender, EventArgs e)
        {
            list();
        }

        private void airim_Click(object sender, EventArgs e)
        {

        }

        private void AirPlaneNamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AirPlaneNamelist.SelectedValue != null)
            {
                int select = (int)AirPlaneNamelist.SelectedValue;
                var air2 = _context.Airlines.FirstOrDefault(u => u.Id == select);

                if (air2 != null)
                {
                    name = air2.NameF;
                    photo = air2.logo;
                    AirPlaneNametxt.Text = air2.NameF;
                    if (air2.logo != null)
                    {
                        using (var ms = new MemoryStream(air2.logo))
                        {
                            airim.Image = Image.FromStream(ms);
                            airim.Tag = air2.logo;

                        }
                    }
                }
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Capacitytxt_KeyDown(object sender, KeyEventArgs e)
        {
            int value=20;

            if (!int.TryParse(Capacitytxt.Text,out value))
            {
                value = 0;
                if (e.KeyCode==Keys.Oemplus || e.KeyCode==Keys.Subtract)
                {
                    if (value<=350)
                    {
                        value++;
                        Capacitytxt.Text = value.ToString();
                        e.SuppressKeyPress = true;
                    }
                }
                if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
                {
                    if (value >= 20)
                    {
                        value--;
                        Capacitytxt.Text = value.ToString();
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }
    }
}
