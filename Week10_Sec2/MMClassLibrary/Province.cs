﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
=======
using System.Text.RegularExpressions;
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
using System.Threading.Tasks;

namespace MMClassLibrary
{
<<<<<<< HEAD
    public class Province
    {
        StreamReader? reader;
        StreamWriter? writer;

        string fileName = "Province.txt";
=======
    // Display and maintain the Province file
    public class Province
    {
        private static StreamReader? reader;
        private static StreamWriter? writer;

        private static bool isInsert = false;
        private static string? fileName = "Province.txt";
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b

        #region Properties
        public string ProvinceCode { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string TaxCode { get; set; }
        public double TaxRate { get; set; }
        public bool IncludesFederalTax { get; set; }
<<<<<<< HEAD
        public string FirstLettorOfPostalCode { get; set; }
=======
        public string FirstLetterOfPostalCode { get; set; }
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
        #endregion

        #region Constructors
        /// <summary>
<<<<<<< HEAD
        /// Create a Country object, empty
=======
        /// Create an empty Province object
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
        /// </summary>
        public Province()
        {
            IncludesFederalTax = false;
        }

        /// <summary>
        /// Create a Province with a provinceCode, name and countryCode
        /// </summary>
        /// <param name="provinceCode"></param>
        /// <param name="name"></param>
        /// <param name="countryCode"></param>
        public Province(string provinceCode, string name, string countryCode)
        {
            ProvinceCode = provinceCode;
            Name = name;
            CountryCode = countryCode;
            IncludesFederalTax = false;
        }
        #endregion

<<<<<<< HEAD
        #region Methods
=======
        #region Get Methods
        /// <summary>
        /// Get province record with the correct province code
        /// </summary>
        /// <param name="provinceCode"></param>
        /// <returns></returns>
        public static Province GetProvinceByCode(string provinceCode)
        {
            using (reader = new StreamReader(fileName)) 
            { 
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    if (record.StartsWith(provinceCode + "\t"))
                        return Parse(record);
                }
            }
            return null;
        }

        public Province GetProvinceByName(string name)
        {
            name = (name + "").Trim();
            using (reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    if (record.StartsWith(name + "\t"))
                        return Parse(record);
                }
            }
            return null;
        }
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
        #endregion

        #region Insert, Update and Delete
        public void Insert()
        {
<<<<<<< HEAD
            try
            {
                Edit();
                using(writer = new StreamWriter(fileName, true)) 
=======
            isInsert = true;
            try
            {
                Edit();
                using (writer = new StreamWriter(fileName, true))
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
                {
                    writer.WriteLine(ToString());
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                throw new Exception($"Exception trying to insert a new Provinc: {ex.Message}");
            }
            
        }

        #endregion

        #region Utilites ... ToString, Parse, Edit, etc
        private void Edit()
        {

        }

=======
                throw new Exception($"exception trying to insert a new Province: {ex.Message}");
            }
        }
        #endregion

        #region Utilities ... ToString, Parse, Edit, etc
>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
        public override string ToString()
        {
            string record = $"{ProvinceCode}\t{Name}\t{CountryCode}\t{TaxCode}\t" +
                $"{TaxRate.ToString()}\t{IncludesFederalTax.ToString()}\t" +
<<<<<<< HEAD
                $"{FirstLettorOfPostalCode}";
            return record;
        }

        #endregion



=======
                $"{FirstLetterOfPostalCode}";
            return record;
        }

        public static Province Parse(string record)
        {
            string[] fields = record.Split('\t');
            if (fields.Length > 7)
            {
                Province province = new Province(fields[0], fields[1], fields[2]);
                province.TaxCode = fields[3];
                province.TaxRate = Convert.ToDouble(fields[4]);
                province.IncludesFederalTax = Convert.ToBoolean(fields[5]);
                province.FirstLetterOfPostalCode = fields[6];
                return province;
            }
            else throw new Exception("province record is missing fields:\n" + record);
        }

        private void Edit()
        {
            string errors = "";
            Regex twoLetters = new Regex("^[A-Z]{2}$");
            ProvinceCode = (ProvinceCode + "").Trim().ToUpper();
            if(!twoLetters.IsMatch(ProvinceCode))
            {
                errors += "province code must be exactly two letters";
            }
            else
            {
                if (GetProvinceByCode(ProvinceCode) != null)
                    errors += "province code is already on file\n";
            }

            Province? province = GetProvinceByName(Name);
            if (province != null && province.ProvinceCode != ProvinceCode)
                errors += "province name is already on file under province code " +
                    province.ProvinceCode;

            Country? country = Country.GetCountryByCode(CountryCode);
            if (country == null)
                errors += "country code is not on file\n";

            if (errors != "") throw new Exception("edit errors:\n" + errors);
        }

        
        #endregion

>>>>>>> 3e354bf95969c67940a6f7aab37b2acf3dcd8a1b
    }
}
