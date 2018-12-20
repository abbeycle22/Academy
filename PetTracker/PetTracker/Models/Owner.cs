using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetTracker.Models
{
    public class Owner
    {
        public int OwnerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}