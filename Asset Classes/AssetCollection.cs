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
            //fill in what u need here
          /*  for i in AssetList:
                if i.assetName is in assetList:
                    return assetList[assetName].index
                else return assetList.Count and add new() asset to assetlist
                */
        }
    }
}
