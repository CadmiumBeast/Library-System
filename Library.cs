using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hameed
{
    internal class Library
    {
        string connectionString = "Data Source=shakeel;Initial Catalog=hameed;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public List<string> collectionofbooks { get; set; }


        

        public string Addbook(Book book)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }

                    string query = "INSERT INTO book (book_name, book_author, book_isbn, book_availabilty) VALUES (@bname, @bauthor, @bisbn, @bavailability)";
                    SqlCommand sqlcmd = new SqlCommand(query, sqlCon);
                    sqlcmd.Parameters.AddWithValue("@bname", book.title);
                    sqlcmd.Parameters.AddWithValue("@bauthor", book.author);
                    sqlcmd.Parameters.AddWithValue("@bisbn", book.isbn);
                    sqlcmd.Parameters.AddWithValue("@bavailability", book.availabilty);

                    sqlcmd.ExecuteNonQuery();

                    DateTime currentdatetime = DateTime.Now;
                    string formatedDate = currentdatetime.ToString("dd/MM/yyyy HH:mm");
                    SqlConnection transcon = new SqlConnection(connectionString);
                    transcon.Open();
                    SqlCommand transcmd = transcon.CreateCommand();
                    transcmd.CommandType = CommandType.Text;
                    transcmd.CommandText = $"INSERT into transactionlog (datetime,type,BookName) VALUES ('{formatedDate}', 'Added Book', '{book.title}')";
                    transcmd.ExecuteNonQuery();
                    transcon.Close();

                    return "Successfully Added";
                }
                catch (Exception ex) {
                    return ex.Message;
                }
            }
        }
        public void removebook(string book)
        {
            collectionofbooks.Remove(book);
        }

        public bool chackavailabilty(string book)
        {
            return collectionofbooks.Contains(book);
        }
        


    }

}
    