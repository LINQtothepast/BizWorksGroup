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
    /// Interaction logic for AssetShow.xaml
    /// </summary>
    public partial class AssetShow : Window
    {
        private string sessionUserAssetShow;
        private string passedAssetName;

        public AssetShow(string sessionUser, string sentUsername)
        {
            InitializeComponent();
            sessionUserAssetShow = sessionUser;
            passedAssetName = sentUsername;

            AssetID.Content = AssetCollection.GetAssetID(passedAssetName);
            AssetName.Text = passedAssetName;
            AssetValue.Text = AssetCollection.GetAssetValue(passedAssetName).ToString();
            AssetQuantity.Text = AssetCollection.GetAssetQuantity(passedAssetName).ToString();
            AssetCategory.Text = AssetCollection.GetAssetCategory(passedAssetName);
            NotesTextBox.Text = AssetCollection.GetAssetNotes(passedAssetName);

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
            int ID;

            ID = AssetCollection.GetAssetID(passedAssetName);
            assetName = AssetName.Text;
            assetValue = Convert.ToDouble(AssetValue.Text);
            assetQuantity = Convert.ToDouble(AssetQuantity.Text);
            category = AssetCategory.Text;
            createdBy = sessionUserAssetShow;
            createdOn = DateTime.Now;
            lastUpdatedBy = sessionUserAssetShow;
            lastUpdatedOn = DateTime.Now;
            notes = NotesTextBox.Text;

            //adds on to the back
            //so access with AssetCollection.last();
            //AssetCollection.AddAsset(ass, assValue, assQuant, cgory, cOn, cBy, notes);
            AssetCollection.ModifyAsset(ID, assetName, assetValue, assetQuantity,
                category, createdOn, createdBy, lastUpdatedOn, lastUpdatedBy, notes);

            MainMenu main = new MainMenu(sessionUserAssetShow);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
