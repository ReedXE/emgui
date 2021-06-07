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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }



        private void wypelnijTabeleProduktyDanymi()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "select idProduct, ProductName, Type, Price, modelNumber from Product";

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
                            this.dgvUpdate.DataSource = dataTable;

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
        string idProduct;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Utworzenie obiektu SqlConnection
            SqlConnection objConn = new SqlConnection(Properties.Settings.Default.store_dbConnectionString);
            //Otrwarcie połączenia z bazą danych
            objConn.Open();

            // Utworzenie wystąpienia obiektu DataAdapter.
            SqlDataAdapter daStudenci = new SqlDataAdapter("select idProduct, ProductName, Type, Price, modelNumber from Product", objConn);

            // Utworzenie wystąpienia obiektu DataSet 
            DataSet dsStudenci = new DataSet("Produkty");
            //Wypełnienie obiektu DataSet  schematem danych
            daStudenci.FillSchema(dsStudenci, SchemaType.Source, "Product");
            //Wypełnienie obiektu DataSet  danymi z tabeli
            daStudenci.Fill(dsStudenci, "Product");
            //****************
            // ROZPOCZĘCIE KODU DODAWANIA 
            // Utworzenie nowego wystąpienia obiektu DataTable.
            DataTable tblStudenci;
            tblStudenci = dsStudenci.Tables["Product"];

            //Utworzenie obiektu DataRow
            DataRow drCurrent;

            // ROZPOCZĘCIE KODU EDYCJI 

            //Ustawienie wiersza do edycji na właściwy wiersz (wybrany z tblStudenci na podstawie wartości z IDStudenta)
            drCurrent = tblStudenci.Rows.Find(idProduct);
            //Rozpoczęcie edycji wiersza
            drCurrent.BeginEdit();
            //Wstawienie  wartości pod wybrane kolumny edytowanego wiersza
            drCurrent["ProductName"] = tbProductName.Text;
            drCurrent["Type"] = tbType.Text;
            drCurrent["Price"] = tbPrice.Text;
            drCurrent["modelNumber"] = tbModelNumber.Text;
            //Zakończenie edycji wiersza
            drCurrent.EndEdit();

            // ZAKOŃCZENIE KODU EDYCJI   
            //*****************
            // ROZPOCZĘCIE PRZESYŁANIA ZMIAN DO SERWERA SQL 
            //Utworzenie obiektu SqlCommandBuilder
            SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(daStudenci);

            // Ustawienie parametru gwarantującego kontynuację zapisu pomimo błędu
            daStudenci.ContinueUpdateOnError = true;

            //Przesłanie zmian do serwera SQL
            daStudenci.Update(dsStudenci, "Product");


            // ZAKOŃCZENIE PRZESYŁANIA ZMIAN DO SERWERA SQL 


            // Zapisanie wartości obiektu DataSet do pliku XML
            dsStudenci.WriteXml("test.xml", XmlWriteMode.WriteSchema);


            wypelnijTabeleProduktyDanymi();
            objConn.Close();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            wypelnijTabeleProduktyDanymi();
        }

        private void dgvUpdate_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdate.SelectedRows.Count > 0)
            {
                idProduct = dgvUpdate.SelectedRows[0].Cells[0].Value.ToString();
                tbProductName.Text = dgvUpdate.SelectedRows[0].Cells[1].Value.ToString();
                tbType.Text = dgvUpdate.SelectedRows[0].Cells[2].Value.ToString();
                tbPrice.Text = dgvUpdate.SelectedRows[0].Cells[3].Value.ToString(); 
                tbModelNumber.Text = dgvUpdate.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }


    }

