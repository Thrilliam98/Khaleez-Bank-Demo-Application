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
    public partial class Check_the_Balance : Form
    {
        Main_Menu MainMenu;
        public Check_the_Balance(Main_Menu mm)
        {
            InitializeComponent();
            MainMenu = mm;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.Show();
        }

        private void btn_Check_Balance_Click(object sender, EventArgs e)
        {
            string found = "n";
            foreach (Account pp in MainMenu.AccountList)
            {
                if (pp.AccountNo == Convert.ToInt32(txt_AccountNo.Text) && pp.AccountType == "Savings")
                {
                    if (pp.BalanceAmount <= 500.00)
                    {
                        found = "y";
                        txt_Balance.Text += string.Format("£{0:#.00}", pp.BalanceAmount);
                        txt_SavingsAccountType.Text = "Standard";
                        break;
                    }
                    else if (pp.BalanceAmount >= 500.00 && pp.BalanceAmount <= 50000.00)
                    {
                        found = "y";
                        txt_Balance.Text += string.Format("£{0:#.00}", pp.BalanceAmount);
                        txt_SavingsAccountType.Text = "Silver";
                        break;
                    }
                    else if (pp.BalanceAmount > 50000.00)
                    {
                        found = "y";
                        txt_Balance.Text += string.Format("£{0:#.00}", pp.BalanceAmount);
                        txt_SavingsAccountType.Text = "Gold";
                        break;
                    }
                }
                else if (pp.AccountNo == Convert.ToInt32(txt_AccountNo.Text) && pp.AccountType == "Current")
                {
                    found = "y";
                    txt_Balance.Text += string.Format("£{0:#.00}", pp.BalanceAmount);
                    break;
                }
            }
            if (found == "n")
            {
                MessageBox.Show("We're sorry, but the account number you've entered is not available. Please Try Again");
                txt_AccountNo.Clear();
            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you can check the balance of an account. Just enter the number of an existing account(A message box will show up if it hasn't been added yet), then press the check balance button to see how much money is inside. In addition, if it is a savings account, the text box in the middle will show whether it is Standard, Silver or Gold. To check another account, just leave and come back again to clear away the text.");
        }
    }
}
