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
    /// Interaction logic for EmployeeShow.xaml
    /// </summary>
    public partial class EmployeeShow : Window
    {
        private string passedUsername;
        private string sessionUserEmployeeShow;
        public EmployeeShow(string sessionUser, string storedUsername)
        {            
            InitializeComponent();
            passedUsername = storedUsername;
            sessionUserEmployeeShow = sessionUser;

            //set Employee Fields
            UserName.Content = passedUsername;
            int holderVariable = UserEmployeeCollection.GetProfileType(passedUsername);
            if (holderVariable == 1)
            { ProfileType.Content = "Owner"; }
            FirstName.Content = UserEmployeeCollection.GetFirstName(passedUsername);
            MiddleName.Content = UserEmployeeCollection.GetMiddleName(passedUsername);
            LastName.Content = UserEmployeeCollection.GetLastName(passedUsername);
            DateOfBirth.Content = UserEmployeeCollection.GetDateOfBirth(passedUsername);
            Gender.Content = UserEmployeeCollection.GetGender(passedUsername);
            StartDate.Content = UserEmployeeCollection.GetStartDate(passedUsername);
            CellPhone1.Content = UserEmployeeCollection.GetMobilePhone1(passedUsername);
            CellPhone2.Content = UserEmployeeCollection.GetMobilePhone2(passedUsername);
            WorkPhone.Content = UserEmployeeCollection.GetWorkPhone(passedUsername);
            FaxPhone.Content = UserEmployeeCollection.GetFaxNumber(passedUsername);
            HomePhone.Content = UserEmployeeCollection.GetHomePhone(passedUsername);
            Email.Content = UserEmployeeCollection.GetEmail(passedUsername);

            //set Address Fields
            Street1.Content = UserEmployeeAddressCollection.GetStreet1(passedUsername);
            City1.Content = UserEmployeeAddressCollection.GetCity1(passedUsername);
            State1.Content = UserEmployeeAddressCollection.GetState1(passedUsername);
            ZipCode1.Content = UserEmployeeAddressCollection.GetZipCode1(passedUsername);
           
            Street2.Content = UserEmployeeAddressCollection2.GetStreet2(passedUsername);
            City2.Content = UserEmployeeAddressCollection2.GetCity2(passedUsername);
            State2.Content = UserEmployeeAddressCollection2.GetState2(passedUsername);
            ZipCode2.Content = UserEmployeeAddressCollection2.GetZipCode2(passedUsername);
            

            //set Emergency Contact Fields
            eFirstName1.Content = UserEmployeeEmergencyCollection.GetFirstName1(passedUsername);
            eLastName1.Content = UserEmployeeEmergencyCollection.GetLastName1(passedUsername);
            ePhoneNumber1.Content = UserEmployeeEmergencyCollection.GetPhone1(passedUsername);
            eRelation1.Content = UserEmployeeEmergencyCollection.GetRelation1(passedUsername);

            eFirstName2.Content = UserEmployeeEmergencyCollection2.GetFirstName2(passedUsername);
            eLastName2.Content = UserEmployeeEmergencyCollection2.GetLastName2(passedUsername);
            ePhoneNumber2.Content = UserEmployeeEmergencyCollection2.GetPhone2(passedUsername);
            eRelation2.Content = UserEmployeeEmergencyCollection2.GetRelation2(passedUsername);
                  
        }

        private void ErrorInEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeModify main = new EmployeeModify(sessionUserEmployeeShow, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void ErrorInAddress_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAddressModify main = new EmployeeAddressModify(sessionUserEmployeeShow, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void ErrorInEmergencyContact_Click(object sender, RoutedEventArgs e)
        {
            EmployeeEContactModify main = new EmployeeEContactModify(sessionUserEmployeeShow, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu(sessionUserEmployeeShow);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
