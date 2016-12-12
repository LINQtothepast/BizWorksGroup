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
    /// Interaction logic for AssetAdd.xaml
    /// </summary>
    public partial class AssetAdd: Window
    {
        private string sessionUserAssetAdd;

        public AssetAdd(string sessionUserMainMenu)
        {
            InitializeComponent();
            sessionUserAssetAdd = sessionUserMainMenu;     
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            string assetName, category, createdBy, notes;
            string lastUpdatedBy;
            double assetValue, assetQuantity;
            DateTime createdOn, lastUpdatedOn;

            assetName = AssetName.Text;
            assetValue  = Convert.ToDouble(AssetValue.Text);
            assetQuantity = Convert.ToDouble(AssetQuantity.Text);
            category = AssetCategory.Text;
            createdBy = sessionUserAssetAdd;
            createdOn = DateTime.Now;
            lastUpdatedBy = sessionUserAssetAdd;
            lastUpdatedOn = DateTime.Now;
            notes = NotesTextBox.Text;

            //adds on to the back
            //so access with AssetCollection.last();
            //AssetCollection.AddAsset(ass, assValue, assQuant, cgory, cOn, cBy, notes);
            AssetCollection.AddAsset(assetName, assetValue, assetQuantity,
                category, createdOn, createdBy, lastUpdatedOn, lastUpdatedBy, notes);

            AssetShow main = new AssetShow(sessionUserAssetAdd, assetName);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
