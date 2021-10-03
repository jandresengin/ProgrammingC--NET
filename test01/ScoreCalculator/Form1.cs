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
 *      Accumulate test score data
 * 
 **************************************************************************************************************/

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int scoreTotalTemp = 0; // Variable scoreTotalTemp is declared with class scope, and initialized to 0. It is not inside any method. As it takes temporary values, it is left ending with the name Temp
        int scoreCountTemp = 0; // Variable scoreCountTemp is declared with class scope, and initialized to 0. It is not inside any method. As it takes temporary values, it is left ending with the name Temp


        /******************************************************************************************************************************************************************
		 *	☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸			⧆		🐘																			†
		 *     Who is the most famous ant scientist?  Albert Antstein				⧆		🐘																			†
		 * ∗☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸			⧆		🐜		🐜		🐜			🐜		🐜			🐜		🐜			🐜		†
		 ****************************************************************************************************************************************************************** 
		 */
        private void btnAdd_Click(object sender, EventArgs e)
        {

            int scoreTemp = Convert.ToInt32(txtScore.Text); //The value entered by the user in the txtScore text box is taken, in this case it is converted from string to integer according to the requirements of the problem.
            scoreTotalTemp += scoreTemp; //The value entered by the user is added to the value of scoreTotalTemp and will increase according to each new value entered by the user.
            scoreCountTemp++; //This counter indicates the number of entries made by the user.
            double averageScore = (double)scoreTotalTemp / (double)scoreCountTemp; //The average is calculated where the variables scoreTotalTemp (sum of all the numbers entered by the user so far) and scoreCountTemp (the number of entries made by the user so far) are converted into double, these two are divided and stored in a double variable called averageScore.


            //Plot in the textbox with the data format.
            txtScoreTotal.Text = scoreTotalTemp.ToString("d"); //The value of scoreTotalTemp is converted to a string and displayed in the txtScoreTotal textbox, with d format for integers
            txtScoreCount.Text = scoreCountTemp.ToString("d"); //The value of scoreCountTemp is converted to a string and displayed in the txtScoreCount textbox, with d format for integers
            txtAverage.Text = averageScore.ToString("f3"); //The value of averageScore is converted to a string and it is displayed in the txtAverage textbox, with f3 format (decimal number with 3 digits)


            //The txtScore textbox is cleaned and the cursor is placed in this texbox so that the user continues entering numbers.
            txtScore.Text = ""; 
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //This instruction executes the closing of the current form and the program.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            scoreTotalTemp = 0; //Variable scoreTotalTemp with class scope is initialized to 0.
            scoreCountTemp = 0; //Variable scoreCountTemp with class scope is initialized to 0.

            txtScore.Text = ""; //The txtScore textbox is cleared.
            txtScoreTotal.Text = ""; //The txtScoreTotal textbox is cleared.
            txtScoreCount.Text = ""; //The txtScoreCount textbox is cleared.
            txtAverage.Text = ""; //The txtAverage textbox is cleared.

            txtScore.Focus(); // The cursor is placed in the txtScore text box

        }
    }
}
