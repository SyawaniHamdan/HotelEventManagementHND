using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Event
{
    class Event
    {
        private string _eventID, _eventName, _eventType, _eventLoc;
        private int _maxseat, _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        private double _totalprice;


        public double Totalprice
        {
            get { return _totalprice; }
            set { _totalprice = value; }
        }

        public int Maxseat
        {
            get { return _maxseat; }
            set { _maxseat = value; }
        }

        public string EventLoc
        {
            get { return _eventLoc; }
            set { _eventLoc = value; }
        }

        public string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; }
        }

        public string EventID
        {
            get { return _eventID; }
            set { _eventID = value; }
        }

        public Event()
        { }

        public Event(string newEventID, string newEventName, string newEventType, string newEvenLoc, int newMaxseat, double newTotalPrice, int newQuantity)
        {
            _eventID = newEventID;
            _eventName = newEventName;
            _eventType = newEventType;
            _eventLoc = newEvenLoc;
            _maxseat = newMaxseat;
            _totalprice = newTotalPrice;
            _quantity = newQuantity;

        }
        public void SetPriceEvent()
        {
            switch (_eventType)
            {
                case "Full Day Meeting":
                    _totalprice = (_totalprice + 800.00 * _quantity) - 100;
                   
                    break;
                case "Half Day Meeting":
                    _totalprice = (_totalprice + 400.00 * _quantity) - 100;
                   
                    break;
                case "Full Day Seminar":
                    _totalprice = (_totalprice + 800.00 * _quantity) - 100;
                    
                    break;
                case "Half Day Seminar":
                    _totalprice = (_totalprice + 400.00 * _quantity) - 100;
                    
                    break;
                case "Birthday Party":
                    _totalprice = (_totalprice + 150.00 * _quantity) - 100;
                   
                    break;
            }
        }
    }
}
