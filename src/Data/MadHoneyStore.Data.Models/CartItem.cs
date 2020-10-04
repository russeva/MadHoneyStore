namespace MadHoneyStore.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class CartItem
    {
        public int CartItemId { get; set; }

        public int Qunatity { get; set; }

        public int TotalCost { get; set; }

        public int CartId { get; set; }

        public Cart Cart { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
