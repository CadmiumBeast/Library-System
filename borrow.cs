using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hameed
{
    public partial class borrow : Form
    {
        
        public borrow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=shakeel;Initial Catalog=hameed;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string borroname = borrowname.Text;
            SqlCommand cmd = new SqlCommand("UPDATE book SET book_availabilty = 0 WHERE CAST(book_name AS NVARCHAR(MAX)) = @bname", conn);
            cmd.Parameters.AddWithValue("@bname", borroname);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                DateTime currentdatetime = DateTime.Now;
                string formatedDate = currentdatetime.ToString("dd/MM/yyyy HH:mm");
                SqlConnection transcon = new SqlConnection(connectionString);
                transcon.Open();
                SqlCommand transcmd = transcon.CreateCommand();
                transcmd.CommandType = CommandType.Text;
                transcmd.CommandText = $"INSERT into transactionlog (datetime,type,BookName) VALUES ('{formatedDate}', 'Book Borrowed', '{borroname}')";
                transcmd.ExecuteNonQuery();
                transcon.Close();
                MessageBox.Show("Book Borrowed");
                this.Close();
                memberboard memberboard = new memberboard();
                memberboard.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string borroname = borrowname.Text;
            string connectionString = "Data Source=shakeel;Initial Catalog=hameed;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT book_availabilty FROM book WHERE CAST(book_name AS NVARCHAR(MAX)) = @bname";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@bname", borroname);
            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value )
            {
                available.Text = "Available";
            }
            else
            {
                available.Text = "Not Available";
            }


        }
    }
}
