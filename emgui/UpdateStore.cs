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
    public partial class UpdateStore : Form
    {
        public UpdateStore()
        {
            InitializeComponent();
        }
        private void wypelnijTabeleProduktyDanymi()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "select * from Store";

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
                            this.dgvUpdateStore.DataSource = dataTable;

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

        private void UpdateStore_Load(object sender, EventArgs e)
        {
            wypelnijTabeleProduktyDanymi();
        }
        string idStore;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Utworzenie obiektu SqlConnection
            SqlConnection objConn = new SqlConnection(Properties.Settings.Default.store_dbConnectionString);
            //Otrwarcie połączenia z bazą danych
            objConn.Open();

            // Utworzenie wystąpienia obiektu DataAdapter.
            SqlDataAdapter daStudenci = new SqlDataAdapter("select * from Store", objConn);

            // Utworzenie wystąpienia obiektu DataSet 
            DataSet dsStudenci = new DataSet("Sklepy");
            //Wypełnienie obiektu DataSet  schematem danych
            daStudenci.FillSchema(dsStudenci, SchemaType.Source, "Store");
            //Wypełnienie obiektu DataSet  danymi z tabeli
            daStudenci.Fill(dsStudenci, "Store");
            //****************
            // ROZPOCZĘCIE KODU DODAWANIA 
            // Utworzenie nowego wystąpienia obiektu DataTable.
            DataTable tblStudenci;
            tblStudenci = dsStudenci.Tables["Store"];

            //Utworzenie obiektu DataRow
            DataRow drCurrent;

            // ROZPOCZĘCIE KODU EDYCJI 

            //Ustawienie wiersza do edycji na właściwy wiersz (wybrany z tblStudenci na podstawie wartości z IDStudenta)
            drCurrent = tblStudenci.Rows.Find(idStore);
            //Rozpoczęcie edycji wiersza
            drCurrent.BeginEdit();
            //Wstawienie  wartości pod wybrane kolumny edytowanego wiersza
            drCurrent["Name"] = tbUS1.Text;
            drCurrent["storeAddress"] = tbUS2.Text;
            drCurrent["City"] = tbUS3.Text;
            drCurrent["Phone"] = tbUS4.Text;
            drCurrent["Other"] = tbUS5.Text;
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
            daStudenci.Update(dsStudenci, "Store");


            // ZAKOŃCZENIE PRZESYŁANIA ZMIAN DO SERWERA SQL 


            // Zapisanie wartości obiektu DataSet do pliku XML
            dsStudenci.WriteXml("test.xml", XmlWriteMode.WriteSchema);


            wypelnijTabeleProduktyDanymi();
            objConn.Close();
        }

        private void dgvUpdateStore_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateStore.SelectedRows.Count > 0)
            {
                idStore = dgvUpdateStore.SelectedRows[0].Cells[0].Value.ToString();
                tbUS1.Text = dgvUpdateStore.SelectedRows[0].Cells[1].Value.ToString();
                tbUS2.Text = dgvUpdateStore.SelectedRows[0].Cells[2].Value.ToString();
                tbUS3.Text = dgvUpdateStore.SelectedRows[0].Cells[3].Value.ToString();
                tbUS4.Text = dgvUpdateStore.SelectedRows[0].Cells[4].Value.ToString();
                tbUS5.Text = dgvUpdateStore.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
    }
}
