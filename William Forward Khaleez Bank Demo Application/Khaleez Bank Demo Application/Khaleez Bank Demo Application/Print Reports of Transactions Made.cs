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
    public partial class Print_Reports_of_Transactions_Made : Form
    {
        Main_Menu MainMenu;
        public Print_Reports_of_Transactions_Made(Main_Menu mm)
        {
            InitializeComponent();
            MainMenu = mm;
        }

        private void btn_Go_Back_Click(object sender, EventArgs e)
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
                    foreach (Transaction tt in pp.Transactions)
                    {
                        found = "y";
                        int n = dgv_Transaction.Rows.Add();
                        dgv_Transaction.Rows[n].Cells[0].Value = pp.CustName;
                        dgv_Transaction.Rows[n].Cells[1].Value = tt.TransactionType;
                        dgv_Transaction.Rows[n].Cells[2].Value = tt.TransactionDate;
                        dgv_Transaction.Rows[n].Cells[3].Value = tt.Amount;
                    }
                }
            }
            if (found == "n")
            {
                MessageBox.Show("We're sorry, but the account number you've entered is not available. Please Try Again");
                txt_AccountNo.Clear();
            }
        }

        private void btn_Print_Report_Click(object sender, EventArgs e)
        {
            foreach (Account pp in MainMenu.AccountList)
            {
                MessageBox.Show("Report is now being printed out.");
                txt_AccountNo.Clear();
                dgv_Transaction.Rows.Clear();
                break;
            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where you can print out the details of every transaction made by an account. You just have to enter an existing account number (a message box will pop up if it isn't there yet), then press the find account button to open up all of the details of every transaction made from the account you've entered. Once that is done, click on the Print Report button to send it to the printer.");
        }
    }
}
