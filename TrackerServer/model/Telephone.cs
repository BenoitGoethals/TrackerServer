namespace TrackerServer.model
{
    public class Telephone
    {
        public Telephone(int id, string countryCode, string nbr)
        {
            Id = id;
            CountryCode = countryCode;
            Nbr = nbr;
        }

        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Nbr { get; set; }

        protected bool Equals(Telephone other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Telephone) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(CountryCode)}: {CountryCode}, {nameof(Nbr)}: {Nbr}";
        }
    }
}