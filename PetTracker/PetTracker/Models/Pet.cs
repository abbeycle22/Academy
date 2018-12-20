using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetTracker.Models
{
    public class Pet
    {
        public int PetID { get; set; }
        public string PetName { get; set; }
        public int PetAge { get; set; }
        public string PetType { get; set; }
        public string PetBreed { get; set; }
        public string PetColor { get; set; }

        public virtual Owner Owner { get; set; }
    }
}