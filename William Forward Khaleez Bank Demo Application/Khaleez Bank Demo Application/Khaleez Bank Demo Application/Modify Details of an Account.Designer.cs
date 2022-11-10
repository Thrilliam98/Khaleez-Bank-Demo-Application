namespace Khaleez_Bank_Demo_Application
{
    partial class Modify_Details_of_an_Account
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
            this.txt_AccountNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AccountDetails = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.txt_AccountBalance = new System.Windows.Forms.TextBox();
            this.btn_Save_Changes = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_FindAccount = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.helpProvider3 = new System.Windows.Forms.HelpProvider();
            this.helpProvider4 = new System.Windows.Forms.HelpProvider();
            this.btn_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Details of an Account";
            // 
            // txt_AccountNo
            // 
            this.txt_AccountNo.Location = new System.Drawing.Point(158, 52);
            this.txt_AccountNo.Name = "txt_AccountNo";
            this.txt_AccountNo.Size = new System.Drawing.Size(100, 20);
            this.txt_AccountNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address Details";
            // 
            // txt_AccountDetails
            // 
            this.helpProvider2.SetHelpString(this.txt_AccountDetails, "Please note that you can only change the account details");
            this.txt_AccountDetails.Location = new System.Drawing.Point(158, 165);
            this.txt_AccountDetails.Name = "txt_AccountDetails";
            this.helpProvider2.SetShowHelp(this.txt_AccountDetails, true);
            this.txt_AccountDetails.Size = new System.Drawing.Size(100, 20);
            this.txt_AccountDetails.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Account Balance";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(158, 111);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(100, 20);
            this.txt_CustomerName.TabIndex = 7;
            // 
            // txt_AccountBalance
            // 
            this.txt_AccountBalance.Location = new System.Drawing.Point(158, 137);
            this.txt_AccountBalance.Name = "txt_AccountBalance";
            this.txt_AccountBalance.Size = new System.Drawing.Size(100, 20);
            this.txt_AccountBalance.TabIndex = 8;
            // 
            // btn_Save_Changes
            // 
            this.helpProvider3.SetHelpString(this.btn_Save_Changes, "Press this button to save the current changes to the address");
            this.btn_Save_Changes.Location = new System.Drawing.Point(25, 198);
            this.btn_Save_Changes.Name = "btn_Save_Changes";
            this.helpProvider3.SetShowHelp(this.btn_Save_Changes, true);
            this.btn_Save_Changes.Size = new System.Drawing.Size(86, 23);
            this.btn_Save_Changes.TabIndex = 9;
            this.btn_Save_Changes.Text = "Save Changes";
            this.btn_Save_Changes.UseVisualStyleBackColor = true;
            this.btn_Save_Changes.Click += new System.EventHandler(this.btn_Save_Changes_Click);
            // 
            // btn_Back
            // 
            this.helpProvider4.SetHelpString(this.btn_Back, "Press this button to go back to the main menu");
            this.btn_Back.Location = new System.Drawing.Point(158, 198);
            this.btn_Back.Name = "btn_Back";
            this.helpProvider4.SetShowHelp(this.btn_Back, true);
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Go Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_FindAccount
            // 
            this.helpProvider1.SetHelpString(this.btn_FindAccount, "Enter an account number and press this button to find it.");
            this.btn_FindAccount.Location = new System.Drawing.Point(96, 78);
            this.btn_FindAccount.Name = "btn_FindAccount";
            this.helpProvider1.SetShowHelp(this.btn_FindAccount, true);
            this.btn_FindAccount.Size = new System.Drawing.Size(80, 23);
            this.btn_FindAccount.TabIndex = 11;
            this.btn_FindAccount.Text = "Find Account";
            this.btn_FindAccount.UseVisualStyleBackColor = true;
            this.btn_FindAccount.Click += new System.EventHandler(this.btn_FindAccount_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(54, 229);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(157, 23);
            this.btn_Help.TabIndex = 17;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Modify_Details_of_an_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_FindAccount);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Save_Changes);
            this.Controls.Add(this.txt_AccountBalance);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_AccountDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AccountNo);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modify_Details_of_an_Account";
            this.Text = "Modify Details of an Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AccountNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AccountDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.TextBox txt_AccountBalance;
        private System.Windows.Forms.Button btn_Save_Changes;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_FindAccount;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.HelpProvider helpProvider3;
        private System.Windows.Forms.HelpProvider helpProvider4;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btn_Help;
    }
}