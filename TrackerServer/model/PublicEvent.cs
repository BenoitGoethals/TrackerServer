using System;
using System.Collections.Generic;

namespace TrackerServer.model
{
    public class PublicEvent
    {
        public int Id { get; set; }
        public string NameEvent { get; set; }
        public DateTime DateTimeEvent { get; set; }
        public TypeEvent TypeEvent { get; set; }
        public string Description { get; set; }
        public int Peoples { get; set; }
        public Boolean PossibleGroundZeroBySubject { get; set; }
        public List<Person> KnownPerson { get; set; }
        

        protected bool Equals(PublicEvent other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PublicEvent) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}