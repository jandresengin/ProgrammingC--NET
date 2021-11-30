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
        public static int numberOfLateMovies = 0;
        decimal totalOwed = 0;


        public frmMain()
        {
            InitializeComponent();
            labelNumberLateFilms.Text = numberOfLateMovies.ToString();
            labelTotalLateFee.Text = totalOwed.ToString();
        }

        

        private void btnNewRelease_Click(object sender, EventArgs e)
        {

            //When performing the action of pressing the Return button, the form is instantiated as an object, this allows to call it.
            frmNewRelease newRelease = new frmNewRelease(); //The frmNewRelease form object is instantiated.
            
            //this.Hide();//the current form is hidden.

            DialogResult numberMoviesEnteredSummary = newRelease.ShowDialog(); //the newRelease form is called.


        

            
            numberOfLateMovies = newRelease.GetNumberMoviesSummary();
            labelNumberLateFilms.Text = numberOfLateMovies.ToString();
            totalOwed = frmNewRelease.totalWithDiscount;
            labelTotalLateFee.Text = totalOwed.ToString();
        }



        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {
            //When performing the action of pressing the Return button, the form is instantiated as an object, this allows to call it.
            frmLibraryMovies libraryMovies = new frmLibraryMovies(); //The frmLibraryMovies form object is instantiated.
            this.Hide(); //the current form is hidden.
            libraryMovies.ShowDialog(); //the libraryMovies form is called.
            this.Close(); //At the end the current form is closed to not leave active forms or threads.
        }

        private void btnKidsMovie_Click(object sender, EventArgs e)
        {
            //When performing the action of pressing the Return button, the form is instantiated as an object, this allows to call it.
            frmKidsMovies kidsMovies = new frmKidsMovies(); //The frmKidsMovies form object is instantiated.  
            this.Hide(); //the current form is hidden.
            kidsMovies.ShowDialog(); //the libraryMovies form is called.
            this.Close(); //At the end the current form is closed to not leave active forms or threads.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //The current form and the program are closed completely, in this case.
        }
        

        private void btnLateFilms_Click(object sender, EventArgs e)
        {
            //When performing the action of pressing the Return button, the form is instantiated as an object, this allows to call it.
            frmLateFilms lateFilms = new frmLateFilms(); //The frmKidsMovies form object is instantiated.  
            DialogResult numberMoviesLateCounter =  lateFilms.ShowDialog(); //Grab the button

            numberOfLateMovies = lateFilms.GetNumberMovies();

            //lateFilms.Tag.ToString();
            MessageBox.Show(numberOfLateMovies.ToString(), "Value returned of the new form");
            labelNumberLateFilms.Text = numberOfLateMovies.ToString();

        }

    }
}
