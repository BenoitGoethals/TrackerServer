﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TrackerServer.model
{
    public class Address
    {
        public Address(int id, string street, string nr, ZipCode zipCode, string city, Country country, int addressOfPersonId, Person person)
        {
            Id = id;
            Street = street;
            Nr = nr;
            ZipCode = zipCode;
            City = city;
            Country = country;
            AddressOfPersonId = addressOfPersonId;
            Person = person;
        }

        public Address()
        {
        }

        public int Id { get; set; }
        public string Street { get; set; }
        public string Nr { get; set; }
        public ZipCode ZipCode { get; set; }
        public string City { get; set; }
        public Country Country { get; set; }

        public int AddressOfPersonId { get; set; }
        public Person Person { get; set; }

        protected bool Equals(Address other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Address) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}