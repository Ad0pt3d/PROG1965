using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMClassLibrary
{
    public class Province
    {
        StreamReader? reader;
        StreamWriter? writer;

        string fileName = "Province.txt";

        #region Properties
        public string ProvinceCode { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string TaxCode { get; set; }
        public double TaxRate { get; set; }
        public bool IncludesFederalTax { get; set; }
        public string FirstLettorOfPostalCode { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Create a Country object, empty
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

        #region Methods
        #endregion

        #region Insert, Update and Delete
        public void Insert()
        {
            try
            {
                Edit();
                using(writer = new StreamWriter(fileName, true)) 
                {
                    writer.WriteLine(ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception trying to insert a new Provinc: {ex.Message}");
            }
            
        }

        #endregion

        #region Utilites ... ToString, Parse, Edit, etc
        private void Edit()
        {

        }

        public override string ToString()
        {
            string record = $"{ProvinceCode}\t{Name}\t{CountryCode}\t{TaxCode}\t" +
                $"{TaxRate.ToString()}\t{IncludesFederalTax.ToString()}\t" +
                $"{FirstLettorOfPostalCode}";
            return record;
        }

        #endregion



    }
}
