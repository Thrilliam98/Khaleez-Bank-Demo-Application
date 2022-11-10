namespace Khaleez_Bank_Demo_Application
{
    partial class Main_Menu
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
            this.Create = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.helpProvider3 = new System.Windows.Forms.HelpProvider();
            this.helpProvider4 = new System.Windows.Forms.HelpProvider();
            this.helpProvider5 = new System.Windows.Forms.HelpProvider();
            this.helpProvider6 = new System.Windows.Forms.HelpProvider();
            this.helpProvider7 = new System.Windows.Forms.HelpProvider();
            this.btn_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.helpProvider1.SetHelpString(this.Create, "Press This Button to Create a New Account");
            this.Create.Location = new System.Drawing.Point(59, 42);
            this.Create.Name = "Create";
            this.helpProvider1.SetShowHelp(this.Create, true);
            this.Create.Size = new System.Drawing.Size(157, 23);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create a New Account";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Deposit
            // 
            this.helpProvider2.SetHelpString(this.Deposit, "Press This Button to Deposit Money");
            this.Deposit.Location = new System.Drawing.Point(59, 71);
            this.Deposit.Name = "Deposit";
            this.helpProvider2.SetShowHelp(this.Deposit, true);
            this.Deposit.Size = new System.Drawing.Size(157, 23);
            this.Deposit.TabIndex = 1;
            this.Deposit.Text = "Deposit Money";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Withdraw
            // 
            this.helpProvider3.SetHelpString(this.Withdraw, "Press This Button to Withdraw Money");
            this.Withdraw.Location = new System.Drawing.Point(59, 100);
            this.Withdraw.Name = "Withdraw";
            this.helpProvider3.SetShowHelp(this.Withdraw, true);
            this.Withdraw.Size = new System.Drawing.Size(157, 23);
            this.Withdraw.TabIndex = 2;
            this.Withdraw.Text = "Withdraw Money";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Check
            // 
            this.helpProvider4.SetHelpString(this.Check, "Press This Button to Check the Balance");
            this.Check.Location = new System.Drawing.Point(59, 129);
            this.Check.Name = "Check";
            this.helpProvider4.SetShowHelp(this.Check, true);
            this.Check.Size = new System.Drawing.Size(157, 23);
            this.Check.TabIndex = 3;
            this.Check.Text = "Check the Balance";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Modify
            // 
            this.helpProvider5.SetHelpString(this.Modify, "Press This Button to Modify the Details of an Account");
            this.Modify.Location = new System.Drawing.Point(59, 158);
            this.Modify.Name = "Modify";
            this.helpProvider5.SetShowHelp(this.Modify, true);
            this.Modify.Size = new System.Drawing.Size(157, 23);
            this.Modify.TabIndex = 4;
            this.Modify.Text = "Modify Details of an Account";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Print
            // 
            this.helpProvider7.SetHelpString(this.Print, "");
            this.helpProvider6.SetHelpString(this.Print, "Press This Button to Print out Transactions");
            this.Print.Location = new System.Drawing.Point(59, 187);
            this.Print.Name = "Print";
            this.helpProvider7.SetShowHelp(this.Print, false);
            this.helpProvider6.SetShowHelp(this.Print, true);
            this.Print.Size = new System.Drawing.Size(157, 23);
            this.Print.TabIndex = 5;
            this.Print.Text = "Print Reports of Transactions";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Exit
            // 
            this.helpProvider7.SetHelpString(this.Exit, "Press This Button to Exit the Program");
            this.Exit.Location = new System.Drawing.Point(59, 216);
            this.Exit.Name = "Exit";
            this.helpProvider7.SetShowHelp(this.Exit, true);
            this.Exit.Size = new System.Drawing.Size(157, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khaleez Bank";
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(59, 257);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(157, 23);
            this.btn_Help.TabIndex = 8;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 299);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Create);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.HelpProvider helpProvider3;
        private System.Windows.Forms.HelpProvider helpProvider4;
        private System.Windows.Forms.HelpProvider helpProvider5;
        private System.Windows.Forms.HelpProvider helpProvider6;
        private System.Windows.Forms.HelpProvider helpProvider7;
        private System.Windows.Forms.Button btn_Help;
    }
}

