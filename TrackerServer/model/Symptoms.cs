using System;

namespace TrackerServer.model
{
    public class Symptoms 
    {
        private int Id { get; set; }
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