using Users;

namespace MainForm
{
    /* UserManagementApp.cs
     * This app creates users and gives them all unique ids and allows them to input
     * a username and password and date created. It has validation for password requirements
     * and validates the other fields as well. It has a miscellaneous section that saves phrases
     * and removes all the punctuation from the phrases once a show all phrases button is pressed.
     * The phrases are displayed and messages to show errors or if a user was created successfully
     * also display.
     * 
     * Revision History:
     *      Rafi Miah & Danial Tossel, 2024.07.24: Created
     */

    public partial class UserManagementApp : Form
    {
        private UserManager userManager;
        private List<string> phrases = new List<string>();

        public UserManagementApp()
        {
            InitializeComponent();
            userManager = new UserManager(); // create a UserManager object

            // handles the click event on the buttons to the click methods
            btnGetNewId.Click += BtnGetNewId_Click;
            btnAddNewUser.Click += BtnAddNewUser_Click;
            btnSavePhrase.Click += BtnSavePhrase_Click;
            btnShowAllPhrases.Click += BtnShowAllPhrases_Click;
        }

        // method called on get new id button click
        private void BtnGetNewId_Click(object? sender, EventArgs e)
        {
            // generates a new id using the user manager class
            int newId = userManager.GetNewId();
            txtId.Text = newId.ToString();
        }

        // method called on add new user button click
        private void BtnAddNewUser_Click(object? sender, EventArgs e)
        {
            // clears the text box of errors
            rtbMessages.Clear();

            // reads the values in the text boxes
            int id = int.Parse(txtId.Text);
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            DateTime dateCreated = dtpDateCreated.Value;

            // validates the inputs, out keyword to pass the argument by reference instead of value
            bool isValid = ValidateInputs(username, password, dateCreated);

            if (isValid)
            {
                User newUser = new User(id, username, password, dateCreated); // create a user using the parameters
                userManager.AddNewUser(newUser);
                rtbMessages.ForeColor = Color.Black; // sets text color of rich text box to black
                rtbMessages.AppendText($"New user \"{username}\" was added successfully.");

                // clears the existing user information
                txtId.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        // method to validate the inputs given
        private bool ValidateInputs(string username, string password, DateTime dateCreated)
        {
            rtbMessages.ForeColor = Color.Red; // sets the rich text box color to red

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(username))
            {
                rtbMessages.AppendText("Username cannot be empty.\n"); // appends the text to the rich text box
                isValid = false;
            }

            if (password.Length < 6)
            {
                rtbMessages.AppendText("Password must be at least 6 characters long.\n"); // appends the text to the rich text box
                isValid = false;
            }

            // booleans to check if the password has the requirements
            bool hasLetter = false;
            bool hasDigit = false;
            bool hasPunctuation = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                    hasLetter = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
                else if (char.IsPunctuation(c))
                    hasPunctuation = true;
            }

            if (!(hasLetter && hasDigit && hasPunctuation))
            {
                rtbMessages.AppendText("Password must contain at least one letter, one digit, and one punctuation.\n"); // appends the text to the rich text box
                isValid = false;
            }

            if (dateCreated > DateTime.Now)
            {
                rtbMessages.AppendText("Date created cannot be in the future.\n"); // appends the text to the rich text box
                isValid = false;
            }

            return isValid;
        }

        // method called on save phrase button click
        private void BtnSavePhrase_Click(object? sender, EventArgs e)
        {
            string phrase = txtPhrase.Text.Trim();
            if (!string.IsNullOrWhiteSpace(phrase))
            {
                phrases.Add(phrase);
                txtPhrase.Clear();
            }
        }

        // method called on show all phrases button click
        private void BtnShowAllPhrases_Click(object? sender, EventArgs e)
        {
            rtbAllPhrases.Clear();

            // creates an array with the size of the phrases in the list
            string[] reversedPhrases = new string[phrases.Count];

            for (int i = phrases.Count - 1, j = 0; i >= 0; i--, j++)
            {
                string cleanedPhrase = RemovePunctuation(phrases[i]);
                reversedPhrases[j] = $"{j}: {cleanedPhrase}";
            }

            foreach (string phrase in reversedPhrases)
            {
                rtbAllPhrases.AppendText(phrase + "\n");
            }
        }

        // method to remove punctuations
        private string RemovePunctuation(string input)
        {
            return new string(input.Where(c => !char.IsPunctuation(c)).ToArray());
        }


    }
}
