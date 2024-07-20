/*
 * Project: Class Libraries
 * Created by: Rafi Miah
 * Date: 09-07-2024
 */
namespace MMClassLibrary
{
    public class Country
    {
        StreamReader reader;
        StreamWriter writer;

        string fileName = "Country.txt";

        #region Properties
        // Attributes describe an object of the class (use camalCase)
        private string countryCode = "";

        public string CountryCode { get => countryCode; set => countryCode = (value + "").Trim().ToUpper(); }

        // Type 'prop' and double tab
        // 'Name' property (pascal) is a method, replacing get/set
        // whereas 'CountryCode' is public access to 'countryCode' above it
        public string Name { get; set; }

        public string TaxCode { get; set; }

        public double TaxRate { get; set; }

        public string PostalRegex { get; set; }

        public string PhoneRegex { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Create a Country object, empty
        /// </summary>

        public Country()
        {
            TaxRate = 0.0;
        }

        /// <summary>
        /// Create a new Country object with pre-set code and name
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="name"></param>

        public Country(string countryCode, string name)
        {
            CountryCode = countryCode;
            Name = name;
            TaxRate = 0.0;
        }
        #endregion

        #region Get Methods
        public Country GetCountryByCode(string countryCode)
        {
            using (reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    if (record.StartsWith(countryCode + "\t"))
                    {
                        return Parse(record);
                    }
                }

                return null;
            }
        }
        #endregion

        #region Utilities ... ToString, Parse, Edit, etc.

        public Country Parse(string record)
        {
            string[] fields = record.Split('\t');
            if (fields.Length < 6)
            {
                Country country = new Country(fields[0], fields[1]);
                country.TaxCode = fields[2];
                country.TaxRate = Convert.ToDouble(fields[3]);
                country.PostalRegex = fields[4];
                country.PhoneRegex = fields[5];
                return country;
            }
            else
            {
                throw new Exception("Record retrieved does not have enough fields\n" + record);
            }
        }
        #endregion
    }
}
