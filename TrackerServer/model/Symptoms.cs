using System;

namespace TrackerServer.model
{
    public class Symptoms 
    {
        public Symptoms(int id, bool fever, bool fatigue, bool adryCough, bool lossOfAppetite, bool shortnessOfBreath, bool mucus, string extraInfo)
        {
            Id = id;
            Fever = fever;
            Fatigue = fatigue;
            AdryCough = adryCough;
            LossOfAppetite = lossOfAppetite;
            ShortnessOfBreath = shortnessOfBreath;
            Mucus = mucus;
            ExtraInfo = extraInfo;
        }

        public Symptoms()
        {
        }

        public int Id { get; set; }
        public Boolean Fever { get; set; }
        public Boolean Fatigue { get; set; }
        public Boolean AdryCough { get; set; }
        public Boolean LossOfAppetite { get; set; }
        public Boolean ShortnessOfBreath { get; set; }
        public Boolean Mucus  { get; set; }
        public string ExtraInfo { get; set; }

        protected bool Equals(Symptoms other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Symptoms) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}