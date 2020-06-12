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
using System.Text.RegularExpressions;

namespace emgui
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtShowSurname.Clear();
            dgvEmployeeList.Refresh();
        }

            private bool IsSurnameValid()
        {
            if (txtShowSurname.Text == "")
            {
                MessageBox.Show("Please specify the Surname.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnFindBySurname_Click(object sender, EventArgs e)
        {
            if (IsSurnameValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Define a t-SQL query string that has a parameter for orderID.
                    const string sql = "SELECT * FROM dbo.Employee WHERE Surname = @surname";

                    // Create a SqlCommand object.
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        // Define the @orderID parameter and set its value.
                        sqlCommand.Parameters.Add(new SqlParameter("@surname", SqlDbType.VarChar));
                        sqlCommand.Parameters["@surname"].Value = txtShowSurname.Text;

                        try
                        {
                            connection.Open();

                            // Run the query by calling ExecuteReader().
                            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                            {
                                // Create a data table to hold the retrieved data.
                                DataTable dataTable = new DataTable();

                                // Load the data from SqlDataReader into the data table.
                                dataTable.Load(dataReader);

                                // Display the data from the data table in the data grid view.
                                this.dgvEmployeeList.DataSource = dataTable;

                                // Close the SqlDataReader.
                                dataReader.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("The requested could not be loaded into the form.");
                        }
                        finally
                        {
                            // Close the connection.
                            connection.Close();
                        }
                    }
                }
            }

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnFinishUpdates_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowAllEmployees_Click(object sender, EventArgs e)
        {
            
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Define a t-SQL query string that has a parameter for orderID.
                    const string sql = "SELECT Name, Surname, Address, City, Position, Salary, Status FROM dbo.Employee";

                    // Create a SqlCommand object.
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {

                        try
                        {
                            connection.Open();

                            // Run the query by calling ExecuteReader().
                            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                            {
                                // Create a data table to hold the retrieved data.
                                DataTable dataTable = new DataTable();

                                // Load the data from SqlDataReader into the data table.
                                dataTable.Load(dataReader);

                                // Display the data from the data table in the data grid view.
                                this.dgvEmployeeList.DataSource = dataTable;

                                // Close the SqlDataReader.
                                dataReader.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("The requested could not be loaded into the form.");
                        }
                        finally
                        {
                            // Close the connection.
                            connection.Close();
                        }
                    }
                }
            }

        private void btnShowClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }
    }
    
}
