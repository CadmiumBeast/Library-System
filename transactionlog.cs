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
    public partial class transactionlog : Form
    {
        public transactionlog()
        {
            InitializeComponent();
        }

        private void transactionlog_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataGridView1.DataSource = dataTable;
            string connectionString = "Data Source=5;Initial Catalog=hameed;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlDataAdapter bookdata = new SqlDataAdapter("SELECT * FROM transactionlog", conn);
            bookdata.Fill(dataTable);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
