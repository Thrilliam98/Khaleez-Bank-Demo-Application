using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khaleez_Bank_Demo_Application
{
    public partial class Main_Menu : Form
    {
        public List<Account> AccountList = new List<Account>(); //The List containing all of the accounts details.
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Create_a_New_Account a = new Create_a_New_Account(this); //Takes the user to the page where they create a new account.
            this.Hide();
            a.Show();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            Deposit_Money a = new Deposit_Money(this); //Takes the user to the page where they deposit money.
            this.Hide();
            a.Show();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            Withdraw_Money a = new Withdraw_Money(this); //Takes the user to the page where they withdraw money.
            this.Hide();
            a.Show();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Check_the_Balance a = new Check_the_Balance(this); //Takes the user to the page where they check the balance.
            this.Hide();
            a.Show();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            Modify_Details_of_an_Account a = new Modify_Details_of_an_Account(this); //Takes the user to the page where they modify the address details.
            this.Hide();
            a.Show();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Print_Reports_of_Transactions_Made a = new Print_Reports_of_Transactions_Made(this); //Takes the user to the page where they can
            //print out the transaction details.
            this.Hide();
            a.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Closes the program.
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Khaleez Bamk Application. This is the Main Menu where you can guide yourself to any page with just the click of a button. If you wnat to return to this page, don't worry, each of these pages has a return button, so that you can go back to this page. I you want to leave the program, just click the exit button.");
        }
    }
}
