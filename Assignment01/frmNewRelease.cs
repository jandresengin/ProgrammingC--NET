using System;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class frmNewRelease : Form
    {
        public frmNewRelease()
        {
            InitializeComponent();
            // Generate the Current date based in textbox txtCurrentDate
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
        }

         private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Generate the current date
            DateTime dCurrent = DateTime.Now;
            // Generate the due date based on user entry in textbox txtDueDate
            DateTime dDue = DateTime.Parse(txtDueDate.Text);

            // Calculate the number of days late
            TimeSpan totalNumberDays = (dDue.Date - dCurrent.Date);
            double numberOfDays = totalNumberDays.TotalDays;

            //Display the number of days late in the textbox txtNumbersOfDaysLate
            txtNumbersOfDaysLate.Text = numberOfDays.ToString();

            // Calculate the late fee, the newRelease have a fee of 2.
            double lateFeeBill = 2 * numberOfDays;

            // Display the late fee as currency in the textbox txtLateFee
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
