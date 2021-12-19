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
 *          CSD2354 Programming C# NET          Fall 2021       Test 03
 *          Jairo Andres Supelano               c0812859
 ************************************************************************************************************************/



namespace InvoiceTotal
{
    public partial class frmSalesTax : Form
    {
        public frmSalesTax()
        {
            InitializeComponent();
        }
        private decimal SalesTaxPct = 0;

        public decimal GetSalesTaxPercent()//function that returns the number of movies entered in the list.
        {
            return SalesTaxPct;
        }
        private void SaveData()
        {
            string msg = null;
            msg += txtSalesTaxPct.Text;
            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private bool IsValidData() //It evaluates if the number of days entered by the user is not empty, it is a whole number and is between 0 and 50.
        {
            bool success = true;

            string errorMessage = "";
            errorMessage += IsPresent(txtSalesTaxPct.Text, "Sales tax percentage");
            errorMessage += IsDecimal(txtSalesTaxPct.Text, "Sales tax percentage");
            errorMessage += IsWithinRange(txtSalesTaxPct.Text, "Sales tax percentage", (decimal)0, (decimal)9.99999999999999);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
        private string IsPresent(string value, string name)//This generic function evaluates if the value is empty or not.
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }


        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value.\n";
            }
            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n";
                }
            }
            return msg;
        }


    }



}
