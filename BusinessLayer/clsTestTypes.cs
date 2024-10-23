using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestTypes
    {
        public string TestTypeTilte { get; set; }
        public string TestTypeDescription { get; set; }
        public int TestTypeID { get; set; }
        public Decimal TestTypeFees { get; set; }

        public clsTestTypes()
        {
            TestTypeID = -1;
            TestTypeFees = -1;
            TestTypeTilte = "";
            TestTypeDescription = "";
        }
        private clsTestTypes(string TestTypeTilte, string TestTypeDescription, int TestTypeID
            , Decimal TestTypeFees)
        {
            this.TestTypeTilte = TestTypeTilte;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeID = TestTypeID;
            this.TestTypeFees = TestTypeFees;
        }

        static public DataTable GetAllTestTypes()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }

        static public decimal GetTestTypeFees(int TestTypeID)
        {
            return clsTestTypesDataAccess.GetTestFees(TestTypeID);
        }

        public bool UpdateTestType()
        {
            return clsTestTypesDataAccess.UpdateTestType(this.TestTypeID, this.TestTypeTilte,
                this.TestTypeDescription, this.TestTypeFees);
        }

        static public clsTestTypes FindTestType(int TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            Decimal TestTypeFees = -1;

            if (clsTestTypesDataAccess.FindTestTypeByID(ref TestTypeID, ref TestTypeTitle
                , ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestTypes(TestTypeTitle, TestTypeDescription, TestTypeID
                    , TestTypeFees);
            }
            else
                return null;
        }





    }
}
