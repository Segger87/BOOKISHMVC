using System.Collections.Generic;
using Bookish.DataAccess.DataModels;

namespace Bookish.Web.Models
{
    public class HomeViewModel
    {
        public List<BookBorrows> Books { get; set; }
        public string FirstName { get; set; }
        public List<BookTitle> BookTitles { get; set; }
    }
}
