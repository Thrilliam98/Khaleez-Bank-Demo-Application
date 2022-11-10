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
    public partial class Modify_Details_of_an_Account : Form
    {
        Main_Menu MainMenu;
        public Modify_Details_of_an_Account(Main_Menu mm)
        {
            InitializeComponent();
            MainMenu = mm;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.Show();
        }

        private void btn_FindAccount_Click(object sender, EventArgs e)
        {
            string found = "n";
            foreach (Account pp in MainMenu.AccountList)
            {
                if (pp.AccountNo == Convert.ToInt32(txt_AccountNo.Text))
                {
                    found = "y";
                    txt_CustomerName.Text += pp.CustName;
                    txt_AccountBalance.Text += pp.BalanceAmount;
                    txt_AccountDetails.Text += pp.CustAddress;
                    break;
                }
            }
            if (found == "n")
            {
                MessageBox.Show("We're sorry, but the account number you've entered is not available. Please Try Again");
                txt_AccountNo.Clear();
            }
        }

        private void btn_Save_Changes_Click(object sender, EventArgs e)
        {
            foreach (Account acc in MainMenu.AccountList)
            {
                if (acc.AccountNo == Convert.ToInt32(txt_AccountNo.Text))
                {
                    String Address;
                    Address = txt_AccountDetails.Text;
                    acc.CustAddress = Address;
                    txt_AccountNo.Clear();
                    txt_CustomerName.Clear();
                    txt_AccountBalance.Clear();
                    txt_AccountDetails.Clear();
                    break;
                }
            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you can edit the address details of the account (And only the address details). Just enter an existing account number (A message box will show up if it hasn't been added yet), then it will show the customer name, balance and address. Once the address details have been changed, you can click on the save changes button to update it. To change the address details of another account, just leave and come back to the page to clear away everything");
        }
    }
}
