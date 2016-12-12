using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BizWorks
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Window1 wnd = new Window1();
            DateTime value = new DateTime(2016, 11, 1, 5, 20, 00); 
            //call for loading in users from database goes here.
            //below is a temporary test case object
            UserEmployeeCollection.addUser(1, "Derek", "Thomas", "Blankinship", 1, 1,
                "admin", "password", value, 'M', "574-123-1234", "574-234-2345",
                "N/A", "574-345-3456", "N/A", "sun@gmail.com", value,
                value, value, "admin", value, "admin",
                "no notes");
            UserEmployeeCollection.addUser(1, "Hunter", "H", "Johnson", 1, 1,
                "user2", "12345", value, 'M', "574-410-2323", "574-234-7811",
                "N/A", "574-420-6969", "N/A", "hjohnson@gmail.com", value,
                value, value, "admin", value, "admin",
                "no notes");
            UserEmployeeCollection.addUser(1, "Andrew", "A", "Stone", 1, 1,
                "user3", "12345", value, 'M', "574-123-4201", "574-234-6955",
                "N/A", "574-666-1337", "N/A", "astone@gmail.com", value,
                value, value, "admin", value, "admin",
                "no notes");

            UserEmployeeAddressCollection.addUserAddress1("admin", "exampleStreet1",
                "exampleCity1", "exampleState1", 12345, value, "admin", value, "admin", "no notes");
            UserEmployeeAddressCollection2.addUserAddress2("admin", "exampleStreet2",
                "exampleCity2", "exampleState2", 23456, value, "admin", value, "admin", "no notes");
            UserEmployeeEmergencyCollection.addUserEmergencyContact1("admin", "Tara", "Blankinship",
                "574-567-8901", "wife", value, "admin", value, "admin", "no notes");
            UserEmployeeEmergencyCollection2.addUserEmergencyContact2("admin", "ASD", "adf",
                "adsf", "adsf", value, "admin", value, "admin", "no notes");

            UserEmployeeAddressCollection.addUserAddress1("user2", "321 Red Drive",
               "exampleCity1", "exampleState1", 54378, value, "admin", value, "admin", "no notes");
            UserEmployeeAddressCollection.addUserAddress1("user3", "275 Green Avenue",
               "exampleCity1", "exampleState1", 43589, value, "admin", value, "admin", "no notes");
            UserEmployeeEmergencyCollection.addUserEmergencyContact1("user2", "John", "Meme",
               "574-567-6969", "wife", value, "admin", value, "admin", "no notes");
            UserEmployeeEmergencyCollection.addUserEmergencyContact1("user3", "Max", "Smith",
               "574-216-2017", "wife", value, "admin", value, "admin", "no notes");

            CustomerCollection.AddCustomer("Walmart", 3, "walmart", "edlp33", "574-201-5669", "574-420-7878",
                "walmart@walmart.com", value, "N/A", value, "N/A", "no notes");
            CustomerCollection.AddCustomer("Dicks Sporting Goods", 3, "dicks", "sports", "574-343-5555", "574-777-9999",
                "dicks@sportinggoods.com", value, "admin", value, "admin", "no notes");
            CustomerCollection.AddCustomer("Dominos Pizza", 3, "dominos", "pizza", "574-666-6666", "574-323-0909",
                "dominos@pizza.com", value, "admin", value, "admin", "no notes");

            AssetCollection.AddAsset("Lawnmowers", 2000.0, 10.0, "Hardware", value, "admin", value, "admin", "for cutting grass");
            AssetCollection.AddAsset("Leafblowers", 500.0, 5.0, "Hardware", value, "admin", value, "admin", "for blowing leaves");
            AssetCollection.AddAsset("Snowblowers", 400.0, 4.0, "Hardware", value, "admin", value, "admin", "for blowing snow");

            TransactionCollection.AddTransaction(true, "walmart", 50069.00, "Stuff", value, "Lawnmowers", value, "admin", value, "admin", "no notes");
            TransactionCollection.AddTransaction(true, "dominos", 6666.00, "Hardware", value, "Snowblowers", value, "admin", value, "admin", "no notes");
            TransactionCollection.AddTransaction(true, "dicks", 5555.00, "Stuff", value, "Leafblowers", value, "admin", value, "admin", "no notes");

            wnd.Show();
        }

    }
}
