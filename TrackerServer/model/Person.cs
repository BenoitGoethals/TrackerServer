using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace TrackerServer.model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalNbr { get; set; }
        public string ForName { get; set; }
        public Address Address { get; set; }
        public Country Country { get; set; }
        public List<string> Telephones { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Job { get; set; }
        public Realtion Type { get; set; }
        public List<Person> Family { get; set; }

        protected bool Equals(Person other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}