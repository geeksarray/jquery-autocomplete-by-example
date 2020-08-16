using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;

namespace jQueryAutocomplete
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static Customer[] GetCustomers(string country)
        {
            List<Customer> customers = new List<Customer>();
            string query = string.Format("SELECT [CustomerID], [CompanyName], [ContactName], [ContactTitle]," +
                    "[City], [Phone] FROM [Customers] WHERE Country LIKE '%{0}%'", country);

            using (SqlConnection con =
                    new SqlConnection("your connection string to northwind database"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.CustomerID = reader.GetString(0);
                        customer.CompanyName = reader.GetString(1);
                        customer.ContactName = reader.GetString(2);
                        customer.ContactTitle = reader.GetString(3);
                        customer.City = reader.GetString(4);
                        customer.Phone = reader.GetString(5);
                        customers.Add(customer);
                    }
                }
            }

            return customers.ToArray();
        }


        [WebMethod]
        public static string[] GetCountryNames(string keyword)
        {
            List<string> country = new List<string>();
            string query = string.Format("SELECT DISTINCT Country FROM Customers WHERE Country LIKE '%{0}%'", keyword);

            using (SqlConnection con =
                    new SqlConnection("your connection string to northwind database"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        country.Add(reader.GetString(0));
                    }
                }
            }

            return country.ToArray();
        }
    }
}
