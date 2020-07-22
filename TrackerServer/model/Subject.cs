using System;
using System.Collections.Generic;

namespace TrackerServer.model
{
    public class Subject
    {
        public Subject(int id, Person person, bool coronatestPositive, DateTime coronaTest, Symptoms symtoms, DateTime firstSigns, string extraInformation,  StatusSubject statusSubject, string dossierNr)
        {
            Id = id;
            Person = person;
            CoronatTstPositive = coronatestPositive;
            CoronaTest = coronaTest;
            Symtoms = symtoms;
            FirstSigns = firstSigns;
            ExtraInformation = extraInformation;
            
            StatusSubject = statusSubject;
            DossierNr = dossierNr;
        }

        public Subject()
        {
        }

        public  int Id { get; set; }
        public Person Person { get; set; }
        public bool? CoronatTstPositive { get; set; }
        public DateTime CoronaTest { get; set; }
        public Symptoms  Symtoms { get; set; }
        public DateTime FirstSigns { get; set; }
        public string ExtraInformation { get; set; }
        public List<PublicEvent> PublicEvents { get; set; } = new List<PublicEvent>();
        public StatusSubject StatusSubject { get; set; }
        
        public string DossierNr { get; set; }
        
        
        


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