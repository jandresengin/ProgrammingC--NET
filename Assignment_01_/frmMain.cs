using System;
using System.Windows.Forms;

namespace Assignment_01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewRelease_Click(object sender, EventArgs e)
        {

            frmNewRelease newRelease = new frmNewRelease(); //this is to call the form New Release as a object
            this.Hide();
            newRelease.ShowDialog();
            this.Close();
        }

        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {

            frmLibraryMovies libraryMovies = new frmLibraryMovies(); //this is the change, code for redirect  
            this.Hide();
            libraryMovies.ShowDialog();
            this.Close();
        }

        private void btnKidsMovie_Click(object sender, EventArgs e)
        {

            frmKidsMovies kidsMovies = new frmKidsMovies(); //this is the change, code for redirect  
            this.Hide();
            kidsMovies.ShowDialog();
            this.Close();
        }
    }
}
