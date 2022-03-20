using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Customer
    {
        private string _Customer_ID;
        public string Customer_ID 
        { 
            get { return _Customer_ID; }
            set { _Customer_ID = value; }
        }
        private string _First_Name;
        public string First_Name 
        {
            get { return _First_Name; }
            set { _First_Name = value; }
        }
        private string _Middle_Name;
        public string Middle_Name 
        {
            get { return _Middle_Name; }
            set { _Middle_Name = value; }
        }
        private string _Last_Name;
        public string Last_Name
        {
            get { return _Last_Name; }
            set { _Last_Name = value; }
        }
        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
    }
}
