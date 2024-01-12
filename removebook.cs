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
    public partial class removebook : Form
    {
        public removebook()
        {
            InitializeComponent();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=shakeel;Initial Catalog=hameed;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string removebook = removename.Text;
            string query = "DELETE FROM book WHERE CAST(book_name AS NVARCHAR(MAX)) = @bname";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@bname", removebook);

            cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfully");
            this.Close();
            AdminDashboard admin = new AdminDashboard();
            admin.Show();

            DateTime currentdatetime = DateTime.Now;
            string formatedDate = currentdatetime.ToString("dd/MM/yyyy HH:mm");
            SqlConnection transcon = new SqlConnection(connectionString);
            transcon.Open();
            SqlCommand transcmd = transcon.CreateCommand();
            transcmd.CommandType = CommandType.Text;
            transcmd.CommandText = $"INSERT into transactionlog (datetime,type,BookName) VALUES ('{formatedDate}', 'Remove Book', '{removebook}')";
            transcmd.ExecuteNonQuery();
            transcon.Close();

        }
    }
}
