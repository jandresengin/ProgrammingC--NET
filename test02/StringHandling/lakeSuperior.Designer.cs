namespace StringHandling
{
    partial class lakeSuperior
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(405, 243);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(405, 187);
            this.btnFormat.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(94, 30);
            this.btnFormat.TabIndex = 6;
            this.btnFormat.Text = "F&ormat";
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(405, 30);
            this.btnParse.Margin = new System.Windows.Forms.Padding(4);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(94, 34);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "P&arse";
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(131, 105);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(195, 22);
            this.txtCity.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 33);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "City:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(131, 149);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvince.MaxLength = 2;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(62, 22);
            this.txtProvince.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Province:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(128, 194);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostalCode.MaxLength = 7;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(115, 22);
            this.txtPostalCode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(29, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Postal Code:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lakeSuperior
            // 
            this.AcceptButton = this.btnParse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(546, 306);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "lakeSuperior";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lake Superior";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label4;
    }
}

