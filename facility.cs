using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Event
{
    class facility
    {
        private string _facilityID, _eventID;
        private int _chair, _table, _PAsystem, _mic;

        public int Mic
        {
            get { return _mic; }
            set { _mic = value; }
        }

        public int PAsystem
        {
            get { return _PAsystem; }
            set { _PAsystem = value; }
        }

        public int Table
        {
            get { return _table; }
            set { _table = value; }
        }

        public int Chair
        {
            get { return _chair; }
            set { _chair = value; }
        }
        public string EventID
        {
            get { return _eventID; }
            set { _eventID = value; }
        }

        public string FacilityID
        {
            get { return _facilityID; }
            set { _facilityID = value; }
        }

        public facility()
        { }

        public facility(string newFacilityId, string newEventID, int newChair, int newTable, int newPAsystem)
        {
            _facilityID = newFacilityId;
            _eventID = newEventID;
            _chair = newChair;
            _table = newTable;
            _PAsystem = newPAsystem;
        }
    }
}
