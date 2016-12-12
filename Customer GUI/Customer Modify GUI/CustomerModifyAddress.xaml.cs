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
    /// Interaction logic for CustomerModifyAddress.xaml
    /// </summary>
    public partial class CustomerModifyAddress : Window
    {
        private string passedUsername;
        private string sessionUserCustomerModifyAddress;

        public CustomerModifyAddress(string sessionUser, string storedUsername)
        {
            InitializeComponent();
            passedUsername = storedUsername;
            sessionUserCustomerModifyAddress = sessionUser;

            //set address fields
            UserInputStreet1.Text = CustomerAddressCollection.GetStreet1(passedUsername);
            UserInputCity1.Text = CustomerAddressCollection.GetCity1(passedUsername);
            UserInputState1.Text = CustomerAddressCollection.GetState1(passedUsername);
            UserInputZip1.Text = Convert.ToString(CustomerAddressCollection.GetZipCode1(passedUsername));
            NotesTextBox1.Text = CustomerAddressCollection.GetNotes1(passedUsername);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            string street1, city1, state1;
            string notes1;
            int zip1;
            DateTime dateRightNow = DateTime.Now;

            street1 = UserInputStreet1.Text;
            city1 = UserInputCity1.Text;
            state1 = UserInputState1.Text;
            zip1 = Convert.ToInt32(UserInputZip1.Text);
            notes1 = NotesTextBox1.Text;
            CustomerAddressCollection.ModifyCustomerAddress1(passedUsername,
                    street1, city1, state1, zip1, 
                    CustomerAddressCollection.GetCreatedByDate(passedUsername),
                    CustomerAddressCollection.GetCreatedBy(passedUsername), dateRightNow,
                    sessionUserCustomerModifyAddress, notes1);

            CustomerShow main = new CustomerShow(sessionUserCustomerModifyAddress, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }
    }
}
