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
    /// Interaction logic for profileTypeAdd.xaml
    /// </summary>
    public partial class profileTypeAdd : Window
    {
        private string ProfileTypeAddSessionUser;

        public profileTypeAdd(string MainMenuSession)
        {
            InitializeComponent();
            ProfileTypeAddSessionUser = MainMenuSession;
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            int ID;
            string PositionName;
            double Pay;

            ID = Convert.ToInt32(PositionID.Text);
            PositionName = PositionNameTextBox.Text;
            Pay = Convert.ToDouble(PositionPay.Text);

            UserPositionIDCollection.addUserPositionID(ID, PositionName, Pay);

            MainMenu main = new MainMenu(ProfileTypeAddSessionUser);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}
