using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hameed
{
    internal class Members
    {
        public string Name { get; set; }
        public int membershipID { get; set; }
        public List<string> borrowedbooks { get; set; }
        public Members(string name, int membershipID, List<string> borrowedbooks)
        {
            Name = name;
            this.membershipID = membershipID;
            this.borrowedbooks = borrowedbooks;
        }

        public void borrowedBook(string book)
        {
            borrowedbooks.Add(book);
        }
        public void returnBook(string book)
        {
            borrowedbooks.Remove(book);
        }
        public void listofborrowedbook()
        {
           borrowedbooks = new List<string>();
        }

        
    }
}
