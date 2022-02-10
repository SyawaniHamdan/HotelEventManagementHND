using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Event
{
    class reservation
    {
        private string _reserveID, _custID, _eventID, _staff;
        private double _deposit;

        public double Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }

        public string Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }

        public string EventID
        {
            get { return _eventID; }
            set { _eventID = value; }
        }

        public string CustID
        {
            get { return _custID; }
            set { _custID = value; }
        }

        public string ReserveID
        {
            get { return _reserveID; }
            set { _reserveID = value; }
        }
        private DateTime _startDate, _endDate, _timeIn, _timeOut;

        public DateTime TimeOut
        {
            get { return _timeOut; }
            set { _timeOut = value; }
        }

        public DateTime TimeIn
        {
            get { return _timeIn; }
            set { _timeIn = value; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public reservation()
        { }

        public reservation(string newReserveID, string newCustID, string newEventID, string newStaff, DateTime newStartDate, DateTime newEndDate, DateTime newTimeIn, DateTime newTimeOut, double newDeposit)
        {
            _reserveID = newReserveID;
            _custID = newCustID;
            _staff = newStaff;
            _startDate = newStartDate;
            _endDate = newEndDate;
            _timeIn = newTimeIn;
            _timeOut = newTimeOut;
            _deposit = newDeposit;
        }
    }
}
