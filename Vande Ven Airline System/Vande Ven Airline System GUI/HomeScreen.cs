using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vande_Ven_Airline_System_GUI
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
           this.Hide();
           CreateCustomerScreen createCustomer = new CreateCustomerScreen();
           createCustomer.ShowDialog();
           this.Close();
        }

        private void LookupReservationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReservationLookupScreen lookupReservation = new ReservationLookupScreen();
            lookupReservation.ShowDialog();
            this.Close();
        }

        private void BookReservationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReservationMenuScreen reservationMenuScreen = new ReservationMenuScreen();
            reservationMenuScreen.ShowDialog();
            this.Close();
        }

        private void CreateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomerButton_Click(sender, e);
        }

        private void LookupReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LookupReservationButton_Click(sender, e);
        }

        private void BookReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReservationButton_Click(sender, e);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
