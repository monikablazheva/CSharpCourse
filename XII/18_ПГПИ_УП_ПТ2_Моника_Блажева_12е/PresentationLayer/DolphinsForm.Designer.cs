
namespace PresentationLayer
{
    partial class DolphinsForm
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
            this.MAge = new System.Windows.Forms.NumericUpDown();
            this.MGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dolphinsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.MName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolphinsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MAge
            // 
            this.MAge.Location = new System.Drawing.Point(172, 192);
            this.MAge.Name = "MAge";
            this.MAge.Size = new System.Drawing.Size(120, 23);
            this.MAge.TabIndex = 21;
            // 
            // MGender
            // 
            this.MGender.Location = new System.Drawing.Point(172, 227);
            this.MGender.Name = "MGender";
            this.MGender.Size = new System.Drawing.Size(100, 23);
            this.MGender.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Age :";
            // 
            // dolphinsDataGridView
            // 
            this.dolphinsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dolphinsDataGridView.Location = new System.Drawing.Point(388, 84);
            this.dolphinsDataGridView.Name = "dolphinsDataGridView";
            this.dolphinsDataGridView.RowTemplate.Height = 25;
            this.dolphinsDataGridView.Size = new System.Drawing.Size(349, 222);
            this.dolphinsDataGridView.TabIndex = 17;
            this.dolphinsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dolphinsDataGridView_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(520, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MName
            // 
            this.MName.Location = new System.Drawing.Point(172, 149);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(100, 23);
            this.MName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name :";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(152, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(64, 283);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(238, 283);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // DolphinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MAge);
            this.Controls.Add(this.MGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dolphinsDataGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btn_Update);
            this.Name = "DolphinsForm";
            this.Text = "DolphinsForm";
            ((System.ComponentModel.ISupportInitialize)(this.MAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolphinsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MAge;
        private System.Windows.Forms.TextBox MGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dolphinsDataGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox MName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btn_Update;
    }
}