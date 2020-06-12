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
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
        }

        // Storage for IDENTITY values returned from database.
        private int parsedId;

        /// <summary>
        /// Verifies that the customer name text box is not empty.
        /// </summary>
        private bool IsEmployeeValid()
        {
            if (txtEmployeeName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else if (txtEmployeeSurname.Text == "")
            {
                MessageBox.Show("Please enter a surname.");
                return false;
            }
            else if (txtEmployeeAddress.Text == "")
            {
                MessageBox.Show("Please enter a address.");
                return false;
            }
            else if (txtEmployeeCity.Text == "")
            {
                MessageBox.Show("Please enter a city.");
                return false;
            }
            else if (txtEmployeePosition.Text == "")
            {
                MessageBox.Show("Please enter a position.");
                return false;
            }
            else if (numSalary.Value == 0)
            {
                MessageBox.Show("Please enter a value higher than 0.");
                return false;
            }
            else if (txtEmployeeStatus.Text == "")
            {
                MessageBox.Show("Please enter a status value of: 1, 2 or 3.");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Clears the form data.
        /// </summary>
        private void ClearForm()
        {
            txtEmployeeName.Clear();
            txtEmployeeId.Clear();
            txtEmployeeSurname.Clear();
            txtEmployeeAddress.Clear();
            txtEmployeeCity.Clear();
            txtEmployeePosition.Clear();
            dtpStartDate.Value = DateTime.Now;
            numSalary.Value = 0;
            txtEmployeeStatus.Text = "0";
            this.parsedId = 0;
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            if (IsEmployeeValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("dbo.NewEmployee", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add input parameter for the stored procedure and specify what to use as its value.
                        sqlCommand.Parameters.Add(new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@EmployeeName"].Value = txtEmployeeName.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@EmployeeSurname", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@EmployeeSurname"].Value = txtEmployeeSurname.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@EmployeeAddress", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@EmployeeAddress"].Value = txtEmployeeAddress.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@EmployeeCity", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@EmployeeCity"].Value = txtEmployeeCity.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@EmployeePosition", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@EmployeePosition"].Value = txtEmployeePosition.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@EmployeeStartDate", SqlDbType.DateTime));
                        sqlCommand.Parameters["@EmployeeStartDate"].Value = dtpStartDate.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@EmployeeSalary", SqlDbType.Decimal, 12));
                        sqlCommand.Parameters["@EmployeeSalary"].Value = numSalary.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@EmployeeStatus", SqlDbType.Int, 1));
                        sqlCommand.Parameters["@EmployeeStatus"].Value = Convert.ToInt32(txtEmployeeStatus.Text);

                        // Add the output parameter.
                        sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                        sqlCommand.Parameters["@Id"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();

                            // Customer ID is an IDENTITY value from the database.
                            this.parsedId = (int)sqlCommand.Parameters["@Id"].Value;

                            // Put the Customer ID value into the read-only text box.
                            this.txtEmployeeId.Text = Convert.ToString(parsedId);

                            MessageBox.Show("Employee added to Database.");
                        }
                        catch
                        {
                            MessageBox.Show("Employee ID was not returned. Account could not be created.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnAddAnotherEmployee_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnAddFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
