using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MMClassLibrary
{
    // Display and maintain the Province file
    public class Province
    {
        private static StreamReader? reader;
        private static StreamWriter? writer;

        private static bool isInsert = false;
        private static string? fileName = "Province.txt";

        #region Properties
        public string ProvinceCode { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string TaxCode { get; set; }
        public double TaxRate { get; set; }
        public bool IncludesFederalTax { get; set; }
        public string FirstLetterOfPostalCode { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Create an empty Province object
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
        #endregion

        #region Insert, Update and Delete
        public void Insert()
        {
            isInsert = true;
            try
            {
                Edit();
                using (writer = new StreamWriter(fileName, true))
                {
                    writer.WriteLine(ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"exception trying to insert a new Province: {ex.Message}");
            }
        }
        #endregion

        #region Utilities ... ToString, Parse, Edit, etc
        public override string ToString()
        {
            string record = $"{ProvinceCode}\t{Name}\t{CountryCode}\t{TaxCode}\t" +
                $"{TaxRate.ToString()}\t{IncludesFederalTax.ToString()}\t" +
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

    }
}
