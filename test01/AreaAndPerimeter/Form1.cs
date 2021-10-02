using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            decimal diameterEntered = Convert.ToDecimal(txtDiameter.Text);
            double radiusCircle = ((double)diameterEntered) / 2.0;
            double areaCircle = Math.Pow(radiusCircle, 2) * Math.PI;
            double perimeterCircle = 2 * Math.PI * radiusCircle;

            txtArea.Text = areaCircle.ToString("f4");
            txtPerimeter.Text = perimeterCircle.ToString("f4");
            txtDiameter.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
