using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_EF_Assignment_1
{
    internal class Book
    {
        public int Id { get; set; }

        public string Titel { get; set; }

        public string ISBN { get; set; }

        public decimal price { get; set; }

        public int NumberOfPages { get; set; }

        public int PublishedYear { get; set; }

        public bool IsInStock { get; set; }


    }
}
