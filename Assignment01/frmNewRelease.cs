﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class frmNewRelease : Form
    {
        public frmNewRelease()
        {
            InitializeComponent();
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmNewRelease_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime dCurrent = DateTime.Now;
            DateTime dDue = DateTime.Parse(txtDueDate.Text);


            TimeSpan totalNumberDays = (dDue.Date - dCurrent.Date);

            double numberOfDays = totalNumberDays.TotalDays;
            txtNumbersOfDaysLate.Text = numberOfDays.ToString();

            double lateFeeBill = 2 * numberOfDays;
            txtLateFee.Text = lateFeeBill.ToString("c");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain formMain = new frmMain(); //The main form object is instantiated.
            this.Hide(); //the current form is hidden.
            formMain.ShowDialog(); //the main form is called.
            this.Close(); //At the end the current form is closed to not leave active forms or threads.

        }
    }
}
