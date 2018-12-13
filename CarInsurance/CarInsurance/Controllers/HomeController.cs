using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public string _connectionString = @"Data Source=DESKTOP-OS50PJS\SQLEXPRESS;Initial Catalog=Insurance2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public ActionResult Index()
        {
            string queryString = "Select * From Driver";
            List<Models.Driver> Driver = new List<Models.Driver>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Models.Driver driver = new Models.Driver();
                    driver.ID = Convert.ToInt32(reader["Id"]);
                    driver.firstName = reader["FirstName"].ToString();
                    driver.LastName = reader["LastName"].ToString();
                    driver.EmailAddress = reader["EmailAddress"].ToString();
                    driver.Birthday = Convert.ToDateTime(reader["Birthday"].ToString());
                    driver.CarYear = Convert.ToInt32(reader["CarYear"]);
                    driver.CarMake = reader["CarMake"].ToString();
                    driver.CarModel = reader["CarModel"].ToString();
                    driver.DUII = reader["DUII"].ToString();
                    driver.SpeedingTickets = Convert.ToInt32(reader["SpeedingTickets"]);
                    driver.InsuranceType = reader["InsuranceType"].ToString();

                    driver.Add(driver);
                }
                connection.Close();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, string birthday,
            string carYear, string carMake, string carModel, string dUII, string speedingTicket, string insuranceType)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(birthday) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) ||
                string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(speedingTicket))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                return View("FinalQuote");
            }
        }

        [HttpPost]
        public ActionResult FinalQuote()
        {
            string queryString = @"Insert into Final Quotes (FirstName, LastName, EmailAddress, BirthDay, CarYear,
            CarMake, CarModel, DUII, SpeedingTicket, InsuranceType) Values(@FirstName, @LastName,  @EmailAddress, @BirthDay, 
            @CarYear, @CarMake, @CarModel, @DUII, @SpeedingTicket, @InsuranceType )";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);
                command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                command.Parameters.Add("@Birthday", SqlDbType.Date);
                command.Parameters.Add("@CarYear", SqlDbType.Int);
                command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                command.Parameters.Add("@DUII", SqlDbType.Text);
                command.Parameters.Add("@SpeedingaTicket", SqlDbType.Text);
                command.Parameters.Add("@InsuranceType", SqlDbType.VarChar);

                command.Parameters["@FirstName"].Value = Models.Driver.FirstName();
                command.Parameters["@LastName"].Value = Models.Driver.LastName();

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}