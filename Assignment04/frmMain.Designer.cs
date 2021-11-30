
namespace Assignment04
{
    partial class frmMain
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
            this.btnNewRelease = new System.Windows.Forms.Button();
            this.btnLibraryMovie = new System.Windows.Forms.Button();
            this.btnKidsMovie = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLateFilms = new System.Windows.Forms.Button();
            this.labelNumberLateFilmsManual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalLateFee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalNumberMovies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ryan\'s Late Fee Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.Location = new System.Drawing.Point(36, 85);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Size = new System.Drawing.Size(279, 38);
            this.btnNewRelease.TabIndex = 1;
            this.btnNewRelease.Text = "&New Release";
            this.btnNewRelease.UseVisualStyleBackColor = true;
            this.btnNewRelease.Click += new System.EventHandler(this.btnNewRelease_Click);
            // 
            // btnLibraryMovie
            // 
            this.btnLibraryMovie.Location = new System.Drawing.Point(36, 154);
            this.btnLibraryMovie.Name = "btnLibraryMovie";
            this.btnLibraryMovie.Size = new System.Drawing.Size(279, 38);
            this.btnLibraryMovie.TabIndex = 2;
            this.btnLibraryMovie.Text = "&Library Movie";
            this.btnLibraryMovie.UseVisualStyleBackColor = true;
            this.btnLibraryMovie.Click += new System.EventHandler(this.btnLibraryMovie_Click);
            // 
            // btnKidsMovie
            // 
            this.btnKidsMovie.Location = new System.Drawing.Point(36, 227);
            this.btnKidsMovie.Name = "btnKidsMovie";
            this.btnKidsMovie.Size = new System.Drawing.Size(279, 38);
            this.btnKidsMovie.TabIndex = 3;
            this.btnKidsMovie.Text = "&Kids Movie";
            this.btnKidsMovie.UseVisualStyleBackColor = true;
            this.btnKidsMovie.Click += new System.EventHandler(this.btnKidsMovie_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(36, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(279, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLateFilms
            // 
            this.btnLateFilms.Location = new System.Drawing.Point(36, 297);
            this.btnLateFilms.Name = "btnLateFilms";
            this.btnLateFilms.Size = new System.Drawing.Size(279, 38);
            this.btnLateFilms.TabIndex = 5;
            this.btnLateFilms.Text = "L&ate Films";
            this.btnLateFilms.UseVisualStyleBackColor = true;
            this.btnLateFilms.Click += new System.EventHandler(this.btnLateFilms_Click);
            // 
            // labelNumberLateFilmsManual
            // 
            this.labelNumberLateFilmsManual.AutoSize = true;
            this.labelNumberLateFilmsManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberLateFilmsManual.Location = new System.Drawing.Point(576, 85);
            this.labelNumberLateFilmsManual.Name = "labelNumberLateFilmsManual";
            this.labelNumberLateFilmsManual.Size = new System.Drawing.Size(14, 20);
            this.labelNumberLateFilmsManual.TabIndex = 6;
            this.labelNumberLateFilmsManual.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Movies with \r\ndelayed delivery \r\nlast entered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total late fee";
            // 
            // labelTotalLateFee
            // 
            this.labelTotalLateFee.AutoSize = true;
            this.labelTotalLateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLateFee.Location = new System.Drawing.Point(576, 224);
            this.labelTotalLateFee.Name = "labelTotalLateFee";
            this.labelTotalLateFee.Size = new System.Drawing.Size(14, 20);
            this.labelTotalLateFee.TabIndex = 9;
            this.labelTotalLateFee.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Number of Movies \r\nwith delayed delivery";
            // 
            // totalNumberMovies
            // 
            this.totalNumberMovies.AutoSize = true;
            this.totalNumberMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumberMovies.Location = new System.Drawing.Point(576, 154);
            this.totalNumberMovies.Name = "totalNumberMovies";
            this.totalNumberMovies.Size = new System.Drawing.Size(14, 20);
            this.totalNumberMovies.TabIndex = 10;
            this.totalNumberMovies.Text = " ";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnNewRelease;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(649, 485);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalNumberMovies);
            this.Controls.Add(this.labelTotalLateFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumberLateFilmsManual);
            this.Controls.Add(this.btnLateFilms);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKidsMovie);
            this.Controls.Add(this.btnLibraryMovie);
            this.Controls.Add(this.btnNewRelease);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryan\'s Late Fee Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewRelease;
        private System.Windows.Forms.Button btnLibraryMovie;
        private System.Windows.Forms.Button btnKidsMovie;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLateFilms;
        private System.Windows.Forms.Label labelNumberLateFilmsManual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalLateFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalNumberMovies;
    }
}

