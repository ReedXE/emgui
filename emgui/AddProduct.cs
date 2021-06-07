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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void wypelnijTabeleProduktyDanymi()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "SELECT idStore, Name, storeAddress, City, Phone, Other FROM Store";

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
                            this.dgvAddProduct.DataSource = dataTable;

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

        private void ClearForm()
        {
            tbAddProductModel.Clear();
            tbAddProductName.Clear();
            tbAddProductPrice.Clear();
            tbAddProductType.Clear();
        }
        private bool IsProductValid()
        {
            if (tbAddProductModel.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else if (tbAddProductName.Text == "")
            {
                MessageBox.Show("Please enter a surname.");
                return false;
            }
            else if (tbAddProductPrice.Text == "")
            {
                MessageBox.Show("Please enter a address.");
                return false;
            }
            else if (tbAddProductType.Text == "")
            {
                MessageBox.Show("Please enter a city.");
                return false;
            }
      
            else
            {
                return true;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (IsProductValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("dbo.productAdd", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add input parameter for the stored procedure and specify what to use as its value.
                        sqlCommand.Parameters.Add(new SqlParameter("@idStore", SqlDbType.Int, 40));
                        sqlCommand.Parameters["@idStore"].Value = tbAddProductId.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@name"].Value = tbAddProductName.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@type", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@type"].Value = tbAddProductType.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Money, 40));
                        sqlCommand.Parameters["@price"].Value = tbAddProductPrice.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@modelNumber", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@modelNumber"].Value = tbAddProductModel.Text;

                      
                        try
                        {
                            connection.Open();

                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Produkt zostal dodany!");
                        }
                        catch
                        {
                            MessageBox.Show("Produkt nie zostal dodany!");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            wypelnijTabeleProduktyDanymi();
        }

        private void dgvAddProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAddProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                tbAddProductId.Text = dgvAddProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void btnAddProductReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
