using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace TrackerServer.model
{
    [Table("Person")]
    public class Person
    {
        public Person(int id, string name, string nationalNbr, string forName, Address address, Country country, string email, DateTime birthDate, string job, Relation relation)
        {
            Id = id;
            Name = name;
            NationalNbr = nationalNbr;
            ForName = forName;
            Address = address;
            Country = country;
          
            Email = email;
            BirthDate = birthDate;
            Job = job;
            Relation = relation;
          
           
            
        }

        public Person()
        {
            
        }

        
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public string NationalNbr { get; set; }
        
        public string ForName { get; set; }
        
        public Address Address { get; set; }
        
        public Country Country { get; set; }
        
        public List<Telephone> Telephones { get; set; } =new List<Telephone>();
        
        public string Email { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public string Job { get; set; }
        
        public Relation Relation { get; set; }
        
        public List<Person> Family { get; set; } =new List<Person>();
        
        public int CurrentPersonId { get; set; }
        public Person CurrentPerson { get; set; }
        

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