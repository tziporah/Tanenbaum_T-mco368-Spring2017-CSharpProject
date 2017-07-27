namespace TziporahStore
{
    partial class PurchasesForm
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
            this.allButton = new System.Windows.Forms.Button();
            this.dateButton = new System.Windows.Forms.Button();
            this.priceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.beginDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.beginDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.minPriceLabel = new System.Windows.Forms.Label();
            this.maxPriceLabel = new System.Windows.Forms.Label();
            this.minPrice = new System.Windows.Forms.NumericUpDown();
            this.maxPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(45, 28);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(186, 23);
            this.allButton.TabIndex = 0;
            this.allButton.Text = "View All Purchases";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // dateButton
            // 
            this.dateButton.Location = new System.Drawing.Point(45, 88);
            this.dateButton.Name = "dateButton";
            this.dateButton.Size = new System.Drawing.Size(186, 23);
            this.dateButton.TabIndex = 1;
            this.dateButton.Text = "View Purchases Within Date Range";
            this.dateButton.UseVisualStyleBackColor = true;
            this.dateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(45, 180);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(186, 23);
            this.priceButton.TabIndex = 2;
            this.priceButton.Text = "View Purchases Within Price Range";
            this.priceButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PurchaseID     CustomerID     ItemNo     Quantity     PurchaseDate               " +
    "Price";
            this.label1.Visible = false;
            // 
            // beginDateLabel
            // 
            this.beginDateLabel.AutoSize = true;
            this.beginDateLabel.Location = new System.Drawing.Point(42, 123);
            this.beginDateLabel.Name = "beginDateLabel";
            this.beginDateLabel.Size = new System.Drawing.Size(63, 13);
            this.beginDateLabel.TabIndex = 4;
            this.beginDateLabel.Text = "Begin Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(42, 155);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(55, 13);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date:";
            // 
            // beginDate
            // 
            this.beginDate.Location = new System.Drawing.Point(111, 117);
            this.beginDate.Name = "beginDate";
            this.beginDate.Size = new System.Drawing.Size(200, 20);
            this.beginDate.TabIndex = 6;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(111, 149);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 7;
            // 
            // minPriceLabel
            // 
            this.minPriceLabel.AutoSize = true;
            this.minPriceLabel.Location = new System.Drawing.Point(45, 216);
            this.minPriceLabel.Name = "minPriceLabel";
            this.minPriceLabel.Size = new System.Drawing.Size(78, 13);
            this.minPriceLabel.TabIndex = 8;
            this.minPriceLabel.Text = "Minimum Price:";
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.AutoSize = true;
            this.maxPriceLabel.Location = new System.Drawing.Point(45, 239);
            this.maxPriceLabel.Name = "maxPriceLabel";
            this.maxPriceLabel.Size = new System.Drawing.Size(81, 13);
            this.maxPriceLabel.TabIndex = 9;
            this.maxPriceLabel.Text = "Maximum Price:";
            // 
            // minPrice
            // 
            this.minPrice.DecimalPlaces = 2;
            this.minPrice.Location = new System.Drawing.Point(129, 209);
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(120, 20);
            this.minPrice.TabIndex = 10;
            // 
            // maxPrice
            // 
            this.maxPrice.DecimalPlaces = 2;
            this.maxPrice.Location = new System.Drawing.Point(129, 237);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(120, 20);
            this.maxPrice.TabIndex = 11;
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 261);
            this.Controls.Add(this.maxPrice);
            this.Controls.Add(this.minPrice);
            this.Controls.Add(this.maxPriceLabel);
            this.Controls.Add(this.minPriceLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.beginDate);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.beginDateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.dateButton);
            this.Controls.Add(this.allButton);
            this.Name = "PurchasesForm";
            this.Text = "PurchasesForm";
            this.Load += new System.EventHandler(this.PurchasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button dateButton;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label beginDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker beginDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label minPriceLabel;
        private System.Windows.Forms.Label maxPriceLabel;
        private System.Windows.Forms.NumericUpDown minPrice;
        private System.Windows.Forms.NumericUpDown maxPrice;
    }
}