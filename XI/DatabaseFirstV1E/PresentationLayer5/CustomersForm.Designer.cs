
namespace PresentationLayer5
{
    partial class CustomersForm
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
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.countryTxtBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addProductsBtn = new System.Windows.Forms.Button();
            this.productsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(131, 186);
            this.ageBox.Maximum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.ageBox.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(75, 31);
            this.ageBox.TabIndex = 5;
            this.ageBox.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(131, 49);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(150, 31);
            this.nameTxtBox.TabIndex = 3;
            // 
            // countryTxtBox
            // 
            this.countryTxtBox.Location = new System.Drawing.Point(131, 119);
            this.countryTxtBox.Name = "countryTxtBox";
            this.countryTxtBox.Size = new System.Drawing.Size(150, 31);
            this.countryTxtBox.TabIndex = 4;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(37, 255);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(112, 34);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(169, 255);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 34);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(107, 318);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 34);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Location = new System.Drawing.Point(365, 49);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 62;
            this.customersDataGridView.RowTemplate.Height = 33;
            this.customersDataGridView.Size = new System.Drawing.Size(480, 303);
            this.customersDataGridView.TabIndex = 9;
            this.customersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(469, 376);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 34);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addProductsBtn
            // 
            this.addProductsBtn.Location = new System.Drawing.Point(928, 376);
            this.addProductsBtn.Name = "addProductsBtn";
            this.addProductsBtn.Size = new System.Drawing.Size(141, 34);
            this.addProductsBtn.TabIndex = 12;
            this.addProductsBtn.Text = "Add Product";
            this.addProductsBtn.UseVisualStyleBackColor = true;
            this.addProductsBtn.Click += new System.EventHandler(this.addProductsBtn_Click);
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 25;
            this.productsListBox.Location = new System.Drawing.Point(889, 49);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(217, 304);
            this.productsListBox.TabIndex = 11;
            this.productsListBox.SelectedValueChanged += new System.EventHandler(this.productsListBox_SelectedValueChanged);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.addProductsBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.countryTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox countryTxtBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addProductsBtn;
        private System.Windows.Forms.ListBox productsListBox;
    }
}