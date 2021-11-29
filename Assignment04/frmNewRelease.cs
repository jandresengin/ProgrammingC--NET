using System;
using System.Windows.Forms;
/***********************************************************************************************************************
 *          CSD2354 Programming C# NET          Fall 2021       Assignment 4
 *          Jairo Andres Supelano               c0812859
 ************************************************************************************************************************/

namespace Assignment04
{
    public partial class frmNewRelease : Form
    {
        //variable of the number of movies to return by the user. The initial value is 0.
        int numberMoviesEntered = 0;
        //In order to be able to add the movies entered by the user or the unitary movie entry system, an internal variable is handled.
        int numberMoviesEnteredSummary = 0;
        //The minimum number of days of delay is 0, it would be presented if the user enters a invalid numbers of days
        Int32 minDays = 0;
        // The total value to be paid by the customer without applying a discount is saved in the following variable. Initially it is left at 0.
        Double totalWithoutDiscount = 0;
        //the calculation of the number of days of late movie delivery is saved in this variable. It takes the value of the current day of the system where the program is executed and the number selected in the data picker (options were configured so that the maximum day is the current day of the system.)
        double numberOfDays;
        //A boolean variable is created, to change the program's operating mode, if the user enters number of days manually, the way to change the fee is changed, if he does not make changes in that textbox, it operates with only 1 movie by default .
        Boolean isCleared = false;
        public frmNewRelease()
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
        ///     What do you call a dog magician?
        ///     A labracadabrador.
        /// ***********************************************************************************

