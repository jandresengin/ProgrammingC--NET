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
 *          CSD2354 Programming C# NET          Fall 2021       Assignment 4
 *          Jairo Andres Supelano               c0812859
 ************************************************************************************************************************/

namespace Assignment04
{
    public partial class frmMain : Form

    {
        public static int numberOfLateMovies = 0;//Variable with the number of movies entered in the last form
        decimal totalOwed = 0; //it is the total owed, adding the total after discounts of the 3 forms kids, library and new release movies
        int totalNumberMoviesForms = 0; //It is the total of films that are delivered late, adding each calculation made in the 3 forms kids, library and new release movies


        public frmMain()
        {
            InitializeComponent();//When the forms are loaded, the value of the 3 labels is updated
            labelNumberLateFilmsManual.Text = numberOfLateMovies.ToString();
            labelTotalLateFee.Text = totalOwed.ToString();
            totalNumberMovies.Text = totalNumberMoviesForms.ToString();
        }

        

        private void btnNewRelease_Click(object sender, EventArgs e)
        {
            frmNewRelease newRelease = new frmNewRelease(); //The frmNewRelease form object is instantiated.
            
            DialogResult numberMoviesEnteredSummary = newRelease.ShowDialog(); //DialogResult, will return the action and save it in an object instantiated to the form, it is called the opening of the form.
            numberOfLateMovies = newRelease.GetNumberMoviesSummary(); //The object of the instantiated form is called and a function is called that returns the value of the number of movies
            labelNumberLateFilmsManual.Text = numberOfLateMovies.ToString();//The label is updated.
            totalOwed = frmNewRelease.totalWithDiscount + frmLibraryMovies.totalWithDiscount + frmKidsMovies.totalWithDiscount; //The variables of each form are added to the total with a discount, and this will be the total owed by the client.
            totalNumberMoviesForms = frmNewRelease.numberMoviesEnteredSummary + frmLibraryMovies.numberMoviesEnteredSummary + frmKidsMovies.numberMoviesEnteredSummary;//The variables of each form are added to the total with a discount, and this will be the total number of films that the client delivers late.
            totalNumberMovies.Text = totalNumberMoviesForms.ToString();//The label is updated.
            labelTotalLateFee.Text = totalOwed.ToString();//The label is updated.
        }

        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {
            frmLibraryMovies libraryMovies = new frmLibraryMovies(); //The frmLibraryMovies form object is instantiated.
            
            DialogResult numberMoviesEnteredSummary = libraryMovies.ShowDialog(); //DialogResult, will return the action and save it in an object instantiated to the form, it is called the opening of the form.
            numberOfLateMovies = libraryMovies.GetNumberMoviesSummary();//The object of the instantiated form is called and a function is called that returns the value of the number of movies
            labelNumberLateFilmsManual.Text = numberOfLateMovies.ToString();//The label is updated.
            totalOwed = frmNewRelease.totalWithDiscount + frmLibraryMovies.totalWithDiscount + frmKidsMovies.totalWithDiscount;//The variables of each form are added to the total with a discount, and this will be the total owed by the client.
            totalNumberMoviesForms = frmNewRelease.numberMoviesEnteredSummary + frmLibraryMovies.numberMoviesEnteredSummary + frmKidsMovies.numberMoviesEnteredSummary;//The variables of each form are added to the total with a discount, and this will be the total number of films that the client delivers late.
            totalNumberMovies.Text = totalNumberMoviesForms.ToString();//The label is updated.
            labelTotalLateFee.Text = totalOwed.ToString();//The label is updated.

        }

        private void btnKidsMovie_Click(object sender, EventArgs e)
        {
            frmKidsMovies kidsMovies = new frmKidsMovies(); //The frmKidsMovies form object is instantiated.  

            DialogResult numberMoviesEnteredSummary = kidsMovies.ShowDialog(); //DialogResult, will return the action and save it in an object instantiated to the form, it is called the opening of the form.
            numberOfLateMovies = kidsMovies.GetNumberMoviesSummary();//The object of the instantiated form is called and a function is called that returns the value of the number of movies
            labelNumberLateFilmsManual.Text = numberOfLateMovies.ToString();//The label is updated.
            totalOwed = frmNewRelease.totalWithDiscount + frmLibraryMovies.totalWithDiscount + frmKidsMovies.totalWithDiscount;//The variables of each form are added to the total with a discount, and this will be the total owed by the client.
            totalNumberMoviesForms = frmNewRelease.numberMoviesEnteredSummary + frmLibraryMovies.numberMoviesEnteredSummary + frmKidsMovies.numberMoviesEnteredSummary; //The variables of each form are added to the total with a discount, and this will be the total number of films that the client delivers late.
            totalNumberMovies.Text = totalNumberMoviesForms.ToString();//The label is updated.
            labelTotalLateFee.Text = totalOwed.ToString();//The label is updated.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //The current form and the program are closed completely, in this case.
        }
        

        private void btnLateFilms_Click(object sender, EventArgs e)
        {
            frmLateFilms lateFilms = new frmLateFilms(); //The frmKidsMovies form object is instantiated.  

            DialogResult numberMoviesLateCounter =  lateFilms.ShowDialog(); //DialogResult, will return the action and save it in an object instantiated to the form, it is called the opening of the form.

            numberOfLateMovies = lateFilms.GetNumberMovies();//It is called through the instantiated object in the form of a function that brings up the number of movies entered in the list.
            labelNumberLateFilmsManual.Text = numberOfLateMovies.ToString();//The label is updated.
        }

    }
}
