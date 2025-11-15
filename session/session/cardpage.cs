using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace session
{
    public partial class cardpage : Form
    {
        AirPlaneEntities1 _context = new AirPlaneEntities1();
        flight_attendant flight_Attendant = new flight_attendant();
        private Image image;
        private string namet, familyt, codet,chart;
        public cardpage(Image img, string NameT, string FamilyT, string CodeT,string Chart)
        {
            InitializeComponent();
            image = img;
            namet = NameT;
            familyt = FamilyT;
            chart = Chart;
            codet = CodeT;
        }

        private void cardpage_Load(object sender, EventArgs e)
        {
            Fpic.Image = image;
            if (flight_attendant1.photo!=null)
            {
                using (var ms = new MemoryStream(flight_attendant1.photo))
                {
                    Apic.Image = Image.FromStream(ms);

                }
            }
            else
            {
                Apic.Image = null;
            }
            AirLineName.Text = flight_attendant1.name;
            NameFlbl2.Text = namet;
            FamilyFlbl2.Text = familyt;
            Codelbl2.Text = codet;
            Characterlbl2.Text = chart;
        }
    }
}
