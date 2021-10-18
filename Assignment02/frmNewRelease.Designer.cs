using System;
using System.Windows.Forms;
namespace Assignment01
{
    partial class frmNewRelease
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
            this.txtNumberOfMovies = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotalMoviesPartial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.subtotalWithoutDiscount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Due Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 318);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(298, 38);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Location = new System.Drawing.Point(33, 377);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(298, 38);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Location = new System.Drawing.Point(208, 107);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(123, 22);
            this.txtCurrentDate.TabIndex = 5;
            this.txtCurrentDate.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numbers of Days Late";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumbersOfDaysLate
            // 
            this.txtNumbersOfDaysLate.Location = new System.Drawing.Point(208, 157);
            this.txtNumbersOfDaysLate.Name = "txtNumbersOfDaysLate";
            this.txtNumbersOfDaysLate.ReadOnly = true;
            this.txtNumbersOfDaysLate.Size = new System.Drawing.Size(123, 22);
            this.txtNumbersOfDaysLate.TabIndex = 7;
            this.txtNumbersOfDaysLate.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Late Fee";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLateFee
            // 
            this.txtLateFee.Location = new System.Drawing.Point(208, 202);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.ReadOnly = true;
            this.txtLateFee.Size = new System.Drawing.Size(123, 22);
            this.txtLateFee.TabIndex = 9;
            this.txtLateFee.TabStop = false;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.CustomFormat = "MM-dd-yyyy";
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(208, 57);


            DateTime todaysDate = DateTime.Today;
            int year = todaysDate.Year;
            int month = todaysDate.Year;
            int day = todaysDate.Year;

            this.dateTimePickerDueDate.MaxDate = new System.DateTime(year, month, day, 0, 0, 0, 0);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerDueDate.TabIndex = 1;
            this.dateTimePickerDueDate.Value = new System.DateTime(year, month, day, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Movies \r\nDelivered Late";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfMovies
            // 
            this.txtNumberOfMovies.Location = new System.Drawing.Point(594, 57);
            this.txtNumberOfMovies.Name = "txtNumberOfMovies";
            this.txtNumberOfMovies.ReadOnly = true;
            this.txtNumberOfMovies.Size = new System.Drawing.Size(123, 22);
            this.txtNumberOfMovies.TabIndex = 2;
            this.txtNumberOfMovies.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "N",
            "L",
            "J"});
            this.listBox1.Location = new System.Drawing.Point(658, 295);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "N",
            "L",
            "J"});
            this.comboBox1.Location = new System.Drawing.Point(397, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Subtotal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtotalMoviesPartial
            // 
            this.subtotalMoviesPartial.Location = new System.Drawing.Point(208, 252);
            this.subtotalMoviesPartial.Name = "subtotalMoviesPartial";
            this.subtotalMoviesPartial.ReadOnly = true;
            this.subtotalMoviesPartial.Size = new System.Drawing.Size(123, 22);
            this.subtotalMoviesPartial.TabIndex = 16;
            this.subtotalMoviesPartial.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Subtotal Without Discount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtotalWithoutDiscount
            // 
            this.subtotalWithoutDiscount.Location = new System.Drawing.Point(594, 109);
            this.subtotalWithoutDiscount.Name = "subtotalWithoutDiscount";
            this.subtotalWithoutDiscount.ReadOnly = true;
            this.subtotalWithoutDiscount.Size = new System.Drawing.Size(123, 22);
            this.subtotalWithoutDiscount.TabIndex = 18;
            this.subtotalWithoutDiscount.TabStop = false;
            // 
            // frmNewRelease
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(874, 464);
            this.Controls.Add(this.subtotalWithoutDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subtotalMoviesPartial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtNumberOfMovies);
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
            this.Name = "frmNewRelease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Releases";
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
        private Label label5;
        private TextBox txtNumberOfMovies;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox subtotalMoviesPartial;
        private Label label7;
        private TextBox subtotalWithoutDiscount;
    }
}