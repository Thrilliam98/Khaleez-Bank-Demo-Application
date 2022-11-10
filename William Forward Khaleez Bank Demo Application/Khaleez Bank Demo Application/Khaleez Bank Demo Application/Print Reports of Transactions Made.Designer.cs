namespace Khaleez_Bank_Demo_Application
{
    partial class Print_Reports_of_Transactions_Made
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
            this.btn_Go_Back = new System.Windows.Forms.Button();
            this.btn_FindAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AccountNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Print_Report = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.helpProvider3 = new System.Windows.Forms.HelpProvider();
            this.helpProvider4 = new System.Windows.Forms.HelpProvider();
            this.dgv_Transaction = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Go_Back
            // 
            this.helpProvider4.SetHelpString(this.btn_Go_Back, "Press this button to go back to the main menu.");
            this.btn_Go_Back.Location = new System.Drawing.Point(98, 288);
            this.btn_Go_Back.Name = "btn_Go_Back";
            this.helpProvider4.SetShowHelp(this.btn_Go_Back, true);
            this.btn_Go_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Go_Back.TabIndex = 0;
            this.btn_Go_Back.Text = "Go Back";
            this.btn_Go_Back.UseVisualStyleBackColor = true;
            this.btn_Go_Back.Click += new System.EventHandler(this.btn_Go_Back_Click);
            // 
            // btn_FindAccount
            // 
            this.helpProvider1.SetHelpString(this.btn_FindAccount, "Enter an Account Number and press this button to find it.");
            this.btn_FindAccount.Location = new System.Drawing.Point(99, 72);
            this.btn_FindAccount.Name = "btn_FindAccount";
            this.helpProvider1.SetShowHelp(this.btn_FindAccount, true);
            this.btn_FindAccount.Size = new System.Drawing.Size(80, 23);
            this.btn_FindAccount.TabIndex = 14;
            this.btn_FindAccount.Text = "Find Account";
            this.btn_FindAccount.UseVisualStyleBackColor = true;
            this.btn_FindAccount.Click += new System.EventHandler(this.btn_FindAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Account Number";
            // 
            // txt_AccountNo
            // 
            this.txt_AccountNo.Location = new System.Drawing.Point(161, 46);
            this.txt_AccountNo.Name = "txt_AccountNo";
            this.txt_AccountNo.Size = new System.Drawing.Size(100, 20);
            this.txt_AccountNo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Print Reports of Transactions Made";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Transactions Made";
            // 
            // btn_Print_Report
            // 
            this.helpProvider3.SetHelpString(this.btn_Print_Report, "Press this button to print out the report.");
            this.btn_Print_Report.Location = new System.Drawing.Point(17, 288);
            this.btn_Print_Report.Name = "btn_Print_Report";
            this.helpProvider3.SetShowHelp(this.btn_Print_Report, true);
            this.btn_Print_Report.Size = new System.Drawing.Size(75, 23);
            this.btn_Print_Report.TabIndex = 18;
            this.btn_Print_Report.Text = "Print Report";
            this.btn_Print_Report.UseVisualStyleBackColor = true;
            this.btn_Print_Report.Click += new System.EventHandler(this.btn_Print_Report_Click);
            // 
            // dgv_Transaction
            // 
            this.dgv_Transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column8,
            this.Column5,
            this.Column7});
            this.dgv_Transaction.Location = new System.Drawing.Point(12, 136);
            this.dgv_Transaction.Name = "dgv_Transaction";
            this.dgv_Transaction.Size = new System.Drawing.Size(445, 146);
            this.dgv_Transaction.TabIndex = 19;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Name";
            this.Column2.Name = "Column2";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Transaction Type";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Transaction Date";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(238, 288);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(157, 23);
            this.btn_Help.TabIndex = 20;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Print_Reports_of_Transactions_Made
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 336);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.dgv_Transaction);
            this.Controls.Add(this.btn_Print_Report);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_FindAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AccountNo);
            this.Controls.Add(this.btn_Go_Back);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Print_Reports_of_Transactions_Made";
            this.Text = "Print Reports of Transactions Made";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Go_Back;
        private System.Windows.Forms.Button btn_FindAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AccountNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Print_Report;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.HelpProvider helpProvider3;
        private System.Windows.Forms.HelpProvider helpProvider4;
        private System.Windows.Forms.DataGridView dgv_Transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_Help;
    }
}