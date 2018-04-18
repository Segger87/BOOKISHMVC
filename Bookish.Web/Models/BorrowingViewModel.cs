using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookish.Web.Models
{
    public class BorrowingViewModel
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime DateDue { get; set; }
    }
}