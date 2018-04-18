using System;

namespace Bookish.DataAccess.DataModels
{
    public class Book
    {
        public int BookId { get; set; }

        public int TitleId { get; set; }

        public int Copies { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DueDate { get; set; }

    }
}
