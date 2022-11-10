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
    public partial class Withdraw_Money : Form
    {
        Main_Menu MainMenu;
        public Withdraw_Money(Main_Menu mm)
        {
            InitializeComponent();
            MainMenu = mm;
            var time = DateTime.Now;
            string formattedTime = time.ToString("dd, MM, yyyy");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.Show();
        }

        private void btn_FindAccount_Click(object sender, EventArgs e)
        {
            string found = "n";
            foreach(Account pp in MainMenu.AccountList)
            {
                if (pp.AccountNo == Convert.ToInt32(txt_AccountNo.Text))
                {
                    if (pp.AccountType == "Savings")
                    {
                        found = "y";
                        txt_AccountType.Text = pp.AccountType;
                        MessageBox.Show("We're sorry, but this is a Savings Account. Please Try Again");
                        txt_AccountNo.Clear();
                        break;
                    }
                    else
                    {
                        found = "y";
                        txt_AccountType.Text = pp.AccountType;
                        MessageBox.Show("Account Found");
                        break;
                    }
                }
            }
            if (found == "n")
            {
                MessageBox.Show("We're sorry, but the account number you've entered is not available. Please Try Again");
                txt_AccountNo.Clear();
            }
        }

        private void btn_Withdraw_Money_Click(object sender, EventArgs e)
        {
            double ol = -500.00;
            double withdrawal = 0;
            withdrawal = Convert.ToDouble(txt_Amount.Text);
            DateTime CurrentDate;
            CurrentDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));

            foreach (Account acc in MainMenu.AccountList)
            {
                if (acc.AccountNo == Convert.ToInt32(txt_AccountNo.Text))
                {
                    if (withdrawal >= acc.BalanceAmount && withdrawal >= ol)
                    {
                        string Message = "You won't have enough fund in the account. It will be Overdrawn!";
                        MessageBox.Show(Message);
                        break;
                    }
                    else
                    {
                        Transaction tt = new Transaction();

                        tt.TransactionDate = CurrentDate;
                        tt.Amount = Convert.ToDouble(txt_Amount.Text);

                        acc.BalanceAmount = acc.BalanceAmount - withdrawal--;
                        tt.TransactionType = "Withdrawal";
                        MessageBox.Show("Withdrawal was successful");
                        int n = dgv_CustomerRecord.Rows.Add();
                        dgv_CustomerRecord.Rows[n].Cells[0].Value = acc.CustName;
                        dgv_CustomerRecord.Rows[n].Cells[1].Value = acc.CustAddress;
                        dgv_CustomerRecord.Rows[n].Cells[2].Value = acc.CustDOB;
                        dgv_CustomerRecord.Rows[n].Cells[3].Value = tt.TransactionDate;
                        dgv_CustomerRecord.Rows[n].Cells[4].Value = acc.AccountType;
                        dgv_CustomerRecord.Rows[n].Cells[5].Value = tt.Amount;
                        dgv_CustomerRecord.Rows[n].Cells[6].Value = tt.TransactionType;
                        break;
                    }
                }
            }
        }

        private void btn_Save_Transaction_Click(object sender, EventArgs e)
        {
            foreach (Account acc in MainMenu.AccountList)
            {
                if (acc.AccountNo == Convert.ToInt32(txt_AccountNo.Text))
                {
                    Transaction tt = new Transaction();

                    DateTime CurrentDate;
                    CurrentDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM,yyyy"));
                    
                    tt.TransactionDate = DateTime.Now;
                    tt.Amount = Convert.ToDouble(txt_Amount.Text);
                    tt.TransactionType = Convert.ToString(dgv_CustomerRecord.Rows[0].Cells[6].Value);

                    acc.Transactions.Add(tt);
                    txt_AccountNo.Clear();
                    txt_Amount.Clear();
                    dgv_CustomerRecord.Rows.Clear();
                    break;
                }
            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you can withdraw money. Like with when you deposit money, you can enter an existing account number. If it doens't show up, either it hasn't been added, or it is becuase it is a savings account (You can't withdraw from a savings account), both of which will be displayed in a message box. Also like the deposit page, transaction details will be displayed and you can save them (Make sure they are there though).");
        }
    }
}
