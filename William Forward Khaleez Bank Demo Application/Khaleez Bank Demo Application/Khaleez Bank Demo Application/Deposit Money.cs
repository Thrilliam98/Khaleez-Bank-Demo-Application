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
    public partial class Deposit_Money : Form
    {
        Main_Menu MainMenu;
        public Deposit_Money(Main_Menu mm)
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
                if(pp.AccountNo == Convert.ToInt32(txt_AccountNumber.Text))
                {
                    found = "y";
                    txt_AccountType.Text += pp.AccountType;
                    break;
                }
            }
            if (found == "n")
            {
                MessageBox.Show("We're sorry, but the account number you've entered is not available. Please Try Again");
                txt_AccountNumber.Clear();
            }
        }

        private void btn_Deposit_Money_Click(object sender, EventArgs e)
        {
            double payment = 0;
            payment = Convert.ToDouble(txt_Amount.Text);
            DateTime CurrentDate;
            CurrentDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));

            foreach (Account acc in MainMenu.AccountList)
            {
                if (acc.AccountNo == Convert.ToInt32(txt_AccountNumber.Text))
                {
                    Transaction tt = new Transaction();

                    acc.BalanceAmount = payment++ + acc.BalanceAmount;
                    tt.TransactionDate = CurrentDate;
                    tt.Amount = Convert.ToDouble(txt_Amount.Text);
                    tt.TransactionType = "Deposit";

                    int n = dgv_CustomerRecord.Rows.Add();
                    dgv_CustomerRecord.Rows[n].Cells[0].Value = acc.CustName;
                    dgv_CustomerRecord.Rows[n].Cells[1].Value = acc.CustAddress;
                    dgv_CustomerRecord.Rows[n].Cells[2].Value = acc.CustDOB;
                    dgv_CustomerRecord.Rows[n].Cells[3].Value = tt.TransactionDate;
                    dgv_CustomerRecord.Rows[n].Cells[4].Value = acc.AccountType;
                    dgv_CustomerRecord.Rows[n].Cells[5].Value = tt.Amount;
                    dgv_CustomerRecord.Rows[n].Cells[6].Value = tt.TransactionType;
                }
            }
        }

        private void btn_Save_Transaction_Click(object sender, EventArgs e)
        {
            foreach (Account acc in MainMenu.AccountList)
            {
                if (acc.AccountNo == Convert.ToInt32(txt_AccountNumber.Text))
                {
                    Transaction tt = new Transaction();

                    DateTime CurrentDate;
                    CurrentDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM,yyyy"));
                    
                    tt.TransactionDate = CurrentDate;
                    tt.Amount = Convert.ToDouble(txt_Amount.Text);
                    tt.TransactionType = Convert.ToString(dgv_CustomerRecord.Rows[0].Cells[6].Value);

                    acc.Transactions.Add(tt);
                    txt_AccountNumber.Clear();
                    txt_AccountType.Clear();
                    txt_Amount.Clear();
                    dgv_CustomerRecord.Rows.Clear();
                    break;
                }
            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you can deposite money. Firstly, you need to enter the number of an existing account. If it doesn't show up, then it is likely that it hasn't been added yet (A message box will tell you that). Once it finds the account your looking for, it will show the accound type. After that, you can enter how every much money you want to deposit. Once that is done, the transaction details will be display in the data grid. Afterwards, you can save those details by clicking on the save button. Make sure that the detaisl are there first before saving them.");
        }
    }
}
