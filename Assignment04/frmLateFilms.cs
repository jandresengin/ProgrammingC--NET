using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment04
{
    public partial class frmLateFilms : Form
    {
        public frmLateFilms()
        {
            InitializeComponent();
        }

        List<string> lateMoviesList = new List<string>(); //Creation of SortedList to save data type String
        private int numberMoviesLateCounter = 0; //variable creation to keep track of the number of items in the SortedList .
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                //The resulting number of days is taken, it is converted to an integer and it is verified that it is an adequate value to calculate
                //If the number of days of delay is greater than or equal to 0, the associated costs will be calculated.

                if (IsValidDayData()) //This function will evaluate if the number of days (isPast) and number of movies are valid for the normal execution of the program.
                {
                    lateMoviesList.Add(txtLateFilms.Text);//The action of pressing the Add button will add the title entered by the user to the ordered list.
                    lateMoviesList.Sort();//It will be ordered alphabetically
                    foreach (string movie in lateMoviesList) //It will go through each element of the SortedList
                    {
                        message += movie.ToString() + "\n";//Message to display is created
                    }
            
                    MessageBox.Show(message, "Order Totals - List");//The list of movies entered by the user is displayed.
                }
            }
            //After evaluating if the number of movies data is valid, the error message will be brought with what was found with the validation function.
            catch (Exception ex)
            {//A message is displayed in a separate messagebox with what is found.
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }
        
        public int GetNumberMovies()//function that returns the number of movies entered in the list.
        {
            return numberMoviesLateCounter;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {//The action of pressing the OK button is to update the number of movies entered in the list and close the current form.
            numberMoviesLateCounter = lateMoviesList.Count;
            MessageBox.Show(lateMoviesList.Count.ToString(), " Total number of movies entered");//the number of movies in the list is displayed.
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //At the end the current form is closed to not leave active forms or threads.
        }

        private bool IsValidDayData() //The IsValidDayData function is called to know if the entered value (number of days and number of movies) meets the program conditions.
        {//The number of films is validated again only if the program operates in unitary mode.

            bool success = true;
            string errorMessage = "";
            errorMessage += IsEmpty(txtLateFilms.Text, "Name of the movie");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
        private string IsEmpty(string value, string name)//This generic function evaluates if the value is empty or not.
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }
    }
}
