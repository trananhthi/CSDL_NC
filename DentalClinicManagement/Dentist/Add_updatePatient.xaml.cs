using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

namespace DentalClinicManagement.Dentist
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Add_updatePatient : Page
    {
        private DB db;
        public Add_updatePatient()
        {
            InitializeComponent();


        }
        private void backHome(object sender, RoutedEventArgs e)
        {
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;


            if (mainWindow != null && mainWindow.MainFrame != null)
            {
                mainWindow.MainFrame.Navigate(new DentalClinicManagement.Dentist.SeePatient());
            }
        }

        private void SaveChange(object sender, RoutedEventArgs e)
        {
            string Phone_ = Phone.Text.Trim();
            string Name_ = Name.Text.Trim();
            string Sex_ = Sex.Text.Trim();
            string Birthday_ = Birthday.Text.Trim();

            try
            {
                db = new DB();
                using (SqlConnection connection = db.Connection)
                {
                    string query = $"EXEC dbo.sp_seepatientlist";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }



        }
        private void UpdateRecord(string id)
        {
            // Implement your update logic here
            // Example:
            // string updateQuery = $"UPDATE YourTable SET Column1 = 'NewValue' WHERE ID = '{id}'";
            // Execute the update query
        }

        private void InsertRecord(string id)
        {
            // Implement your insert logic here
            // Example:
            // string insertQuery = $"INSERT INTO YourTable (ID, Column1) VALUES ('{id}', 'SomeValue')";
            // Execute the insert query
        }
    }
}
