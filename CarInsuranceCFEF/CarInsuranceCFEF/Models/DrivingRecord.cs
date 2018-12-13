using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceCFEF.Models
{
    public class DrivingRecord
    {
        public string DUII { get; set; }
        public int speedingTickets { get; set; }
        public string insuranceType { get; set; }
    }
}