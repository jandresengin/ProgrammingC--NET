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
    public partial class lakeSuperior : Form
    {
        public lakeSuperior()
        {
            InitializeComponent();
        }
        //*******************************************************************************************************************************************************************************************
        /*
         * the name of the largest (area) freshwater lake in the world. LAKE SUPERIOR
         * 
         */////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////****
        private void btnParse_Click(object sender, System.EventArgs e)
        {
            string emailEntry = txtEmail.Text; //the value entered by the user is saved in the email text field, in a variable called emailEntry
            emailEntry = emailEntry.Trim(); //Blank fields at the beginning and end of the email entered by the user are removed.
            int indexCharacterSpecial1 = emailEntry.IndexOf("@"); //It looks for if the character @ exists in the email input made by the user.      
            if (indexCharacterSpecial1 == -1) //If there is no @ character, an error message will be displayed.
            {
                MessageBox.Show("Please enter a valid email address. The email does not contain the @ sign.", "ERROR. Parsed String");
            }
            else
            {
                string userName = emailEntry.Substring(0, indexCharacterSpecial1);//Now the program will save in a variable called userName the initial part of the email, from the first character to where the @ is.
                if (userName.Length == 0)//If the username is of length 0, an error message will be displayed indicating that the user must enter a user name in the email.
                {
                    MessageBox.Show("Please enter a valid email address. The email does not contain a user name.", "ERROR. Parsed String");
                }
                else
                {
                    string domainName = emailEntry.Remove(0, indexCharacterSpecial1 + 1); //Now the program will save in a variable called domainName the last part of the email, from the character @ + 1 position to the end of the email entered by the user.
                    if (domainName.Length == 0)//If the domainName is of length 0, an error message will be displayed indicating that the user must enter a domain name in the email.
                    {
                        MessageBox.Show("Please enter a valid email address. The email does not contain a domain name.", "ERROR. Parsed String");
                    }
                    else
                    { //At the end the message will be displayed with the user name and domain name. If all the fields are not empty and have @
                        MessageBox.Show("User name: " + userName + "\nDomain name: " + domainName, "Parsed String");
                    }
                }
            }
        }

        private void btnFormat_Click(object sender, System.EventArgs e)
        {//The functions that are executed when pressing the X button are programmed
            string cityEntry = txtCity.Text; //the value entered by the user is saved in the txtCity text field, in a variable called cityEntry
            cityEntry = cityEntry.Trim(); //Blank fields at the beginning and end of the city entered by the user are removed.
            string provinceEntry = txtProvince.Text; //the value entered by the user is saved in the txtProvince text field, in a variable called provinceEntry
            provinceEntry = provinceEntry.Trim(); //Blank fields at the beginning and end of the province entered by the user are removed.
            string postalCodeEntry = txtPostalCode.Text; //the value entered by the user is saved in the txtPostalCode text field, in a variable called postalCodeEntry
            postalCodeEntry = postalCodeEntry.Trim();  //Blank fields at the beginning and end of the postal code entered by the user are removed.
            if (cityEntry.Length == 0) //If the city is of length 0, an error message will be displayed indicating that the user must enter a city.
            {
                MessageBox.Show("Please enter a valid city name. The city field must not be empty.", "ERROR. Formatted String");
            }
            else
            {
                if (provinceEntry.Length < 2) //If the province is of length lesser than 2, an error message will be displayed indicating that the user must enter a province of 2 characters.
                {
                    MessageBox.Show("Please enter a valid province name. The province field must be of two characters.", "ERROR. Formatted String");
                }
                else
                {
                    provinceEntry = provinceEntry.ToUpper(); //The province value is converted to uppercase
                    if (postalCodeEntry.Length == 0) //If the postal code is of length 0, an error message will be displayed indicating that the user must enter a postal code.
                    {
                        MessageBox.Show("Please enter a valid postal code. The postal code field must be of two characters.", "ERROR. Formatted String");
                    }
                    else
                    {
                        postalCodeEntry = postalCodeEntry.ToUpper(); //The postal code value is converted to uppercase
                        string blankSpace = postalCodeEntry.Substring(3, 1); //The 3 character of the postal code entered by the user is taken and saved in blankSpace
                        if (blankSpace != " ") //The 4 character is checked to be a blank space, to comply with the standard format
                        {
                            postalCodeEntry = postalCodeEntry.Insert(3, " "); //white space is added in the 3 space.
                        }
                        if (postalCodeEntry.Length > 7)//If the size of the postal code is 7 and without a blank space, an error message will be displayed and the user will be indicated with an example how this space should be filled.
                        {
                            MessageBox.Show("Please enter a valid postal code. The postal code field must be in the format N7S 5A2.", "ERROR. Formatted String");// error message. with an example how this space should be filled.
                        }
                        else
                        {// If no error is found in the fields entered by the user, the message will be displayed with the established format.
                            MessageBox.Show("City, Province, Postal: " + cityEntry + ", " + provinceEntry + " " + postalCodeEntry, "Formatted String");
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