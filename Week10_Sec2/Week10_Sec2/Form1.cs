using UtilitiesClass;

namespace Week10_Sec2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumberCheck_Click(object sender, EventArgs e)
        {
            if (Validations.IsNumeric(txtTaxRate.Text))
            {
                MessageBox.Show("Tax Rate is Numeric");
            }
            else
            {
                MessageBox.Show("Please provide a numeric tax rate");
            }
        }
    }
}
