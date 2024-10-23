using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public enum enGender { Male = 0, Female = 1 }
        public string Phone { get; set; }
        public int NationalityCountryID { get; set; }
        public string Email { get; set; }

        public string ImagePath { get; set; }
        public string Address { get; set; }

        public string FullName
        {
            get {
                return FirstName + " " + SecondName + " " + ThirdName + " " +LastName;}
        }

        public DateTime DateOfBirth { get; set; }

        public enGender Gender = enGender.Male;

        static public int ConvertGenderToIntger(enGender gender)
        {
            if (gender == enGender.Male)
                return 0;
            else
                return 1;
        }

        static public enGender ConvertIntgerToGender(int num)
        {
            if (num == 0)
                return enGender.Male;
            else
                return enGender.Female;

        }

        public clsPeople()

        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now.AddYears(-18);
            this.NationalityCountryID = -1;
            this.SecondName = "";
            this.ImagePath = "";
            this.ThirdName = "";
            this.NationalNo = "";


            Mode = enMode.AddNew;

        }

        private clsPeople(int iD, string nationalNo, string firstName, string secondName
            , string thirdName, string lastName, string phone, int nationalityCountryID
            , string email, string imagePath, string address, DateTime dateOfBirth
            , enGender gender)
        {
            Mode = enMode.Update;
            ID = iD;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Phone = phone;
            NationalityCountryID = nationalityCountryID;
            Email = email;
            ImagePath = imagePath;
            Address = address;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        static public clsPeople Find(int PersonID)
        {

            string FirstName = "", NationalNo = "", SecondName = "", ThirdName = "",
                LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gen = -1, CountryID = -1;

            if (clsPeopleDataAccess.GetPersonInfoByID(ref PersonID, ref NationalNo, ref FirstName,
               ref SecondName, ref ThirdName, ref LastName, ref Email, ref Phone, ref Address
               , ref Gen, ref DateOfBirth, ref CountryID, ref ImagePath))

                return new clsPeople(PersonID, NationalNo, FirstName, SecondName
            , ThirdName, LastName, Phone, CountryID
            , Email, ImagePath, Address, DateOfBirth
            , ConvertIntgerToGender(Gen));
            else
                return null;
        }

        static public clsPeople Find(string NationalNo)
        {

            string FirstName = "", SecondName = "", ThirdName = "",
                LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gen = -1, CountryID = -1, PersonID = -1;

            if (clsPeopleDataAccess.GetPersonInfoByNationalNo(ref PersonID, ref NationalNo, ref FirstName,
               ref SecondName, ref ThirdName, ref LastName, ref Email, ref Phone, ref Address
               , ref Gen, ref DateOfBirth, ref CountryID, ref ImagePath))

                return new clsPeople(PersonID, NationalNo, FirstName, SecondName
            , ThirdName, LastName, Phone, CountryID
            , Email, ImagePath, Address, DateOfBirth
            , ConvertIntgerToGender(Gen));
            else
                return null;
        }

        bool _AddNewContact()
        {
            int g;
            if (Gender == enGender.Male) g = 0;
            else g = 1;

            this.ID = clsPeopleDataAccess.AddNewContact(this.NationalNo, this.FirstName, this.SecondName
            , this.ThirdName, this.LastName, this.Email, this.Phone, this.Address, g
            , this.DateOfBirth, this.NationalityCountryID, this.ImagePath);

            return (this.ID > 0);
        }

        bool _UpdatePerson()
        {
            return clsPeopleDataAccess.UpdatePerson(this.ID, this.NationalNo, this.FirstName,
                this.SecondName, this.ThirdName, this.LastName, this.Email, this.Phone, this.Address
                , ConvertGenderToIntger(this.Gender), this.DateOfBirth, this.NationalityCountryID, this.ImagePath);
        }

        static public bool DeletePerson(int PersonID)
        {
            return clsPeopleDataAccess.DeletePerson(PersonID);
        }
        static public bool IsPersonExists(string NationalNo)
        {
            return clsPeopleDataAccess.IsPersonExists(NationalNo);
        }

        static public bool IsPersonExists(int PersonID)
        {
            return clsPeopleDataAccess.IsPersonExists(PersonID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }
            return false;
        }

        static public DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }

    }
}
