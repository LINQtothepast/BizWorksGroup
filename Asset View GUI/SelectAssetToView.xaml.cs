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
    /// Interaction logic for SelectAssetToView.xaml
    /// </summary>
    public partial class SelectAssetToView : Window
    {
        private string sessionUserSelectAssetToView;
        private string selectedAssetName;
        
        public SelectAssetToView(string sessionUserMainMenu)
        {
            InitializeComponent();
            sessionUserSelectAssetToView = sessionUserMainMenu;

            List<Asset> ListOfAssets = new List<Asset>();
            ListOfAssets = AssetCollection.ReturnAList();

            this.AssetListSelect.ItemsSource = ListOfAssets;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AssetShow main = new AssetShow(sessionUserSelectAssetToView, selectedAssetName);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void AssetListSelect_CellClick(object sender, SelectedCellsChangedEventArgs e)
        {
            string x = GetSelectedCellValue();
            TestLabel.Content = x;
            selectedAssetName = x;
            List<Asset> checkXList = new List<Asset>();
            checkXList = AssetCollection.ReturnAList();
            bool isThere = false;
            foreach (var element in checkXList)
            {
                if (element.AssetName == x)
                {
                    isThere = true;
                }
            }
            if (isThere == false) MessageBox.Show("Please Select a AssetName before trying to click the Next button");
        }

        public string GetSelectedCellValue()
        {
            DataGridCellInfo cellInfo = AssetListSelect.SelectedCells[0];
            if (cellInfo == null) return null;

            DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
            if (column == null) return null;

            FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
            BindingOperations.SetBinding(element, TagProperty, column.Binding);

            return element.Tag.ToString();
        }
    }
}
