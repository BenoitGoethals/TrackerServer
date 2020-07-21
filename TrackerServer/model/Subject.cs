using System;
using System.Collections.Generic;

namespace TrackerServer.model
{
    public class Subject
    {

        public  int Id { get; set; }
        public Person Person { get; set; }
        public Boolean CoronatestPositive { get; set; }
        public DateTime CoronaTest { get; set; }
        public Symptoms  Symtoms { get; set; }
        public DateTime FirstSigns { get; set; }
        public string ExtraInformation { get; set; }
        public List<PublicEvent> PublicEvents { get; set; }
        public StatusSubject StatusSubject { get; set; }
        
        
        


        protected bool Equals(Subject other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Subject) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

    public enum StatusSubject
    {
        Hospital,
        Quaritaine,
        Death
        
    }

    public enum TypeEvent
    {
        Party,
        FamilyParty,
        Pinick,
        Sport
    }
    
    
    
}