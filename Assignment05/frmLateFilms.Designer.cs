using System;
using System.Windows.Forms;
namespace Assignment05
{
    partial class frmLateFilms
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
            this.btnDueDate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstRentalItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRentalItemsSelected = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewRelease = new System.Windows.Forms.Button();
            this.btnLibraryMovie = new System.Windows.Forms.Button();
            this.btnKidsMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDueDate
            // 
            this.btnDueDate.Location = new System.Drawing.Point(632, 46);
            this.btnDueDate.Name = "btnDueDate";
            this.btnDueDate.Size = new System.Drawing.Size(279, 36);
            this.btnDueDate.TabIndex = 3;
            this.btnDueDate.Text = "Select &Due Date";
            this.btnDueDate.UseVisualStyleBackColor = true;
            this.btnDueDate.Click += new System.EventHandler(this.btnDueDate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(632, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(279, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstRentalItems
            // 
            this.lstRentalItems.FormattingEnabled = true;
            this.lstRentalItems.ItemHeight = 16;
            this.lstRentalItems.Location = new System.Drawing.Point(40, 45);
            this.lstRentalItems.Name = "lstRentalItems";
            this.lstRentalItems.Size = new System.Drawing.Size(546, 228);
            this.lstRentalItems.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rental Items";
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.CustomFormat = "MM-dd-yyyy";
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(747, 304);
            DateTime todaysDate = DateTime.Today;
            int year = todaysDate.Year;
            int month = todaysDate.Month;
            int day = todaysDate.Day;
            this.dateTimePickerDueDate.MaxDate = new System.DateTime(year, month, day, 0, 0, 0, 0);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerDueDate.TabIndex = 8;
            this.dateTimePickerDueDate.Value = new System.DateTime(year, month, day, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Due Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstRentalItemsSelected
            // 
            this.lstRentalItemsSelected.FormattingEnabled = true;
            this.lstRentalItemsSelected.ItemHeight = 16;
            this.lstRentalItemsSelected.Location = new System.Drawing.Point(40, 353);
            this.lstRentalItemsSelected.Name = "lstRentalItemsSelected";
            this.lstRentalItemsSelected.Size = new System.Drawing.Size(546, 228);
            this.lstRentalItemsSelected.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selected Items";
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.Location = new System.Drawing.Point(632, 382);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Size = new System.Drawing.Size(279, 38);
            this.btnNewRelease.TabIndex = 11;
            this.btnNewRelease.Text = "&New Release";
            this.btnNewRelease.UseVisualStyleBackColor = true;
            this.btnNewRelease.Click += new System.EventHandler(this.btnNewRelease_Click);
            // 
            // btnLibraryMovie
            // 
            this.btnLibraryMovie.Location = new System.Drawing.Point(632, 453);
            this.btnLibraryMovie.Name = "btnLibraryMovie";
            this.btnLibraryMovie.Size = new System.Drawing.Size(279, 38);
            this.btnLibraryMovie.TabIndex = 12;
            this.btnLibraryMovie.Text = "&Library Movie";
            this.btnLibraryMovie.UseVisualStyleBackColor = true;
            this.btnLibraryMovie.Click += new System.EventHandler(this.btnLibraryMovie_Click);
            // 
            // btnKidsMovie
            // 
            this.btnKidsMovie.Location = new System.Drawing.Point(632, 522);
            this.btnKidsMovie.Name = "btnKidsMovie";
            this.btnKidsMovie.Size = new System.Drawing.Size(279, 38);
            this.btnKidsMovie.TabIndex = 13;
            this.btnKidsMovie.Text = "&Kids Movie";
            this.btnKidsMovie.UseVisualStyleBackColor = true;
            this.btnKidsMovie.Click += new System.EventHandler(this.btnKidsMovie_Click);
            // 
            // frmLateFilms
            // 
            this.AcceptButton = this.btnDueDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(988, 617);
            this.Controls.Add(this.btnKidsMovie);
            this.Controls.Add(this.btnLibraryMovie);
            this.Controls.Add(this.btnNewRelease);
            this.Controls.Add(this.lstRentalItemsSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstRentalItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDueDate);
            this.Name = "frmLateFilms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Late Films";
            this.Load += new System.EventHandler(this.frmRentalItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDueDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstRentalItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRentalItemsSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewRelease;
        private System.Windows.Forms.Button btnLibraryMovie;
        private System.Windows.Forms.Button btnKidsMovie;
    }
}