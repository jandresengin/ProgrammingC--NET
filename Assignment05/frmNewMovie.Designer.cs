
namespace Assignment05
{
    partial class frmNewMovie
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
            this.txtMovieNumber = new System.Windows.Forms.TextBox();
            this.txtMovieDescription = new System.Windows.Forms.TextBox();
            this.txtFilmRating = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTypeMovie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie’s number";
            // 
            // txtMovieNumber
            // 
            this.txtMovieNumber.Location = new System.Drawing.Point(203, 23);
            this.txtMovieNumber.Name = "txtMovieNumber";
            this.txtMovieNumber.Size = new System.Drawing.Size(228, 22);
            this.txtMovieNumber.TabIndex = 1;
            this.txtMovieNumber.Tag = "Movie\'s number";
            // 
            // txtMovieDescription
            // 
            this.txtMovieDescription.Location = new System.Drawing.Point(203, 68);
            this.txtMovieDescription.Name = "txtMovieDescription";
            this.txtMovieDescription.Size = new System.Drawing.Size(228, 22);
            this.txtMovieDescription.TabIndex = 2;
            this.txtMovieDescription.Tag = "Movie\'s description";
            // 
            // txtFilmRating
            // 
            this.txtFilmRating.Location = new System.Drawing.Point(203, 116);
            this.txtFilmRating.Name = "txtFilmRating";
            this.txtFilmRating.Size = new System.Drawing.Size(228, 22);
            this.txtFilmRating.TabIndex = 3;
            this.txtFilmRating.Tag = "Film\'s rating";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(316, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Movie’s description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Film’s rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type Movie";
            // 
            // comboBoxTypeMovie
            // 
            this.comboBoxTypeMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeMovie.FormattingEnabled = true;
            this.comboBoxTypeMovie.Items.AddRange(new object[] {
            "Release",
            "Library",
            "Kids"});
            this.comboBoxTypeMovie.Location = new System.Drawing.Point(203, 163);
            this.comboBoxTypeMovie.Name = "comboBoxTypeMovie";
            this.comboBoxTypeMovie.Size = new System.Drawing.Size(228, 24);
            this.comboBoxTypeMovie.TabIndex = 10;
            this.comboBoxTypeMovie.Tag = "Type Movie";
            this.comboBoxTypeMovie.SelectedIndex = 0;
            // 
            // frmNewMovie
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(468, 293);
            this.Controls.Add(this.comboBoxTypeMovie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFilmRating);
            this.Controls.Add(this.txtMovieDescription);
            this.Controls.Add(this.txtMovieNumber);
            this.Controls.Add(this.label1);
            this.Name = "frmNewMovie";
            this.Text = "New Movie form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieNumber;
        private System.Windows.Forms.TextBox txtMovieDescription;
        private System.Windows.Forms.TextBox txtFilmRating;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox comboBoxTypeMovie;
    }
}