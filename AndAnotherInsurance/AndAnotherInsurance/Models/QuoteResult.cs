using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AndAnotherInsurance.Models
{
    public class QuoteResult
    {
        //private readonly string connectionString = @"Data Source=DESKTOP-OS50PJS\SQLEXPRESS;Initial Catalog=Quote;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //private readonly string queryString;
        //private readonly string queryString = @"INSERT INTO Quote (finalQuote) VALUES (@finalQuote)";

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Birthday { get; set; }
        public string CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUII { get; set; }
        public int SpeedingTickets { get; set; }
        public string InsuranceType { get; set; }
        public string FullCoverage { get; set; }
        public string FinalQuote { get; set; }

        private static readonly int age;

        private static int CalculateAge(DateTime Birthday)
        {
            int age = 0;
            age = DateTime.Now.Year - Birthday.Year;
            if (DateTime.Now.DayOfYear < Birthday.DayOfYear)
                age = age - 1;

            return age;
        }

        public static int Quote()
        {

            int baseRate = 50;
            QuoteResult quote = new QuoteResult();

            //age section
            if (age < 25) baseRate += 25;
            else if (age < 18) baseRate += 100;
            else if (age > 100) baseRate += 25;
            //caryear section
            if (2000 > Convert.ToInt32(quote.CarYear)) baseRate += 25;
            else if (Convert.ToInt32(quote.CarYear) > 2015) baseRate += 25;
            //carmake and model section
            if (quote.CarMake == "Porsche" && quote.CarModel == "911 Carrera") baseRate += 50;
            else if (quote.CarMake == "Porsche") baseRate += 25;
            //DUII section
            if (quote.DUII == "Yes") baseRate *= Convert.ToInt32(1.25);
            //Speeding Ticket Section
            if (quote.SpeedingTickets > 0) baseRate += (quote.SpeedingTickets * 10);
            //Full Coverage Section
            if (quote.FullCoverage == "Yes") baseRate *= Convert.ToInt32(1.5);
            //Final Quote area
            string FinalQuote = Convert.ToString(baseRate);


            return (baseRate);


        }


    }
}