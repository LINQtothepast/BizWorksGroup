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
    /// Interaction logic for SelectCustomerToView.xaml
    /// </summary>
    public partial class SelectCustomerToView : Window
    {
        private string sessionUserSelectCustomerToView;
        private string passedUsername;

        public SelectCustomerToView(string sessionUserMainMenu)
        {
            passedUsername = sessionUserMainMenu;
            sessionUserSelectCustomerToView = sessionUserMainMenu;

            InitializeComponent();

            List<Customer> ListOfCustomers = new List<Customer>();
            ListOfCustomers = CustomerCollection.ReturnAList();

            var tempList =
                from customer in ListOfCustomers
                select new
                {
                    Name = customer.CompanyName,
                    Username = customer.Username,
                    Email = customer.Email,
                    CreatedBy = customer.UserCreatedBy,
                    CreatedOn = customer.UserCreatedOn,
                    UpdatedBy = customer.UserLastUpdatedBy,
                    UpdatedOn = customer.UserLastUpdatedOn
                };

            this.CustomerListSelect.ItemsSource = tempList;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CustomerShow main = new CustomerShow(sessionUserSelectCustomerToView, passedUsername);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void CustomerListSelect_CellClick(object sender, SelectedCellsChangedEventArgs e)
        {
            string x = GetSelectedCellValue();
            TestLabel.Content = x;
            passedUsername = x;
            List<Customer> checkXList = new List<Customer>();
            checkXList = CustomerCollection.ReturnAList();
            bool isThere = false;
            foreach (var element in checkXList)
            {
                if (element.Username == x)
                {
                    isThere = true;
                }
            }
            if (isThere == false) MessageBox.Show("Please Select a Username before trying to click the Next button");
        }

        public string GetSelectedCellValue()
        {
            DataGridCellInfo cellInfo = CustomerListSelect.SelectedCells[0];
            if (cellInfo == null) return null;

            DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
            if (column == null) return null;

            FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
            BindingOperations.SetBinding(element, TagProperty, column.Binding);

            return element.Tag.ToString();
        }
    }
}
