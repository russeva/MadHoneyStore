namespace MadHoneyStore.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Cart
    {
        public int Id { get; set; }

        public int CardId { get; set; }

        public double TotalCost { get; set; }

        public int PaymentId { get; set; }

        public Payment Payment { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
