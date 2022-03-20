using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Product
    {
        private string _Product_ID;
        public string Product_ID
        {
            get { return _Product_ID; }
            set { _Product_ID = value; }
        }
        private string _Product_Name;
        public string Product_Name
        {
            get { return _Product_Name; }
            set { _Product_Name = value; }
        }
        private string _Product_Description;
        public string Product_Description
        {
            get { return _Product_Description; }
            set { _Product_Description = value; }
        }
        private decimal _Listing_Price;
        public decimal Listing_Price
        {
            get { return _Listing_Price; }
            set { _Listing_Price = value; }
        }
        private int _Quantity_in_hand;
        public int Quantity_in_hand
        {
            get { return _Quantity_in_hand; }
            set { _Quantity_in_hand = value; }
        }
        public int _Reorder_Level;
        public int Reorder_Level
        {
            get { return _Reorder_Level; }
            set { _Reorder_Level = value; }
        }
    }
}
