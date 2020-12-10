﻿namespace GeekSpot.Models.EntityModels
{
    public class Purchase
    {
        public Purchase()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal FinalPrice { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}