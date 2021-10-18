using System;
using System.Windows.Forms;
/***********************************************************************************************************************
 *          CSD2354 Programming C# NET          Fall 2021       Assignment 1
 *          Jairo Andres Supelano               c0812859
 ************************************************************************************************************************/

namespace Assignment01
{
    public partial class frmNewRelease : Form
    {
        int numberMoviesEntered = 0;
        Double totalWithoutDiscount = 0;
        public frmNewRelease()
        {
            InitializeComponent();
            // DateTime is called to obtain the current date and the format is converted so that it can be read as month day year.
            // This is printed in the textbox txtCurrentDate
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
            txtNumberOfMovies.Text = numberMoviesEntered.ToString("d");
        }

      
        


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // The current date is stored in the variable dCurrent.
            string selectedTypeCustomer = txtTypeCustomer.Text;
            double lateFeeBill = 0;







            decimal discountPercent = .0m;

            int numberOfDaysLate;
            DateTime dCurrent = DateTime.Now;
            // The date entered by the user is saved in the variable dDue,
            // in this case it is converted to a DateTime type format.
            //DateTime dDue = DateTime.Parse(txtDueDate.Text);
            DateTime dDue = dateTimePickerDueDate.Value;
            


            // TimeSpan is called, which makes the comparison between the current date and the date that the user entered.
            // I work in this order to avoid negative numbers.
            //TimeSpan totalNumberDays = (dDue.Date - dCurrent.Date);
            TimeSpan totalNumberDays = (dCurrent.Date - dDue.Date);

            // The total number of days of the date difference calculated
            // in the previous step is captured in a double variable called numberOfDays.
            double numberOfDays = totalNumberDays.TotalDays;

            // The variable numberOfDays is converted to a string to be printed in the textbox called txtNumbersOfDaysLate.Text.

            

            txtNumbersOfDaysLate.Text = numberOfDays.ToString();

            bool success = Int32.TryParse(txtNumbersOfDaysLate.Text, out numberOfDaysLate);
            if (success)
            {
                if (numberOfDaysLate >= 0) { 
                    // The rate to be charged is calculated where the number of days late is multiplied with the rate for movies with category New Releases,
                    // which is 2 CAD per day.
                
                    if (numberOfDaysLate != 0)
                    {
                        numberMoviesEntered += 1;
                        lateFeeBill = 2 * numberOfDaysLate;
                        totalWithoutDiscount += lateFeeBill;
                    }
                    

                    

                    // The rate to be charged for the delay of the lateFeeBill variable is converted to String and formatted as currency
                    
                
                    switch(selectedTypeCustomer)
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
