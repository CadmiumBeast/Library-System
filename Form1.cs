using Microsoft.Data.SqlClient;
using System.Data;
namespace Hameed
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=shakeel;Initial Catalog=hameed;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = usenamebox.Text;
            string password = passwordbox.Text;
            using SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                if (uname.Length > 0)
                {
                    if (uname.Equals("admin") && password.Equals("admin123"))
                    {
                        this.Hide();
                        AdminDashboard admin = new AdminDashboard();
                        MessageBox.Show("Welcome Librarian");
                        admin.Show();

                        DateTime currentdatetime = DateTime.Now;
                        string formatedDate = currentdatetime.ToString("dd/MM/yyyy HH:mm");
                        SqlConnection transcon = new SqlConnection(connectionString);
                        transcon.Open();
                        SqlCommand transcmd = transcon.CreateCommand();
                        transcmd.CommandType = CommandType.Text;
                        transcmd.CommandText = $"INSERT into transactionlog (datetime,type,BookName) VALUES ('{formatedDate}', 'AdminLogin', '')";
                        transcmd.ExecuteNonQuery();
                        transcon.Close();

                    }
                    else
                    {
                        string query = "SELECT * FROM login WHERE Username = @Username AND Password = @Password";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Username", uname);
                        cmd.Parameters.AddWithValue("@Password", password);

                            
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);

                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);
                        if(dtable.Rows.Count > 0)
                        {
                            this.Hide();
                            MessageBox.Show($"Welcome {uname}");
                            memberboard memdash = new memberboard();
                            memdash.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials");
                            usenamebox.Clear();
                            passwordbox.Clear();
                        }
                        DateTime currentdatetime = DateTime.Now;
                        string formatedDate = currentdatetime.ToString("dd/MM/yyyy HH:mm");
                        SqlConnection transcon = new SqlConnection(connectionString);
                        transcon.Open();
                        SqlCommand transcmd = transcon.CreateCommand();
                        transcmd.CommandType = CommandType.Text;
                        transcmd.CommandText = $"INSERT into transactionlog (datetime,type,BookName) VALUES ('{formatedDate}', '{uname}'/, '')";
                        transcmd.ExecuteNonQuery();
                        transcon.Close();

                    }
                }


            }
            catch (Exception ex) { }
        }

        
    }
}
