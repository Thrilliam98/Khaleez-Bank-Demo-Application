using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khaleez_Bank_Demo_Application
{
    public class Account
    {
        public int _accountno;
        public string _custname;
        public string _custaddress;
        public DateTime _custdob;
        public string _branchcode;
        public string _accounttype;
        public string _currencytype;
        public int _accountamount;
        public double _balanceamount;
        public double _overdraftlimit;
        public string _accountcreationdate;
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public int AccountNo
        {
            get
            {
                return _accountno;
            }
            set
            {
                _accountno = value;
            }
        }

        public string CustName
        {
            get
            {
                return this._custname;
            }
            set
            {
                this._custname = value;
            }
        }

        public string CustAddress
        {
            get
            {
                return this._custaddress;
            }
            set
            {
                this._custaddress = value;
            }
        }

        public DateTime CustDOB
        {
            get
            {
                return _custdob;
            }
            set
            {
                _custdob = value;
            }
        }

        public string BranchCode
        {
            get
            {
                return this._branchcode;
            }
            set
            {
                this._branchcode = value;
            }
        }

        public string AccountType
        {
            get
            {
                return this._accounttype;
            }
            set
            {
                this._accounttype = value;
            }
        }

        public string CurrencyType
        {
            get
            {
                return this._currencytype;
            }
            set
            {
                this._currencytype = value;
            }
        }

        public int AccountAmount
        {
            get
            {
                return _accountamount;
            }
            set
            {
                _accountamount = value;
            }
        }

        public double BalanceAmount
        {
            get
            {
                return _balanceamount;
            }
            set
            {
                _balanceamount = value;
            }
        }

        public double OverDraftLimit
        {
            get
            {
                return _overdraftlimit;
            }
            set
            {
                _overdraftlimit = value;
            }
        }

        public string AccountCreationDate
        {
            get
            {
                return this._accountcreationdate;
            }
            set
            {
                this._accountcreationdate = value;
            }
        }
    }

    public class Transaction : Account
    {
        public DateTime _transactiondate;
        public double _amount;
        public string _transactiontype;

        public DateTime TransactionDate
        {
            get
            {
                return _transactiondate;
            }
            set
            {
                _transactiondate = value;
            }
        }

        public Double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        public string TransactionType
        {
            get
            {
                return this._transactiontype;
            }
            set
            {
                this._transactiontype = value;
            }
        }
    }
}
