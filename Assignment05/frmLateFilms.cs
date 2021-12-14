using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment05
{
    public partial class frmLateFilms : Form
    {
        int numberOfDays;
        public decimal numberOfReleaseMovies = 0;
        public static SortedList<string, decimal> numberMoviesByType = new SortedList<string, decimal>(3);
        public static SortedList<string, decimal> numberDaysMoviesByType = new SortedList<string, decimal>(3);
        public static decimal numberOfDaysReleaseMovies = 0;

        public static decimal numberOfLibraryMovies = 0;
        public static decimal numberOfDaysLibraryMovies = 0;
        public static decimal numberOfKidsMovies = 0;
        public static decimal numberOfDaysKidsMovies = 0;
        public frmLateFilms()
        {
            InitializeComponent();
            
        }

        private List<RentalItem> rentalItems = null;
        

        List<string> lateMoviesList = new List<string>(); //Creation of SortedList to save data type String
        private int numberMoviesLateCounter = 0; //variable creation to keep track of the number of items in the SortedList .
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                if (IsValidData()) //This function will evaluate if the name of movies are valid for the normal execution of the program.
                {
                    //lateMoviesList.Add(txtLateFilms.Text);//The action of pressing the Add button will add the title entered by the user to the ordered list.
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

        private void frmRentalItems_Load(object sender, EventArgs e)
        {
            rentalItems = RentalItemDB.GetRentalItem();
            FillRentalItemsListBox();
        }


        private void FillRentalItemsListBox()
        {
            lstRentalItems.Items.Clear();
            foreach (RentalItem r in rentalItems)
            {
                lstRentalItems.Items.Add(r.GetDisplayText());
            }
        }
        private void FillRentalItemsListBoxDueDate()
        {

            lstRentalItemsSelected.Items.Clear();
            foreach (RentalItemDueDate r in rentalItemsList)
            {
                lstRentalItemsSelected.Items.Add(r.GetDisplayText());
            }
        }
        public int GetNumberMovies()//function that returns the number of movies entered in the list.
        {
            return numberMoviesLateCounter;
        }

        private RentalItemDueDate rentalItemDate = null;

        List<RentalItemDueDate> rentalItemsList = new List<RentalItemDueDate>();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //At the end the current form is closed to not leave active forms or threads.
        }

        private bool IsValidData() //The IsValidData function is called to know if the entered value (name of movie) meets the program conditions.
        {//The number of films is validated again only if the program operates in unitary mode.

            bool success = true;
            string errorMessage = "";
            //errorMessage += IsEmpty(txtLateFilms.Text, "Name of the movie");

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
        private Double GetNumberDays()
        {
            DateTime dCurrent = DateTime.Now; // The current date is stored in the variable dCurrent.
            DateTime dDue = dateTimePickerDueDate.Value; //According to the value entered in the dateTimePicker, the day is obtained and saved in dDue
            TimeSpan totalNumberDays = (dCurrent.Date - dDue.Date); //The number of days late in returning the movie is calculated according to the value entered by the user.
            Double numberOfDaystotal = totalNumberDays.TotalDays; //Only the data of number of days is extracted from the variable type DateTime
            return numberOfDaystotal;

        }

        private void btnDueDate_Click(object sender, EventArgs e)
        {

            numberOfDays = Convert.ToInt32(GetNumberDays());
            int i = lstRentalItems.SelectedIndex;
            if (i != -1)
            {
                RentalItem rentalItem = rentalItems[i];
                string message = "Are you sure you want to add the number of day late of " +
                    numberOfDays + " for the movie number" + rentalItem.MovieNo + " " + rentalItem.Description + "?";
                DialogResult button = MessageBox.Show(message, "Confirm ADD",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    int movieNumber = rentalItem.MovieNo;
                    string descriptionObject = rentalItem.Description;
                    string ratingObject = rentalItem.Rating;
                    string typeMovieObject = rentalItem.TypeMovie;


                    rentalItemDate = new RentalItemDueDate(movieNumber, descriptionObject, ratingObject, typeMovieObject, numberOfDays);
                    
                    MessageBox.Show(rentalItemDate.GetDisplayText());
                    rentalItemsList.Add(rentalItemDate);
                    FillRentalItemsListBoxDueDate();
                    if (typeMovieObject == "Release")
                    {
                        numberOfReleaseMovies++;
                        numberOfDaysReleaseMovies = numberOfDaysReleaseMovies + numberOfDays;
                    }
                    else if (typeMovieObject == "Library")
                    {
                        numberOfLibraryMovies++;
                        numberOfDaysLibraryMovies = numberOfDaysLibraryMovies + numberOfDays;
                    }
                    else if (typeMovieObject == "Kids")
                    {
                        numberOfKidsMovies++;
                        numberOfDaysKidsMovies = numberOfDaysKidsMovies + numberOfDays;
                    }
                    




                }
            }
            
        }

          private void btnNewRelease_Click(object sender, EventArgs e)
        {

            numberMoviesByType.Clear();
            numberDaysMoviesByType.Clear();

            numberMoviesByType.Add("ReleaseMovie", numberOfReleaseMovies);
            numberMoviesByType.Add("LibraryMovie", numberOfLibraryMovies);
            numberMoviesByType.Add("KidsMovie", numberOfKidsMovies);
            numberDaysMoviesByType.Add("ReleaseMovie", numberOfDaysReleaseMovies);
            numberDaysMoviesByType.Add("LibraryMovie", numberOfDaysLibraryMovies);
            numberDaysMoviesByType.Add("KidsMovie", numberOfDaysKidsMovies);


            MessageBox.Show("Number of Release movies selected: " + numberMoviesByType["ReleaseMovie"].ToString());
            MessageBox.Show("Number of total days selected: " + numberDaysMoviesByType["ReleaseMovie"].ToString());

            frmNewRelease newRelease = new frmNewRelease(); //The frmNewRelease form object is instantiated.

            DialogResult numberMoviesEnteredSummary = newRelease.ShowDialog(); //DialogResult, will return the action and save it in an object instantiated to the form, it is called the opening of the form.


        }


        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {
            
            numberMoviesByType.Clear();
            numberDaysMoviesByType.Clear();

            numberMoviesByType.Add("ReleaseMovie", numberOfReleaseMovies);
            numberMoviesByType.Add("LibraryMovie", numberOfLibraryMovies);
            numberMoviesByType.Add("KidsMovie", numberOfKidsMovies);
            numberDaysMoviesByType.Add("ReleaseMovie", numberOfDaysReleaseMovies);
            numberDaysMoviesByType.Add("LibraryMovie", numberOfDaysLibraryMovies);
            numberDaysMoviesByType.Add("KidsMovie", numberOfDaysKidsMovies);


            MessageBox.Show("Number of Library movies selected: " + numberMoviesByType["LibraryMovie"].ToString());
            MessageBox.Show("Number of total days selected: " + numberDaysMoviesByType["LibraryMovie"].ToString());

            frmLibraryMovies newLibrary = new frmLibraryMovies(); //The frmNewRelease form object is instantiated.

            DialogResult numberMoviesEnteredSummary = newLibrary.ShowDialog(); //DialogResult, will return the action and save it in an object instantiated to the form, it is called the opening of the form.


        }

        private void btnKidsMovie_Click(object sender, EventArgs e)
        {
            
            numberMoviesByType.Clear();
            numberDaysMoviesByType.Clear();

            numberMoviesByType.Add("ReleaseMovie", numberOfReleaseMovies);
            numberMoviesByType.Add("LibraryMovie", numberOfLibraryMovies);
            numberMoviesByType.Add("KidsMovie", numberOfKidsMovies);
            numberDaysMoviesByType.Add("ReleaseMovie", numberOfDaysReleaseMovies);
            numberDaysMoviesByType.Add("LibraryMovie", numberOfDaysLibraryMovies);
            numberDaysMoviesByType.Add("KidsMovie", numberOfDaysKidsMovies);


            MessageBox.Show("Number of Kids movies selected: " + numberMoviesByType["KidsMovie"].ToString());
            MessageBox.Show("Number of total days selected: " + numberDaysMoviesByType["KidsMovie"].ToString());

            frmKidsMovies kidsMovies = new frmKidsMovies(); //The frmLibraryMovies form object is instantiated.

            DialogResult numberMoviesEnteredSummary = kidsMovies.ShowDialog(); //DialogResult, will return the action and save it in an object instantiated to the form, it is called the opening of the form.
        }
    }
}
