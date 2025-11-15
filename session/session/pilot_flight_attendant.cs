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
    public partial class pilot_and_flight_attendant : Form
    {
        public pilot_and_flight_attendant()
        {
            InitializeComponent();
        }

        private void pilotbtn_Click(object sender, EventArgs e)
        {
            pilot1 pilot = new pilot1();
            pilot.ShowDialog();
        }

        private void flight_attendantbtn_Click(object sender, EventArgs e)
        {
            flight_attendant1 flight_Attendant1 = new flight_attendant1();
            flight_Attendant1.ShowDialog();
        }
    }
}
