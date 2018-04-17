using System;

namespace Bookish.DataAccess.DataModels
{
    public class Borrow
    {
        public int UserId { get; set; }

        public int BookId { get; set; }

        public DateTime DateBorrowed { get; set; }
        public DateTime DueDate { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}
