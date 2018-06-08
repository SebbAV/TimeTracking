using System;
using System.Collections.Generic;
using TimeTracking.Models;

namespace TimeTracking
{
    public class Employee
    {
        public string Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Position
        {
            get;
            set;
        }
        public string RFID
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
        public List<TimeTrackingClass> WorkedTime { get; set; }
        public double Payment { get; set; }
    }
}
