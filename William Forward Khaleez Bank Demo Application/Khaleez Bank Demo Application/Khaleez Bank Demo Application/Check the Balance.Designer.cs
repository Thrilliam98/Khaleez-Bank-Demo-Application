namespace Khaleez_Bank_Demo_Application
{
    partial class Check_the_Balance
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
            this.txt_AccountNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.btn_Check_Balance = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SavingsAccountType = new System.Windows.Forms.TextBox();
            this.btn_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check the Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Account Number";
            // 
            // txt_AccountNo
            // 
            this.txt_AccountNo.Location = new System.Drawing.Point(152, 51);
            this.txt_AccountNo.Name = "txt_AccountNo";
            this.txt_AccountNo.Size = new System.Drawing.Size(100, 20);
            this.txt_AccountNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Balance";
            // 
            // txt_Balance
            // 
            this.txt_Balance.Location = new System.Drawing.Point(152, 102);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(100, 20);
            this.txt_Balance.TabIndex = 4;
            // 
            // btn_Check_Balance
            // 
            this.helpProvider1.SetHelpString(this.btn_Check_Balance, "Please enter the account number and press this button to check the balance");
            this.btn_Check_Balance.Location = new System.Drawing.Point(15, 162);
            this.btn_Check_Balance.Name = "btn_Check_Balance";
            this.helpProvider1.SetShowHelp(this.btn_Check_Balance, true);
            this.btn_Check_Balance.Size = new System.Drawing.Size(99, 23);
            this.btn_Check_Balance.TabIndex = 5;
            this.btn_Check_Balance.Text = "Check Balance";
            this.btn_Check_Balance.UseVisualStyleBackColor = true;
            this.btn_Check_Balance.Click += new System.EventHandler(this.btn_Check_Balance_Click);
            // 
            // btn_Back
            // 
            this.helpProvider2.SetHelpString(this.btn_Back, "Press this button to go back the the main menu");
            this.btn_Back.Location = new System.Drawing.Point(177, 162);
            this.btn_Back.Name = "btn_Back";
            this.helpProvider2.SetShowHelp(this.btn_Back, true);
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Go Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Savings Account Type";
            // 
            // txt_SavingsAccountType
            // 
            this.txt_SavingsAccountType.Location = new System.Drawing.Point(152, 77);
            this.txt_SavingsAccountType.Name = "txt_SavingsAccountType";
            this.txt_SavingsAccountType.Size = new System.Drawing.Size(100, 20);
            this.txt_SavingsAccountType.TabIndex = 8;
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(61, 210);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(157, 23);
            this.btn_Help.TabIndex = 16;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Check_the_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.txt_SavingsAccountType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Check_Balance);
            this.Controls.Add(this.txt_Balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AccountNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Check_the_Balance";
            this.Text = "Check the Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AccountNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.Button btn_Check_Balance;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SavingsAccountType;
        private System.Windows.Forms.Button btn_Help;
    }
}