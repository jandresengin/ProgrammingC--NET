using System;
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
    public partial class frmLibraryMovies : Form
    {
        public frmLibraryMovies()
        {
            InitializeComponent();
            // Generate the Current date based in textbox txtCurrentDate
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // The current date is stored in the variable dCurrent.
            DateTime dCurrent = DateTime.Now;
            // The date entered by the user is saved in the variable dDue,
            // in this case it is converted to a DateTime type format.
            DateTime dDue = DateTime.Parse(txtDueDate.Text);

            // TimeSpan is called, which makes the comparison between the current date and the date that the user entered.
            // I work in this order to avoid negative numbers.
            TimeSpan totalNumberDays = (dDue.Date - dCurrent.Date);
            // The total number of days of the date difference calculated
            // in the previous step is captured in a double variable called numberOfDays.
            double numberOfDays = totalNumberDays.TotalDays;

            // The variable numberOfDays is converted to a string to be printed in the textbox called txtNumbersOfDaysLate.Text.
            txtNumbersOfDaysLate.Text = numberOfDays.ToString();

            // The rate to be charged is calculated where the number of days late is multiplied with the rate for movies with category Library Movies,
            // which is 0.57 CAD per day.
            double lateFeeBill = 0.57 * numberOfDays;

            // The rate to be charged for the delay of the lateFeeBill variable is converted to String and formatted as currency
            txtLateFee.Text = lateFeeBill.ToString("c");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //When performing the action of pressing the Return button, the form is instantiated as an object, this allows to call it.
            frmMain formMain = new frmMain(); //The main form object is instantiated.
            this.Hide(); //the current form is hidden.
            formMain.ShowDialog(); //the main form is called.
            this.Close(); //At the end the current form is closed to not leave active forms or threads.
        }
    }
}
