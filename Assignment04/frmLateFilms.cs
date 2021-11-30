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

        List<string> lateMoviesList = new List<string>();
        private int numberMoviesLateCounter = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            //clear the dialog result so it won't close
            lateMoviesList.Add(txtLateFilms.Text);
            lateMoviesList.Sort();
            foreach (string movie in lateMoviesList)
            {
                message += movie.ToString() + "\n";
            }
            
            MessageBox.Show(message, "Order Totals - List");
            MessageBox.Show(lateMoviesList.Count.ToString(), " Total list members");
        }
        
        public int GetNumberMovies()
        {
            return numberMoviesLateCounter;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {

            numberMoviesLateCounter = lateMoviesList.Count;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //When performing the action of pressing the Return button, the form is instantiated as an object, this allows to call it.
            frmMain formMain = new frmMain(); //The main form object is instantiated.
            this.Hide(); //the current form is hidden.
            formMain.ShowDialog(); //the main form is called.
            this.Close(); //At the end the current form is closed to not leave active forms or threads.
        }

    }
}
