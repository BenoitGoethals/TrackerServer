namespace TrackerServer.model
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Nr { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public Country Country { get; set; }

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