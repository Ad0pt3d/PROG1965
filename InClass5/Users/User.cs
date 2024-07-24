namespace Users
{
    /* User.cs
     * This is a class library that handles the creating of users and checks
     * validation on the user information. This class also creates a file to
     * save all the users and creates unique ids for each user.
     * 
     * Revision History:
     *      Rafi Miah & Danial Tossel, 2024.07.24: Created
     */

    // User class
    public class User
    {
        // declaring variables
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime dateCreated { get; set; }

        // default constructor
        public User(int id, string username, string password, DateTime dateCreated)
        {
            // validate all parameters
            ValidateId(id);
            ValidateUsername(username);
            ValidatePassword(password);
            ValidateDateCreated(dateCreated);

            this.id = id;
            this.username = username;
            this.password = password;
            this.dateCreated = dateCreated;
        }

        // id validation
        public void ValidateId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be a postive integer.");
            }
        }

        // username validation
        public void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be empty.");
            }

        }

        // password validation
        public void ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                throw new ArgumentException("Password must be at least 6 characters long.");
            }

            // bools to keep track of password requirements
            bool hasLetter = false;
            bool hasDigit = false;
            bool hasPunctuation = false;

            // checks each char
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
                throw new ArgumentException("Password must contain at least one letter, one digit, and one punctuation symbol.");
            }
        }

        // dateCreated validation
        public void ValidateDateCreated(DateTime dateCreated)
        {
            if (dateCreated > DateTime.Now)
            {
                throw new ArgumentException("DateCreated cannot be in the future");
            }
        }

        // override ToString()
        public override string ToString()
        {
            return $"{id} | {username} | {password} | {dateCreated.ToString("yyyy-MM-dd")}";
        }
    }

    // UserManager class
    public class UserManager
    {
        public string fileName = "users.txt";

        // this constructor will create a file if it does not exist
        public UserManager()
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    // createing file and closing the stream
                    File.Create(fileName).Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error creating or reading file.", e);
            }
        }

        // new id for new user method
        public int GetNewId()
        {
            try
            {
                List<User> users = ReadUsersFromFile();
                // an if expression that checks if users exist then set
                // maxId to the max id in list of users else maxId is 0
                int maxId = users.Count > 0 ? users.Max(u => u.id) : 0;
                return maxId + 1;
            }
            catch (Exception e)
            {
                throw new Exception("Error getting a new id for user.", e);
            }
        }

        // adds a user to the file
        public void AddNewUser(User newUser)
        {
            try
            {
                // appends a user to the file
                using (StreamWriter writer = File.AppendText(fileName))
                {
                    writer.WriteLine(newUser.ToString());
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error adding a new user to the file", e);
            }
        }

        public List<User> ReadUsersFromFile()
        {
            List<User> users = new List<User>();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|'); // splits each line by the delimiter
                        int id = int.Parse(parts[0]); // parses the first part of user to set to id
                        string username = parts[1]; // sets the second part to username
                        string password = parts[2]; // sets the third part to password
                        DateTime dateCreated = DateTime.Parse(parts[3]); // parses the last part to the exact format of the DateTime
                        User user = new User(id, username, password, dateCreated);
                        users.Add(user);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error reading users from the file", e);
            }

            return users;
        }
    }
}
