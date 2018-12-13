using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class Driver
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string EmailAddress { get; set; }
        public string DUII { get; set; }
        public int SpeedingTickets { get; set; }
        public string InsuranceType { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }

        internal void Add(Driver driver)
        {
            throw new NotImplementedException();
        }

        internal static object FirstName()
        {
            throw new NotImplementedException();
        }

        internal static object LastName()
        {
            throw new NotImplementedException();
        }
    }
}