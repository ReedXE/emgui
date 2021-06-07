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
    public partial class ClientAdd : Form
    {
        public ClientAdd()
        {
            InitializeComponent();
        }
        private bool IsProductValid()
        {
            if (tbClientCompany.Text == "")
            {
                MessageBox.Show("Please enter a Address.");
                return false;
            }
            else if (tbClientFax.Text == "")
            {
                MessageBox.Show("Please enter a City.");
                return false;
            }
            else if (tbClientName.Text == "")
            {
                MessageBox.Show("Please enter a Name.");
                return false;
            }
            else if (tbClientPhone.Text == "")
            {
                MessageBox.Show("Please enter a Phone.");
                return false;
            }
            else if (tbClientSurname.Text == "")
            {
                MessageBox.Show("Please enter a Phone.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (IsProductValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("dbo.clientAdd", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add input parameter for the stored procedure and specify what to use as its value.
                        sqlCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@name"].Value = tbClientName.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@surrname", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@surrname"].Value = tbClientSurname.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@companyName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@companyName"].Value = tbClientCompany.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@mobile", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@mobile"].Value = tbClientPhone.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@fax", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@fax"].Value = tbClientFax.Text;


                        try
                        {
                            connection.Open();

                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Klient zostal dodany!");
                        }
                        catch
                        {
                            MessageBox.Show("Klient nie zostal dodany!");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            tbClientCompany.Clear();
            tbClientFax.Clear();
            tbClientName.Clear();
            tbClientPhone.Clear();
            tbClientSurname.Clear();
        }
    }
}
