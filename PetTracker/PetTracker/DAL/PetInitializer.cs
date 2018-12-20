using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PetTracker.Models;

namespace PetTracker.DAL
{
    public class PetInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PetContext>
    {
        protected override void Seed(PetContext context)
        {
            var owners = new List<Owner>
            {
                new Owner{FirstName="Lorri",LastName="Henry",Address="8401 NE 276th St", City="Battle Ground", State="WA", ZipCode= 98604, PhoneNumber="360-521-6005"}
            };

            owners.ForEach(s => context.Owners.Add(s));
            context.SaveChanges();
            var pets = new List<Pet>
            {
                new Pet{PetName="Mochi", PetAge= 1, PetType="Dog", PetBreed="Chihuhua", PetColor="Brown"}
            };
            pets.ForEach(s => context.Pets.Add(s));
            context.SaveChanges();
            
        }
    }
}