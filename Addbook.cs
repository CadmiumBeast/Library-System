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
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string bookname = Bname.Text;
            string bookauthor = Bauthor.Text;
            string isbm = bisbn.Text;


            Book newbook = new Book(bookname, bookauthor, isbm);
            Library addbook = new Library();
            string outer = addbook.Addbook(newbook);

            MessageBox.Show(outer);

            this.Close();
            AdminDashboard admin = new AdminDashboard();
            admin.Show();


        }
    }
}
