namespace TziporahStore
{
    partial class ItemsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._DBModel_ContextDataSet = new TziporahStore._DBModel_ContextDataSet();
            this.dBModelContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tziporahStoreDataSet = new TziporahStore.TziporahStoreDataSet();
            this.tziporahStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new TziporahStore.TziporahStoreDataSetTableAdapters.ItemTableAdapter();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.qty1 = new System.Windows.Forms.NumericUpDown();
            this.qty2 = new System.Windows.Forms.NumericUpDown();
            this.qty3 = new System.Windows.Forms.NumericUpDown();
            this.qty4 = new System.Windows.Forms.NumericUpDown();
            this.qty5 = new System.Windows.Forms.NumericUpDown();
            this.qty6 = new System.Windows.Forms.NumericUpDown();
            this.qty7 = new System.Windows.Forms.NumericUpDown();
            this.qty8 = new System.Windows.Forms.NumericUpDown();
            this.qty9 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DBModel_ContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBModelContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tziporahStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tziporahStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priceDataGridViewTextBoxColumn,
            this.descriptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // _DBModel_ContextDataSet
            // 
            this._DBModel_ContextDataSet.DataSetName = "_DBModel_ContextDataSet";
            this._DBModel_ContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBModelContextDataSetBindingSource
            // 
            this.dBModelContextDataSetBindingSource.DataSource = this._DBModel_ContextDataSet;
            this.dBModelContextDataSetBindingSource.Position = 0;
            // 
            // tziporahStoreDataSet
            // 
            this.tziporahStoreDataSet.DataSetName = "TziporahStoreDataSet";
            this.tziporahStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tziporahStoreDataSetBindingSource
            // 
            this.tziporahStoreDataSetBindingSource.DataSource = this.tziporahStoreDataSet;
            this.tziporahStoreDataSetBindingSource.Position = 0;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.tziporahStoreDataSetBindingSource;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // descriptDataGridViewTextBoxColumn
            // 
            this.descriptDataGridViewTextBoxColumn.DataPropertyName = "descript";
            this.descriptDataGridViewTextBoxColumn.HeaderText = "descript";
            this.descriptDataGridViewTextBoxColumn.Name = "descriptDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(368, 169);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(274, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(368, 209);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(274, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(368, 250);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(274, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(368, 288);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(274, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(368, 326);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(274, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // qty1
            // 
            this.qty1.Location = new System.Drawing.Point(649, 11);
            this.qty1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty1.Name = "qty1";
            this.qty1.Size = new System.Drawing.Size(35, 20);
            this.qty1.TabIndex = 10;
            this.qty1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qty2
            // 
            this.qty2.Location = new System.Drawing.Point(649, 47);
            this.qty2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty2.Name = "qty2";
            this.qty2.Size = new System.Drawing.Size(35, 20);
            this.qty2.TabIndex = 11;
            this.qty2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qty3
            // 
            this.qty3.Location = new System.Drawing.Point(649, 91);
            this.qty3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty3.Name = "qty3";
            this.qty3.Size = new System.Drawing.Size(34, 20);
            this.qty3.TabIndex = 12;
            this.qty3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qty4
            // 
            this.qty4.Location = new System.Drawing.Point(649, 130);
            this.qty4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty4.Name = "qty4";
            this.qty4.Size = new System.Drawing.Size(33, 20);
            this.qty4.TabIndex = 13;
            this.qty4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qty5
            // 
            this.qty5.Location = new System.Drawing.Point(649, 171);
            this.qty5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty5.Name = "qty5";
            this.qty5.Size = new System.Drawing.Size(32, 20);
            this.qty5.TabIndex = 14;
            this.qty5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qty6
            // 
            this.qty6.Location = new System.Drawing.Point(649, 211);
            this.qty6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty6.Name = "qty6";
            this.qty6.Size = new System.Drawing.Size(31, 20);
            this.qty6.TabIndex = 15;
            this.qty6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qty7
            // 
            this.qty7.Location = new System.Drawing.Point(649, 252);
            this.qty7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty7.Name = "qty7";
            this.qty7.Size = new System.Drawing.Size(30, 20);
            this.qty7.TabIndex = 16;
            this.qty7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qty8
            // 
            this.qty8.Location = new System.Drawing.Point(649, 290);
            this.qty8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty8.Name = "qty8";
            this.qty8.Size = new System.Drawing.Size(34, 20);
            this.qty8.TabIndex = 17;
            this.qty8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qty9
            // 
            this.qty9.Location = new System.Drawing.Point(649, 328);
            this.qty9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qty9.Name = "qty9";
            this.qty9.Size = new System.Drawing.Size(35, 20);
            this.qty9.TabIndex = 18;
            this.qty9.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 388);
            this.Controls.Add(this.qty9);
            this.Controls.Add(this.qty8);
            this.Controls.Add(this.qty7);
            this.Controls.Add(this.qty6);
            this.Controls.Add(this.qty5);
            this.Controls.Add(this.qty4);
            this.Controls.Add(this.qty3);
            this.Controls.Add(this.qty2);
            this.Controls.Add(this.qty1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DBModel_ContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBModelContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tziporahStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tziporahStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dBModelContextDataSetBindingSource;
        private _DBModel_ContextDataSet _DBModel_ContextDataSet;
        private System.Windows.Forms.BindingSource tziporahStoreDataSetBindingSource;
        private TziporahStoreDataSet tziporahStoreDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private TziporahStoreDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown qty1;
        private System.Windows.Forms.NumericUpDown qty2;
        private System.Windows.Forms.NumericUpDown qty3;
        private System.Windows.Forms.NumericUpDown qty4;
        private System.Windows.Forms.NumericUpDown qty5;
        private System.Windows.Forms.NumericUpDown qty6;
        private System.Windows.Forms.NumericUpDown qty7;
        private System.Windows.Forms.NumericUpDown qty8;
        private System.Windows.Forms.NumericUpDown qty9;
    }
}