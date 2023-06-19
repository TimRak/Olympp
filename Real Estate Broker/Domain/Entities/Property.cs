namespace Real_Estate_Broker.Domain.Entities
{
    public class Property
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public User Owner { get; set; }
    }
}
