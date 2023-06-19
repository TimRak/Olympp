namespace Real_Estate_Broker.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public User Buyer { get; set; }
        public Property Property { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }
}
