using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalcBMIBtn_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            double result;
            string resultCurtail;

            weight = Convert.ToDouble(weightInput.Text);
            height = Convert.ToDouble(heightInput.Text);

            result = weight / (height * height);
            resultCurtail = result.ToString("#.##");

            bmiOutput.Text = $"Your BMI is {resultCurtail}.";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
