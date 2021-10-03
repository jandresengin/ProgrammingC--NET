using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**************************************************************************************************************
 * 
 *      CSD2354 Programming C# NET          Instructor: Noah Petrides
 *      Jairo Andres Supelano Rativa        c0812859
 *      Calculate area and perimeter
 * 
 **************************************************************************************************************/


namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*      🦉🦉🦉🦉🦉🦉🦉🦉🦉🦉🦉🦉🦉                                                       ⁂⁂
         *                                                                                             ⁂⁂
         *      Knock, knock.                                                                          ⁂⁂
                Who’s there?                                                                           ⁂⁂
                Who.                                                                                   ⁂⁂
                Who who?                                                                               ⁂⁂
                I didn’t know you were an owl!                                                         ⁂⁂
         *                                                                                             ⁂⁂
         *      🦉🦉🦉🦉🦉🦉🦉🦉🦉🦉🦉🦉🦉                                                       ⁂⁂
         */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal diameterEntered = Convert.ToDecimal(txtDiameter.Text); //The value entered by the user in the Diameter text box is taken, in this case it is converted from string to decimal according to the requirements of the problem.
            double radiusCircle = ((double)diameterEntered) / 2.0; // The radius is calculated, where the saved value of diameter is taken but converting it to double and dividing by 2. With this we obtain greater precision.
            double areaCircle = Math.Pow(radiusCircle, 2) * Math.PI; // The area is calculated, where the value of the radius calculated in the previous step is taken and raised to the power of 2, with the Math.Pow library and then multiplied by the value of pi, which is called by invoking the Math library. PI.
            double perimeterCircle = 2 * Math.PI * radiusCircle; //In this step, the perimeter is only calculated taking the value of the radius and multiplied by 2, then by the value of PI invoking Math.PI.

            //Plot in the textbox with the data format.
            txtArea.Text = areaCircle.ToString("f4"); // The value of the area is taken and converted to String, but it is indicated to show the result in F4 format (Float with 4 decimal places).
            txtPerimeter.Text = perimeterCircle.ToString("f4"); //The value of the perimeter is taken and converted to String, but it is indicated to show the result in F4 format (Float with 4 decimal places).
            txtDiameter.Focus(); // The focus is sent to the textbox txtDiameter
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //This instruction executes the closing of the current form and the program.
        }
    }
}
