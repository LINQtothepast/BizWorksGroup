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
    /// Interaction logic for CustomerAdd2.xaml
    /// </summary>
    public partial class CustomerAdd2 : Window
    {
        private string sessionUserCustomerAdd2;
        private string passedUsername;

        public CustomerAdd2(string sessionUserCustomerAdd1, string storedUsername)
        {
            InitializeComponent();
            sessionUserCustomerAdd2 = sessionUserCustomerAdd1;
            passedUsername = storedUsername;
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
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
            CustomerAddressCollection.addCustomerAddress(passedUsername,
                    street1, city1, state1, zip1, dateRightNow,
                    sessionUserCustomerAdd2, dateRightNow,
                    sessionUserCustomerAdd2, notes1);

            MainMenu main = new MainMenu(sessionUserCustomerAdd2);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
