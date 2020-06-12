using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace emgui
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;


        private void btnUpdateShow_Click(object sender, EventArgs e)
        {
            
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
                // Define a t-SQL query string that has a parameter for orderID.
                sda = new SqlDataAdapter(@"SELECT * FROM dbo.Employee", connection);

                // Define the @orderID parameter and set its value.

                dt = new DataTable();
                sda.Fill(dt);
                dgvUpdate.DataSource = dt;

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }


    }
}
