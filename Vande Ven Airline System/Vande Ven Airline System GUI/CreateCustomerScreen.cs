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
    public partial class CreateCustomerScreen : Form
    {

        Regex firstNameRegex = new Regex("^[a-zA-Z]{1,20}$");
        Regex lastNameRegex = new Regex("^[a-zA-Z]{1,20}$");
        Regex cityRegex = new Regex("^[a-zA-Z\\s]{3,30}[a-zA-Z\\s]{0,30}[a-zA-Z\\s]{0,25}$");
        Regex streetAddressRegex = new Regex("[0-9h-t]{3,10}\\s[a-zA-Z\\s]{1,50}[a-zA-Z]{0,30}\\.{0,1}\\s{0,4}$");
        Regex zipCodeRegex = new Regex("^[0-9]{5}$");
        Regex phoneRegex = new Regex("^[0-9]{10}$");
        Regex creditCardRegex = new Regex("^[0-9]{16}$");


        public CreateCustomerScreen()
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


        private void CustomerSubmitButton_Click(object sender, EventArgs e)
        {

            Customer customer;

            //Test for null values
            if (!(firstNameTextBox.Text).Equals("") && !(lastNameTextBox.Text).Equals("") && !(addressTextBox.Text).Equals("") &&
                !(cityTextBox.Text).Equals("") && !(stateListBox.Text).Equals("") && !(zipCodeTextBox.Text).Equals("") &&
                !(phoneTextBox.Text).Equals("") && !(creditCardTextBox.Text).Equals("") && firstNameTextBox.Text != null && 
                lastNameTextBox.Text != null && addressTextBox.Text != null && cityTextBox.Text != null && stateListBox.Text != null &&
                zipCodeTextBox.Text != null && phoneTextBox.Text != null && creditCardTextBox.Text != null)
            {

                //Check text fields for proper values
                if (!checkRegexBoxes())
                {
                    return; //stops submission and exits methods
                }
        
                try 
                {
                    
                    customer = new Customer(firstNameTextBox.Text, lastNameTextBox.Text, addressTextBox.Text, cityTextBox.Text,
                        stateListBox.Text, zipCodeTextBox.Text, phoneTextBox.Text, creditCardTextBox.Text);

                    try
                    {
                        Transaction transaction = new Transaction();

                        transaction.CreateCustomer(customer);

                        MessageBox.Show(customer.ToString());

                        this.Hide();
                        HomeScreen newHomeScreen = new HomeScreen();
                        newHomeScreen.ShowDialog();
                        this.Close();
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("Error creating new customer.");
                    }
                
                }
                catch(System.Exception)
                {
                    MessageBox.Show("Error, invalid customer data.");
                }
                
            }else
            {
                MessageBox.Show("All fields must be filled before submitting.\nPlease try again.");
            }
        }

        //Checks all values in the customer creation form with Regex
        public bool checkRegexBoxes() 
        {
            if (!firstNameRegex.IsMatch(firstNameTextBox.Text))
            {
                MessageBox.Show("First Name text field can only contain string characters.");
                firstNameTextBox.Text = null;
                return false; //exits method
            }

            if (!lastNameRegex.IsMatch(lastNameTextBox.Text))
            {
                MessageBox.Show("The Last Name text field can only contain string characters.");
                lastNameTextBox.Text = null;
                return false; //exits method
            }


            if (!cityRegex.IsMatch(cityTextBox.Text))
            {
                MessageBox.Show("The City text field can only contain string characters.");
                cityTextBox.Text = null;
                return false; //exits method
            }

            if (!streetAddressRegex.IsMatch(addressTextBox.Text))
            {
                MessageBox.Show("The Street Address text field cannot contain any special characters.");
                addressTextBox.Text = null;
                return false; //exits method
            }

            if (!zipCodeRegex.IsMatch(zipCodeTextBox.Text))
            {
                MessageBox.Show("The Zip Code text field can only contain five consecutive numbers and no special characters.");
                zipCodeTextBox.Text = null;
                return false; //exits method
            }

            if (!phoneRegex.IsMatch(phoneTextBox.Text))
            {
                MessageBox.Show("The Phone Number text field must contain ten consecutive numbers and no special characters.");
                phoneTextBox.Text = null;
                return false; //exits method
            }

            if (!creditCardRegex.IsMatch(creditCardTextBox.Text))
            {
                MessageBox.Show("The Credit Card Number text field must contain 16 consecutive numbers and no special characters.");
                creditCardTextBox.Text = null;
                return false; //exits method
            }

            return true;
        }

    }
}
