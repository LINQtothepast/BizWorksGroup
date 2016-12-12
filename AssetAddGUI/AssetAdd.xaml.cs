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
        private string assetAddUsernamePass;

        public AssetAdd(string sessionUserMainMenu)
        {
            InitializeComponent();
            sessionUserEmployeeAdd1 = sessionUserMainMenu;     
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
             float assetValue, assetQuantity;
             string category;
             DateTime createdOn, 
             
             
             ass = AssetName.Text;
             assValue  = AssetValue.Text;
             assQuant = TransactionAmount.Text;
             cgory = Category.Text;
             cBy = Username.Text;
             cOn = DateTime.Today;
             notes = Notes.Text;

            //adds on to the back
            //so access with AssetCollection.last();
            AssetCollection.AddAsset(ass, assValue, assQuant, cgory, cOn, cBy, notes);

            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
