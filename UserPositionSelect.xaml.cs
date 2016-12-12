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
    /// Interaction logic for UserPositionSelect.xaml
    /// </summary>
    public partial class UserPositionSelect : Window
    {
        private string sesstionUserSelectPosition;
        private string passedUsername;
        private string position;

        public UserPositionSelect(string sessionUserMainMenu, string sentUsername)
        {
            sentUsername = sessionUserMainMenu;
            sesstionUserSelectPosition = sessionUserMainMenu;

            InitializeComponent();

            List<UserPositionID> ListOfPositions = new List<UserPositionID>();
            ListOfPositions = UserPositionIDCollection.ReturnAList();

            this.CustomerListSelect.ItemsSource = ListOfPositions;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ProfileTypeModify main = new ProfileTypeModify(sesstionUserSelectPosition, passedUsername, position);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void CustomerListSelect_CellClick(object sender, SelectedCellsChangedEventArgs e)
        {
            string x = GetSelectedCellValue();
            TestLabel.Content = x;
            position = x;
            List<UserPositionID> checkXList = new List<UserPositionID>();
            checkXList = UserPositionIDCollection.ReturnAList();
            bool isThere = false;
            foreach (var element in checkXList)
            {
                if (element.UserPosition == x)
                {
                    isThere = true;
                }
            }
            if (isThere == false) MessageBox.Show("Please Select a Position Name before trying to click the Next button");
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
