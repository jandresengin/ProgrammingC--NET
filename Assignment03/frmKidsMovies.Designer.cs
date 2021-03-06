using System;
namespace Assignment01
{
    partial class frmKidsMovies
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumbersOfDaysLate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.subtotalWithoutDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalWithDiscount = new System.Windows.Forms.TextBox();
            this.txtNumberOfMovies = new System.Windows.Forms.TextBox();
            this.comboBoxCustomerType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Due Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(32, 249);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(298, 38);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Location = new System.Drawing.Point(32, 318);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(298, 38);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Current Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Location = new System.Drawing.Point(207, 72);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(123, 22);
            this.txtCurrentDate.TabIndex = 6;
            this.txtCurrentDate.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numbers of Days Late";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumbersOfDaysLate
            // 
            this.txtNumbersOfDaysLate.Location = new System.Drawing.Point(207, 130);
            this.txtNumbersOfDaysLate.Name = "txtNumbersOfDaysLate";
            this.txtNumbersOfDaysLate.ReadOnly = true;
            this.txtNumbersOfDaysLate.Size = new System.Drawing.Size(123, 22);
            this.txtNumbersOfDaysLate.TabIndex = 8;
            this.txtNumbersOfDaysLate.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Late Fee";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLateFee
            // 
            this.txtLateFee.Location = new System.Drawing.Point(207, 184);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.ReadOnly = true;
            this.txtLateFee.Size = new System.Drawing.Size(123, 22);
            this.txtLateFee.TabIndex = 10;
            this.txtLateFee.TabStop = false;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.CustomFormat = "MM-dd-yyyy";
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(207, 27);
            DateTime todaysDate = DateTime.Today;
            int year = todaysDate.Year;
            int month = todaysDate.Month;
            int day = todaysDate.Day;
            this.dateTimePickerDueDate.MaxDate = new System.DateTime(year, month, day, 0, 0, 0, 0);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerDueDate.TabIndex = 1;
            this.dateTimePickerDueDate.Value = new System.DateTime(year, month, day, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of Movies \r\nDelivered Late";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Subtotal Without Discount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtotalWithoutDiscount
            // 
            this.subtotalWithoutDiscount.Location = new System.Drawing.Point(577, 72);
            this.subtotalWithoutDiscount.Name = "subtotalWithoutDiscount";
            this.subtotalWithoutDiscount.ReadOnly = true;
            this.subtotalWithoutDiscount.Size = new System.Drawing.Size(123, 22);
            this.subtotalWithoutDiscount.TabIndex = 26;
            this.subtotalWithoutDiscount.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 68);
            this.label6.TabIndex = 27;
            this.label6.Text = "Customer Type:\r\nType L for loyal customer\r\nType J for Junior customer\r\nType N for" +
    " New Customer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total With Discount";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalWithDiscount
            // 
            this.txtTotalWithDiscount.Location = new System.Drawing.Point(533, 336);
            this.txtTotalWithDiscount.Name = "txtTotalWithDiscount";
            this.txtTotalWithDiscount.ReadOnly = true;
            this.txtTotalWithDiscount.Size = new System.Drawing.Size(167, 22);
            this.txtTotalWithDiscount.TabIndex = 30;
            this.txtTotalWithDiscount.TabStop = false;
            // 
            // txtNumberOfMovies
            // 
            this.txtNumberOfMovies.Location = new System.Drawing.Point(577, 24);
            this.txtNumberOfMovies.Name = "txtNumberOfMovies";
            this.txtNumberOfMovies.Size = new System.Drawing.Size(123, 22);
            this.txtNumberOfMovies.TabIndex = 2;
            this.txtNumberOfMovies.Leave += new System.EventHandler(this.ClearNumberMovies);
            // 
            // comboBoxCustomerType
            // 
            this.comboBoxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerType.FormattingEnabled = true;
            this.comboBoxCustomerType.Items.AddRange(new object[] {
            "L",
            "J",
            "N"});
            this.comboBoxCustomerType.Location = new System.Drawing.Point(579, 130);
            this.comboBoxCustomerType.Name = "comboBoxCustomerType";
            this.comboBoxCustomerType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCustomerType.TabIndex = 3;
            this.comboBoxCustomerType.SelectedIndex = 2;
            // 
            // frmKidsMovies
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(734, 385);
            this.Controls.Add(this.comboBoxCustomerType);
            this.Controls.Add(this.txtNumberOfMovies);
            this.Controls.Add(this.txtTotalWithDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtotalWithoutDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.txtLateFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumbersOfDaysLate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Name = "frmKidsMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kids Movies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumbersOfDaysLate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLateFee;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox subtotalWithoutDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalWithDiscount;
        private System.Windows.Forms.TextBox txtNumberOfMovies;
        internal System.Windows.Forms.ComboBox comboBoxCustomerType;
    }
}