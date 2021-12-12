using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment05
{
    public partial class frmNewMovie : Form
    {
        public frmNewMovie()
        {
            InitializeComponent();
        }

        private RentalItem rentalItem = null;

        public RentalItem GetNewRentalItem()
        {
            this.ShowDialog();
            return rentalItem;
        }
        string selectedTypeCustomer;
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsValidData())
            {
                rentalItem = new RentalItem(Int32.Parse(txtMovieNumber.Text), txtMovieDescription.Text,
                    txtFilmRating.Text, selectedTypeCustomer = GetValueComBox()) ;

                this.Close();
            }
        }
        private bool IsValidData()
        {
            return Validator.IsPresent(txtMovieNumber) &&
                Validator.IsInt32(txtMovieNumber) &&
                Validator.IsPresent(txtMovieDescription) &&
                Validator.IsPresent(txtFilmRating) &&
                Validator.IsPresentComboBox(selectedTypeCustomer);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GetValueComBox()
        {
            
            var itemComboBox = this.comboBoxTypeMovie.GetItemText(this.comboBoxTypeMovie.SelectedItem);

            return itemComboBox;

        }

    }
}
