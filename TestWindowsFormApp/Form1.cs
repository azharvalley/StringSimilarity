using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringSimilarity;

namespace TestWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compute_Click(object sender, EventArgs e)
        {
            var string1 = string1txtBox.Text.ToString();
            var string2 = string2txtBox.Text.ToString();

            var levenstainResult = LevenstainDistance.CalculateSimilarity(string1, string2);

            var jaroWinklerResult = JaroWinclerDistance.GetDistance(string1, string2);

            var triGramResult = NGramsComparision.CompareStringsWithTriGram(string1, string2);

            var diceResult = DiceCoefficient.DiceCoefficientCount(string1, string2);

            levenstainTxtBox.Text = (Math.Round(levenstainResult, 2) * 100).ToString();
            levenstainTxtBox.Text += '%';

            jaroWinklerTxtBox.Text = (Math.Round(jaroWinklerResult, 2) * 100).ToString();
            jaroWinklerTxtBox.Text += '%';

            nGramTxtBox.Text = (Math.Round(triGramResult, 2) * 100).ToString();
            nGramTxtBox.Text += '%';

            diceCoefficientTxtBox.Text = (Math.Round(diceResult, 2) * 100).ToString();
            diceCoefficientTxtBox.Text += '%';
        }

        private void string1txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
