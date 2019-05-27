using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PasswordHashGenerator
{
    class Validation
    {
        public static bool DataValidation(string clientName, string date)
        {
            if (clientName == null || clientName.Length == 0)
            {
                MessageBox.Show("Client name cannot be empty!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else if (date == null)
            {
                return false;
            }
            else return true;
        }

    }
}
