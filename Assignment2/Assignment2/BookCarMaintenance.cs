using System.Text.RegularExpressions;

namespace Assignment2
{
    public partial class BookCarMaintenance : Form
    {
        public BookCarMaintenance()
        {
            InitializeComponent();

            dtpAppointment.CustomFormat = "dd MMM yyyy"; // Sets the date time pickers custom format to 
            lblErrors.Text = string.Empty; // Sets the error label to empty on load
        }

        private async void btnBookAppointment_Click(object sender, EventArgs e)
        {
            string fileName = "../../../BookCarMaintenance.txt"; // File path and name 
            string writeBuffer = ""; // A buffer to store all the data to write to file


            string errors = "";

            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                errors += "Customer Name must be provided.\n";
            }
            else
            {
                // Runs the capitalize function on the customer name
                txtCustomerName.Text = ValidationHelper.Capitalize(txtCustomerName.Text);
                writeBuffer += $"Customer Name: {txtCustomerName.Text}\n";
            }

            if (string.IsNullOrEmpty(txtAddress.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                errors += "Address is required if email is not provided.\n";
            }
            else
            {
                txtAddress.Text = ValidationHelper.Capitalize(txtAddress.Text);
                writeBuffer = $"Address: {txtAddress.Text}\n";
            }

            if (string.IsNullOrEmpty(txtCity.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                errors += "City is required if email is not provided.\n";
            }
            else
            {
                txtCity.Text = ValidationHelper.Capitalize(txtCity.Text);
                writeBuffer += $"City: {txtCity.Text}\n";
            }

            if (string.IsNullOrEmpty(txtProvince.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                errors += "Province is required if email is not provided.\n";
            }
            else
            {
                // Checks if the province code matches the regex
                if (ValidationHelper.IsValidProvinceCode(txtProvince.Text))
                {
                    txtProvince.Text = txtProvince.Text.ToUpper();
                    writeBuffer += $"Province: {txtProvince.Text}\n";
                }
                else if (string.IsNullOrEmpty(txtProvince.Text))
                {
                    writeBuffer += "Province: Not Provided\n";
                }
                else
                {
                    errors += "Province provided is not a valid province.\n";
                }
            }

            if (string.IsNullOrEmpty(txtPostalCode.Text) && string.IsNullOrEmpty(txtEmail.Text))
            {
                errors += "Postal code is required if email is not provided.\n";
            }
            else
            {
                if (ValidationHelper.IsValidPostalCode(txtPostalCode.Text) && !string.IsNullOrEmpty(txtPostalCode.Text))
                {
                    txtPostalCode.Text = txtPostalCode.Text.ToUpper();
                    // Replaces the postal code to the format of A1A 1A1
                    txtPostalCode.Text = Regex.Replace(txtPostalCode.Text, @"^([A-Za-z]\d[A-Za-z])(\d[A-Za-z]\d)$", "$1 $2");
                    writeBuffer += $"Postal Code: {txtPostalCode.Text}\n";
                }
                else if (string.IsNullOrEmpty(txtPostalCode.Text))
                {
                    writeBuffer += "Postal Code: Not Provided\n";
                }
                else
                {
                    errors += "Postal code provided is not a valid postal code, format (A1A 1A1 or A1A1A1)\n";
                }
            }

            // Email regex pattern
            string emailRegex = @"^\w+@\w+\.\w+$";

            if (Regex.IsMatch(txtEmail.Text, emailRegex))
            {
                txtEmail.Text = txtEmail.Text.ToLower();
                writeBuffer += $"{txtEmail.Text}\n";
            }
            else
            {
                errors += "The email provided does not match a valid email.\n";
            }

            if (string.IsNullOrEmpty(txtHomePhone.Text) && string.IsNullOrEmpty(txtCellPhone.Text))
            {
                errors += "Home or Cell phone number must be provided, one or both.\n";
            }
            else
            {
                if (ValidationHelper.IsValidPhoneNumber(txtHomePhone.Text) && !string.IsNullOrEmpty(txtHomePhone.Text))
                {
                    // Replaces the phone with the format 123-456-7890
                    txtHomePhone.Text = Regex.Replace(txtHomePhone.Text, @"^(\d{3})(\d{3})(\d{4})$", "$1-$2-$3");
                    writeBuffer += $"{txtHomePhone.Text}\n";
                }
                else if (ValidationHelper.IsValidPhoneNumber(txtCellPhone.Text) && !string.IsNullOrEmpty(txtCellPhone.Text))
                {
                    // Replaces the phone with the format 123-456-7890
                    txtCellPhone.Text = Regex.Replace(txtCellPhone.Text, @"^(\d{3})(\d{3})(\d{4})}$", "$1-$2-$3");
                    writeBuffer += $"{txtCellPhone.Text}\n";
                }
                else
                {
                    errors += "Home or Cell number is not provided in the correct format (123-456-7890 or 1234567890)\n";
                }
            }

            if (string.IsNullOrEmpty(txtMakeModel.Text))
            {
                errors += "Make and Model must be provided.\n";
            }
            else
            {
                txtMakeModel.Text = ValidationHelper.Capitalize(txtMakeModel.Text);
                writeBuffer += $"{txtMakeModel.Text}\n";
            }

            if (!string.IsNullOrEmpty(txtYear.Text))
            {
                DateTime currentDate = DateTime.Now;
                int year = Convert.ToInt32(txtYear.Text);

                if (year < 1900 || year > currentDate.Year + 1)
                {
                    errors += $"Year is optional, if provided must be between 1900 and {currentDate.Year + 1}.\n";
                }
                else
                {
                    writeBuffer += $"{txtYear.Text}\n";
                }
            }

            if (!string.IsNullOrEmpty(dtpAppointment.Text))
            {
                DateTime currentDate = DateTime.Now;

                if (dtpAppointment.Value.Day < DateTime.Now.Day)
                {
                    errors += "Date cannot be set in the past.\n";
                }
                else
                {
                    writeBuffer += $"{dtpAppointment.Text}\n\n";
                }
            }

            if (errors == "")
            {
                // Tries to write to file
                try
                {
                    // StreamWriter writes to the file path and appends if file exists
                    using (StreamWriter writer = new StreamWriter(fileName, true))
                    {
                        writer.WriteLine(writeBuffer);

                        writer.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            lblErrors.Text = errors;
        }

        private void btnPreFill_Click(object sender, EventArgs e)
        {
            // Initialize random object
            Random rand = new Random();

            // Initialize random fields into arrays with a test email
            string[] randomNames = { "Rafi Miah", "John Doe", "Homer Simpson", "rafi miah", "john doe", "homer simpson" };
            string[] randomAddress = { "123 Maple Street", "456 Oak Avenue", "789 Jordan Drive", "123 maple street", "456 oak avenue", "789 jordan drive" };
            string[] randomCity = { "Waterloo", "Springfield", "waterloo", "springfield" };
            string[] randomProvince = { "ON", "On", "oN", "NS", "ns", "Ns" };
            string[] randomPostalCode = { "A1A 2B2", "C5Z 7J8", "a1a2b2", "c5z7j8", "A1A2B2", "C5Z7J8", "a1a 2b2", "c5z 7j8" };
            string[] randomPhone = { "519-555-0123", "226-555-4567", "548-555-8910", "5195550123", "2265554567", "5485558910" };
            string testEmail = "rafim1234@rmail.com";
            string[] randomMakeModel = { "Honda Civic", "Ford Mustang", "Nissan Kicks", "Toyota GR86", "honda civic", "ford mustang", "nissan kicks", "toyota gr86" };
            string[] randomYear = { "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" };

            // Set all the fields on the form to a random test case input
            txtCustomerName.Text = randomNames[rand.Next(randomNames.Length)];
            txtAddress.Text = randomAddress[rand.Next(randomAddress.Length)];
            txtCity.Text = randomCity[rand.Next(randomCity.Length)];
            txtProvince.Text = randomProvince[rand.Next(randomProvince.Length)];
            txtPostalCode.Text = randomPostalCode[rand.Next(randomPostalCode.Length)];
            txtCellPhone.Text = randomPhone[rand.Next(randomPhone.Length)];
            txtEmail.Text = testEmail;
            txtMakeModel.Text = randomMakeModel[rand.Next(randomMakeModel.Length)];
            txtYear.Text = randomYear[rand.Next(randomYear.Length)];
            dtpAppointment.Text = DateTime.Today.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Resets all fields to empty and sets date to the current date (today)
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtProvince.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtCellPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMakeModel.Text = string.Empty;
            txtYear.Text = string.Empty;
            dtpAppointment.Text = DateTime.Today.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Exits application (form)
            Application.Exit();
        }
    }
}
