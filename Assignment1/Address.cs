using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Address
    {
        // Default values
        const string DEF_STREET_NO = "No Street number provided";
        const string DEF_STREET_NAME = "No Street name provided";
        const string DEF_SUBURB = "No Suburb provided";
        const string DEF_POSTCODE = "No Postcode provided";
        const string DEF_STATE = "No State provided";

        // Getters & Setters
        public string AddressStreetNo { get; set; }
        public string AddressStreetName { get; set; }
        public string AddressSuburb { get; set; }
        public string AddressPostcode { get; set; }
        public string AddressState { get; set; }

        // All-arg constructor
        public Address(string addressStreetNo, string addressStreetName, string addressSuburb, string addressPostcode, string addressState)
        {
            AddressStreetNo = addressStreetNo;
            AddressStreetName = addressStreetName;
            AddressSuburb = addressSuburb;
            AddressPostcode = addressPostcode;
            AddressState = addressState;
        }

        // No-arg constructor
        public Address() : this(DEF_STREET_NO, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE) { }

        // ToString
        public override string ToString()
        {
            return "Street number: " + AddressStreetNo + 
                 "\nStreet name: "+ AddressStreetName +
                 "\nSuburb: " + AddressSuburb +
                 "\nPostcode: " + AddressPostcode +
                 "\nState: " + AddressState +
                 "\n";
        }
    }
}
