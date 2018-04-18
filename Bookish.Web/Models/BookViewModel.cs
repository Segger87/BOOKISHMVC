using System;
using System.Collections.Generic;
using Bookish.DataAccess.DataModels;

namespace Bookish.Web.Models
{
    public class BookViewModel
    {
        public int Copies { get; set; }
        public int TitleId { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DueDate { get; set; }
        public List<Book> Borrowed { get; set; }

        public string Title { get; set; }

    }
}