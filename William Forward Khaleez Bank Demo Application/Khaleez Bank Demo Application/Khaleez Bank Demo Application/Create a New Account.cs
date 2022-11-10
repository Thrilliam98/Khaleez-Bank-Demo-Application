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
    public partial class Create_a_New_Account : Form
    {
        Main_Menu MainMenu;
        public Create_a_New_Account(Main_Menu mm)
        {
            InitializeComponent();
            MainMenu = mm; //This is how the page links to the main menu and the button that guides the user here.
            DateTime today = DateTime.Today; //Shows the current date.
            txt_AccountCreationDate.Text = today.ToShortDateString(); //The format for the current date.
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Account p1 = new Account(); //Code to add the details of a new account.
            double ol = 500.00; //The Overdraft Limit.
            
            p1.AccountNo = Convert.ToInt32(txt_AccountNumber.Text);
            p1.CustName = txt_CustName.Text;
            p1.CustAddress = txt_CustAddress.Text;
            p1.CustDOB = Convert.ToDateTime(txt_CustDOB.Text);
            p1.BranchCode = txt_BranchCode.Text;
            p1.AccountType = txt_AccountType.Text;
            p1.CurrencyType = cb_CurrencyType.SelectedText;
            p1.AccountAmount = Convert.ToInt32(txt_AccountAmount.Text);
            p1.BalanceAmount = Convert.ToDouble(txt_BalanceAmount.Text);
            p1.AccountCreationDate = txt_AccountCreationDate.Text;
            if (p1.AccountType == "Current")
            {
                p1.BalanceAmount= ol++ + Convert.ToDouble(txt_BalanceAmount.Text); //Adds overdraft limit to balance.
                MainMenu.AccountList.Add(p1); //Adds the account details to the list.
                txt_AccountNumber.Clear();
                txt_CustName.Clear();
                txt_CustAddress.Clear();
                txt_CustDOB.Clear();
                txt_BranchCode.Clear();
                txt_AccountType.Clear();
                cb_CurrencyType.SelectedIndex = -1;
                txt_AccountAmount.Clear();
                txt_BalanceAmount.Clear();
            }
            else if (p1.AccountType == "Savings") //There are 3 different types of savings accounts.
            {
                if (p1.BalanceAmount <= 500.00) //Standard Account
                {
                    string message = "You've created a Standard Account";
                    MessageBox.Show(message);
                    MainMenu.AccountList.Add(p1);
                    txt_AccountNumber.Clear();
                    txt_CustName.Clear();
                    txt_CustAddress.Clear();
                    txt_CustDOB.Clear();
                    txt_BranchCode.Clear();
                    txt_AccountType.Clear();
                    cb_CurrencyType.SelectedIndex = -1;
                    txt_AccountAmount.Clear();
                    txt_BalanceAmount.Clear();
                }
                else if (p1.BalanceAmount >= 500.00 && p1.BalanceAmount <= 50000.00) //Silver Account
                {
                    string message = "You've created a Silver Account";
                    MessageBox.Show(message);
                    MainMenu.AccountList.Add(p1);
                    txt_AccountNumber.Clear();
                    txt_CustName.Clear();
                    txt_CustAddress.Clear();
                    txt_CustDOB.Clear();
                    txt_BranchCode.Clear();
                    txt_AccountType.Clear();
                    cb_CurrencyType.SelectedIndex = -1;
                    txt_AccountAmount.Clear();
                    txt_BalanceAmount.Clear();
                }
                else //Gold Account
                {
                    string message = "You've created a Gold Account";
                    MessageBox.Show(message);
                    MainMenu.AccountList.Add(p1);
                    txt_AccountNumber.Clear();
                    txt_CustName.Clear();
                    txt_CustAddress.Clear();
                    txt_CustDOB.Clear();
                    txt_BranchCode.Clear();
                    txt_AccountType.Clear();
                    cb_CurrencyType.SelectedIndex = -1;
                    txt_AccountAmount.Clear();
                    txt_BalanceAmount.Clear();
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e) //Takes the user back to the main menu
        {
            this.Hide();
            MainMenu.Show();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you can create a new account. All you have to do is enter a number for the account, add the name of the customer including their address and date of birth, enter their branch code, choose an account type (either Current or Savings, the program will only except these 2), choose a currency type in the combo box, enter how many accounts the customer would like and then finally enter the balance. After that, press the add button to automatically create the new account. Keep in mind that if you choose Current, an overdraft limit of £500 will automaticaly be added to the account. If a Savings account is chosen, there are 3 different types. If £500 or less were entered, you would get a Standard Account. If any number between £500 and £50000 were entered, you would get a Silver Account. If £50000 or more were entered, you would get a Gold Account. Please make sure everything is added and selected properly before you press add.");
        }
    }
}
