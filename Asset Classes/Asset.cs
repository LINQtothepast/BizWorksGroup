using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizWorks
{
    public class Asset : CreateUpdate
    {
        private int assetID;
        private string assetName;
        private float assetValue;
        private float assetQuantity;
        private string category;
        private float totalValue;
   
        //constructor
        public Asset(string assetName, float assetValue, float assetQuantity, string category,
            DateTime createdOn, string createdBy, DateTime lastUpdatedOn,
            string lastUpdatedBy, string notes)
            : base(createdOn, createdBy, lastUpdatedOn, lastUpdatedBy, notes)
        { 
            AssetName = assetName;
            AssetValue = assetValue;
            AssetQuantity = assetQuantity;
            Category = category;
            AssetID = AssetCollection.GetAssetID();
            TotalValue = assetValue * assetQuantity;
        }

        //properties
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
        
        public float TotalValue
        {
            get { return totalValue; }
            set { totalValue = value; }
        }

        //methods
        public static void update(int assetID, bool isCredit,
            float transactionAmount)
        {
            // update asset amount
        }
    }
}
