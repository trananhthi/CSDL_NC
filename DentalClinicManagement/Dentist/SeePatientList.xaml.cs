using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class SeePatientList : Page
    {
        
        private DB db;
        public SeePatientList()
        {
            InitializeComponent();
            try
            {
                db = new DB();
                using (SqlConnection connection = db.Connection)
                {
                    string query = $"SELECT * FROM BENHNHAN";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Assuming you have defined a DataGrid in XAML with x:Name="patientDataGrid"
                    patientDataGrid.ItemsSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }

}
