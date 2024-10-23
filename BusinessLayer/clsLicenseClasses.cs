using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicenseClasses
    {
        public int licenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        static public DataTable GetAllLicenseClassesName()
        {
            return clsLicenseClassesDataAccess.GetAllLicenseClassesName();
        }

        static public string GetLicenseClassName(int licenseClassID)
        {
            return clsLicenseClassesDataAccess.GetLicenseClassNameByID(licenseClassID);
        }

        clsLicenseClasses(int licenseClassID, string className, string classDescription
            , byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {
            this.licenseClassID = licenseClassID;
            this.ClassName = className;
            this.ClassDescription = classDescription;
            this.MinimumAllowedAge = minimumAllowedAge;
            this.DefaultValidityLength = defaultValidityLength;
            this.ClassFees = classFees;
        }

        static public clsLicenseClasses Find(int LicenseClassID)
        {
            string ClassName = "", ClassDescription = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = -1;

            if (clsLicenseClassesDataAccess.Find(LicenseClassID, ref ClassName
                , ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength
                , ref ClassFees))
            {
                return new clsLicenseClasses(LicenseClassID, ClassName
                    , ClassDescription, MinimumAllowedAge, DefaultValidityLength
                    , ClassFees);
            }
            else
                return null;
        }
    }
}
