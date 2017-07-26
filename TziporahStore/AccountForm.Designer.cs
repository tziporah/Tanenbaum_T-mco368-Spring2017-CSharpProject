namespace TziporahStore
{
    partial class AccountForm
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
            this.accountLabel = new System.Windows.Forms.Label();
            this.makePaymentButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.enterAmountLabel = new System.Windows.Forms.Label();
            this.updateAccountButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(71, 47);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(55, 13);
            this.accountLabel.TabIndex = 0;
            this.accountLabel.Text = "Welcome!";
            this.accountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // makePaymentButton
            // 
            this.makePaymentButton.Location = new System.Drawing.Point(90, 103);
            this.makePaymentButton.Name = "makePaymentButton";
            this.makePaymentButton.Size = new System.Drawing.Size(111, 23);
            this.makePaymentButton.TabIndex = 1;
            this.makePaymentButton.Text = "Make Payment";
            this.makePaymentButton.UseVisualStyleBackColor = true;
            this.makePaymentButton.Click += new System.EventHandler(this.makePaymentButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(134, 173);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Visible = false;
            // 
            // enterAmountLabel
            // 
            this.enterAmountLabel.AutoSize = true;
            this.enterAmountLabel.Location = new System.Drawing.Point(32, 175);
            this.enterAmountLabel.Name = "enterAmountLabel";
            this.enterAmountLabel.Size = new System.Drawing.Size(73, 13);
            this.enterAmountLabel.TabIndex = 3;
            this.enterAmountLabel.Text = "Enter amount:";
            this.enterAmountLabel.Visible = false;
            // 
            // updateAccountButton
            // 
            this.updateAccountButton.Location = new System.Drawing.Point(83, 204);
            this.updateAccountButton.Name = "updateAccountButton";
            this.updateAccountButton.Size = new System.Drawing.Size(118, 23);
            this.updateAccountButton.TabIndex = 4;
            this.updateAccountButton.Text = "Update Account";
            this.updateAccountButton.UseVisualStyleBackColor = true;
            this.updateAccountButton.Visible = false;
            this.updateAccountButton.Click += new System.EventHandler(this.updateAccountButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(32, 142);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(214, 13);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "There was an error processing your request.";
            this.errorLabel.Visible = false;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.updateAccountButton);
            this.Controls.Add(this.enterAmountLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.makePaymentButton);
            this.Controls.Add(this.accountLabel);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Button makePaymentButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label enterAmountLabel;
        private System.Windows.Forms.Button updateAccountButton;
        private System.Windows.Forms.Label errorLabel;
    }
}