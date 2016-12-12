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
using System.Windows.Shapes;
using System.Globalization;

namespace BizWorks
{
    /// <summary>
    /// Interaction logic for CustomerAdd1.xaml
    /// </summary>
    public partial class CustomerAdd1 : Window
    {
        private string sessionUserCustomerAdd1;

        public CustomerAdd1(string sessionUserMainMenu)
        {
            InitializeComponent();
            sessionUserCustomerAdd1 = sessionUserMainMenu;
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            int selectedProfileType = 0;
            string workNumber, fax, name;
            string userEmail, storedUsername, storedPassword;
            string notes;
            workNumber = WorkPhone.Text;
            fax = FaxNumber.Text;
            name = ComName.Text;
            userEmail = Email.Text;
            storedUsername = Username.Text;
            storedPassword = Password.Text;
            notes = NotesTextBox.Text;
            if (ProfileType.Text == "Customer")
            {
                selectedProfileType = 3;
            }

            DateTime dateRightNow = DateTime.Now;

            //adds on to the back
            //so access with UserCollection.last();
            CustomerCollection.AddCustomer(name, selectedProfileType,
                storedUsername, storedPassword,  workNumber,
                fax, userEmail,
                dateRightNow, sessionUserCustomerAdd1, dateRightNow,
                sessionUserCustomerAdd1, notes);

            CustomerAdd2 main = new CustomerAdd2(sessionUserCustomerAdd1, storedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

    }
}
