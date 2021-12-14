
namespace Assignment05
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLateFilms = new System.Windows.Forms.Button();
            this.btnNewFilms = new System.Windows.Forms.Button();
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
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(36, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(279, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLateFilms
            // 
            this.btnLateFilms.Location = new System.Drawing.Point(36, 83);
            this.btnLateFilms.Name = "btnLateFilms";
            this.btnLateFilms.Size = new System.Drawing.Size(279, 38);
            this.btnLateFilms.TabIndex = 5;
            this.btnLateFilms.Text = "L&ate Films";
            this.btnLateFilms.UseVisualStyleBackColor = true;
            this.btnLateFilms.Click += new System.EventHandler(this.btnLateFilms_Click);
            // 
            // btnNewFilms
            // 
            this.btnNewFilms.Location = new System.Drawing.Point(36, 151);
            this.btnNewFilms.Name = "btnNewFilms";
            this.btnNewFilms.Size = new System.Drawing.Size(279, 38);
            this.btnNewFilms.TabIndex = 12;
            this.btnNewFilms.Text = "N&ew Films";
            this.btnNewFilms.UseVisualStyleBackColor = true;
            this.btnNewFilms.Click += new System.EventHandler(this.btnNewFilms_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(360, 292);
            this.Controls.Add(this.btnNewFilms);
            this.Controls.Add(this.btnLateFilms);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryan\'s Late Fee Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLateFilms;
        private System.Windows.Forms.Button btnNewFilms;
    }
}

