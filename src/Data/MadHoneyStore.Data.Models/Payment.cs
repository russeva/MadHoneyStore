namespace MadHoneyStore.Data.Models
{
    using MadHoneyStore.Data.Models.Enum;
    using System;
    using System.Collections.Generic;

    public class Payment
    {
        public int PaymentId { get; set; }

        public double Amount { get; set; }

        public PaymentType PaymentType { get; set; }

        public int CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public int CardId { get; set; }

        public virtual Cart Cart { get; set; }
    }
}
