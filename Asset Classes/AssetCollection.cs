using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class AssetCollection
    {
        private static List<Asset> AssetList = new List<Asset>();

        public static void AddAsset(string assetName, double assetValue, double assetQuantity,
            string category, DateTime createdOn, string createdBy,
            DateTime lastUpdatedOn, string lastUpdatedBy, string notes)
        {
            AssetList.Add(new Asset(assetName, assetValue, assetQuantity,
                category, createdOn, createdBy, lastUpdatedOn, lastUpdatedBy, notes));
        }

        public static void ModifyAsset(int ID, string assetName, double assetValue, double assetQuantity,
            string category, DateTime createdOn, string createdBy,
            DateTime lastUpdatedOn, string lastUpdatedBy, string notes)
        {
            foreach (var element in AssetList
                .Where(element => element.AssetID == ID))
            {
                element.AssetName = assetName;
                element.AssetValue = assetValue;
                element.AssetQuantity = assetQuantity;
                element.Category = category;
                element.UserCreatedOn = createdOn;
                element.UserCreatedBy = createdBy;
                element.UserLastUpdatedOn = lastUpdatedOn;
                element.UserLastUpdatedBy = lastUpdatedBy;
                element.UserNotes = notes;
            }
        }

        public static List<Asset> ReturnAList()
        {
            List<Asset> theList = new List<Asset>();
            theList = AssetList;

            return theList;
        }

        public static int SetAssetID()
        {
            int x = 0;
            x = AssetList.Count();
            return x;
        }
        
        public static double GetTotalValue(Asset ass)
        {
            return ass.AssetValue * ass.AssetQuantity;
        }
            
        
        public static void printDetails(String name){

            foreach (var element in AssetList)
            {
                if (element.AssetName == name)
                {
                    Console.WriteLine("Name : ", element.AssetName);
                    Console.WriteLine("Value : ", element.AssetValue);
                    Console.WriteLine("Quantity : ", element.AssetQuantity);
                    Console.WriteLine("Total Value : ", GetTotalValue(element));
                }
            }
         }

        public static double GetAssetValue(string assetName)
        {
            double x = 0;
            var query =
                from element in AssetList
                where element.AssetName == assetName
                select element.AssetValue;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static double GetAssetQuantity(string assetName)
        {
            double x = 0;
            var query =
                from element in AssetList
                where element.AssetName == assetName
                select element.AssetQuantity;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetAssetCategory(string assetName)
        {
            string x = " ";
            var query =
                from element in AssetList
                where element.AssetName == assetName
                select element.Category;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static int GetAssetID(string assetName)
        {
            int x = 0;
            var query =
                from element in AssetList
                where element.AssetName == assetName
                select element.AssetID;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetCreatedBy(string assetName)
        {
            string x = " ";
            var query =
                from element in AssetList
                where element.AssetName == assetName
                select element.Category;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static DateTime GetCreatedOn(string assetName)
        {
            DateTime x = new DateTime();
            var query =
                from element in AssetList
                where element.AssetName == assetName
                select element.UserCreatedOn;
            foreach (var item in query) { x = item; }
            return x;
        }
        public static string GetAssetNotes(string assetName)
        {
            string x = " ";
            var query =
                from element in AssetList
                where element.AssetName == assetName
                select element.UserNotes;
            foreach (var item in query) { x = item; }
            return x;
        }
    }
}
