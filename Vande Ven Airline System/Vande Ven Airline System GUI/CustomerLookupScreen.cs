using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vande_Ven_Airline_System_GUI
{
    public partial class CustomerLookupScreen : Form
    {

        
        private bool searchCustomerID = true; //The form start with that one already selected
        private bool searchReservationID = false;
        private bool searchCreditCard = false;

        Regex searchBoxRegex = new Regex("^[0-9]{1,20}$");
        Regex creditCardRegex = new Regex("^[0-9]{16}$");
        Regex firstNameRegex = new Regex("^[a-zA-Z]{1,20}$");
        Regex lastNameRegex = new Regex("^[a-zA-Z]{1,20}$");
        Regex zipCodeRegex = new Regex("^[0-9]{5}$");


        public CustomerLookupScreen()
        {
            InitializeComponent();
        }


        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen newHomeScreen = new HomeScreen();
            newHomeScreen.ShowDialog();
            this.Close();
        }

        private void Customer_ID_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {
            searchCustomerID = true;
            searchReservationID = false;
            searchCreditCard = false;

            searchGroupBox.Text = "Enter Customer ID";
            nameGroupBox.Text = null;
            zipGroupBox.Text = null;

            nameGroupBox.Hide();
            zipGroupBox.Hide();
        }

        private void Reservation_ID_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {
            searchCustomerID = false;
            searchReservationID = true;
            searchCreditCard = false;

            searchGroupBox.Text = "Enter Reservation ID";
            nameGroupBox.Text = null;
            zipGroupBox.Text = null;

            nameGroupBox.Hide();
            zipGroupBox.Hide();

        }

        private void Credit_Card_Radio_Button_CheckedChanged(object sender, EventArgs e)
        {
            searchCustomerID = false;
            searchReservationID = false;
            searchCreditCard = true;

            searchGroupBox.Text = "Enter Credit Card Number";
            nameGroupBox.Text = "Enter First and Last Name";
            zipGroupBox.Text = "Enter Zip Code";

            nameGroupBox.Show();
            zipGroupBox.Show();
        }


        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.ShowDialog();
            this.Close();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {

            Transaction transaction = new Transaction();

            //Takes a DataGridView Object and populates it
            transaction.ShowAllCustomers(searchDataGridView);
        }

        private void SearchDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string customerID = null;

            //Gets the CustomerID from double click on table
            customerID = searchDataGridView.CurrentRow.Cells[0].Value.ToString();
            
            ReservationScreen bookReservation = new ReservationScreen(customerID);
            bookReservation.ShowDialog();
        }

        private void CustomerSearchButton_Click(object sender, EventArgs e)
        {
            String searchValue = customerSearchTextBox.Text;

            //Validation for null values
            if (searchValue != null && !searchValue.Equals(""))
            {

                //Checks search box values against regex
                if (!searchBoxRegex.IsMatch(customerSearchTextBox.Text))
                {
                    MessageBox.Show("The Customer Search text field can only contain positive number values.");
                    customerSearchTextBox.Text = null;
                    return;
                }


                Transaction transaction = new Transaction();

                //Determines type of search
                if (searchCustomerID)
                {
                    transaction.CustomerSearchCustomerID(searchDataGridView, searchValue);
                    EmptyDataGridView(); //Check if search found

                }
                else if (searchReservationID)
                {
                    transaction.CustomerSearchReservationID(searchDataGridView, searchValue);
                    EmptyDataGridView();//Check if search found

                }
                else if (searchCreditCard)
                {
                    //Check for nulls in all 3 boxes
                    if (!(firstNameTextBox.Text).Equals("") && !(lastNameTextBox.Text).Equals("") &&
                        !(zipCodeTextBox.Text).Equals("") && firstNameTextBox.Text != null
                        && lastNameTextBox.Text != null && zipCodeTextBox.Text != null)
                    {

                        if (!checkRegexBoxes())
                        {
                            return;
                        }
                        
                        transaction.CustomerSearchCreditCardNum(searchDataGridView, searchValue,
                            firstNameTextBox.Text, lastNameTextBox.Text, zipCodeTextBox.Text);
                        
                        EmptyDataGridView();//Checks if search found
                    }
                    else
                    {
                        MessageBox.Show("All fields must be filled before querying by credit card.\nPlease try again.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Customer search box is empty.\nPlease try again.");
            }
        }
        
        //Sends Message Box if Search was not found
        private void EmptyDataGridView() 
        {
            if (searchDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Search not found.");
            }
        }


        //Checks all values in the customer creation form with Regex
        public bool checkRegexBoxes()
        {
            if (searchCreditCard)
            {
                if (!creditCardRegex.IsMatch(customerSearchTextBox.Text))
                {
                    MessageBox.Show("The Credit Card Number text field must contain 16 consecutive numbers and no special characters.");
                    customerSearchTextBox.Text = null;
                    return false; //exits method
                }

                if (!firstNameRegex.IsMatch(firstNameTextBox.Text))
                {
                    MessageBox.Show("First Name text field can only contain string characters.");
                    firstNameTextBox.Text = null;
                    return false;
                }

                if (!lastNameRegex.IsMatch(lastNameTextBox.Text))
                {
                    MessageBox.Show("The Last Name text field can only contain string characters.");
                    lastNameTextBox.Text = null;
                    return false;
                }

                if (!zipCodeRegex.IsMatch(zipCodeTextBox.Text))
                {
                    MessageBox.Show("The Zip Code text field can only contain five consecutive numbers and no special characters.");
                    zipCodeTextBox.Text = null;
                    return false;
                }
            }
            

            return true;
        }
    }
}
