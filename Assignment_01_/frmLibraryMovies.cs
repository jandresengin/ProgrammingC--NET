using System;
using System.Windows.Forms;

namespace Assignment_01
{
    public partial class frmLibraryMovies : Form
    {
        public frmLibraryMovies()
        {
            InitializeComponent();
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain formMain = new frmMain(); //The main form object is instantiated.
            this.Hide(); //the current form is hidden.
            formMain.ShowDialog(); //the main form is called.
            this.Close(); //At the end the current form is closed to not leave active forms or threads.
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime dCurrent = DateTime.Now;
            DateTime dDue = DateTime.Parse(txtDueDate.Text);


            TimeSpan totalNumberDays = (dDue.Date - dCurrent.Date);

            double numberOfDays = totalNumberDays.TotalDays;
            txtNumbersOfDaysLate.Text = numberOfDays.ToString();

            double lateFeeBill = 0.57 * numberOfDays;
            txtLateFee.Text = lateFeeBill.ToString("c");
        }
    }
}
