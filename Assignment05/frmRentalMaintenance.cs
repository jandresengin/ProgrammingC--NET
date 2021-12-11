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
    public partial class frmRentalMaintenance : Form
    {
        public frmRentalMaintenance()
        {
            InitializeComponent();
        }

        private List<RentalItem> rentalItems = null;

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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewMovie addRentalItemForm = new frmNewMovie();
            RentalItem rentalItem = addRentalItemForm.GetNewRentalItem();
            if (rentalItem != null)
            {
                rentalItems.Add(rentalItem);
                RentalItemDB.SaveRentalItem(rentalItems);
                FillRentalItemsListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstRentalItems.SelectedIndex;
            if (i != -1)
            {
                RentalItem rentalItem = rentalItems[i];
                string message = "Are you sure you want to delete "
                    + rentalItem.MovieNo + " " + rentalItem.Description + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    rentalItems.Remove(rentalItem);
                    RentalItemDB.SaveRentalItem(rentalItems);
                    FillRentalItemsListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
