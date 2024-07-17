using MMClassLibrary;

namespace Week10_Sec2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMessage.Text = string.Empty;
        }

        // pre-load the input fields with the province with the selected province code
        private void btnFindCode_Click(object sender, EventArgs e)
        {
            Province province = Province.GetProvinceByCode(txtFindCode.Text);

            if (province != null )
            {
                lblMessage.Text = "province code is not on file";
            }
            else
            {
                PopulateForm(province);
            }
        }

        private void PopulateForm(Province province)
        {
            txtProvinceCode.Text = province.ProvinceCode;
            txtName.Text = province.Name;
            txtCountryCode.Text = province.CountryCode;
            txtTaxCode.Text = province.TaxCode;
            txtTaxRate.Text = province.TaxRate.ToString();
            txtFedTax.Text = province.IncludesFederalTax.ToString();
            txtFirstPostCode.Text = province.FirstLetterOfPostalCode;
        }
    }
}
