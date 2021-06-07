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
    public partial class ClientUpdate : Form
    {
        public ClientUpdate()
        {
            InitializeComponent();
        }

        private void ClientUpdate_Load(object sender, EventArgs e)
        {
            wypelnijTabeleProduktyDanymi();
        }
        string idClient;
        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            //Utworzenie obiektu SqlConnection
            SqlConnection objConn = new SqlConnection(Properties.Settings.Default.store_dbConnectionString);
            //Otrwarcie połączenia z bazą danych
            objConn.Open();

            // Utworzenie wystąpienia obiektu DataAdapter.
            SqlDataAdapter daStudenci = new SqlDataAdapter("select * from Client", objConn);

            // Utworzenie wystąpienia obiektu DataSet 
            DataSet dsStudenci = new DataSet("Klienci");
            //Wypełnienie obiektu DataSet  schematem danych
            daStudenci.FillSchema(dsStudenci, SchemaType.Source, "Client");
            //Wypełnienie obiektu DataSet  danymi z tabeli
            daStudenci.Fill(dsStudenci, "Client");
            //****************
            // ROZPOCZĘCIE KODU DODAWANIA 
            // Utworzenie nowego wystąpienia obiektu DataTable.
            DataTable tblStudenci;
            tblStudenci = dsStudenci.Tables["Client"];

            //Utworzenie obiektu DataRow
            DataRow drCurrent;

            // ROZPOCZĘCIE KODU EDYCJI 

            //Ustawienie wiersza do edycji na właściwy wiersz (wybrany z tblStudenci na podstawie wartości z IDStudenta)
            drCurrent = tblStudenci.Rows.Find(idClient);
            //Rozpoczęcie edycji wiersza
            drCurrent.BeginEdit();
            //Wstawienie  wartości pod wybrane kolumny edytowanego wiersza
            drCurrent["Name"] = tb1.Text;
            drCurrent["Surrname"] = tb2.Text;
            drCurrent["CompanyName"] = tb3.Text;
            drCurrent["MobileNo"] = tb4.Text;
            drCurrent["FaxNo"] = tb5.Text;
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
            daStudenci.Update(dsStudenci, "Client");


            // ZAKOŃCZENIE PRZESYŁANIA ZMIAN DO SERWERA SQL 


            // Zapisanie wartości obiektu DataSet do pliku XML
            dsStudenci.WriteXml("test.xml", XmlWriteMode.WriteSchema);


            wypelnijTabeleProduktyDanymi();
            objConn.Close();
        }

        private void dgvClientUpdate_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientUpdate.SelectedRows.Count > 0)
            {
                idClient = dgvClientUpdate.SelectedRows[0].Cells[0].Value.ToString();
                tb1.Text = dgvClientUpdate.SelectedRows[0].Cells[1].Value.ToString();
                tb2.Text = dgvClientUpdate.SelectedRows[0].Cells[2].Value.ToString();
                tb3.Text = dgvClientUpdate.SelectedRows[0].Cells[3].Value.ToString();
                tb4.Text = dgvClientUpdate.SelectedRows[0].Cells[4].Value.ToString();
                tb5.Text = dgvClientUpdate.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void wypelnijTabeleProduktyDanymi()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "select * from Client";

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
                            this.dgvClientUpdate.DataSource = dataTable;

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
}
