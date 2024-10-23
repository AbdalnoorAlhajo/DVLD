using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsCountries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        static public DataTable GetAllCountriesName()
        {
            return clsCountryDataAccess.GetAllCountriesName();
        }

        clsCountries(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        public static clsCountries Find(int CountryID)
        {
            string CountryName = "";

            if (clsCountryDataAccess.Find(ref CountryID, ref CountryName))
                return new clsCountries(CountryID, CountryName);
            else
                return null;
        }
    }
}
