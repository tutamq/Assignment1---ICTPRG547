using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Person
    {
        // Default values
        const string DEF_NAME = "No Name provided";
        const string DEF_EMAIL = "No Email provided";
        const string DEF_PHONE_NO = "No Phone number provided";

        // Aggregation class Address
        public Address PersonAddress;


        // Getters & Setters
        public string PersonName { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPhoneNo { get; set; }
        public Address Address { get; set; }

        // All-arg constructor
        public Person(string personName, string personEmail, string personPhoneNo, Address address)
        {
            PersonName = personName;
            PersonEmail = personEmail;
            PersonPhoneNo = personPhoneNo;
            PersonAddress = address;
        }

        // No-arg constructor
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NO, new Address()) { }

        // ToString
        public override string ToString()
        {
            return  "Name: " + PersonName + 
                  "\nEmail: " + PersonEmail + 
                  "\nPhone number: " + PersonPhoneNo + 
                  "\n--- Address:\n" + PersonAddress + 
                  "\n";
        }

    }
}
