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
    public partial class memberboard : Form
    {
        public memberboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Availability availability = new Availability();
            availability.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            borrow borrow = new borrow();
            borrow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnBooks returnBooks = new ReturnBooks();
            returnBooks.Show();
        }
    }
}
