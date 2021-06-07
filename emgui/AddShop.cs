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
    public partial class AddShop : Form
    {
        public AddShop()
        {
            InitializeComponent();
        }
        private bool IsProductValid()
        {
            if (tbAddress.Text == "")
            {
                MessageBox.Show("Please enter a Address.");
                return false;
            }
            else if (tbCity.Text == "")
            {
                MessageBox.Show("Please enter a City.");
                return false;
            }
            else if (tbName.Text == "")
            {
                MessageBox.Show("Please enter a Name.");
                return false;
            }
            else if (tbPhone.Text == "")
            {
                MessageBox.Show("Please enter a Phone.");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void btnAddShop_Click(object sender, EventArgs e)
        {
            if (IsProductValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("dbo.storeAdd", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add input parameter for the stored procedure and specify what to use as its value.
                        sqlCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@name"].Value = tbName.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@storeAddress", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@storeAddress"].Value = tbAddress.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@city", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@city"].Value = tbCity.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.Money, 40));
                        sqlCommand.Parameters["@phone"].Value = tbPhone.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@other", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@other"].Value = rtbOther.Text;


                        try
                        {
                            connection.Open();

                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Sklep zostal dodany!");
                        }
                        catch
                        {
                            MessageBox.Show("Sklep nie zostal dodany!");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
