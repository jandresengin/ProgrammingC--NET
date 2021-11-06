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
 *          CSD2354 Programming C# NET          Fall 2021       Assignment 3
 *          Jairo Andres Supelano               c0812859
 ************************************************************************************************************************/

namespace Assignment01
{
    public partial class frmKidsMovies : Form
    {
        //variable of the number of movies to return by the user. The initial value is 0.
        int numberMoviesEntered = 0;
        int numberMoviesEnteredSummary = 0;
        Int32 minDays = 0;
        // The total value to be paid by the customer without applying a discount is saved in the following variable. Initially it is left at 0.
        Double totalWithoutDiscount = 0;
        double numberOfDays;

        Boolean isCleared = false;
        public frmKidsMovies()
        {
            InitializeComponent();
            // DateTime is called to obtain the current date and the format is converted so that it can be read as month day year.
            // This is printed in the textbox txtCurrentDate
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
            // The number of movies to return is 0 and it is printed in the textbox
            txtNumberOfMovies.Text = numberMoviesEntered.ToString("d");


            //The focus after load the form is over the dataTimepicker.
            dateTimePickerDueDate.Focus();
        }
        /// ***********************************************************************************
        ///     How you fix a broken pumpkin? 
        ///     With a pumpkin patch.
        /// ***********************************************************************************
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // The default value of the type of customer is New Customer "N". It was configured in the Designer.cs The user could change and apply for a better discount.
            var itemComboBox = this.comboBoxCustomerType.GetItemText(this.comboBoxCustomerType.SelectedItem);
            string selectedTypeCustomer = itemComboBox;//   The value entered by the client is taken, where you have the type of client that is and with it apply to discounts.  
            double lateFeeBill = 0; //Variable is declared and initialized to 0.
            decimal discountPercent = .0m; // This variable indicates the discount percentage to be applied to special customers.
            int numberOfDaysLate; //This variable stores the number of days late in returning the movie.


            DateTime dCurrent = DateTime.Now; // The current date is stored in the variable dCurrent.
            DateTime dDue = dateTimePickerDueDate.Value; //According to the value entered in the dateTimePicker, the day is obtained and saved in dDue
            TimeSpan totalNumberDays = (dCurrent.Date - dDue.Date); //The number of days late in returning the film is calculated according to the value entered by the user.
            numberOfDays = totalNumberDays.TotalDays; //Only the data of number of days is extracted from the variable type DateTime
            txtNumbersOfDaysLate.Text = numberOfDays.ToString(); //The resulting number of days is shown in the textbox.

