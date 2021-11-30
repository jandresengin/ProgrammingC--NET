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
            lateMoviesList.Add(txtLateFilms.Text);//The action of pressing the Add button will add the title entered by the user to the ordered list.
            lateMoviesList.Sort();//It will be ordered alphabetically
            foreach (string movie in lateMoviesList) //It will go through each element of the SortedList
            {
                message += movie.ToString() + "\n";//Message to display is created
            }
            
            MessageBox.Show(message, "Order Totals - List");//The list of movies entered by the user is displayed.
            
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
    }
}
