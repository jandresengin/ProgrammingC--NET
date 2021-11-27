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
    }
}
