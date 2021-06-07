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
    public partial class DelShop : Form
    {
        public DelShop()
        {
            InitializeComponent();
        }
        DataClasses1DataContext repozytorium = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //zdefiniowanie zmiennej przechowującej dane wynikowe
                var zmiennaUsuwanie =
                //definicja zapytania zwracająca wszystkie wiersze w tabeli Osoba w formacie LINQ zgodnie z warunkiem where (wartość jest konwertowana na typ Int32)
                from wiersz in repozytorium.Store
                where wiersz.idStore == System.Convert.ToInt32(dgvDelShop.SelectedRows[0].Cells[0].Value.ToString())
                select wiersz;

                //dla każdego wiersza w zmiennej przechowującej dane wynikowe wykonaj operację Usunięcia (Delete)
                foreach (var wiersz in zmiennaUsuwanie)
                {
                    repozytorium.Store.DeleteOnSubmit(wiersz);
                }

                try
                {
                    //prześlij zmiany do bazy danych
                    repozytorium.SubmitChanges();
                    //Wywołanie funkcji pobierającej dane z bazy i wyświetlające je w obiekcie DataGridView
                    wypelnijTabeleProduktyDanymi();
                }
                catch (Exception ex)
                {
                    //Wyświetlenie informacji o ewentualnym wyjątku
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                //Wyświetlenie informacji o ewentualnym wyjątku
                MessageBox.Show(ex.ToString());
            }
        }
        private void wypelnijTabeleProduktyDanymi()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.store_dbConnectionString))
            {
                // Define a t-SQL query string that has a parameter for orderID.
                const string sql = "Select * FROM Store";

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
                            this.dgvDelShop.DataSource = dataTable;

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

        private void DelShop_Load(object sender, EventArgs e)
        {
            wypelnijTabeleProduktyDanymi();
        }
    }

}
