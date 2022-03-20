using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Order
    {
        private int _Order_ID;
        public int Order_ID
        {
            get { return _Order_ID; }
            set { _Order_ID = value; }
        }
        private DateTime _Order_Date;
        public DateTime Order_Date
        {
            get { return _Order_Date; }
            set { _Order_Date = value; }
        }
        private decimal _Order_Amount;
        public decimal Order_Amount
        {
            get { return _Order_Amount; }
            set { _Order_Amount = value; }
        }
        private DateTime _Shippment_Date;
        public DateTime Shippment_Date
        {
            get { return _Shippment_Date; }
            set { _Shippment_Date = value; }
        }
        private DateTime _Delivered_Date;
        public DateTime Delivered_Date
        {
            get { return _Delivered_Date; }
            set { _Delivered_Date = value; }
        }

        private string _Order_status;
        public string Order_status
        {
            get { return _Order_status; }
            set { _Order_status = value; }
        }
        private string _Paid_status;
        public string Paid_status
        {
            get { return _Paid_status; }
            set { _Paid_status = value; }
        }
        private string _Customer_ID;
        public string Customer_ID
        {
            get { return _Customer_ID; }
            set { _Customer_ID = value; }
        }
    }
}
