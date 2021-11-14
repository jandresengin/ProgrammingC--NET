using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, System.EventArgs e)
        {
            string emailEntry = txtEmail.Text;
            emailEntry = emailEntry.Trim();
            int indexCharacterSpecial1 = emailEntry.IndexOf("@");      
            if (indexCharacterSpecial1 == -1)
            {
                MessageBox.Show("Please enter a valid email address. The email does not contain the @ sign.", "ERROR. Parsed String");
            }
            else
            {
                string userName = emailEntry.Substring(0, indexCharacterSpecial1);
                if (userName.Length == 0)
                {
                    MessageBox.Show("Please enter a valid email address. The email does not contain a user name.", "ERROR. Parsed String");
                }
                else
                {
                    string domainName = emailEntry.Remove(0, indexCharacterSpecial1 + 1);
                    if (domainName.Length == 0)
                    {
                        MessageBox.Show("Please enter a valid email address. The email does not contain a domain name.", "ERROR. Parsed String");
                    }
                    else
                    {
                        MessageBox.Show("User name: " + userName + "\nDomain name: " + domainName, "Parsed String");
                    }
                        
                    
                }
                
            }
        }

        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e)
        {
            string cityEntry = txtCity.Text;
            cityEntry = cityEntry.Trim();
            string provinceEntry = txtProvince.Text;
            provinceEntry = provinceEntry.Trim();
            string postalCodeEntry = txtPostalCode.Text;
            postalCodeEntry = postalCodeEntry.Trim();
            if (cityEntry.Length == 0)
            {
                MessageBox.Show("Please enter a valid city name. The city field must not be empty.", "ERROR. Formatted String");
            }
            else
            {
                if (provinceEntry.Length < 2)
                {
                    MessageBox.Show("Please enter a valid province name. The province field must be of two characters.", "ERROR. Formatted String");
                }
                else
                {
                    provinceEntry = provinceEntry.ToUpper();
                    if (postalCodeEntry.Length == 0)
                    {
                        MessageBox.Show("Please enter a valid postal code. The postal code field must be of two characters.", "ERROR. Formatted String");
                    }
                    else
                    {
                        postalCodeEntry = postalCodeEntry.ToUpper();
                        string blankSpace = postalCodeEntry.Substring(3, 1);
                        if (blankSpace == " ")
                        {
                            MessageBox.Show("City, Province, Postal: " + cityEntry + ", " + provinceEntry + " " + postalCodeEntry, "Formatted String");
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid postal code. The postal code field must be in the format N7S 5A2.", "ERROR. Formatted String");
                        }
                        
                        
                    }
                }
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}