using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes_3
{
    public class Address
    {
        public int StreetNumber { get; set; }
        public string StreeName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }

        public Address()
        {
            StreeName = string.Empty;
            StreetNumber = 0;
            State = string.Empty;
            City = string.Empty;
            Zipcode = 0;
        }

        public Address(int streetnumber, string streetname, string state, string city, int zipcode)
        {
            StreeName = streetname;
            StreetNumber = streetnumber;
            State = state;
            City = city;
            Zipcode = zipcode;
        }
        public override string ToString()
        {
            return $"{StreetNumber} {StreeName}, {City} {State}, {Zipcode}";
        }
    }
}
