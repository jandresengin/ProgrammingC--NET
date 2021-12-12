
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLateFilms = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDueDate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstRentalItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the title of \r\nthe movie:";
            // 
            // txtLateFilms
            // 
            this.txtLateFilms.Location = new System.Drawing.Point(508, 302);
            this.txtLateFilms.Name = "txtLateFilms";
            this.txtLateFilms.Size = new System.Drawing.Size(224, 22);
            this.txtLateFilms.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(632, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDueDate
            // 
            this.btnDueDate.Location = new System.Drawing.Point(632, 112);
            this.btnDueDate.Name = "btnDueDate";
            this.btnDueDate.Size = new System.Drawing.Size(100, 36);
            this.btnDueDate.TabIndex = 3;
            this.btnDueDate.Text = "&Due Date";
            this.btnDueDate.UseVisualStyleBackColor = true;
            this.btnDueDate.Click += new System.EventHandler(this.btnDueDate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(632, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
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
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(508, 396);
            this.dateTimePickerDueDate.MaxDate = new System.DateTime(2021, 12, 11, 0, 0, 0, 0);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerDueDate.TabIndex = 8;
            this.dateTimePickerDueDate.Value = new System.DateTime(2021, 12, 11, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Due Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLateFilms
            // 
            this.AcceptButton = this.btnDueDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(967, 498);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstRentalItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDueDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLateFilms);
            this.Controls.Add(this.label1);
            this.Name = "frmLateFilms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Late Films";
            this.Load += new System.EventHandler(this.frmRentalItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLateFilms;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDueDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstRentalItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label label3;
    }
}