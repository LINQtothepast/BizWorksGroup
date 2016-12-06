using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class Asset
    {
        private int assetID;
        private string assetName;
        private float assetValue;
        private float assetQuantity;
        private string category;
        private float totalValue;
   
        
        private static List<Asset> AssetList = new List<Asset>();
     

        //constructor
        public Asset(string assetName, float assetValue, float assetQuantity, string category){
            AssetName = assetName;
            AssetValue = assetValue;
            AssetQuantity = assetQuantity;
            Category = category;
            AssetID = assetList.size();
            TotalValue = assetValue * assetQuantity;
        }
        
        public static update(assetID, isCredit, transactionAmount){
            // update asset amount
        }
        
        public int AssetID
        {
            get { return assetID; }
            set { assetID = value; }
        }
        
        public string AssetName
        {
            get { return assetName; }
            set {assetName = value; }
        }
  
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
     
        public float AssetValue
        {
            get { return assetValue; }
            set { assetValue = value; }
        }
        
        public float AssetQuantity
        {
            get {return assetQuantity; }
            set { assetQuantity = value; }
        }
          
    }
}
