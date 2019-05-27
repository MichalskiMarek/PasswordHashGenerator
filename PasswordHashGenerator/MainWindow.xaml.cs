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


namespace PasswordHashGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string clientName;
        string date;
        string hashedPassword;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validation.DataValidation(clientName, date))
            {
                 hashedPassword = Hashing.CreateHashedPassword(clientName, date);
                 HashedPassword.Text = hashedPassword;
            }
        }

        private void ClientNameData_TextChanged(object sender, TextChangedEventArgs e)
        {
            clientName = ClientNameData.Text;
        }

        private void DateBox_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            date = DateBox.SelectedDate.Value.ToString("dd.MM.yyyy");
        }
    }
}
