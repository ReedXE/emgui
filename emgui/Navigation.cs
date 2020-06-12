using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emgui
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            Form frm = new NewEmployee();
            frm.Show();
        }

        private void btnGoToDel_Click(object sender, EventArgs e)
        {
            Form frm = new DelEmployee();
            frm.Show();
        }

        private void btnGoToShow_Click(object sender, EventArgs e)
        {
            Form frm = new Show();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            Form frm = new Update();
            frm.Show();
        }
    }
}
