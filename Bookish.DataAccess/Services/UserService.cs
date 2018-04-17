using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Bookish.DataAccess.DataModels;
using Dapper;

namespace Bookish.DataAccess.Services
{
    public class UserService
    {
        public static void RegisterUser(string emailAddress, string password, string firstname, string lastname)
        {
            IDbConnection db =
                new SqlConnection(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
            string sqlstring = "Insert into tblUsers (EmailAddress, Password, FirstName, Surname) VALUES ('" +
                               emailAddress + "', '" + password + "', '" + firstname + "', '" + lastname + "')";
            db.Query(sqlstring);
        }

        public static string RetriveFirstName(string emailAddress)
        {
            IDbConnection db =
                new SqlConnection(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
            string sqlstring = "SELECT FirstName FROM tblUsers WHERE EmailAddress ='" + emailAddress + "'";
            var data = db.Query<Users>(sqlstring).FirstOrDefault()?.FirstName ?? "";
            return data;
        }
    }
}
