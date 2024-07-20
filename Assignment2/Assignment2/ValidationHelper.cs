using System.Text.RegularExpressions;

namespace Assignment2
{
    public static class ValidationHelper
    {
        public static string Capitalize(string input)
        {
            // Convert null input to an empty string
            if (input == null)
            {
                input = string.Empty;
            }

            // Trim leading and trailing spaces and convert all to lowercase
            input = input.Trim().ToLower();

            // If the input is an empty string after trimming, return it
            if (input.Length == 0)
            {
                return input;
            }

            // Split the string into words
            // 'StringSplitOptions.RemoveEmptyEntries' will remove any
            // strings and substrings that are empty after splitting
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Loop through each word to capitalize
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    // Capitalize the first word OR any word longer that 1 letter
                    if (i == 0 || words[i].Length > 1)
                    {
                        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                    }
                }
            }

            // Joins the words back into one string with spaces in between
            return string.Join(" ", words);
        }

        public static bool IsValidPostalCode(string postalCode)
        {
            // Regex pattern in format A1A 1A1 or A1A1A1
            string postalRegex = @"^[A-Za-z]\d[A-Za-z][ ]?\d[A-Za-z]\d$";

            if (string.IsNullOrEmpty(postalCode))
            {
                return false;
            }

            // Returns a boolean based on if the input matches the pattern
            bool isValid = Regex.IsMatch(postalCode, postalRegex, RegexOptions.IgnoreCase);

            return isValid;
        }

        public static bool IsValidProvinceCode(string provinceCode)
        {
            // An array holding the province codes
            string[] validProvinceCodes = { "AB", "BC", "MB", "NB", "NL", "NS", "NT", "NU", "ON", "PE", "QC", "SK", "YT" };

            if (string.IsNullOrEmpty(provinceCode))
            {
                return false;
            }

            // Returns a boolean if the input in an all uppercase form is included in the array
            bool isValid = validProvinceCodes.Contains(provinceCode.Trim().ToUpper());

            return isValid;
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regex pattern in format 123-456-7890 or 1234567890
            string phoneRegex = @"^\d{3}[-]?\d{3}[-]?\d{4}$";

            if (string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }

            // Returns a boolean based on if the input matches the pattern
            bool isValid = Regex.IsMatch(phoneNumber, phoneRegex, RegexOptions.IgnoreCase);

            return isValid;
        }
    }
}
