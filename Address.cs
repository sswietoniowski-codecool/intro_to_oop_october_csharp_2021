using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Address(string street, string city, string state, string zip)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        public Address()
        {
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {State} {Zip}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            var other = (Address)obj;

            return Street == other.Street &&
                   City == other.City &&
                   State == other.State &&
                   Zip == other.Zip;
        }

        public override int GetHashCode()
        {
            return Street.GetHashCode() ^ City.GetHashCode() ^ State.GetHashCode() ^ Zip.GetHashCode();
        }

        public static bool operator ==(Address a1, Address a2)
        {
            return a1.Equals(a2);
        }

        public static bool operator !=(Address a1, Address a2)
        {
            return !a1.Equals(a2);
        }

        public static Address operator +(Address a1, Address a2)
        {
            return new Address(a1.Street + a2.Street, a1.City + a2.City, a1.State + a2.State, a1.Zip + a2.Zip);
        }

        public static Address operator -(Address a1, Address a2)
        {
            return new Address(a1.Street - a2.Street, a1.City - a2.City, a1.State - a2.State, a1.Zip - a2.Zip);
        }
    }
}
