using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AndAnotherInsurance.Models;

namespace AndAnotherInsurance.Controllers
{
    public class HomeController : Controller
    {

        private readonly string connectionString = @"Data Source=DESKTOP-OS50PJS\SQLEXPRESS;Initial Catalog=Quote;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly string queryString;
        private object finalQuote;
        private object Birthday;
        private readonly int age;

        public ActionResult Index()
        {
            return View();
        }

        readonly QuoteResult result = new QuoteResult();

        
        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, string birthday, string carYear,
            string carMake, string carModel, string DUII, string speedingTickets, string insuranceType, string finalQuote)
        {
            
            int baseRate = 50;
            DateTime Birthday = Convert.ToDateTime(birthday);
            int age = 0;
            age = DateTime.Now.Year - Birthday.Year;


            //age section
            if (age < 25) baseRate += 25;
            else if (age < 18) baseRate += 100;
            else if (age > 100) baseRate += 25;
            //caryear section
            if (2000 > Convert.ToInt32(carYear)) baseRate += 25;
            else if (Convert.ToInt32(carYear) > 2015) baseRate += 25;
            //carmake and model section
            if (carMake == "Porsche" && carModel == "911 Carrera") baseRate += 50;
            else if (carMake == "Porsche") baseRate += 25;
            //DUII section
            if (DUII == "Yes") baseRate *= Convert.ToInt32(1.25);
            //Speeding Ticket Section
            if (Convert.ToInt32(speedingTickets) > 0) baseRate += (Convert.ToInt32(speedingTickets) * 10);
            //Full Coverage Section
            if (insuranceType == "Yes") baseRate *= Convert.ToInt32(1.5);
            //Final Quote area
            string FinalQuote = Convert.ToString(baseRate);


            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(birthday) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) ||
                string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(DUII) || string.IsNullOrEmpty(speedingTickets) ||
                string.IsNullOrEmpty(insuranceType))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {

                string queryString = @"INSERT INTO Quote (firstName, lastName, emailAddress, birthday, carYear, 
                                        carMake, carModel, DUII, speedingTickets, insuranceType, finalQuote) VALUES (@firstName, 
                                        @lastName, @emailAddress, @birthday, @carYear, @carMake, @carModel, @DUII,
                                        @speedingTickets, @insuranceType, @FinalQuote)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);



                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@Birthday", SqlDbType.VarChar);
                    command.Parameters.Add("@CarYear", SqlDbType.VarChar);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@DUII", SqlDbType.VarChar);
                    command.Parameters.Add("@SpeedingTickets", SqlDbType.VarChar);
                    command.Parameters.Add("@InsuranceType", SqlDbType.VarChar);
                    command.Parameters.Add("@FinalQuote", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@Birthday"].Value = birthday;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@DUII"].Value = DUII;
                    command.Parameters["@SpeedingTickets"].Value = speedingTickets;
                    command.Parameters["@InsuranceType"].Value = insuranceType;
                    command.Parameters["@FinalQuote"].Value = FinalQuote;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                    return View("Success");
            }
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT ID, FirstName, LastName, EmailAddress, FinalQuote from Quote";
            List<Models.QuoteResult> results = new List<Models.QuoteResult>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var quote = new Models.QuoteResult();
                    quote.ID = Convert.ToInt32(reader["ID"]);
                    quote.FirstName = reader["FirstName"].ToString();
                    quote.LastName = reader["LastName"].ToString();
                    quote.EmailAddress = reader["EmailAddress"].ToString();
                    //quote.Birthday = Convert.ToDateTime(reader["Birthday"].ToString());
                    //quote.CarYear = reader["CarYear"].ToString();
                    //quote.CarMake = reader["CarMake"].ToString();
                    //quote.CarModel = reader["CarModel"].ToString();
                    //quote.DUII = reader["DUII"].ToString();
                    //quote.SpeedingTickets = Convert.ToInt32(reader["SpeedingTickets"].ToString());
                    //quote.InsuranceType = reader["InsuranceType"].ToString();
                    quote.FinalQuote = reader["FinalQuote"].ToString();
                    results.Add(quote);
                    
                }
            }


            var resultsVms = new List<ViewModels.ResultsVM>();
            foreach (var quote in results)
            {
                var resultsVm = new ViewModels.ResultsVM();
                resultsVm.FirstName = quote.FirstName;
                resultsVm.LastName = quote.LastName;
                resultsVm.EmailAddress = quote.EmailAddress;
                resultsVm.FinalQuote = quote.FinalQuote;
                resultsVms.Add(resultsVm);
            }
                return View(resultsVms);
        }

       


    }
}