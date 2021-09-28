
namespace Assignment_01
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ryan\'s Late Fee Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.Location = new System.Drawing.Point(87, 89);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Size = new System.Drawing.Size(175, 35);
            this.btnNewRelease.TabIndex = 1;
            this.btnNewRelease.Text = "&New Release";
            this.btnNewRelease.UseVisualStyleBackColor = true;
            this.btnNewRelease.Click += new System.EventHandler(this.btnNewRelease_Click);
            // 
            // btnLibraryMovie
            // 
            this.btnLibraryMovie.Location = new System.Drawing.Point(87, 161);
            this.btnLibraryMovie.Name = "btnLibraryMovie";
            this.btnLibraryMovie.Size = new System.Drawing.Size(175, 35);
            this.btnLibraryMovie.TabIndex = 2;
            this.btnLibraryMovie.Text = "&Library Movie";
            this.btnLibraryMovie.UseVisualStyleBackColor = true;
            this.btnLibraryMovie.Click += new System.EventHandler(this.btnLibraryMovie_Click);
            // 
            // btnKidsMovie
            // 
            this.btnKidsMovie.Location = new System.Drawing.Point(87, 227);
            this.btnKidsMovie.Name = "btnKidsMovie";
            this.btnKidsMovie.Size = new System.Drawing.Size(175, 35);
            this.btnKidsMovie.TabIndex = 3;
            this.btnKidsMovie.Text = "&Kids Movie";
            this.btnKidsMovie.UseVisualStyleBackColor = true;
            this.btnKidsMovie.Click += new System.EventHandler(this.btnKidsMovie_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(87, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 379);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKidsMovie);
            this.Controls.Add(this.btnLibraryMovie);
            this.Controls.Add(this.btnNewRelease);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
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
    }
}

