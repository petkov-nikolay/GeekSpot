namespace GeekSpot.Models.EntityModels
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string SessionId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}