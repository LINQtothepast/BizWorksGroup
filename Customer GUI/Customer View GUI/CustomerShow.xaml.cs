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

namespace BizWorks
{
    /// <summary>
    /// Interaction logic for CustomerShow.xaml
    /// </summary>
    public partial class CustomerShow : Window
    {
        private string passedUsername;
        private string sessionUserCustomerShow;

        public CustomerShow(string sessionUser, string storedUsername)
        {
            InitializeComponent();
            passedUsername = storedUsername;
            sessionUserCustomerShow = sessionUser;


            //set customer fields
            ComName.Content = CustomerCollection.GetCompanyName(passedUsername);
            UserName.Content = passedUsername;
            int holderVariable = CustomerCollection.GetProfileType(passedUsername);
            if (holderVariable == 3)
            { ProfileType.Content = "Customer"; }
            WorkPhone.Content = CustomerCollection.GetWorkPhone(passedUsername);
            FaxPhone.Content = CustomerCollection.GetFaxNumber(passedUsername);
            Email.Content = CustomerCollection.GetEmail(passedUsername);

            //set address fields
            Street1.Content = CustomerAddressCollection.GetStreet1(passedUsername);
            City1.Content = CustomerAddressCollection.GetCity1(passedUsername);
            State1.Content = CustomerAddressCollection.GetState1(passedUsername);
            ZipCode1.Content = CustomerAddressCollection.GetZipCode1(passedUsername);
        }

        private void ErrorInCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerModifyProfile main = new CustomerModifyProfile(sessionUserCustomerShow, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void ErrorInCustomerAddress_Click(object sender, RoutedEventArgs e)
        {
            CustomerModifyAddress main = new CustomerModifyAddress(sessionUserCustomerShow, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu(sessionUserCustomerShow);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
