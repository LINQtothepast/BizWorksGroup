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
    /// Interaction logic for TransactionView.xaml
    /// </summary>
    public partial class TransactionView : Window
    {
        private string sessionUserViewAllTransactions;

        public TransactionView(string sessionUserMainMenu)
        {
            InitializeComponent();
            sessionUserViewAllTransactions = sessionUserMainMenu;

            List<Transaction> ListOfTransaction = new List<Transaction>();
            ListOfTransaction = TransactionCollection.ReturnAList();

            this.TransactionListSelect.ItemsSource = ListOfTransaction;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu(sessionUserViewAllTransactions);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

    }
}
