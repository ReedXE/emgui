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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            wypelnijTabeleProduktyDanymi();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form frm = new AddProduct();
            frm.Show();
        }


        private void wypelnijTabeleProduktyDanymi()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "SELECT dbo.Store.Name, dbo.Store.storeAddress, dbo.Store.City, dbo.Product.[ProductName], dbo.Product.Type, dbo.Product.Price FROM dbo.Product INNER JOIN dbo.Store ON dbo.Product.idStore = dbo.Store.idStore";

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
                            this.dgvProdukty.DataSource = dataTable;

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
        private void wypelnijTabeleProduktyDanymi2()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "SELECT * From Store ";

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
                            this.dgvShopList.DataSource = dataTable;

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
        private void wypelnijTabeleProduktyDanymi3()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "SELECT * From Store ";

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
                            this.dgvShopList.DataSource = dataTable;

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

        private void wypelnijTabeleProduktyDanymi4()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "SELECT * From Client";

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
                            this.dgvKlienci.DataSource = dataTable;

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
        private void txtboxSearchData_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                string sql = "SELECT Store.[Name], Store.storeAddress, Store.City, Product.[ProductName], Product.Type, Product.Price FROM Product INNER JOIN Store ON Product.idStore = Store.idStore Where " + cbSearchData.Text + " Like '%" + txtboxSearchData.Text + "%'";

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
                            this.dgvProdukty.DataSource = dataTable;

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

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            Form frm = new DelProduct();
            frm.Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Form frm = new UpdateProduct();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wypelnijTabeleProduktyDanymi();
        }

        private void btnAddShop_Click(object sender, EventArgs e)
        {
            Form frm = new AddShop();
            frm.Show();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            wypelnijTabeleProduktyDanymi2();
            wypelnijTabeleProduktyDanymi4();
        }

        private void btnDelShop_Click(object sender, EventArgs e)
        {
            Form frm = new DelShop();
            frm.Show();
        }

        private void tbSklepySearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                string sql = "SELECT * FROM Store Where " + cbSklepySearch.Text + " Like '%" + tbSklepySearch.Text + "%'";

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
                            this.dgvShopList.DataSource = dataTable;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new UpdateStore();
            frm.Show();
        }

        private void btnKlienciAdd_Click(object sender, EventArgs e)
        {
            Form frm = new ClientAdd();
            frm.Show();
        }

        private void btnKlienciDel_Click(object sender, EventArgs e)
        {
            Form frm = new ClientDel();
            frm.Show();
        }

        private void btnKlienciUpdate_Click(object sender, EventArgs e)
        {
            Form frm = new ClientUpdate();
            frm.Show();
        }

        private void tbKlienciSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                string sql = "SELECT * FROM Client Where " + cbKlienciSearch.Text + " Like '%" + tbKlienciSearch.Text + "%'";

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
                            this.dgvKlienci.DataSource = dataTable;

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

        private void button2_Click(object sender, EventArgs e)
        {
            wypelnijTabeleProduktyDanymi4();
        }
    }
}