        private string GetValueComBox()
        {
            // The default value of the type of customer is New Customer "N". It was configured in the Designer.cs The user could change and apply for a better discount.
            var itemComboBox = this.comboBoxCustomerType.GetItemText(this.comboBoxCustomerType.SelectedItem);

            return itemComboBox;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            
            string selectedTypeCustomer = GetValueComBox();//   The value entered by the client is taken, where you have the type of client that is and with it apply to discounts.  
            double lateFeeBill = 0; //Variable is declared and initialized to 0.
            decimal discountPercent = .0m; // This variable indicates the discount percentage to be applied to special customers.
            int numberOfDaysLate; //This variable stores the number of days late in returning the movie.
            

            DateTime dCurrent = DateTime.Now; // The current date is stored in the variable dCurrent.
            DateTime dDue = dateTimePickerDueDate.Value; //According to the value entered in the dateTimePicker, the day is obtained and saved in dDue
            TimeSpan totalNumberDays = (dCurrent.Date - dDue.Date); //The number of days late in returning the movie is calculated according to the value entered by the user.
            numberOfDays = totalNumberDays.TotalDays; //Only the data of number of days is extracted from the variable type DateTime
            txtNumbersOfDaysLate.Text = numberOfDays.ToString(); //The resulting number of days is shown in the textbox.

            //Because the only data that the user enters is the number of days, it will be evaluated that the data is valid, the failure will be caught and the user will be indicated the requirements for this data.
            try
            {
                //The resulting number of days is taken, it is converted to an integer and it is verified that it is an adequate value to calculate
                //If the number of days of delay is greater than or equal to 0, the associated costs will be calculated.

                if (IsValidDayData()) //This function will evaluate if the number of days (isPast) and number of movies are valid for the normal execution of the program.
                {
                    // The rate to be charged is calculated where the number of days late is multiplied with the rate for movies with category New Releases,
                    // which is 2 CAD per day.
                    //Only the whole part of the number of days late is feared, with this it is avoided to charge partials of 1 day.
                    numberOfDaysLate = (int)numberOfDays;
                    if (numberOfDaysLate != 0) //If the number of days of delay is 0 (Due day = Current day), no surcharge is calculated, because the movie is being delivered on the indicated date.
                    {
                        //If the user does not enter the number of movies manually, the isCleared flag will be equal to false, executing the sum of movies program in a unitary way.
                        if (isCleared == false)
                        {
                            numberMoviesEntered += 1; //The number of movies is increased by 1.
                            numberMoviesEnteredSummary += 1; //Movie number accumulator increases by 1.
                            lateFeeBill = CalculateLateFeeUnity(numberOfDaysLate); //The fee is calculated for a single movie entry, with the function CalculateLateFeeUnity


                        }
                        //If the user generates an action to modify the box for the number of movies, the flag isCleared == true will be activated, and the fee will be calculated for several movies delivered late.
                        else
                        {
                            //// The rate is calculated for the number of movies entered by the user, with the CalculateLateFee function
                            lateFeeBill = CalculateLateFee(numberOfDaysLate, numberMoviesEntered);
                            numberMoviesEnteredSummary += numberMoviesEntered;//Movie number accumulator increases by the number of movies entered by the user.
                        }
                        totalWithoutDiscount += lateFeeBill; //The previous value is added to the accumulator of the total of movies to be returned, with this the user can calculate different movies of this type and of different days.

                    }

                    //A combobox was created to only have 3 possible values "L", "J" or "N", and according to this, the membership discount will be defined, if at any time it is possible to enter a different value, a message will be displayed to the user and a discount type "N" is left
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
                    // The fee for the total number of movies entered by the user, and the discount applied by the type of membership will be evaluated. the function CalculateLateFeeIncludesDiscount is called with 2 parameters and 2 values are returned in a tuple.
                    (decimal invoiceTotal, decimal discountAmount) = CalculateLateFeeIncludesDiscount(Convert.ToDecimal(totalWithoutDiscount), discountPercent);

                    //It will be evaluated if the number of movies entered is equal to the accumulator of the number of movies, this case is if unit movies or group of movies are entered interleaved.
                    if (numberMoviesEntered == numberMoviesEnteredSummary)
                    {
                        txtNumberOfMovies.Text = numberMoviesEntered.ToString("d"); //The number of movies entered so far is graphed, it is changed to string format.
                    }
                    else
                    {
                        numberMoviesEntered = numberMoviesEnteredSummary; //If the user enters movies manually, all associated fees are calculated and at the end the total number of movies entered so far is displayed.
                        txtNumberOfMovies.Text = numberMoviesEnteredSummary.ToString("d"); //The number of movies entered so far is graphed, it is changed to string format.

                    }

                    txtLateFee.Text = lateFeeBill.ToString("c"); //The amount owed for the movie that is delivered late is graphed, the format is changed to string currency.
                    subtotalWithoutDiscount.Text = totalWithoutDiscount.ToString("c"); //The value owed for the movies that were delivered late without discount is graphed (Acummulator), the format is changed to string currency.
                    txtTotalWithDiscount.Text = invoiceTotal.ToString("c"); //The amount owed so far for all the movies calculated with the applicable discount is graphed, the format is changed to string currency.

                    btnReturn.Focus(); //The focus is moved to the return button
                }
            }
            //After evaluating if the number of movies data is valid, the error message will be brought with what was found with the validation function.
            catch (Exception ex)
            {//A message is displayed in a separate messagebox with what is found.
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
            //At the end, the manual movie input flag is returned to work in a unitary way.
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

        //This function calculates the associated fees for unit movie entry.
        private static double CalculateLateFeeUnity(int numberOfDaysLate)
        {
            double lateFeeBill = 0;
            lateFeeBill = 2 * numberOfDaysLate; //for the type of movie a fee of 2 cad is charged.
            return lateFeeBill;

        }

        //This function is in charge of calculating the value to be paid by the user according to the membership discount, returning the final value and the value of the discount.
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
        //This function calculates the associated fees for the entry of several movies by the user.
        private static double CalculateLateFee(int numberOfDaysLate, int numberMoviesEntered)
        {
            double lateFeeBill = 0;
            lateFeeBill = 2 * numberOfDaysLate * numberMoviesEntered; //for the type of movie a fee of 2 cad is charged.
            return lateFeeBill;

        }
        

        private void ClearNumberMovies(object sender, EventArgs e)
        {
            string selectedTypeCustomer = GetValueComBox();
            try
            {   //This function is created tied to an event, which will clean the textbox and evaluate if the data entered is a valid number.
                if (IsValidData()) //The IsValidData function is called to know if the entered value (number of movies) meets the program conditions.
                {
                    txtNumbersOfDaysLate.Text = "";
                    txtLateFee.Text = "";
                    numberMoviesEntered = Convert.ToInt32(txtNumberOfMovies.Text);
                    isCleared = true;
                }
            }
            catch (Exception ex) //If it does not meet the conditions, the message will indicates that it must comply.
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }

        private bool IsValidData() //It evaluates if the number of days entered by the user is not empty, it is a whole number and is between 0 and 50.
        {
            string selectedTypeCustomer = GetValueComBox();
            bool success = true;
            string errorMessage = "";
            errorMessage += IsPresent(txtNumberOfMovies.Text, "Number of Movies Delivered Late");
            errorMessage += IsDateTime(txtNumbersOfDaysLate.Text, "Number of Days Delivered Late");
            errorMessage += IsCustType(selectedTypeCustomer, "Number of Days Delivered Late", "L", "J", "N");
            errorMessage += IsInt32(txtNumberOfMovies.Text, "Number of Movies Delivered Late");
            errorMessage += IsWithinRange(txtNumberOfMovies.Text, "Number of Movies Delivered Late", 0, 50);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }



        private string IsPresent(string value, string name)//This generic function evaluates if the value is empty or not.
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }
        private string IsDateTime(string value, string name)//This generic function evaluates if the value is empty or not.
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }

        private string IsInt32(string value, string name)//This generic function evaluates if the value is an integer.
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value.\n";
            }
            return msg;
        }
        //This generic function evaluates if the value is between a minimum and greater range of values.

        private string IsCustType(string value, string name, string opcion1, string opcion2, string opcion3)
        {
            string msg = "";
            
                if (value != opcion1 && value != opcion2 && value != opcion3)
                {
                    msg += name + " must be a value like " + opcion1 + ", " + opcion2 + " or " + opcion3 + ".\n";
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


        private bool IsValidDayData() //The IsValidDayData function is called to know if the entered value (number of days and number of movies) meets the program conditions.
        {//The number of films is validated again only if the program operates in unitary mode.
            string selectedTypeCustomer = GetValueComBox();
            bool success = true;
            string errorMessage = "";
            errorMessage += IsPast(txtNumbersOfDaysLate.Text, "Numbers of Days Late", minDays);
            errorMessage += IsDateTime(txtNumbersOfDaysLate.Text, "Number of Days Delivered Late");
            errorMessage += IsCustType(selectedTypeCustomer, "Number of Days Delivered Late", "L", "J", "N");
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


        private string IsPast(string value, string name, Int32 min) //// This generic function evaluates if the value is greater than a minimum of 0 days.
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
