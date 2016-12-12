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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        private string sessionUserMainMenu;

        public MainMenu(string sessionUserLogin)
        {
            InitializeComponent();
            sessionUserMainMenu = sessionUserLogin;
        }

        private void AddEmployeeClick(object sender, RoutedEventArgs e)
        {
            EmployeeAdd1 main = new EmployeeAdd1(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void EmployeeUpdate_Click(object sender, RoutedEventArgs e)
        {
            SelectUserToView main = new SelectUserToView(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void EmployeeChangeStatusClick(object sender, RoutedEventArgs e)
        {
            SelectUserToView1 main = new SelectUserToView1(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void AddCustomerClick(object sender, RoutedEventArgs e)
        {
            CustomerAdd1 main = new CustomerAdd1(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void EditCustomerClick(object sender, RoutedEventArgs e)
        {
            SelectCustomerToView main = new SelectCustomerToView(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void AddAssetClick(object sender, RoutedEventArgs e)
        {
            AssetAdd main = new AssetAdd(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void EditAssetClick(object sender, RoutedEventArgs e)
        {
            SelectAssetToView main = new SelectAssetToView(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void AddTransactionClick(object sender, RoutedEventArgs e)
        {
            TransactionSelectCustomer main = new TransactionSelectCustomer(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void ViewTransactionClick(object sender, RoutedEventArgs e)
        {
            TransactionView main = new TransactionView(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void PositionAddClick(object sender, RoutedEventArgs e)
        {
            profileTypeAdd main = new profileTypeAdd(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
        private void PositionUpdateClick(object sender, RoutedEventArgs e)
        {
            SelectUserToView2 main = new SelectUserToView2(sessionUserMainMenu);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
