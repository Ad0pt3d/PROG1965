using System.Text.RegularExpressions;

namespace UtilitiesClass
{
    /// <summary>
    /// numeric, date and string validations
    /// </summary>
    public class Validations
    {
        /// <summary>
        /// returns true if the string contains a number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumeric(string value)
        {
            Regex pattern = new Regex(@"^-?\d+\.\d+|\.\d+$");
            return pattern.IsMatch(value + "");
        }

        /// <summary>
        /// return true if object contains a Double
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumeric(object value)
        {
            // Regex only works on strings an object doesn't have
            // contents (technically speaking) but everything in C#
            // world is an object SOLID (Liskov) says we should be able
            // to take a sub-class and pass it to a method of the super-class
            // See below - exception in the try catch we could probably get
            // 'invalid cast exception' or similar. but doesn't matter - all
            // will go to the super-class 'Exception'

            try
            {
                Convert.ToInt32 (value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsInteger(string value)
        {
            return IsNumeric(value) && !value.Contains(".");
        }
        // Contains is a string method. Need to seperately pass variable to string
        public static bool IsInteger(double value)
        {
            return IsInteger(value.ToString());
        }

        public static bool IsInteger(object value)
        {
            try
            {
                Convert.ToInt32(value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
