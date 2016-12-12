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
        private double assetValue;
        private double assetQuantity;
        private string category;
        private double totalValue;
   
        //constructor
        public Asset(string assetName, double assetValue, double assetQuantity, string category,
            DateTime createdOn, string createdBy, DateTime updatedOn, string updatedBy, string notes)
            : base(createdOn, createdBy, updatedOn, updatedBy, notes)
        {
            AssetID = AssetCollection.SetAssetID();
            AssetName = assetName;
            AssetValue = assetValue;
            AssetQuantity = assetQuantity;
            Category = category;
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
     
        public double AssetValue
        {
            get { return assetValue; }
            set { assetValue = value; }
        }
        
        public double AssetQuantity
        {
            get {return assetQuantity; }
            set { assetQuantity = value; }
        }
        
        public double TotalValue
        {
            get { return totalValue; }
            set { totalValue = value; }
        }
    }
}
