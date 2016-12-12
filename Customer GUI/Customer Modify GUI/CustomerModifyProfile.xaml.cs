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
    /// Interaction logic for CustomerModifyProfile.xaml
    /// </summary>
    public partial class CustomerModifyProfile : Window
    {
        private string passedUsername;
        private string sessionUserCustomerModifyProfile;

        public CustomerModifyProfile(string sessionUser, string storedUsername)
        {
            InitializeComponent();
            passedUsername = storedUsername;
            sessionUserCustomerModifyProfile = sessionUser;

            //set customer fields
            ComName.Text = CustomerCollection.GetCompanyName(passedUsername);
            int holderVariable = CustomerCollection.GetProfileType(passedUsername);
            if (holderVariable == 3)
            { ProfileType.Text = "Customer"; }
            WorkPhone.Text = CustomerCollection.GetWorkPhone(passedUsername);
            FaxNumber.Text = CustomerCollection.GetFaxNumber(passedUsername);
            Email.Text = CustomerCollection.GetEmail(passedUsername);
            NotesTextBox.Text = CustomerCollection.GetNotes(passedUsername);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            int selectedProfileType = 0;
            string workNumber, fax;
            string userEmail, storedPassword;
            string notes, comName;
            comName = ComName.Text;
            workNumber = WorkPhone.Text;
            fax = FaxNumber.Text;
            //name = ComName.Text;
            userEmail = Email.Text;
            storedPassword = CustomerCollection.GetPassword(passedUsername);
            notes = NotesTextBox.Text;
            if (ProfileType.Text == "Customer")
            {
                selectedProfileType = 3;
            }

            DateTime dateRightNow = DateTime.Now;

            //adds on to the back
            //so access with UserCollection.last();
            CustomerCollection.ModifyCustomer(comName, selectedProfileType,
                passedUsername, storedPassword, workNumber,
                fax, userEmail,
                CustomerCollection.GetCreatedByDate(passedUsername), 
                CustomerCollection.GetCreatedBy(passedUsername), dateRightNow,
                sessionUserCustomerModifyProfile, notes);

            CustomerShow main = new CustomerShow(sessionUserCustomerModifyProfile, passedUsername);
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
