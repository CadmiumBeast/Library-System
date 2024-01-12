using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hameed
{
    internal class Book 
    {
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public bool availabilty { get; set; }

        public Book(string title, string author, string isbn) { 

            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.availabilty = true;
        }
        public void GetDetails()
        {
            var details = new List<string>();
        }
        public bool CheckAvailbility()
        {
            return availabilty;
        }

        public void BorrowBook()
        {
            if (availabilty)
            {
                availabilty = false;
            }
        }

        public void ReturnBook()
        {
            if (!availabilty)
            {
            availabilty = true;
            }
        }

    }
}
