namespace GeekSpot.Models.EntityModels
{
    public class Customer
    {
        public Customer()
        {
            this.Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }

        public int Warnings { get; set; }

        public decimal Credits { get; set; }

        public string UserId { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}