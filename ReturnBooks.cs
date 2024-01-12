using Microsoft.Data.SqlClient;
using System;
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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bname = returnBook.Text;

            string connectionString = "Data Source=shakeel;Initial Catalog=hameed;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE book SET book_availabilty = 1 WHERE CAST(book_name AS NVARCHAR(MAX)) = @bname", conn);
            cmd.Parameters.AddWithValue("@bname", bname);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Book Returned");
                this.Close();
                memberboard memberboard = new memberboard();
                memberboard.Show();
            }
        }
    }
}
