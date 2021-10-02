using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int scoreTotalTemp = 0;
        int scoreCountTemp = 0;
        /******************************************************************************************************************************************************************
		 *	☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸			⧆		🐘																			†
		 *     Who is the most famous ant scientist?  Albert Antstein				⧆		🐘																			†
		 * ∗☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸☸			⧆		🐜		🐜		🐜			🐜		🐜			🐜		🐜			🐜		†
		 ****************************************************************************************************************************************************************** 
		 */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int scoreTemp = Convert.ToInt32(txtScore.Text);
            scoreTotalTemp += scoreTemp;
            scoreCountTemp++;
            double averageScore = (double)scoreTotalTemp / (double)scoreCountTemp;
            txtScoreTotal.Text = scoreTotalTemp.ToString("d");
            txtScoreCount.Text = scoreCountTemp.ToString("d");
            txtAverage.Text = averageScore.ToString("f3");

            txtScore.Text = "";
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            scoreTotalTemp = 0;
            scoreCountTemp = 0;

            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();

        }
    }
}
