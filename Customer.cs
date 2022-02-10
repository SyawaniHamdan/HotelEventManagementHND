using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Event
{
    class Customer
    {
        private string _custName, _custID, _phoneNo, _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }

        public string CustID
        {
            get { return _custID; }
            set { _custID = value; }
        }

        public string CustName
        {
            get { return _custName; }
            set { _custName = value; }
        }

        public Customer()
        { }

        public Customer(string newCustName, string newCustID, string newPhoneNo, string newEmail)
        {
            _custID = newCustID;
            _custName = newCustName;
            _phoneNo = newPhoneNo;
            _email = newEmail;
        }
    }
}
