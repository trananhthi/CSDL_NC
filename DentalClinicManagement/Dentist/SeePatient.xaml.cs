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

namespace DentalClinicManagement.Dentist
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class SeePatient : Page
    {
        public SeePatient()
        {
            InitializeComponent();
        }

        private void SeePatientList_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to show the patient list
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;


            if (mainWindow != null && mainWindow.MainFrame != null)
            {
                mainWindow.MainFrame.Navigate(new DentalClinicManagement.Dentist.SeePatientList());
            }
        }

        private void AddUpdatePatient_Click(object sender, RoutedEventArgs e)
        {
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;


            if (mainWindow != null && mainWindow.MainFrame != null)
            {
                mainWindow.MainFrame.Navigate(new DentalClinicManagement.Dentist.SeePatientList());
            }
        }

        private void SeePatientRecord_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to show a specific patient's record
            MessageBox.Show("Showing Patient Record");
        }
    }
}
