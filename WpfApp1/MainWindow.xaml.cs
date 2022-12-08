using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Holds connection to DB
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["WpfApp1.Properties.Settings.SQLServerExampleConnectionString"].ConnectionString;

            // Init connection
            sqlConnection = new SqlConnection(connectionString);
        }

        private void DisplayStores()
        {
            try
            {
                string query = "SELECT * FROM Store";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable storeTable = new DataTable();
                    sqlDataAdapter.Fill(storeTable);
                    storeList.DisplayMemberPath = "Name";
                    storeList.SelectedValuePath= "Id";
                    storeList.ItemsSource = storeTable.DefaultView;
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.ToString());
            }
        }

        private void DisplayStoreInventory()
        {
            try
            {
                string query = "SELECT * FROM Product p inner join StoreInventory si ON p.Id = si.ProductId WHERE si.StoreId = @StoreId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("StoreId",storeList.SelectedValuePath);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void storeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddStoreClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteStoreClick(object sender, RoutedEventArgs e)
        {

        }

        private void AddInventoryClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteInventoryClick(object sender, RoutedEventArgs e)
        {

        }

        private void AddProductClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteProductClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
