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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Addbook addbook = new Addbook();
            addbook.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            removebook removebook = new removebook();
            removebook.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Availability availability = new Availability();
            availability.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            transactionlog transactionlog = new transactionlog();
            transactionlog.Show();
        }
    }
}