using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Bookish.DataAccess;
using Bookish.DataAccess.DataModels;
using Dapper;


namespace Bookish.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
            string Sqlstring = "Select * from tblTitle";
            var titles = (List<BookTitle>) db.Query<BookTitle>(Sqlstring);

            foreach (var title in titles)
            {
                Console.WriteLine(title.Author);
                Console.WriteLine(title.Isbn);
                Console.WriteLine(title.Title);
            }

            //Console.ReadLine();

            string Sqlstring1 = "Select * from tblUsers";
            var users = (List<Users>)db.Query<Users>(Sqlstring1);

            foreach (var user in users)
            {
                Console.WriteLine(user.EmailAddress);
                Console.WriteLine(user.Password);
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.Surname);
            }

            string Sqlstring2 = "Select * from tblBorrow";
            var borrows = (List<Borrow>)db.Query<Borrow>(Sqlstring2);

            foreach (var borrow in borrows)
            {
                Console.WriteLine(borrow.UserId);
                Console.WriteLine(borrow.BookId);
                Console.WriteLine(borrow.DateBorrowed);
                Console.WriteLine(borrow.DueDate);
                Console.WriteLine(borrow.DateReturned);
            }

            Console.ReadLine();
        }
    }
}