            try
            {
                //The resulting number of days is taken, it is converted to an integer and it is verified that it is an adequate value to calculate
                //If the number of days of delay is greater than or equal to 0, the associated costs will be calculated.

                if (IsValidDayData())
                {
                    // The rate to be charged is calculated where the number of days late is multiplied with the rate for movies with category New Releases,
                    // which is 0.15 CAD per day.
                    numberOfDaysLate = (int)numberOfDays;
                    if (numberOfDaysLate != 0) //If the number of days of delay is 0 (Due day = Current day), no surcharge is calculated, because the film is being delivered on the indicated date.
                    {

                        if (isCleared == false)
                        {
                            numberMoviesEntered += 1; //The number of movies is increased by 1.
                            numberMoviesEnteredSummary += 1;
                            lateFeeBill = CalculateLateFeeUnity(numberOfDaysLate);


                        }
                        else
                        {
                            lateFeeBill = CalculateLateFee(numberOfDaysLate, numberMoviesEntered);
                            numberMoviesEnteredSummary += numberMoviesEntered;
                        }
                        totalWithoutDiscount += lateFeeBill; //The previous value is added to the accumulator of the total of films to be returned, with this the user can calculate different films of this type and of different days.

                    }

                    // // The rate to be charged for the delay of the lateFeeBill variable is converted to String and formatted as currency
                    switch (selectedTypeCustomer)
                    {
                        case "L":   //If you are an L Loyal user, a 10% discount is applied.
                            discountPercent = .1m;
                            break;
                        case "J":   //If you are a J junior user, a 5% discount is applied.
                            discountPercent = .05m;
                            break;
                        case "N":   //If you are an N New user, a 0% discount is applied.
                            discountPercent = 0;
                            break;
                        default:   //If a different type of character is entered, a discount of 0% is applied, and a message is displayed to the user that in order to apply to any type of discount, he must select the type of user he is.
                            MessageBox.Show("To apply any kind of discount please select your Loyal customers  \nL for Loyal Customer 10% Discount, J for Junior Customer 5% discount or N New user 0%. ");
                            discountPercent = 0;
                            break;
                    }
                    // CalculateLateFee methods that returns a tuple 
                    (decimal invoiceTotal, decimal discountAmount) = CalculateLateFeeIncludesDiscount(Convert.ToDecimal(totalWithoutDiscount), discountPercent);



                    if (numberMoviesEntered == numberMoviesEnteredSummary)
                    {
                        txtNumberOfMovies.Text = numberMoviesEntered.ToString("d"); //The number of movies entered so far is graphed, it is changed to string format.
                    }
                    else
                    {
                        numberMoviesEntered = numberMoviesEnteredSummary;
                        txtNumberOfMovies.Text = numberMoviesEnteredSummary.ToString("d"); //The number of movies entered so far is graphed, it is changed to string format.

                    }

                    txtLateFee.Text = lateFeeBill.ToString("c"); //The amount owed for the film that is delivered late is graphed, the format is changed to string currency.
                    subtotalWithoutDiscount.Text = totalWithoutDiscount.ToString("c"); //The value owed for the films that were delivered late without discount is graphed (Acummulator), the format is changed to string currency.
                    txtTotalWithDiscount.Text = invoiceTotal.ToString("c"); //The amount owed so far for all the films calculated with the applicable discount is graphed, the format is changed to string currency.

                    btnReturn.Focus(); //The focus is moved to the return button
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
            isCleared = false;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //When performing the action of pressing the Return button, the form is instantiated as an object, this allows to call it.
            frmMain formMain = new frmMain(); //The main form object is instantiated.
            this.Hide(); //the current form is hidden.
            formMain.ShowDialog(); //the main form is called.
            this.Close(); //At the end the current form is closed to not leave active forms or threads.
        }




        private static double CalculateLateFeeUnity(int numberOfDaysLate)
        {
            double lateFeeBill = 0;
            lateFeeBill = 0.15 * numberOfDaysLate;
            return lateFeeBill;

        }


        private (decimal invoiceTotal, decimal discountAmount)
            CalculateLateFeeIncludesDiscount(decimal totalWithoutDiscount, decimal discountPercent)
        {
            decimal invoiceTotal = 0;
            //The discount that the user has is calculated for the type of user that entered.
            decimal discountAmount = totalWithoutDiscount * discountPercent;
            //The final value to be paid is calculated, after applying discounts.
            invoiceTotal = totalWithoutDiscount - discountAmount;


            return (invoiceTotal, discountAmount);

        }
        private static double CalculateLateFee(int numberOfDaysLate, int numberMoviesEntered)
        {
            double lateFeeBill = 0;
            lateFeeBill = 0.15 * numberOfDaysLate * numberMoviesEntered;
            return lateFeeBill;

        }


        private void ClearNumberMovies(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    txtNumbersOfDaysLate.Text = "";
                    txtLateFee.Text = "";
                    numberMoviesEntered = Convert.ToInt32(txtNumberOfMovies.Text);
                    isCleared = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += IsPresent(txtNumberOfMovies.Text, "Number of Movies Delivered Late");
            errorMessage += IsInt32(txtNumberOfMovies.Text, "Number of Movies Delivered Late");
            errorMessage += IsWithinRange(txtNumberOfMovies.Text, "Number of Movies Delivered Late", 0, 50);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }



        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }


        private string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value.\n";
            }
            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Int32.TryParse(value, out Int32 number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n";
                }
            }
            return msg;
        }


        private bool IsValidDayData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += IsPast(txtNumbersOfDaysLate.Text, "Numbers of Days Late", minDays);
            errorMessage += IsPresent(txtNumberOfMovies.Text, "Number of Movies Delivered Late");
            errorMessage += IsInt32(txtNumberOfMovies.Text, "Number of Movies Delivered Late");
            errorMessage += IsWithinRange(txtNumberOfMovies.Text, "Number of Movies Delivered Late", 0, 50);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }


        private string IsPast(string value, string name, Int32 min)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min)
                {
                    msg += "The number of days introducted is not correct " + name + " must be greater or equal to " + min + ".\n";
                }
            }
            return msg;
        }


    }
}
