using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emgui
{
    public partial class DelEmployee : Form
    {
        public DelEmployee()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtDelEmployeeName.Clear();
            txtDelEmployeeSurname.Clear();
        }

        private bool IsEmployeeValid()
        {
            if (txtDelEmployeeName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else if (txtDelEmployeeSurname.Text == "")
            {
                MessageBox.Show("Please enter a surname.");
                return false;
            }
            else
            {
                return true;
            }
        }


            private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            if (IsEmployeeValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("dbo.DelEmployee", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add input parameter for the stored procedure and specify what to use as its value.
                        sqlCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@name"].Value = txtDelEmployeeName.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@surname"].Value = txtDelEmployeeSurname.Text;

                        try
                        {
                            connection.Open();

                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Employee deleted.");

                        }
                        catch
                        {
                            MessageBox.Show("Delete operation does not succed.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnDelAnotherEmployee_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnDelFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
