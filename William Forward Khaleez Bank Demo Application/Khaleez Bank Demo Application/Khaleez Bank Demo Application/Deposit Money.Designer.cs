﻿namespace Khaleez_Bank_Demo_Application
{
    partial class Deposit_Money
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AccountNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Deposit_Money = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Save_Transaction = new System.Windows.Forms.Button();
            this.txt_AccountType = new System.Windows.Forms.TextBox();
            this.btn_FindAccount = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.helpProvider3 = new System.Windows.Forms.HelpProvider();
            this.helpProvider4 = new System.Windows.Forms.HelpProvider();
            this.helpProvider5 = new System.Windows.Forms.HelpProvider();
            this.dgv_CustomerRecord = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposit Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Account Number";
            // 
            // txt_AccountNumber
            // 
            this.helpProvider1.SetHelpString(this.txt_AccountNumber, "Enter an account number first, then press the button to find it. The account box " +
        "will tell you what type it is");
            this.txt_AccountNumber.Location = new System.Drawing.Point(157, 39);
            this.txt_AccountNumber.Name = "txt_AccountNumber";
            this.helpProvider1.SetShowHelp(this.txt_AccountNumber, true);
            this.txt_AccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_AccountNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Amount to Deposit";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(157, 124);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Account Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Customer Deposit Record:";
            // 
            // btn_Deposit_Money
            // 
            this.helpProvider2.SetHelpString(this.btn_Deposit_Money, "Enter how much you want to desposit and press this button");
            this.btn_Deposit_Money.Location = new System.Drawing.Point(104, 165);
            this.btn_Deposit_Money.Name = "btn_Deposit_Money";
            this.helpProvider2.SetShowHelp(this.btn_Deposit_Money, true);
            this.btn_Deposit_Money.Size = new System.Drawing.Size(87, 23);
            this.btn_Deposit_Money.TabIndex = 8;
            this.btn_Deposit_Money.Text = "Deposit Money";
            this.btn_Deposit_Money.UseVisualStyleBackColor = true;
            this.btn_Deposit_Money.Click += new System.EventHandler(this.btn_Deposit_Money_Click);
            // 
            // btn_Back
            // 
            this.helpProvider5.SetHelpString(this.btn_Back, "Press this button to go back to the main menu");
            this.btn_Back.Location = new System.Drawing.Point(177, 337);
            this.btn_Back.Name = "btn_Back";
            this.helpProvider5.SetShowHelp(this.btn_Back, true);
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Go Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Save_Transaction
            // 
            this.helpProvider4.SetHelpString(this.btn_Save_Transaction, "Press this button to save the transaction");
            this.btn_Save_Transaction.Location = new System.Drawing.Point(12, 337);
            this.btn_Save_Transaction.Name = "btn_Save_Transaction";
            this.helpProvider4.SetShowHelp(this.btn_Save_Transaction, true);
            this.btn_Save_Transaction.Size = new System.Drawing.Size(110, 23);
            this.btn_Save_Transaction.TabIndex = 10;
            this.btn_Save_Transaction.Text = "Save Transaction";
            this.btn_Save_Transaction.UseVisualStyleBackColor = true;
            this.btn_Save_Transaction.Click += new System.EventHandler(this.btn_Save_Transaction_Click);
            // 
            // txt_AccountType
            // 
            this.txt_AccountType.Location = new System.Drawing.Point(157, 69);
            this.txt_AccountType.Name = "txt_AccountType";
            this.txt_AccountType.Size = new System.Drawing.Size(100, 20);
            this.txt_AccountType.TabIndex = 11;
            // 
            // btn_FindAccount
            // 
            this.btn_FindAccount.Location = new System.Drawing.Point(104, 95);
            this.btn_FindAccount.Name = "btn_FindAccount";
            this.btn_FindAccount.Size = new System.Drawing.Size(87, 23);
            this.btn_FindAccount.TabIndex = 12;
            this.btn_FindAccount.Text = "Find Account";
            this.btn_FindAccount.UseVisualStyleBackColor = true;
            this.btn_FindAccount.Click += new System.EventHandler(this.btn_FindAccount_Click);
            // 
            // dgv_CustomerRecord
            // 
            this.dgv_CustomerRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_CustomerRecord.Location = new System.Drawing.Point(12, 242);
            this.dgv_CustomerRecord.Name = "dgv_CustomerRecord";
            this.dgv_CustomerRecord.Size = new System.Drawing.Size(746, 72);
            this.dgv_CustomerRecord.TabIndex = 13;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Customer Address";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer DOB";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Deposit Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Account Type";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Money In";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Transaction Type";
            this.Column8.Name = "Column8";
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(313, 337);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(157, 23);
            this.btn_Help.TabIndex = 14;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Deposit_Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 384);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.dgv_CustomerRecord);
            this.Controls.Add(this.btn_FindAccount);
            this.Controls.Add(this.txt_AccountType);
            this.Controls.Add(this.btn_Save_Transaction);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Deposit_Money);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AccountNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deposit_Money";
            this.Text = "Deposit Money";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Deposit_Money;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Save_Transaction;
        private System.Windows.Forms.TextBox txt_AccountType;
        private System.Windows.Forms.Button btn_FindAccount;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider3;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.HelpProvider helpProvider5;
        private System.Windows.Forms.HelpProvider helpProvider4;
        private System.Windows.Forms.DataGridView dgv_CustomerRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btn_Help;
    }
}