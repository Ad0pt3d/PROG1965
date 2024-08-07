<<<<<<< HEAD
﻿/*
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

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMClassLibrary
{
    // Display and maintain the Country file
    public class Country
    {
        private static StreamReader reader;
        private static StreamWriter writer;

        private static string fileName = "Country.txt";

        // #region and #endregion specify a block of code that we can expand or collapse
        // use the - and + to collapse or expand

        #region Properties
        // Attributes describe an object of the class (use camal case)
        private string countryCode = "";

        // Type 'prop' and then double tab
        public string CountryCode { get => countryCode; set => countryCode = (value + "").Trim().ToUpper(); }

        // 'Name' property (pascal) is a method, replacing get/set.
        // whereas, at line 24 'CountryCode is a public access to 'countryCode' above it
        public string Name { get; set; }
        public string TaxCode {  get; set; }
        public double TaxRate { get; set; }
        public string PostalRegex { get; set; }
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
        public string PhoneRegex { get; set; }
        #endregion

        #region Constructors
<<<<<<< HEAD
        /// <summary>
        /// Create a Country object, empty
        /// </summary>

=======

        /// <summary>
        /// Create a Country object, empty
        /// </summary>
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
        public Country()
        {
            TaxRate = 0.0;
        }

        /// <summary>
        /// Create a new Country object with pre-set code and name
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="name"></param>
<<<<<<< HEAD

=======
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
        public Country(string countryCode, string name)
        {
            CountryCode = countryCode;
            Name = name;
            TaxRate = 0.0;
        }
<<<<<<< HEAD
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
=======
        // TaxRate here is default value
        // because we manually create a constructor, the default is not created.
        // We have taken control of the system
        #endregion

        #region Get Methods

        public static Country GetCountryByCode(string countryCode)
        {
            using (reader = new StreamReader(fileName))
            {
                while(!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    if (record.StartsWith(countryCode + "\t"))
                        return Parse(record);
                }
            }
            return null;
        }
        #endregion

        #region Utilites ... ToString, Parse, Edit, etc.

        public static Country Parse(string record)
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
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
<<<<<<< HEAD
                throw new Exception("Record retrieved does not have enough fields\n" + record);
            }
        }
        #endregion
=======
                throw new Exception("record retrieved does not have enough fields\n"
                    + record);
            }
        }

        #endregion

>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
    }
}
