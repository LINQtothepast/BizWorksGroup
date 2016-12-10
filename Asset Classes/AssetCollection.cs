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

        public static void AddAsset(string assetName, float assetValue, float assetQuantity,
            string category, DateTime createdOn, string createdBy,
            DateTime lastUpdatedOn, string lastUpdatedBy, string notes)
        {
            AssetList.Add(new Asset(assetName, assetValue, assetQuantity,
                category, createdOn, createdBy, lastUpdatedOn, lastUpdatedBy, notes));
        }

        public static int GetAssetID()
        {
            int x = AssetList.Count();
            return x;
        }
        
        public static float GetTotalValue(Asset ass)
        {
            return ass.assetValue * ass.assetQuantity;
        }
            
        
        public static String printDetails(String name){
            for (int i = 0; i <= AssetList.Count(); i++)
            {
                if (AssetList[i].assetName == name){
                    Console.WriteLine("Name : ", AssetList[i].name);
                    Console.WriteLine("Value : ", AssetList[i].assetValue);
                    Console.WriteLine("Quantity : ", AssetList[i].assetQuantity);
                    Console.WriteLine("Total Value : ", GetTotalValue(assetList[i]);
                    }
            }
         }
                                      
    }
}
