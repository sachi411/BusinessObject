using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderLine
    {
        private string _Product_ID;
        public string Product_ID
        {
            get { return _Product_ID; }
            set { _Product_ID = value; }
        }
        private int _Order_ID;
        public int Order_ID
        {
            get { return _Order_ID; }
            set { _Order_ID = value; }
        }
        private decimal _Selling_Price;
        public decimal Selling_Price
        {
            get { return _Selling_Price; }
            set { _Selling_Price = value; }
        }
        private int _Quantity_ordered;
        public int Quantity_ordered
        {
            get { return _Quantity_ordered; }
            set { _Quantity_ordered = value; }
        }
        private decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
    }
}
