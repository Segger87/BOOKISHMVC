using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Bookish.DataAccess.DataModels
{
    public class BookTitle
    {
        public int TitleId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }

        public List<BookTitle> GetTitleList()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["BookishConnection"].ConnectionString);
            string Sqlstring = "Select * from tblTitle";
             var titles = (List<BookTitle>)db.Query<BookTitle>(Sqlstring);
            return titles;
        }
    }
}
