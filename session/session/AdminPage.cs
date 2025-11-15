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
    public partial class AdminPage : Form
    {
        AirPlaneEntities1 _context = new AirPlaneEntities1();
        
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Users.ToList();
            if (dataGridView1.Columns[dataGridView1.Columns.Count - 1] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)dataGridView1.Columns[dataGridView1.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            dataGridView1.RowTemplate.Height = 100;
        }
        private void filter()
        {
            string name = nametxt.Text.Trim();
            string family = familytxt.Text.Trim();
            var result = _context.Users.Where(e => (name == "" || e.firstName.Contains(name)) && (family == "" || e.LastName.Contains(family))).ToList();
            dataGridView1.DataSource = result;
        }

        private void familytxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter();
        }
    }
}
