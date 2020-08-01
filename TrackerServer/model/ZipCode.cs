namespace TrackerServer.model
{
    public class ZipCode
    {
        //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Code { get; set; }
        public string City { get; set; }

        public ZipCode(int id, string code, string city)
        {
            Id = id;
            Code = code;
            City = city;
        }

        public ZipCode()
        {
           
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Code)}: {Code}, {nameof(City)}: {City}";
        }

        protected bool Equals(ZipCode other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ZipCode) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}