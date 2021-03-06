﻿namespace TrackerServer.model
{
    public class Country
    {
        public Country(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Country()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        protected bool Equals(Country other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Country) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}