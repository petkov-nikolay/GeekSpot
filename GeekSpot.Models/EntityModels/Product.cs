namespace GeekSpot.Models.EntityModels
{
    public abstract class Product
    {
        protected Product()
        {
            this.IsAvailable = true;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }

        public int Views { get; set; }

        public bool IsAvailable { get; set; }

        public decimal Rating { get; set; }
    }
}