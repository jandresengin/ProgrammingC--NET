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
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
            labelTax.Text = "Tax (4.25%):";
        }
        /// #################################################################################
        /// /       tax rate of Michigan 4.25 %   (Too Low)
        /// #################################################################################
        private decimal SalesTaxPct = 4.25m;


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                calculateFinalValue();
            }
        }

        public bool IsValidData()
        {
            return
                IsPresent(txtProductTotal, "Subtotal") &&
                IsDecimal(txtProductTotal, "Subtotal") &&
                IsWithinRange(txtProductTotal, "Subtotal", 0, 1000000);
        }

        public void calculateFinalValue()
        {
            decimal productTotal = Convert.ToDecimal(txtProductTotal.Text);
            decimal discountPercent = .0m;

            if (productTotal < 100)
                discountPercent = .0m;
            else if (productTotal >= 100 && productTotal < 250)
                discountPercent = .1m;
            else if (productTotal >= 250)
                discountPercent = .25m;

            decimal discountAmount = productTotal * discountPercent;
            decimal subtotal = productTotal - discountAmount;
            decimal tax = subtotal * SalesTaxPct / 100;
            decimal total = subtotal + tax;

            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtTotal.Text = total.ToString("c");

            txtProductTotal.Focus();
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number <= min || number >= max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePercent_Click(object sender, EventArgs e)
        {
            
            frmSalesTax salesTax = new frmSalesTax();
            DialogResult salesTaxPercent = salesTax.ShowDialog();

            
            if (salesTaxPercent == DialogResult.OK)
            {
                labelTax.Text = "Tax (" + (String) salesTax.Tag + "%):";
                SalesTaxPct = Convert.ToDecimal((String)salesTax.Tag);
                calculateFinalValue();
            }

        }

    }
}