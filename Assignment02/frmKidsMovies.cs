using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/***********************************************************************************************************************
 *          CSD2354 Programming C# NET          Fall 2021       Assignment 1
 *          Jairo Andres Supelano               c0812859
 ************************************************************************************************************************/

namespace Assignment01
{
    public partial class frmKidsMovies : Form
    {
        int numberMoviesEntered = 0;
        Double totalWithoutDiscount = 0;
        public frmKidsMovies()
        {
            InitializeComponent();
            // DateTime is called to obtain the current date and the format is converted so that it can be read as month day year.
            // This is printed in the textbox txtCurrentDate
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
            txtNumberOfMovies.Text = numberMoviesEntered.ToString("d");
            txtTypeCustomer.Text = "N";
            dateTimePickerDueDate.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // The current date is stored in the variable dCurrent.

            string selectedTypeCustomer = txtTypeCustomer.Text;
            double lateFeeBill = 0;
            decimal discountPercent = .0m;
            int numberOfDaysLate;
            DateTime dCurrent = DateTime.Now;
            DateTime dDue = dateTimePickerDueDate.Value;
            TimeSpan totalNumberDays = (dCurrent.Date - dDue.Date);
            double numberOfDays = totalNumberDays.TotalDays;
            txtNumbersOfDaysLate.Text = numberOfDays.ToString();
            bool success = Int32.TryParse(txtNumbersOfDaysLate.Text, out numberOfDaysLate);
            if (success)
            {
                if (numberOfDaysLate >= 0)
                {
                    // The rate to be charged is calculated where the number of days late is multiplied with the rate for movies with category New Releases,
                    // which is 2 CAD per day.

                    if (numberOfDaysLate != 0)
                    {
                        numberMoviesEntered += 1;
                        lateFeeBill = 0.15 * numberOfDaysLate;
                        totalWithoutDiscount += lateFeeBill;
                    }

                    // The rate to be charged for the delay of the lateFeeBill variable is converted to String and formatted as currency
                    switch (selectedTypeCustomer)
                    {
                        case "L":
                            discountPercent = .1m;
                            break;
                        case "J":
                            discountPercent = .05m;
                            break;
                        case "N":
                            discountPercent = 0;
                            break;
                        default:
                            MessageBox.Show("To apply any kind of discount please select your Loyal customers ");
                            discountPercent = 0;
                            break;
                    }
                    decimal discountAmount = Convert.ToDecimal(totalWithoutDiscount) * discountPercent;
                    decimal invoiceTotal = Convert.ToDecimal(totalWithoutDiscount) - discountAmount;
                    txtNumberOfMovies.Text = numberMoviesEntered.ToString("d");
                    txtLateFee.Text = lateFeeBill.ToString("c");
                    subtotalWithoutDiscount.Text = totalWithoutDiscount.ToString("c");
                    txtTotalWithDiscount.Text = invoiceTotal.ToString("c");

                    btnReturn.Focus();
                }
            }
            else
            {
                MessageBox.Show("The number of days introducted is not correct ' " + numberOfDaysLate + " '.");
            }
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